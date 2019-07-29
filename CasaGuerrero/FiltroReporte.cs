using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaGuerrero
{
    public partial class FiltroReporte : Form
    {
        public FiltroReporte()
        {
            InitializeComponent();
        }

        private void FiltroReporte_Load(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData != Keys.Escape)
                return base.ProcessCmdKey(ref msg, keyData);
            if (keyData == Keys.Escape) { Close(); }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            string fech1 = dateTimePicker1.Text;
            dateTimePicker1.CustomFormat = "dddd dd ' de' MMMM 'del ' yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            string fech2 = dateTimePicker2.Text;
            dateTimePicker2.CustomFormat = "dddd dd ' de' MMMM 'del ' yyyy";

            Informe form = new Informe(fech1, fech2);
            form.Show();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            string fech1 = dateTimePicker1.Text;
            dateTimePicker1.CustomFormat = "dddd dd ' de' MMMM 'del ' yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            string fech2 = dateTimePicker2.Text;
            dateTimePicker2.CustomFormat = "dddd dd ' de' MMMM 'del ' yyyy";

            Informe form = new Informe(fech1, fech2);
            form.Show();
        }
    }
}
