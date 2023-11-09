namespace Cauciones
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MontoInicialTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TasaInicialTxt = new System.Windows.Forms.TextBox();
            this.TasaFinalTxt = new System.Windows.Forms.TextBox();
            this.ComisionBrokerTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PeriodicidadDiasTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FechaFinalCaucionDtp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.IntervaloAgrupacionCmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CalcularBtn = new System.Windows.Forms.Button();
            this.CaucionesDgv = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.InversionAcumLbl = new System.Windows.Forms.Label();
            this.InteresCobradoLbl = new System.Windows.Forms.Label();
            this.ComisionesPagadasLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CaucionesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MontoInicialTxt
            // 
            this.MontoInicialTxt.Location = new System.Drawing.Point(31, 22);
            this.MontoInicialTxt.Name = "MontoInicialTxt";
            this.MontoInicialTxt.Size = new System.Drawing.Size(146, 20);
            this.MontoInicialTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "InversionInicial";
            // 
            // TasaInicialTxt
            // 
            this.TasaInicialTxt.Location = new System.Drawing.Point(217, 21);
            this.TasaInicialTxt.Name = "TasaInicialTxt";
            this.TasaInicialTxt.Size = new System.Drawing.Size(100, 20);
            this.TasaInicialTxt.TabIndex = 2;
            // 
            // TasaFinalTxt
            // 
            this.TasaFinalTxt.Location = new System.Drawing.Point(345, 21);
            this.TasaFinalTxt.Name = "TasaFinalTxt";
            this.TasaFinalTxt.Size = new System.Drawing.Size(100, 20);
            this.TasaFinalTxt.TabIndex = 3;
            // 
            // ComisionBrokerTxt
            // 
            this.ComisionBrokerTxt.Location = new System.Drawing.Point(479, 21);
            this.ComisionBrokerTxt.Name = "ComisionBrokerTxt";
            this.ComisionBrokerTxt.Size = new System.Drawing.Size(100, 20);
            this.ComisionBrokerTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tasa Inicial %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tasa Final %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Comision Broker %";
            // 
            // PeriodicidadDiasTxt
            // 
            this.PeriodicidadDiasTxt.Location = new System.Drawing.Point(612, 21);
            this.PeriodicidadDiasTxt.Name = "PeriodicidadDiasTxt";
            this.PeriodicidadDiasTxt.Size = new System.Drawing.Size(100, 20);
            this.PeriodicidadDiasTxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = " plazo caución";
            // 
            // FechaFinalCaucionDtp
            // 
            this.FechaFinalCaucionDtp.Location = new System.Drawing.Point(70, 93);
            this.FechaFinalCaucionDtp.Name = "FechaFinalCaucionDtp";
            this.FechaFinalCaucionDtp.Size = new System.Drawing.Size(200, 20);
            this.FechaFinalCaucionDtp.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Final Inversion";
            // 
            // IntervaloAgrupacionCmb
            // 
            this.IntervaloAgrupacionCmb.FormattingEnabled = true;
            this.IntervaloAgrupacionCmb.Location = new System.Drawing.Point(367, 91);
            this.IntervaloAgrupacionCmb.Name = "IntervaloAgrupacionCmb";
            this.IntervaloAgrupacionCmb.Size = new System.Drawing.Size(121, 21);
            this.IntervaloAgrupacionCmb.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Periodo Agrupación";
            // 
            // CalcularBtn
            // 
            this.CalcularBtn.Location = new System.Drawing.Point(603, 89);
            this.CalcularBtn.Name = "CalcularBtn";
            this.CalcularBtn.Size = new System.Drawing.Size(109, 23);
            this.CalcularBtn.TabIndex = 14;
            this.CalcularBtn.Text = "Calcular";
            this.CalcularBtn.UseVisualStyleBackColor = true;
            this.CalcularBtn.Click += new System.EventHandler(this.CalcularBtn_Click);
            // 
            // CaucionesDgv
            // 
            this.CaucionesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CaucionesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CaucionesDgv.Location = new System.Drawing.Point(31, 161);
            this.CaucionesDgv.Name = "CaucionesDgv";
            this.CaucionesDgv.Size = new System.Drawing.Size(681, 313);
            this.CaucionesDgv.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Inversión Acumulada:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Intereses Cobrados:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 567);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Comisiones Pagadas:";
            // 
            // InversionAcumLbl
            // 
            this.InversionAcumLbl.AutoSize = true;
            this.InversionAcumLbl.Location = new System.Drawing.Point(147, 519);
            this.InversionAcumLbl.Name = "InversionAcumLbl";
            this.InversionAcumLbl.Size = new System.Drawing.Size(0, 13);
            this.InversionAcumLbl.TabIndex = 19;
            // 
            // InteresCobradoLbl
            // 
            this.InteresCobradoLbl.AutoSize = true;
            this.InteresCobradoLbl.Location = new System.Drawing.Point(147, 543);
            this.InteresCobradoLbl.Name = "InteresCobradoLbl";
            this.InteresCobradoLbl.Size = new System.Drawing.Size(0, 13);
            this.InteresCobradoLbl.TabIndex = 20;
            // 
            // ComisionesPagadasLbl
            // 
            this.ComisionesPagadasLbl.AutoSize = true;
            this.ComisionesPagadasLbl.Location = new System.Drawing.Point(147, 567);
            this.ComisionesPagadasLbl.Name = "ComisionesPagadasLbl";
            this.ComisionesPagadasLbl.Size = new System.Drawing.Size(0, 13);
            this.ComisionesPagadasLbl.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 629);
            this.Controls.Add(this.ComisionesPagadasLbl);
            this.Controls.Add(this.InteresCobradoLbl);
            this.Controls.Add(this.InversionAcumLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CaucionesDgv);
            this.Controls.Add(this.CalcularBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IntervaloAgrupacionCmb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechaFinalCaucionDtp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PeriodicidadDiasTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComisionBrokerTxt);
            this.Controls.Add(this.TasaFinalTxt);
            this.Controls.Add(this.TasaInicialTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MontoInicialTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calc Cauciones V1.0.0.1";
            ((System.ComponentModel.ISupportInitialize)(this.CaucionesDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MontoInicialTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TasaInicialTxt;
        private System.Windows.Forms.TextBox TasaFinalTxt;
        private System.Windows.Forms.TextBox ComisionBrokerTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PeriodicidadDiasTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechaFinalCaucionDtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox IntervaloAgrupacionCmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CalcularBtn;
        private System.Windows.Forms.DataGridView CaucionesDgv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label InversionAcumLbl;
        private System.Windows.Forms.Label InteresCobradoLbl;
        private System.Windows.Forms.Label ComisionesPagadasLbl;
    }
}

