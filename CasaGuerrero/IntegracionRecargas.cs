using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Net;

namespace CasaGuerrero
{
    public partial class IntegracionRecargas : Form
    {
        Metodos serv = new Metodos();

        int transaccion_0, cadena_5, establecimiento_6, terminal_7;
        string cr;
        string code;
        string telefono_1, sku_2, fecha_hora_3, cve_estado_4, cajero_8, clave_9;
        string ruta;
        string montoSinPuntos;
        string[] args = Environment.GetCommandLineArgs();
        string almacen;
        String iDcadena = "5000", iDestablecimiento = "11678", yyyymmdd = "", dia, mes;

        public IntegracionRecargas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //medir la pantalla------------------------->//this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //ventana a tamaño de la pantalla----------->//this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            dia = DateTime.Today.Day.ToString();//obtenemos el dia
            mes = DateTime.Today.Month.ToString();//obtenemos el mes
            if (dia.Length == 1) { dia = "0" + dia; }//si la cantidad de caracteres del dia es 1 le agregamos el 0 al inicio para cumplir con la cantidad de caracteres solicitados
            if (mes.Length == 1) { mes = "0" + mes; }//si la cantidad de caracteres del mes es 1 le agregamos el 0 al inicio para cumplir con la cantidad de caracteres solicitados

            //*********CREAR LA CARPETA Y EL ARCHIVO .TXT***********
            yyyymmdd = DateTime.Today.Year.ToString() + mes + dia; //obtenemos el año mes y dia

            ruta = @"\\192.168.0.2\Sistemas\temp\MTCCTAE" + iDcadena + iDestablecimiento + yyyymmdd + ".txt";//creamos la ruta
            
            if (File.Exists(ruta) == false){
                using (var fileStream = File.Create(ruta))
                {
                    fileStream.Flush();
                }
            }

            string[] args = Environment.GetCommandLineArgs();//extraemos el numero de operacion

            txtNum1.MaxLength = 10;//asignamos la maxima cantidad de caracteres que en este caso serian 10
            txtNum2.MaxLength = 10;//asignamos la maxima cantidad de caracteres que en este caso serian 10
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersWidth = 200;
        }

        //ACCIONES QUE REALIZA AL PULSAR LAS TECLAS F1, F2, F3, F4, F5, F6, F7, F8, F9 Y F10********************************
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if ((keyData != Keys.F1) & (keyData != Keys.F2) & (keyData != Keys.F3) & (keyData != Keys.F4)
                & (keyData != Keys.F5) & (keyData != Keys.F6) & (keyData != Keys.F7) & (keyData != Keys.F8)
                 & (keyData != Keys.F9) & (keyData != Keys.F10) & (keyData != Keys.F11) & (keyData != Keys.F12)
                  & (keyData != Keys.Alt + 1) & (keyData != Keys.Alt + 2))
                return base.ProcessCmdKey(ref msg, keyData);
            if (dataGridView1.CanFocus) { dataGridView1.Focus(); }
            if (keyData == Keys.F1) { btnTelcel.PerformClick(); }
            if (keyData == Keys.F2) { btnAlo.PerformClick(); }
            if (keyData == Keys.F3) { btnMovistar.PerformClick(); }
            if (keyData == Keys.F4) { btnAtYtIusacell.PerformClick(); }
            if (keyData == Keys.F5) { btnUnefon.PerformClick(); }
            if (keyData == Keys.F6) { btnNextel.PerformClick(); }
            if (keyData == Keys.F7) { btnVirginMobile.PerformClick(); }
            if (keyData == Keys.F8) { if (label7.Visible) { rbTelcelTae.Checked = true; rbTelcelTae.PerformClick(); } }
            if (keyData == Keys.F9) { if (label7.Visible) { rbTelcelAmigoSinLimite.Checked = true; rbTelcelAmigoSinLimite.PerformClick(); } }
            if (keyData == Keys.F10) { if (label7.Visible) { rbTelcelInternet.Checked = true; rbTelcelInternet.PerformClick(); } }
            if (keyData == Keys.Alt) { MessageBox.Show("as hecho clic sobre las teclas Alt + 1"); }
            return true;
        }
        //BOTON DE TELCEL *******************************************************************************************************
        private void BtnTelcel_Click(object sender, EventArgs e)
        {
            rbTelcelAmigoSinLimite.Visible = true;
            rbTelcelTae.Visible = true;
            rbTelcelInternet.Visible = true;
            label7.Visible = true;
            //groupBox1.Text = "TELCEL";
            btnTelcel.BackColor = Color.LightBlue;
            //groupBox1.BackColor = Color.LightBlue;
            //dataGridView1.BackgroundColor = Color.LightBlue;
            btnAlo.BackColor = Color.LightGray;
            btnMovistar.BackColor = Color.LightGray;
            btnAtYtIusacell.BackColor = Color.LightGray;
            btnUnefon.BackColor = Color.LightGray;
            btnNextel.BackColor = Color.LightGray;
            btnVirginMobile.BackColor = Color.LightGray;
            dataGridView1.Rows.Clear();
        }
        //BOTON DE ALO *******************************************************************************************
        private void BtnAlo_Click(object sender, EventArgs e)
        {
            try
            {
                rbTelcelAmigoSinLimite.Checked = false;
                rbTelcelInternet.Checked = false;
                rbTelcelTae.Checked = false;

                dataGridView1.Focus();
                rbTelcelAmigoSinLimite.Visible = false;
                rbTelcelTae.Visible = false;
                rbTelcelInternet.Visible = false;

                label7.Visible = false;

                groupBox1.Text = "ALO";

                btnAlo.BackColor = Color.Salmon;
                //groupBox1.BackColor = Color.Salmon;
                //dataGridView1.BackgroundColor = Color.Salmon;
                btnTelcel.BackColor = Color.LightGray;
                btnMovistar.BackColor = Color.LightGray;
                btnAtYtIusacell.BackColor = Color.LightGray;
                btnUnefon.BackColor = Color.LightGray;
                btnNextel.BackColor = Color.LightGray;
                btnVirginMobile.BackColor = Color.LightGray;

                String servidor = serv.GetServidor();
                SqlConnection cn = new SqlConnection(servidor);
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                SqlDataReader lector;
                cmd.CommandText = "SELECT producto, costo, sku FROM Alo";
                lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    dataGridView1.Rows.Clear();
                    while (lector.Read())
                    {
                        dataGridView1.Rows.Add(lector.GetString(0), lector.GetDecimal(1), lector.GetString(2));
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //BOTON DE MOVISTAR ******************************************************************************
        private void BtnMovistar_Click(object sender, EventArgs e)
        {
            try
            {
                rbTelcelAmigoSinLimite.Checked = false;
                rbTelcelInternet.Checked = false;
                rbTelcelTae.Checked = false;

                dataGridView1.Focus();
                rbTelcelAmigoSinLimite.Visible = false;
                rbTelcelTae.Visible = false;
                rbTelcelInternet.Visible = false;

                label7.Visible = false;

                groupBox1.Text = "MOVISTAR";

                btnMovistar.BackColor = Color.PaleGreen;
                //groupBox1.BackColor = Color.PaleGreen;
                //dataGridView1.BackgroundColor = Color.PaleGreen;
                btnAlo.BackColor = Color.LightGray;
                btnTelcel.BackColor = Color.LightGray;
                btnAtYtIusacell.BackColor = Color.LightGray;
                btnUnefon.BackColor = Color.LightGray;
                btnNextel.BackColor = Color.LightGray;
                btnVirginMobile.BackColor = Color.LightGray;


                String servidor = serv.GetServidor();
                SqlConnection cn = new SqlConnection(servidor);
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                SqlDataReader lector;
                cmd.CommandText = "SELECT producto, costo, sku FROM Movistar";
                lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    dataGridView1.Rows.Clear();
                    while (lector.Read())
                    {
                        dataGridView1.Rows.Add(lector.GetString(0), lector.GetDecimal(1), lector.GetString(2));
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //BOTON DE AT&T IUSACELL ********************************************************************************
        private void BtnAtYtIusacell_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Focus();

                rbTelcelAmigoSinLimite.Checked = false;
                rbTelcelInternet.Checked = false;
                rbTelcelTae.Checked = false;
                
                rbTelcelAmigoSinLimite.Visible = false;
                rbTelcelTae.Visible = false;
                rbTelcelInternet.Visible = false;

                label7.Visible = false;

                groupBox1.Text = "AT&T IUSACELL";

                btnAtYtIusacell.BackColor = Color.DeepSkyBlue;
                //groupBox1.BackColor = Color.DeepSkyBlue;
                //dataGridView1.BackgroundColor = Color.DeepSkyBlue;
                btnAlo.BackColor = Color.LightGray;
                btnMovistar.BackColor = Color.LightGray;
                btnTelcel.BackColor = Color.LightGray;
                btnUnefon.BackColor = Color.LightGray;
                btnNextel.BackColor = Color.LightGray;
                btnVirginMobile.BackColor = Color.LightGray;

                String servidor = serv.GetServidor();
                SqlConnection cn = new SqlConnection(servidor);
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                SqlDataReader lector;
                cmd.CommandText = "SELECT producto, costo, sku FROM AtatIusacell";
                lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    dataGridView1.Rows.Clear();
                    while (lector.Read())
                    {
                        dataGridView1.Rows.Add(lector.GetString(0), lector.GetDecimal(1), lector.GetString(2));
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // BOTON DE UNEFON ************************************************************************************************
        private void BtnUnefon_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Focus();

                rbTelcelAmigoSinLimite.Checked = false;
                rbTelcelInternet.Checked = false;
                rbTelcelTae.Checked = false;

                rbTelcelAmigoSinLimite.Visible = false;
                rbTelcelTae.Visible = false;
                rbTelcelInternet.Visible = false;

                label7.Visible = false;

                groupBox1.Text = "UNEFON";

                btnUnefon.BackColor = Color.LightGoldenrodYellow;
                //groupBox1.BackColor = Color.LightGoldenrodYellow;
                //dataGridView1.BackgroundColor = Color.LightGoldenrodYellow;
                btnAlo.BackColor = Color.LightGray;
                btnMovistar.BackColor = Color.LightGray;
                btnAtYtIusacell.BackColor = Color.LightGray;
                btnTelcel.BackColor = Color.LightGray;
                btnNextel.BackColor = Color.LightGray;
                btnVirginMobile.BackColor = Color.LightGray;

                String servidor = serv.GetServidor();
                SqlConnection cn = new SqlConnection(servidor);
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                SqlDataReader lector;
                cmd.CommandText = "SELECT producto, costo, sku FROM Unefon";
                lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    dataGridView1.Rows.Clear();
                    while (lector.Read())
                    {
                        dataGridView1.Rows.Add(lector.GetString(0), lector.GetDecimal(1), lector.GetString(2));
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // BOTON DE NEXTEL ************************************************************************************
        private void BtnNextel_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Focus();

                rbTelcelAmigoSinLimite.Checked = false;
                rbTelcelInternet.Checked = false;
                rbTelcelTae.Checked = false;

                rbTelcelAmigoSinLimite.Visible = false;
                rbTelcelTae.Visible = false;
                rbTelcelInternet.Visible = false;

                label7.Visible = false;

                groupBox1.Text = "NEXTEL";

                btnNextel.BackColor = Color.Orange;
                //groupBox1.BackColor = Color.Orange;
                //dataGridView1.BackgroundColor = Color.Orange;
                btnAlo.BackColor = Color.LightGray;
                btnMovistar.BackColor = Color.LightGray;
                btnAtYtIusacell.BackColor = Color.LightGray;
                btnUnefon.BackColor = Color.LightGray;
                btnTelcel.BackColor = Color.LightGray;
                btnVirginMobile.BackColor = Color.LightGray;

                String servidor = serv.GetServidor();
                SqlConnection cn = new SqlConnection(servidor);
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                SqlDataReader lector;
                cmd.CommandText = "SELECT producto, costo, sku FROM Nextel";
                lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    dataGridView1.Rows.Clear();
                    while (lector.Read())
                    {
                        dataGridView1.Rows.Add(lector.GetString(0), lector.GetDecimal(1), lector.GetString(2));
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //BOTON DE VIRGIN MOVIL *****************************************************************************
        private void BtnVirginMobile_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Focus();

                rbTelcelAmigoSinLimite.Checked = false;
                rbTelcelInternet.Checked = false;
                rbTelcelTae.Checked = false;

                rbTelcelAmigoSinLimite.Visible = false;
                rbTelcelTae.Visible = false;
                rbTelcelInternet.Visible = false;

                label7.Visible = false;

                groupBox1.Text = "VIRGIN MOBILE";

                btnVirginMobile.BackColor = Color.LightCoral;
                //groupBox1.BackColor = Color.LightCoral;
                //dataGridView1.BackgroundColor = Color.LightCoral;
                btnAlo.BackColor = Color.LightGray;
                btnMovistar.BackColor = Color.LightGray;
                btnAtYtIusacell.BackColor = Color.LightGray;
                btnUnefon.BackColor = Color.LightGray;
                btnNextel.BackColor = Color.LightGray;
                btnTelcel.BackColor = Color.LightGray;

                String servidor = serv.GetServidor();
                SqlConnection cn = new SqlConnection(servidor);
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                SqlDataReader lector;
                cmd.CommandText = "SELECT producto, costo, sku FROM VirginMobile";
                lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    dataGridView1.Rows.Clear();
                    while (lector.Read())
                    {
                        dataGridView1.Rows.Add(lector.GetString(0), lector.GetDecimal(1), lector.GetString(2));
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // RADIO BUTTON TELCEL TAE *********************************************************************************
        private void RbTelcelTae_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lector;
            cmd.CommandText = "SELECT producto, costo, sku FROM TelcelTae";
            lector = cmd.ExecuteReader();
            if (lector.HasRows)
            {
                dataGridView1.Rows.Clear();
                while (lector.Read())
                {
                    dataGridView1.Rows.Add(lector.GetString(0), lector.GetDecimal(1), lector.GetString(2));
                }
            }
            cn.Close();
        }
        // RADIO BUTTON TELCEL AMIGO SIN LIMITE **********************************************************************
        private void RbTelcelAmigoSinLimite_CheckedChanged(object sender, EventArgs e)
        {
            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lector;
            cmd.CommandText = "SELECT producto, costo, sku FROM TelcelAmigoSinLimite";
            lector = cmd.ExecuteReader();
            if (lector.HasRows)
            {
                dataGridView1.Rows.Clear();
                while (lector.Read())
                {
                    dataGridView1.Rows.Add(lector.GetString(0), lector.GetDecimal(1), lector.GetString(2));
                }
            }
            cn.Close();
        }
        // RADIO BUTTON TELCEL INTERNET *********************************************************************************
        private void RbTelcelInternet_CheckedChanged(object sender, EventArgs e)
        {
            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lector;
            cmd.CommandText = "SELECT producto, costo, sku FROM TelcelInternet";
            lector = cmd.ExecuteReader();
            if (lector.HasRows)
            {
                dataGridView1.Rows.Clear();
                while (lector.Read())
                {
                    dataGridView1.Rows.Add(lector.GetString(0), lector.GetDecimal(1), lector.GetString(2));
                }
            }
            cn.Close();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        // EVENTO CUANDO SE HACE CLIC SOBRE UNA FILA DE LA TABLA ****************************************************************
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;
                //Aqui se obtiene la fila seleccionada.
                String monto;
                monto = row[0].Cells["costo"].Value.ToString();
                txtMonto.Text = monto.Replace(",", ".");
                //txtNum1.Focus();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // CUANDO DEJEMOS EL FOCO DEL BOTON DE "ACEPTAR" SE IRA EL FOCO AL BOTON DE "CANCELAR" **********************************
        private void BtnRecarga_Leave(object sender, EventArgs e)
        {
            btnCancelar.Focus();
        }
        // CUANDO DEJEMOS EL FOCO DEL BOTON DE "CANCELAR" SE IRA AL FOCO DE CONSULTAR *******************************************
        private void BtnCancelar_Leave(object sender, EventArgs e)
        {
            btnConsultar.Focus();
        }
        // CUANDO CAMBIA EL TEXTO ***********************************************************************************************
        private void TxtNum2_TextChanged(object sender, EventArgs e)
        {
            try{
                string num1 = txtNum1.Text.Substring(0, txtNum2.Text.Length);
                string num2 = txtNum2.Text.Substring(0, txtNum2.Text.Length);

                if (num1 != num2) { txtNum2.BackColor = Color.Red; }
                else { txtNum2.BackColor = Color.White; }
            }catch (Exception)
            {
                //MessageBox.Show(iO.Message);
            }
        }
        // CUANDO DAMOS ENTER SOBRE UNA FILA DE LA TABLA *************************************************************************
        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try
                {
                    DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;
                    //Aqui se obtiene la fila seleccionada.
                    String monto;
                    monto = row[0].Cells["costo"].Value.ToString();
                    txtMonto.Text = monto.Replace(",", ".");
                    txtNum1.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // CUANDO DEJAMOS EL FOCO DEL NUMERO 2 *****************************************************************************************
        private void TxtNum2_Leave(object sender, EventArgs e)
        {
            btnRecarga.Focus();
            if (txtNum2.Text.Length == 10 && txtNum2.BackColor == Color.White) { txtNum2.PasswordChar = '*'; }
            else
            {
                txtNum2.PasswordChar = '\0';
                txtNum2.BackColor = Color.Red;
                /*txtNum2.Focus();
                MessageBox.Show("Debes de ingresar los 10 caracteres primero");*/
            }
        }
        // CUANDO PULSAMOS UNA TECLA SOBRO EL CAMPO TEXTO DEL NUMERO 1 *****************************************************************
        private void TxtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }

            if (txtNum1.Text.Length <= 10) {
                txtNum1.PasswordChar = '\0';
                txtNum1.BackColor = Color.White;
            }
        }
        // CUANDO DEJAMOS EL FOCO DE NUMERO 1 VERIFICAMOS QUE SE HAYA INGRERSADO LOS 10 DIGITOS DE LO CONTRARIO LO OBLIGAMOS ************
        private void TxtNum1_Leave(object sender, EventArgs e)
        {
                if (txtNum1.Text.Length == 10)
            { txtNum1.PasswordChar = '*'; }
            else
            {
                txtNum1.PasswordChar = '\0';
                //txtNum2.BackColor = Color.Red;
                txtNum1.Focus();
                MessageBox.Show("Debes de ingresar los 10 caracteres primero");
            }
        }
        // CUANDO PRESIONAMOS UNA TECLA SOBRE EL TEXTBOX 2 *******************************************************************************
        private void TxtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //instruciones para validar que los caracteres ingresados sean numericos
                if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
                else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }

                if (txtNum2.Text.Length <= 10 && txtNum2.Text == txtNum1.Text)
                {
                    txtNum2.PasswordChar = '\0';
                    txtNum2.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // CUANDO HACEMOS CLIC SOBRE EL BOTON DE CANCELAR ***********************************************************************************
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new IntegracionRecargas();
                f.Show();
                IntegracionRecargas f2 = new IntegracionRecargas();
                f2.Close();
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        //BOTON QUE VALIDA QUE LOS DATOS INGRESADOS SEAN LOS CORRECTOS Y EN CASO DE QUE SI ENVIAR LOS PARAMETROS SOLICITADOS DEL WEB SERVICE
        private void BtnRecarga_Click(object sender, EventArgs e)
        {
            String sku1, producto, costo;

            //validar que se hayan seleccionado un monto de la tabla de recargas disponibles
            if (txtMonto.Text == "0.00") { MessageBox.Show("FAVOR DE SELECCIONAR UN PROVEDOR Y UN MONTO DE LA TABLA"); }
            //validar que la cantidad de caracteres sean 10
            else if (txtNum1.TextLength < 10 || txtNum2.TextLength < 10) { MessageBox.Show("FAVOR DE INGRESAR LOS 10 DIGITOS"); }
            //validar que los numeros ingresados sean iguales
            else if (txtNum1.Text != txtNum2.Text) { MessageBox.Show("LOS NUMEROS NO COINCIDEN FAVOR DE VERIFICARLOS"); }
            //SI TODO SALE BIEN SE ENVIARAN LOS PARAMETROS AL WEB SERVICE Y EL MONTO SE REINICIARA EN CEROS PARA QUE NO SE PUEDA ENVIAR 
            //LA PETICION DE LA RECARGA 2 VECES O MAS EN CASO DE QUE LA CAJERA LO PULSE POR ERROR MAS DE 1 VEZ
            else {
                
                try
                {
                    //creamos los objetos para el WEB SERVICE
                    WSMTCenter.ServiceSoapClient ws = new WSMTCenter.ServiceSoapClient();
                    WSMTCenter.recargaRequestBody peticion = new WSMTCenter.recargaRequestBody();
                    WSMTCenter.recargaResponseBody respuesta = new WSMTCenter.recargaResponseBody();

                    WSMTCenter.InputRecarga inputRecarga = new WSMTCenter.InputRecarga();
                    WSMTCenter.OutputRecarga outputRecarga = new WSMTCenter.OutputRecarga();
                    WSMTCenter.Cuenta cuenta = new WSMTCenter.Cuenta();

                    // obtenemos la fila seleccionada.
                    DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;
                    
                    sku1 = row[0].Cells["sku"].Value.ToString();
                    producto = row[0].Cells["producto"].Value.ToString();
                    costo = row[0].Cells["costo"].Value.ToString();
                    String servidor = serv.GetServidor();
                    SqlConnection cn = new SqlConnection(servidor);
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    SqlDataReader lector;

                    string fecha = serv.Getfecha(DateTime.Now.ToString());
                    MessageBox.Show(fecha);

                    cmd.CommandText = "insert into Recarga values('"+ txtNum2.Text +"', '"+ sku1 +"', '"+ fecha +"', '14', 5000, 11678, 32424, '39326', 'F#(/G0@dwZ', '', '', '"+ producto + "',  '" + args[1] + "' , '"+costo+"', '')";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "Select * from Recarga where no_transaccion in(select MAX(no_transaccion)as maximo from Recarga)";
                    lector = cmd.ExecuteReader();
                    if (lector.HasRows)
                    {
                        lector.Read();

                        transaccion_0 = lector.GetInt32(0);
                        telefono_1 = lector.GetString(1);
                        sku_2 = lector.GetString(2);
                        fecha_hora_3 = lector.GetString(3);
                        cve_estado_4 = lector.GetString(4);
                        cadena_5 = lector.GetInt32(5);
                        establecimiento_6 = lector.GetInt32(6);
                        terminal_7 = lector.GetInt32(7);
                        cajero_8 = lector.GetString(8);
                        clave_9 = lector.GetString(9);

                        cuenta.cadena = cadena_5;
                        cuenta.establecimiento = establecimiento_6;
                        cuenta.terminal = terminal_7;
                        cuenta.cajero = cajero_8;
                        cuenta.clave = clave_9;
                        inputRecarga.cuenta = cuenta;

                        inputRecarga.no_transaccion = transaccion_0;
                        inputRecarga.telefono = telefono_1;
                        inputRecarga.sku = sku_2;
                        inputRecarga.fecha_hora = fecha_hora_3;
                        inputRecarga.cve_estado = cve_estado_4;

                        lector.Close();

                        outputRecarga = ws.recarga(inputRecarga);
                        
                        cr = outputRecarga.codigo_respuesta.ToString();

                        cmd.CommandText = "select * from codigoRespuesta where code = " + cr;
                        lector = cmd.ExecuteReader();

                        if (lector.HasRows)
                        {
                            lector.Read();
                            code = lector.GetString(0);
                            string descripcion = lector.GetString(1);
                            lector.Close();
                            cmd.CommandText = "update Recarga set code = '"+ code +"', descripcion = '"+ descripcion + "' where no_transaccion in(select MAX(no_transaccion)as maximo from Recarga)";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("CODIGO DE RESPUESTA: "+ code + " DESCRIPCION: " + descripcion + "");
                        }
                        else
                        {
                            lector.Close();
                            cmd.CommandText = "update Recarga set code = '" + cr + "', descripcion = 'CODIGO DE ERROR NO IDENTIFICADO' where no_transaccion in(select MAX(no_transaccion)as maximo from Recarga)";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show(cr + "-CODIGO DE ERROR NO IDENTIFICADO");
                        }
                    }else
                    {
                        MessageBox.Show("NO EXISTE LA RECARGA SELECCIONADA");
                    }
                    cn.Close();
                    
                    txtNum1.Text = "";
                    txtNum2.Text = "";

                    //IMPRIMIR TICKET *****************************************************************************************************************
                    try
                    {
                        
                        if (cr == "0")
                        {
                            CrearTicket ticket = new CrearTicket();
                    //verificar almacen
                            string sucursal = args[1].Substring(4, 2);
                    
                            if (sucursal == "01" || sucursal == "02" || sucursal == "03" || sucursal == "04" || sucursal == "05" || sucursal == "13" || sucursal == "14" || sucursal == "15" || sucursal == "19" || sucursal == "20") {
                                almacen = "01";//GUADALAJARA
                            } else if (sucursal == "06" || sucursal == "07" || sucursal == "08" || sucursal == "09") {
                                almacen = "02";//ATEQUIZA
                            } else if (sucursal == "10" || sucursal == "11" || sucursal == "12") {
                                almacen = "03"; //IXTLAHUACAN
                            } else if (sucursal == "21" || sucursal == "22" || sucursal == "23" || sucursal == "24" || sucursal == "25" || sucursal == "26" || sucursal == "27" || sucursal == "28" || sucursal == "29"){
                                almacen = "04"; //TLAJOMULCO
                            }
                            
                            //ticket.TextoIzquierda(" ");
                            ticket.TextoCentro("********* RECARGA TAE *********");
                            ticket.TextoIzquierda(" ");
                            ticket.TextoCentro("CASA GUERRERO DEPARTAMENTAL");
                            ticket.TextoCentro("COMERCIAL DE RETIRO S.A. DE C.V.");
                            ticket.TextoCentro("Manuel Acuña #56   Col. El Retiro");
                            ticket.TextoIzquierda(" ");
                            ticket.TextoIzquierda("Almacen:      " + almacen);
                            ticket.TextoIzquierda("Folio:        " + args[1]);
                            ticket.TextoIzquierda("Fecha:        " + fecha_hora_3.Substring(0, 10));
                            ticket.TextoIzquierda("Hora:         " + fecha_hora_3.Substring(11, 8));
                            ticket.TextoIzquierda("Vendedor:    CAJA " + args[1].Substring(4, 2));
                            ticket.TextoIzquierda(" ");
                            //ticket.TextoExtremos("FECHA : " + fecha_hora_3.Substring(0, 10), "HORA : " + fecha_hora_3.Substring(10, 9));
                            ticket.TextoIzquierda(" ");
                            ticket.EncabezadoVenta();
                            ticket.lineasGuio();
                            ticket.AgregaArticulo(producto + " " + telefono_1, 1, decimal.Parse(txtMonto.Text));
                            ticket.lineasIgual();
                            ticket.AgregarTotales("              TOTAL : $ ", decimal.Parse(txtMonto.Text));
                            ticket.TextoIzquierda(" ");
                            ticket.TextoIzquierda(" ");
                            ticket.TextoIzquierda("Transaccion               " + transaccion_0.ToString());
                            ticket.TextoIzquierda("Autorizacion              " + cr);
                            ticket.TextoIzquierda(" ");
                            ticket.TextoIzquierda(" ");
                            ticket.lineasIgual();
                            ticket.TextoIzquierda(" ");
                            ticket.TextoIzquierda(" ");
                            ticket.CortaTicket();
                            ticket.ImprimirTicket("EPSON TM-T20II Receipt");

                            montoSinPuntos = txtMonto.Text;
                            montoSinPuntos = montoSinPuntos.Replace(".", "");
                            int cantMonto = montoSinPuntos.Length;
                            if (cantMonto == 4){
                                montoSinPuntos = "000" + montoSinPuntos;
                            }
                            else if (cantMonto == 5) {
                                montoSinPuntos = "00" + montoSinPuntos;
                            }

                            cr = cr.PadLeft(20, ' ');

                            //MessageBox.Show(montoSinPuntos);
                            MessageBox.Show(cr.Length.ToString());
                            string texto = "TRXMTC" + "005000" + "011678" + fecha_hora_3.Substring(0, 10) + fecha_hora_3.Substring(11, 8) + montoSinPuntos + telefono_1 + cr;
                            File.AppendAllLines(ruta, new String[] { texto });
                            txtMonto.Text = "0.00";
                        }
                        else
                        {
                            montoSinPuntos = txtMonto.Text;
                            montoSinPuntos = montoSinPuntos.Replace(".", "");
                            int cantMonto = montoSinPuntos.Length;
                            if (cantMonto == 4)
                            {
                                montoSinPuntos = "000" + montoSinPuntos;
                            }
                            else if (cantMonto == 5)
                            {
                                montoSinPuntos = "00" + montoSinPuntos;
                            }

                            //Cambio de cr
                            
                            cr = cr.PadLeft(20, ' ');
                            
                            //MessageBox.Show(montoSinPuntos);
                            //MessageBox.Show(cr.Length.ToString());

                            string texto = "TRXMTC" + "005000" + "011678" + fecha_hora_3.Substring(0, 10) + fecha_hora_3.Substring(11, 8) + montoSinPuntos + telefono_1 + cr;
                            File.AppendAllLines(ruta, new String[] { texto });
                        }
                    }
                    catch (Exception eeee){
                        MessageBox.Show(eeee.Message);
                    }

                    //ACTUALIZAR EL ARCHIVO FTP********************************************************************************************************************
                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://consultorti.com.mx//MTCCTAE" + iDcadena + iDestablecimiento + yyyymmdd + ".txt");
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential("consulto", "W9fc02dL1a");
                    request.UsePassive = true;
                    request.UseBinary = true;
                    request.KeepAlive = true;
                    FileStream stream = File.OpenRead(ruta);
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    stream.Close();
                    Stream reqStream = request.GetRequestStream();
                    reqStream.Write(buffer, 0, buffer.Length);
                    reqStream.Flush();
                    reqStream.Close();
                    IntegracionRecargas ir = new IntegracionRecargas();
                    ir.Show();
                    this.Close();

                }
                catch (Exception ex){
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaRecargas cons = new ConsultaRecargas();
            cons.Show();
            this.Close();
        }
    }
}
