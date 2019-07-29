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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnRecargas_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
        }

        private void BtnPagoServicio_Click(object sender, EventArgs e)
        {
            IntegracionPagoServicio form2 = new IntegracionPagoServicio();
            form2.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
