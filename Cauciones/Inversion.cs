using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cauciones
{
    public class Inversion
    {
        public DateTime Fecha { get; set; }
        public decimal InteresPeriodo { get; set; }
        public decimal InversionAcumulada { get; set; }
        public decimal ComisionesPagadas { get; set; }

        public Inversion (DateTime fecha, decimal interes, decimal invacum, decimal comision)
        {
            Fecha = fecha;
            InteresPeriodo = interes;
            InversionAcumulada = invacum;
            ComisionesPagadas = comision;
        }
    }
    
}
