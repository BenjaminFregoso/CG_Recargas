using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CasaGuerrero
{
    public partial class Informe : Form
    {
        string fecha1, fecha2;
        public Informe(string fech1, string fech2)
        {
            InitializeComponent();
            
            this.fecha1 = fech1;
            this.fecha2 = fech2;

        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData != Keys.Escape)
                return base.ProcessCmdKey(ref msg, keyData);
            if (keyData == Keys.Escape) { Close(); }
            return true;
        }
        private void Informe_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'recargasDataSet.General' Puede moverla o quitarla según sea necesario.
            this.GeneralTableAdapter.Fill(this.recargasDataSet.General);

            // TODO: esta línea de código carga datos en la tabla 'recargasDataSet.Recarga' Puede moverla o quitarla según sea necesario.
            this.RecargaTableAdapter.FillByConsultas(this.recargasDataSet.Recarga);
            RecargaBindingSource.Filter = "fecha >= '"+fecha1+"' AND fecha <= '"+fecha2+"'";
            
            RecargaBindingSource.Filter = "code == '0'";


            //Array que contendrá los parámetros
            ReportParameter[] parameters = new ReportParameter[2];
            //Establecemos el valor de los parámetros
            parameters[0] = new ReportParameter("fecha1", fecha1);
            parameters[1] = new ReportParameter("fecha2", fecha2);
           
            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();

        }
    }
}
