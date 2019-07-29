using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CasaGuerrero
{
    public partial class IntegracionPagoServicio : Form
    {
        Metodos serv = new Metodos();
        public IntegracionPagoServicio()
        {
            InitializeComponent();
        }

        private void TxtMonto1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || (e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)) || ((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator) && txt.Text.Contains('.'));
        }

        private void TxtMonto2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || (e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)) || ((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator) && txt.Text.Contains('.'));
        }

        private void BtnAxtel_Click(object sender, EventArgs e)
        {
            btnAxtel.BackColor = Color.Tomato;

            btnCFE.BackColor = Color.LightGray;
            btnDish.BackColor = Color.LightGray;
            btnFactAtytIusacell.BackColor = Color.LightGray;
            btnFactMovistar.BackColor = Color.LightGray;
            btnInfonavit.BackColor = Color.LightGray;
            btnIzzi.BackColor = Color.LightGray;
            btnTelmex.BackColor = Color.LightGray;
            btnMegacable.BackColor = Color.LightGray;
            btnMegacableSuscriptor.BackColor = Color.LightGray;
            btnSkyVeTv.BackColor = Color.LightGray;
            btnSiapaGdl.BackColor = Color.LightGray;
            btnTotalPlay.BackColor = Color.LightGray;

            groupBox2.Text = "AXTEL";
            pictureBox2.Image = Image.FromFile("C:\\Users\\sistemas2\\source\\repos\\CasaGuerrero\\CasaGuerrero\\Imagenes\\AXTEL.png");

            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lec;
            cmd.CommandText = "select * from Servicios where Producto = 'AXTEL'";
            lec = cmd.ExecuteReader();
            if (lec.HasRows)
            {
                lec.Read();
                txtClaveProducto.Text = lec.GetString(0);
                txtProducto.Text = lec.GetString(1);
                lec.Close();
            }
            cn.Close();
        }

        private void BtnCFE_Click(object sender, EventArgs e)
        {
            btnCFE.BackColor = Color.DarkSeaGreen;

            btnAxtel.BackColor = Color.LightGray;
            btnDish.BackColor = Color.LightGray;
            btnFactAtytIusacell.BackColor = Color.LightGray;
            btnFactMovistar.BackColor = Color.LightGray;
            btnInfonavit.BackColor = Color.LightGray;
            btnIzzi.BackColor = Color.LightGray;
            btnTelmex.BackColor = Color.LightGray;
            btnMegacable.BackColor = Color.LightGray;
            btnMegacableSuscriptor.BackColor = Color.LightGray;
            btnSkyVeTv.BackColor = Color.LightGray;
            btnSiapaGdl.BackColor = Color.LightGray;
            btnTotalPlay.BackColor = Color.LightGray;

            groupBox2.Text = "CFE";
            pictureBox2.Image = Image.FromFile("C:\\Users\\sistemas2\\source\\repos\\CasaGuerrero\\CasaGuerrero\\Imagenes\\CFE.png");

            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lec;
            cmd.CommandText = "select * from Servicios where Producto = 'CFE'";
            lec = cmd.ExecuteReader();
            if (lec.HasRows)
            {
                lec.Read();
                txtClaveProducto.Text = lec.GetString(0);
                txtProducto.Text = lec.GetString(1);
                lec.Close();
            }
            cn.Close();
        }

        private void BtnDish_Click(object sender, EventArgs e)
        {
            btnDish.BackColor = Color.Tomato;

            btnAxtel.BackColor = Color.LightGray;
            btnCFE.BackColor = Color.LightGray;
            btnFactAtytIusacell.BackColor = Color.LightGray;
            btnFactMovistar.BackColor = Color.LightGray;
            btnInfonavit.BackColor = Color.LightGray;
            btnIzzi.BackColor = Color.LightGray;
            btnTelmex.BackColor = Color.LightGray;
            btnMegacable.BackColor = Color.LightGray;
            btnMegacableSuscriptor.BackColor = Color.LightGray;
            btnSkyVeTv.BackColor = Color.LightGray;
            btnSiapaGdl.BackColor = Color.LightGray;
            btnTotalPlay.BackColor = Color.LightGray;

            groupBox2.Text = "DISH";
            pictureBox2.Image = Image.FromFile("C:\\Users\\sistemas2\\source\\repos\\CasaGuerrero\\CasaGuerrero\\Imagenes\\DISH.png");

            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lec;
            cmd.CommandText = "select * from Servicios where Producto = 'DISH'";
            lec = cmd.ExecuteReader();
            if (lec.HasRows)
            {
                lec.Read();
                txtClaveProducto.Text = lec.GetString(0);
                txtProducto.Text = lec.GetString(1);
                lec.Close();
            }
            cn.Close();
        }

        private void BtnFactAtytIusacell_Click(object sender, EventArgs e)
        {
            btnFactAtytIusacell.BackColor = Color.DeepSkyBlue;

            btnAxtel.BackColor = Color.LightGray;
            btnDish.BackColor = Color.LightGray;
            btnCFE.BackColor = Color.LightGray;
            btnFactMovistar.BackColor = Color.LightGray;
            btnInfonavit.BackColor = Color.LightGray;
            btnIzzi.BackColor = Color.LightGray;
            btnTelmex.BackColor = Color.LightGray;
            btnMegacable.BackColor = Color.LightGray;
            btnMegacableSuscriptor.BackColor = Color.LightGray;
            btnSkyVeTv.BackColor = Color.LightGray;
            btnSiapaGdl.BackColor = Color.LightGray;
            btnTotalPlay.BackColor = Color.LightGray;

            groupBox2.Text = "FACTURA AT&T IUSACELL";
            pictureBox2.Image = Image.FromFile("C:\\Users\\sistemas2\\source\\repos\\CasaGuerrero\\CasaGuerrero\\Imagenes\\ATT.png");

            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lec;
            cmd.CommandText = "select * from Servicios where Producto = 'FACTURAS	AT&T / IUSACELL'";
            lec = cmd.ExecuteReader();
            if (lec.HasRows)
            {
                lec.Read();
                txtClaveProducto.Text = lec.GetString(0);
                txtProducto.Text = lec.GetString(1);
                lec.Close();
            }
            cn.Close();
        }

        private void BtnFactMovistar_Click(object sender, EventArgs e)
        {
            btnFactMovistar.BackColor = Color.SkyBlue;

            btnAxtel.BackColor = Color.LightGray;
            btnDish.BackColor = Color.LightGray;
            btnCFE.BackColor = Color.LightGray;
            btnFactAtytIusacell.BackColor = Color.LightGray;
            btnInfonavit.BackColor = Color.LightGray;
            btnIzzi.BackColor = Color.LightGray;
            btnTelmex.BackColor = Color.LightGray;
            btnMegacable.BackColor = Color.LightGray;
            btnMegacableSuscriptor.BackColor = Color.LightGray;
            btnSkyVeTv.BackColor = Color.LightGray;
            btnSiapaGdl.BackColor = Color.LightGray;
            btnTotalPlay.BackColor = Color.LightGray;

            groupBox2.Text = "FACTURA MOVISTAR";
            pictureBox2.Image = Image.FromFile("C:\\Users\\sistemas2\\source\\repos\\CasaGuerrero\\CasaGuerrero\\Imagenes\\FACT MOVISTAR.png");

            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lec;
            cmd.CommandText = "select * from Servicios where Producto = 'FACTURAS TELEFONICA MOVISTAR'";
            lec = cmd.ExecuteReader();
            if (lec.HasRows)
            {
                lec.Read();
                txtClaveProducto.Text = lec.GetString(0);
                txtProducto.Text = lec.GetString(1);
                lec.Close();
            }
            cn.Close();
        }

        private void BtnInfonavit_Click(object sender, EventArgs e)
        {
            btnInfonavit.BackColor = Color.Tomato;

            btnAxtel.BackColor = Color.LightGray;
            btnDish.BackColor = Color.LightGray;
            btnCFE.BackColor = Color.LightGray;
            btnFactAtytIusacell.BackColor = Color.LightGray;
            btnFactMovistar.BackColor = Color.LightGray;
            btnIzzi.BackColor = Color.LightGray;
            btnTelmex.BackColor = Color.LightGray;
            btnMegacable.BackColor = Color.LightGray;
            btnMegacableSuscriptor.BackColor = Color.LightGray;
            btnSkyVeTv.BackColor = Color.LightGray;
            btnSiapaGdl.BackColor = Color.LightGray;
            btnTotalPlay.BackColor = Color.LightGray;

            groupBox2.Text = "INFONAVIT";
            pictureBox2.Image = Image.FromFile("C:\\Users\\sistemas2\\source\\repos\\CasaGuerrero\\CasaGuerrero\\Imagenes\\INFONAVIT.png");

            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lec;
            cmd.CommandText = "select * from Servicios where Producto = 'INFONAVIT'";
            lec = cmd.ExecuteReader();
            if (lec.HasRows)
            {
                lec.Read();
                txtClaveProducto.Text = lec.GetString(0);
                txtProducto.Text = lec.GetString(1);
                lec.Close();
            }
            cn.Close();
        }

        private void BtnIzzi_Click(object sender, EventArgs e)
        {
            btnIzzi.BackColor = Color.MediumTurquoise;

            btnAxtel.BackColor = Color.LightGray;
            btnDish.BackColor = Color.LightGray;
            btnCFE.BackColor = Color.LightGray;
            btnFactAtytIusacell.BackColor = Color.LightGray;
            btnInfonavit.BackColor = Color.LightGray;
            btnFactMovistar.BackColor = Color.LightGray;
            btnTelmex.BackColor = Color.LightGray;
            btnMegacable.BackColor = Color.LightGray;
            btnMegacableSuscriptor.BackColor = Color.LightGray;
            btnSkyVeTv.BackColor = Color.LightGray;
            btnSiapaGdl.BackColor = Color.LightGray;
            btnTotalPlay.BackColor = Color.LightGray;

            groupBox2.Text = "IZZI";
            pictureBox2.Image = Image.FromFile("C:\\Users\\sistemas2\\source\\repos\\CasaGuerrero\\CasaGuerrero\\Imagenes\\IZZI.png");

            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lec;
            cmd.CommandText = "select * from Servicios where Producto = 'IZZI TELECOM'";
            lec = cmd.ExecuteReader();
            if (lec.HasRows)
            {
                lec.Read();
                txtClaveProducto.Text = lec.GetString(0);
                txtProducto.Text = lec.GetString(1);
                lec.Close();
            }
            cn.Close();
        }

        private void BtnTelmex_Click(object sender, EventArgs e)
        {
            btnTelmex.BackColor = Color.SteelBlue;

            btnAxtel.BackColor = Color.LightGray;
            btnDish.BackColor = Color.LightGray;
            btnCFE.BackColor = Color.LightGray;
            btnFactAtytIusacell.BackColor = Color.LightGray;
            btnInfonavit.BackColor = Color.LightGray;
            btnFactMovistar.BackColor = Color.LightGray;
            btnIzzi.BackColor = Color.LightGray;
            btnMegacable.BackColor = Color.LightGray;
            btnMegacableSuscriptor.BackColor = Color.LightGray;
            btnSkyVeTv.BackColor = Color.LightGray;
            btnSiapaGdl.BackColor = Color.LightGray;
            btnTotalPlay.BackColor = Color.LightGray;

            groupBox2.Text = "TELMEX";
            pictureBox2.Image = Image.FromFile("C:\\Users\\sistemas2\\source\\repos\\CasaGuerrero\\CasaGuerrero\\Imagenes\\TELMEX.png");

            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lec;
            cmd.CommandText = "select * from Servicios where Producto = 'TELMEX'";
            lec = cmd.ExecuteReader();
            if (lec.HasRows)
            {
                lec.Read();
                txtClaveProducto.Text = lec.GetString(0);
                txtProducto.Text = lec.GetString(1);
                lec.Close();
            }
            cn.Close();
        }

        private void BtnMegacable_Click(object sender, EventArgs e)
        {
           btnMegacable.BackColor = Color.DodgerBlue;

            btnAxtel.BackColor = Color.LightGray;
            btnDish.BackColor = Color.LightGray;
            btnCFE.BackColor = Color.LightGray;
            btnFactAtytIusacell.BackColor = Color.LightGray;
            btnInfonavit.BackColor = Color.LightGray;
            btnFactMovistar.BackColor = Color.LightGray;
            btnIzzi.BackColor = Color.LightGray;
            btnTelmex.BackColor = Color.LightGray;
            btnMegacableSuscriptor.BackColor = Color.LightGray;
            btnSkyVeTv.BackColor = Color.LightGray;
            btnSiapaGdl.BackColor = Color.LightGray;
            btnTotalPlay.BackColor = Color.LightGray;

            groupBox2.Text = "MEGACABLE";
            pictureBox2.Image = Image.FromFile("C:\\Users\\sistemas2\\source\\repos\\CasaGuerrero\\CasaGuerrero\\Imagenes\\MEGACABLE.png");

            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lec;
            cmd.CommandText = "select * from Servicios where Producto = 'MEGACABLE'";
            lec = cmd.ExecuteReader();
            if (lec.HasRows)
            {
                lec.Read();
                txtClaveProducto.Text = lec.GetString(0);
                txtProducto.Text = lec.GetString(1);
                lec.Close();
            }
            cn.Close();
        }

        private void BtnMegacableSuscriptor_Click(object sender, EventArgs e)
        {
            btnMegacableSuscriptor.BackColor = Color.DodgerBlue;

            btnAxtel.BackColor = Color.LightGray;
            btnDish.BackColor = Color.LightGray;
            btnCFE.BackColor = Color.LightGray;
            btnFactAtytIusacell.BackColor = Color.LightGray;
            btnInfonavit.BackColor = Color.LightGray;
            btnFactMovistar.BackColor = Color.LightGray;
            btnIzzi.BackColor = Color.LightGray;
            btnTelmex.BackColor = Color.LightGray;
            btnMegacable.BackColor = Color.LightGray;
            btnSkyVeTv.BackColor = Color.LightGray;
            btnSiapaGdl.BackColor = Color.LightGray;
            btnTotalPlay.BackColor = Color.LightGray;

            groupBox2.Text = "MEGACABLE SUSCRIPTOR";
            pictureBox2.Image = Image.FromFile("C:\\Users\\sistemas2\\source\\repos\\CasaGuerrero\\CasaGuerrero\\Imagenes\\MEGACABLE.png");

            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lec;
            cmd.CommandText = "select * from Servicios where Producto = 'MEGACABLE (NUM. SUSCRIPTOR)'";
            lec = cmd.ExecuteReader();
            if (lec.HasRows)
            {
                lec.Read();
                txtClaveProducto.Text = lec.GetString(0);
                txtProducto.Text = lec.GetString(1);
                lec.Close();
            }
            cn.Close();
        }

        private void BtnSkyVeTv_Click(object sender, EventArgs e)
        {
            btnSkyVeTv.BackColor = Color.DodgerBlue;

            btnAxtel.BackColor = Color.LightGray;
            btnDish.BackColor = Color.LightGray;
            btnCFE.BackColor = Color.LightGray;
            btnFactAtytIusacell.BackColor = Color.LightGray;
            btnInfonavit.BackColor = Color.LightGray;
            btnFactMovistar.BackColor = Color.LightGray;
            btnIzzi.BackColor = Color.LightGray;
            btnTelmex.BackColor = Color.LightGray;
            btnMegacable.BackColor = Color.LightGray;
            btnMegacableSuscriptor.BackColor = Color.LightGray;
            btnSiapaGdl.BackColor = Color.LightGray;
            btnTotalPlay.BackColor = Color.LightGray;

            groupBox2.Text = "SKY Y VeTv";
            pictureBox2.Image = Image.FromFile("C:\\Users\\sistemas2\\source\\repos\\CasaGuerrero\\CasaGuerrero\\Imagenes\\SKY VET TV.png");

            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lec;
            cmd.CommandText = "select * from Servicios where Producto = 'SKY &	VeTV'";
            lec = cmd.ExecuteReader();
            if (lec.HasRows)
            {
                lec.Read();
                txtClaveProducto.Text = lec.GetString(0);
                txtProducto.Text = lec.GetString(1);
                lec.Close();
            }
            cn.Close();
        }

        private void BtnSiapaGdl_Click(object sender, EventArgs e)
        {
            btnSiapaGdl.BackColor = Color.Aqua;

            btnAxtel.BackColor = Color.LightGray;
            btnDish.BackColor = Color.LightGray;
            btnCFE.BackColor = Color.LightGray;
            btnFactAtytIusacell.BackColor = Color.LightGray;
            btnInfonavit.BackColor = Color.LightGray;
            btnFactMovistar.BackColor = Color.LightGray;
            btnIzzi.BackColor = Color.LightGray;
            btnTelmex.BackColor = Color.LightGray;
            btnMegacable.BackColor = Color.LightGray;
            btnMegacableSuscriptor.BackColor = Color.LightGray;
            btnSkyVeTv.BackColor = Color.LightGray;
            btnTotalPlay.BackColor = Color.LightGray;

            groupBox2.Text = "SIAPA GUADALAJARA";
            pictureBox2.Image = Image.FromFile("C:\\Users\\sistemas2\\source\\repos\\CasaGuerrero\\CasaGuerrero\\Imagenes\\SIAPA.png");

            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lec;
            cmd.CommandText = "select * from Servicios where Producto = 'SIAPA (GUADALAJARA)'";
            lec = cmd.ExecuteReader();
            if (lec.HasRows)
            {
                lec.Read();
                txtClaveProducto.Text = lec.GetString(0);
                txtProducto.Text = lec.GetString(1);
                lec.Close();
            }
            cn.Close();
        }

        private void BtnTotalPlay_Click(object sender, EventArgs e)
        {
            btnTotalPlay.BackColor = Color.Violet;

            btnAxtel.BackColor = Color.LightGray;
            btnDish.BackColor = Color.LightGray;
            btnCFE.BackColor = Color.LightGray;
            btnFactAtytIusacell.BackColor = Color.LightGray;
            btnInfonavit.BackColor = Color.LightGray;
            btnFactMovistar.BackColor = Color.LightGray;
            btnIzzi.BackColor = Color.LightGray;
            btnTelmex.BackColor = Color.LightGray;
            btnMegacable.BackColor = Color.LightGray;
            btnMegacableSuscriptor.BackColor = Color.LightGray;
            btnSkyVeTv.BackColor = Color.LightGray;
            btnSiapaGdl.BackColor = Color.LightGray;

            groupBox2.Text = "TOTAL PLAY";
            pictureBox2.Image = Image.FromFile("C:\\Users\\sistemas2\\source\\repos\\CasaGuerrero\\CasaGuerrero\\Imagenes\\TOTAL PLAY.png");

            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lec;
            cmd.CommandText = "select * from Servicios where Producto = 'TOTAL	PLAY'";
            lec = cmd.ExecuteReader();
            if (lec.HasRows)
            {
                lec.Read();
                txtClaveProducto.Text = lec.GetString(0);
                txtProducto.Text = lec.GetString(1);
                lec.Close();
            }
            cn.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form ips = new IntegracionPagoServicio();
            ips.Show();
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text == "-"){
                MessageBox.Show(" FAVOR DE SELECCIONAR EL SERVICIO A PAGAR ");
            }else if(txtReferencia.Text == ""){
                MessageBox.Show(" FAVOR DE INGRESAR LA REFERENCIA ");
            }else if (txtMonto1.Text == "" || txtMonto2.Text == "") {
                MessageBox.Show(" FAVOR DE INGRESAR UN MONTO ");
            }else if(txtMonto1.Text  != txtMonto2.Text)
            {
                MessageBox.Show(" LOS MONTOS NO COINCIDEN FAVOR DE VERIFICARLOS ");
            }
            else
            { 
                /*try
                {*/
                    String servidor = serv.GetServidor();
                    SqlConnection cn = new SqlConnection(servidor);
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    SqlDataReader lec;
                    String mont = txtMonto1.Text.Replace(",", ".");
                    cmd.CommandText = "insert into PagoServicio values('"+ txtReferencia.Text +"', '1', '"+ txtClaveProducto.Text +"', '"+ DateTime.Now.ToString() +"',"+ mont + ", 5000, 11678, 32424, '39326', 'F#(/G0@dwZ')";
                    cmd.ExecuteNonQuery();

                    WSMTCenterServicios.ServiceSoapClient wsps = new WSMTCenterServicios.ServiceSoapClient();
                    WSMTCenterServicios.InputPagoServicios input = new WSMTCenterServicios.InputPagoServicios();
                    WSMTCenterServicios.OutputPagoServicios output = new WSMTCenterServicios.OutputPagoServicios();
                    WSMTCenterServicios.Cuenta cuenta = new WSMTCenterServicios.Cuenta();

                    cmd.CommandText = "Select * from PagoServicio where no_transaccion in(select MAX(no_transaccion)as maximo from PagoServicio)";
                    lec = cmd.ExecuteReader();
                    if (lec.HasRows)
                    {
                        lec.Read();
                        input.no_transaccion = lec.GetInt32(0);//___________________________1
                        input.referencia1 = lec.GetString(1);//_______________2
                        input.referencia2 = lec.GetString(2);//_______________3
                        input.sku = lec.GetString(3);//____________________4
                        input.fecha_hora = lec.GetString(4);//___________5
                        input.monto =Double.Parse(lec.GetDecimal(5).ToString());//_____________________6

                        cuenta.cadena = lec.GetInt32(6);//_________________________________7
                        cuenta.establecimiento = lec.GetInt32(7);//_______________________8
                        cuenta.terminal = lec.GetInt32(8);//______________________________9
                        cuenta.cajero = lec.GetInt32(9).ToString();//______________________________10
                        cuenta.clave = lec.GetString(10);//__________________________11

                        output = wsps.servicio(input);

                        MessageBox.Show(output.codigo_respuesta.ToString());

                        txtReferencia.Text = "";
                        txtMonto1.Text = "";
                        txtMonto2.Text = "";
                    }

                    /*input.no_transaccion = 101;//___________________________1
                    input.referencia1 = txtReferencia.Text;//_______________2
                    input.referencia2 = txtReferencia.Text;//_______________3
                    input.sku = txtClaveProducto.Text;//____________________4
                    input.fecha_hora = DateTime.Now.ToString();//___________5
                    
                    input.monto = Double.Parse(mont);//_____________________6

                    cuenta.cadena = 5000;//_________________________________7
                    cuenta.establecimiento = 11678;//_______________________8
                    cuenta.terminal = 32424;//______________________________9
                    cuenta.cajero = "39326";//______________________________10
                    cuenta.clave = "F#(/G0@dwZ";//__________________________11
                    */
                    
                    
                /*}catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/
                
            }
        }
    }
}
