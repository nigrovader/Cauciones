using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cauciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarFormulario();
                        
        }

        private decimal inversionInicial { get; set; }
        private decimal tasaInicial { get; set; }
        private decimal tasaFinal { get; set; }
        private decimal comisionBroker { get; set; }
        private int periodicidadDias { get; set; }
        private DateTime fechaFinalInversion { get; set; }
        private int periodoAgrupacion { get; set; }
        private List<Inversion> inversiones { get; set; }

        private void InicializarFormulario()
        {
            List<AgrupComboboxItem> agrupadores = new List<AgrupComboboxItem>();
            agrupadores.Add(new AgrupComboboxItem("Diario", 1));
            agrupadores.Add(new AgrupComboboxItem("Semanal", 7));
            agrupadores.Add(new AgrupComboboxItem("Quincenal", 15));
            agrupadores.Add(new AgrupComboboxItem("Mensual", 30));
            IntervaloAgrupacionCmb.DataSource = agrupadores;
            FechaFinalCaucionDtp.MinDate = DateTime.Now.AddDays(2);
            //MontoInicialTxt.Text.ToString(NumberFormatInfo.CurrentInfo);
            
        }

        private void CalcularBtn_Click(object sender, EventArgs e)
        {
            bool esCorrecto = ValidarFormulario();
            if (!esCorrecto) { return; }

            int diasInversion = fechaFinalInversion.Subtract(DateTime.Now).Days;
            decimal difInteresDiario = (tasaFinal - tasaInicial) / diasInversion;
            int diasTranscurridos = 0;
            decimal tasaActualizada = tasaInicial;
            decimal inversionAcumulada = inversionInicial;
            inversiones = new List<Inversion>();
            List<Inversion> inverBrutas = new List<Inversion>();
            List<Inversion> inverTmp = new List<Inversion>();
            decimal comision = 0;
            DateTime fechaCiclo = DateTime.Now;
            int periodicidadInterna = 0;

            do
            {
                
                if (fechaCiclo.DayOfWeek == DayOfWeek.Friday & periodicidadDias == 1) { periodicidadInterna = 3; } else { periodicidadInterna = periodicidadDias; }
                tasaActualizada = tasaInicial + (diasTranscurridos * difInteresDiario);
                if (fechaCiclo.AddDays(periodicidadInterna) > fechaFinalInversion) { periodicidadInterna = (int)fechaFinalInversion.Subtract(fechaCiclo).TotalDays; }
                decimal tasaPeriodo = ((tasaActualizada / 365) / 100) * periodicidadInterna;
                decimal interesPeriodo = inversionAcumulada * tasaPeriodo;                
                comision = interesPeriodo * (comisionBroker / 100);
                inversionAcumulada = inversionAcumulada + interesPeriodo - comision;

                Inversion inv = new Inversion(fechaCiclo, interesPeriodo, inversionAcumulada, comision);
                inverBrutas.Add(inv);
                diasTranscurridos = diasTranscurridos + periodicidadInterna;
                fechaCiclo = fechaCiclo.AddDays(periodicidadInterna);

            } while (diasTranscurridos < diasInversion);
            
            if (periodoAgrupacion > 1)
            {
                DateTime fechaInicioCiclo = DateTime.Now;                
                DateTime fechaFinCiclo = fechaFinalInversion;
                List<DateTime> periodos = new List<DateTime>();
                Double diasCiclo = fechaFinCiclo.Subtract(fechaInicioCiclo).TotalDays;
                Double numero1 = diasCiclo / periodoAgrupacion;
                int cantidadPeriodos = (int)Math.Truncate(numero1) +1; 

                for (int d=0; d <= cantidadPeriodos; d++)
                {
                    periodos.Add(fechaInicioCiclo.AddDays(d * periodoAgrupacion));
                }

                foreach (DateTime j in periodos)
                {
                    decimal interesAcumuladoAgrup = 0;
                    decimal comisionAcumAgrup = 0;
                    
                    inverTmp = inverBrutas.Where(x => x.Fecha < j.AddDays(periodoAgrupacion)
                            & x.Fecha >= j)
                            .ToList();
                    if (inverTmp.Count != 0)
                    {
                            foreach (Inversion inv in inverTmp)
                        {
                            interesAcumuladoAgrup = interesAcumuladoAgrup + inv.InteresPeriodo;
                            comisionAcumAgrup = comisionAcumAgrup + inv.ComisionesPagadas;
                        }
                   
                            Inversion inv1 = new Inversion(
                                inverTmp.Last().Fecha,
                                interesAcumuladoAgrup,
                                inverTmp.Last().InversionAcumulada,
                                comisionAcumAgrup);
                            inversiones.Add(inv1);
                        }
                }                      
               
                       
            }
            else
            {
                inversiones = inverBrutas;
            }

            CargarDatos();
                       
        }

        private void CargarDatos()
        {
            if (inversiones.Count != 0)
            {
                InversionAcumLbl.Text = inversiones.Last().InversionAcumulada.ToString("C");
                InteresCobradoLbl.Text = inversiones.Sum(x => x.InteresPeriodo).ToString("C");
                ComisionesPagadasLbl.Text = inversiones.Sum(x => x.ComisionesPagadas).ToString("C");

                DataTable datos = new DataTable("Cauciones");
                datos.Columns.Add(new DataColumn("Fecha", typeof(DateTime)));
                datos.Columns.Add(new DataColumn("Interes Periodo", typeof(string)));
                datos.Columns.Add(new DataColumn("Inversion Acumulada", typeof(string)));
                datos.Columns.Add(new DataColumn("Comisiones Pagadas", typeof(string)));

                foreach (Inversion inv in inversiones)
                {
                    DataRow dr = datos.NewRow();
                    dr = LLenarRow(inv, dr);
                    datos.Rows.Add(dr);
                }

                CaucionesDgv.DataSource = datos;
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar. Es posible que estes usando un plazo de caución alto y estes intentando agrupar por quincena o mes.");

            }

        }

        private DataRow LLenarRow (Inversion inv,DataRow dr)
        {
            dr["Fecha"] = inv.Fecha.ToString("dd/MM/yyyy");
            dr["Interes Periodo"] = inv.InteresPeriodo.ToString("C");
            dr["Inversion Acumulada"] = inv.InversionAcumulada.ToString("C");
            dr["Comisiones Pagadas"] = inv.ComisionesPagadas.ToString("C");
            return dr;
        }

        private bool ValidarFormulario()
        {
            decimal numero = new decimal();
            if ( !decimal.TryParse(MontoInicialTxt.Text, out numero))
            {
                MessageBox.Show("El monto inicial debe ser un numero");
                return false;
            }
            numero = ParseDecimal(MontoInicialTxt.Text);
            if (numero < 0) { MessageBox.Show("El monto inicial debe ser positivo"); return false; }
            inversionInicial = numero;

            if (!decimal.TryParse(TasaInicialTxt.Text,out numero)) { MessageBox.Show("La tasa inicial debe ser un numero"); return false; }
            numero = ParseDecimal(TasaInicialTxt.Text);
            if (numero < 0) { MessageBox.Show("La tasa inicial debe ser positiva"); return false; }
            tasaInicial = numero;

            if (String.IsNullOrWhiteSpace(TasaFinalTxt.Text)) { tasaFinal = tasaInicial; }       
            else
            {
                if (!decimal.TryParse(TasaFinalTxt.Text, out numero)) { MessageBox.Show("La tasa final debe ser un numero"); return false; }
                numero = ParseDecimal(TasaFinalTxt.Text);
                if (numero < 0) { MessageBox.Show("La tasa final debe ser positiva"); return false; }
                tasaFinal = numero;
            }

            if (!decimal.TryParse(ComisionBrokerTxt.Text, out numero)) { MessageBox.Show("La comisión debe ser un numero"); return false; }
            numero = ParseDecimal(ComisionBrokerTxt.Text);
            if (numero < 0) { MessageBox.Show("La comisión debe ser positiva"); return false; }
            comisionBroker = numero;

            int entero = new Int32();
            if (String.IsNullOrWhiteSpace(PeriodicidadDiasTxt.Text)) { periodicidadDias = 1; }
            else
            {
                if (!Int32.TryParse(PeriodicidadDiasTxt.Text, out entero)) { MessageBox.Show("La periodicidad debe ser un numero"); return false; }
                entero = Int32.Parse(PeriodicidadDiasTxt.Text);
                if (entero < 0) { MessageBox.Show("La periodicidad debe ser positiva"); return false; }
                periodicidadDias = entero;
            }

            fechaFinalInversion = FechaFinalCaucionDtp.Value;
            periodoAgrupacion = ((AgrupComboboxItem)IntervaloAgrupacionCmb.SelectedItem).Value;

            return true;
        }

        #region METODOS AUXILIARES
        private Decimal ParseDecimal(object value)
        {
            Decimal result;

            string doubleAsString = value.ToString();
            IEnumerable<char> doubleAsCharList = doubleAsString.ToList();

            if (doubleAsCharList.Where(ch => ch == '.' || ch == ',').Count() <= 1)
            {
                Decimal.TryParse(doubleAsString.Replace(',', '.'),
                    System.Globalization.NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out result);
            }
            else
            {
                if (doubleAsCharList.Where(ch => ch == '.').Count() <= 1
                    && doubleAsCharList.Where(ch => ch == ',').Count() > 1)
                {
                    Decimal.TryParse(doubleAsString.Replace(",", string.Empty),
                        System.Globalization.NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out result);
                }
                else if (doubleAsCharList.Where(ch => ch == ',').Count() <= 1
                    && doubleAsCharList.Where(ch => ch == '.').Count() > 1)
                {
                    Decimal.TryParse(doubleAsString.Replace(".", string.Empty).Replace(',', '.'),
                        System.Globalization.NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out result);
                }
                else
                {
                    throw new Exception($"Error parsing {doubleAsString} as double, try removing thousand separators (if any)");
                }
            }

            return result;
        }
        #endregion
    }
}
