namespace CasaGuerrero
{
    partial class IntegracionRecargas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntegracionRecargas));
            this.btnRecarga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.rbTelcelInternet = new System.Windows.Forms.RadioButton();
            this.rbTelcelAmigoSinLimite = new System.Windows.Forms.RadioButton();
            this.rbTelcelTae = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnVirginMobile = new System.Windows.Forms.Button();
            this.btnNextel = new System.Windows.Forms.Button();
            this.btnUnefon = new System.Windows.Forms.Button();
            this.btnAtYtIusacell = new System.Windows.Forms.Button();
            this.btnMovistar = new System.Windows.Forms.Button();
            this.btnAlo = new System.Windows.Forms.Button();
            this.btnTelcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecarga
            // 
            this.btnRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecarga.Location = new System.Drawing.Point(438, 288);
            this.btnRecarga.Name = "btnRecarga";
            this.btnRecarga.Size = new System.Drawing.Size(105, 33);
            this.btnRecarga.TabIndex = 1;
            this.btnRecarga.Text = "Aceptar";
            this.btnRecarga.UseVisualStyleBackColor = true;
            this.btnRecarga.Click += new System.EventHandler(this.BtnRecarga_Click);
            this.btnRecarga.Leave += new System.EventHandler(this.BtnRecarga_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.rbTelcelInternet);
            this.groupBox1.Controls.Add(this.rbTelcelAmigoSinLimite);
            this.groupBox1.Controls.Add(this.rbTelcelTae);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNum2);
            this.groupBox1.Controls.Add(this.txtNum1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnRecarga);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 384);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(438, 327);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(214, 33);
            this.btnConsultar.TabIndex = 17;
            this.btnConsultar.Text = "Consultar recargas";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // rbTelcelInternet
            // 
            this.rbTelcelInternet.AutoSize = true;
            this.rbTelcelInternet.Location = new System.Drawing.Point(220, 64);
            this.rbTelcelInternet.Name = "rbTelcelInternet";
            this.rbTelcelInternet.Size = new System.Drawing.Size(191, 20);
            this.rbTelcelInternet.TabIndex = 16;
            this.rbTelcelInternet.TabStop = true;
            this.rbTelcelInternet.Text = "................Telcel Internet (F10)";
            this.rbTelcelInternet.UseVisualStyleBackColor = true;
            this.rbTelcelInternet.Visible = false;
            this.rbTelcelInternet.CheckedChanged += new System.EventHandler(this.RbTelcelInternet_CheckedChanged);
            // 
            // rbTelcelAmigoSinLimite
            // 
            this.rbTelcelAmigoSinLimite.AutoSize = true;
            this.rbTelcelAmigoSinLimite.Location = new System.Drawing.Point(220, 43);
            this.rbTelcelAmigoSinLimite.Name = "rbTelcelAmigoSinLimite";
            this.rbTelcelAmigoSinLimite.Size = new System.Drawing.Size(190, 20);
            this.rbTelcelAmigoSinLimite.TabIndex = 15;
            this.rbTelcelAmigoSinLimite.TabStop = true;
            this.rbTelcelAmigoSinLimite.Text = "Telcel Amigo sin Lìmite (F9)";
            this.rbTelcelAmigoSinLimite.UseVisualStyleBackColor = true;
            this.rbTelcelAmigoSinLimite.Visible = false;
            this.rbTelcelAmigoSinLimite.CheckedChanged += new System.EventHandler(this.RbTelcelAmigoSinLimite_CheckedChanged);
            // 
            // rbTelcelTae
            // 
            this.rbTelcelTae.AutoSize = true;
            this.rbTelcelTae.Location = new System.Drawing.Point(220, 22);
            this.rbTelcelTae.Name = "rbTelcelTae";
            this.rbTelcelTae.Size = new System.Drawing.Size(189, 20);
            this.rbTelcelTae.TabIndex = 14;
            this.rbTelcelTae.TabStop = true;
            this.rbTelcelTae.Text = ".......................Telcel TAE (F8)";
            this.rbTelcelTae.UseVisualStyleBackColor = true;
            this.rbTelcelTae.Visible = false;
            this.rbTelcelTae.CheckedChanged += new System.EventHandler(this.RbTelcelTae_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(543, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 33);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            this.btnCancelar.Leave += new System.EventHandler(this.BtnCancelar_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMonto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(438, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 58);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.AutoSize = true;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(102, 20);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(62, 29);
            this.txtMonto.TabIndex = 7;
            this.txtMonto.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Seleccione el tipo de recarga: ";
            this.label7.Visible = false;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(438, 256);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(214, 26);
            this.txtNum2.TabIndex = 5;
            this.txtNum2.TextChanged += new System.EventHandler(this.TxtNum2_TextChanged);
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum2_KeyPress);
            this.txtNum2.Leave += new System.EventHandler(this.TxtNum2_Leave);
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(438, 208);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(214, 26);
            this.txtNum1.TabIndex = 4;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum1_KeyPress);
            this.txtNum1.Leave += new System.EventHandler(this.TxtNum1_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Repetir nùmero de celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nùmero de celular (10 digitos):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione el monto de la recarga:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.costo,
            this.sku});
            this.dataGridView1.Location = new System.Drawing.Point(27, 128);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(367, 234);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // producto
            // 
            this.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.producto.HeaderText = "PRODUCTO";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 5;
            // 
            // costo
            // 
            this.costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.costo.HeaderText = "COSTO";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            this.costo.Width = 5;
            // 
            // sku
            // 
            this.sku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sku.HeaderText = "SKU";
            this.sku.Name = "sku";
            this.sku.ReadOnly = true;
            this.sku.Width = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "TELCEL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "ALO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "MOVISTAR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(347, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "AT&T IUSACELL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(452, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "UNEFON";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(557, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "NEXTEL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(663, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "VIRGIN MOBILE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(662, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "(F7)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(556, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "(F6)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(451, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "(F5)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(346, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "(F4)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(241, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "(F3)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(136, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "(F2)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(37, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "(F1)";
            // 
            // btnVirginMobile
            // 
            this.btnVirginMobile.BackgroundImage = global::CasaGuerrero.Properties.Resources.VIRGINMOBILE;
            this.btnVirginMobile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVirginMobile.ForeColor = System.Drawing.Color.LightGray;
            this.btnVirginMobile.Location = new System.Drawing.Point(665, 37);
            this.btnVirginMobile.Name = "btnVirginMobile";
            this.btnVirginMobile.Size = new System.Drawing.Size(99, 70);
            this.btnVirginMobile.TabIndex = 9;
            this.btnVirginMobile.UseVisualStyleBackColor = true;
            this.btnVirginMobile.Click += new System.EventHandler(this.BtnVirginMobile_Click);
            // 
            // btnNextel
            // 
            this.btnNextel.BackgroundImage = global::CasaGuerrero.Properties.Resources.NEXTEL;
            this.btnNextel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextel.ForeColor = System.Drawing.Color.LightGray;
            this.btnNextel.Location = new System.Drawing.Point(560, 37);
            this.btnNextel.Name = "btnNextel";
            this.btnNextel.Size = new System.Drawing.Size(99, 70);
            this.btnNextel.TabIndex = 7;
            this.btnNextel.UseVisualStyleBackColor = true;
            this.btnNextel.Click += new System.EventHandler(this.BtnNextel_Click);
            // 
            // btnUnefon
            // 
            this.btnUnefon.BackgroundImage = global::CasaGuerrero.Properties.Resources.UNEFON;
            this.btnUnefon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnefon.ForeColor = System.Drawing.Color.LightGray;
            this.btnUnefon.Location = new System.Drawing.Point(455, 37);
            this.btnUnefon.Name = "btnUnefon";
            this.btnUnefon.Size = new System.Drawing.Size(99, 70);
            this.btnUnefon.TabIndex = 6;
            this.btnUnefon.UseVisualStyleBackColor = true;
            this.btnUnefon.Click += new System.EventHandler(this.BtnUnefon_Click);
            // 
            // btnAtYtIusacell
            // 
            this.btnAtYtIusacell.BackgroundImage = global::CasaGuerrero.Properties.Resources.ATT;
            this.btnAtYtIusacell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtYtIusacell.ForeColor = System.Drawing.Color.LightGray;
            this.btnAtYtIusacell.Location = new System.Drawing.Point(350, 37);
            this.btnAtYtIusacell.Name = "btnAtYtIusacell";
            this.btnAtYtIusacell.Size = new System.Drawing.Size(99, 70);
            this.btnAtYtIusacell.TabIndex = 5;
            this.btnAtYtIusacell.UseVisualStyleBackColor = true;
            this.btnAtYtIusacell.Click += new System.EventHandler(this.BtnAtYtIusacell_Click);
            // 
            // btnMovistar
            // 
            this.btnMovistar.BackgroundImage = global::CasaGuerrero.Properties.Resources.MOVISTAR;
            this.btnMovistar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMovistar.ForeColor = System.Drawing.Color.LightGray;
            this.btnMovistar.Location = new System.Drawing.Point(245, 37);
            this.btnMovistar.Name = "btnMovistar";
            this.btnMovistar.Size = new System.Drawing.Size(99, 70);
            this.btnMovistar.TabIndex = 4;
            this.btnMovistar.UseVisualStyleBackColor = true;
            this.btnMovistar.Click += new System.EventHandler(this.BtnMovistar_Click);
            // 
            // btnAlo
            // 
            this.btnAlo.BackgroundImage = global::CasaGuerrero.Properties.Resources.ALO;
            this.btnAlo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlo.ForeColor = System.Drawing.Color.LightGray;
            this.btnAlo.Location = new System.Drawing.Point(140, 37);
            this.btnAlo.Name = "btnAlo";
            this.btnAlo.Size = new System.Drawing.Size(99, 70);
            this.btnAlo.TabIndex = 3;
            this.btnAlo.UseVisualStyleBackColor = true;
            this.btnAlo.Click += new System.EventHandler(this.BtnAlo_Click);
            // 
            // btnTelcel
            // 
            this.btnTelcel.BackgroundImage = global::CasaGuerrero.Properties.Resources.TELCEL;
            this.btnTelcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTelcel.ForeColor = System.Drawing.Color.LightGray;
            this.btnTelcel.Location = new System.Drawing.Point(35, 37);
            this.btnTelcel.Name = "btnTelcel";
            this.btnTelcel.Size = new System.Drawing.Size(99, 70);
            this.btnTelcel.TabIndex = 2;
            this.btnTelcel.UseVisualStyleBackColor = true;
            this.btnTelcel.Click += new System.EventHandler(this.BtnTelcel_Click);
            // 
            // IntegracionRecargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 545);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVirginMobile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNextel);
            this.Controls.Add(this.btnUnefon);
            this.Controls.Add(this.btnAtYtIusacell);
            this.Controls.Add(this.btnMovistar);
            this.Controls.Add(this.btnAlo);
            this.Controls.Add(this.btnTelcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IntegracionRecargas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTEGRACIÒN RECARGAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRecarga;
        private System.Windows.Forms.Button btnTelcel;
        private System.Windows.Forms.Button btnAlo;
        private System.Windows.Forms.Button btnMovistar;
        private System.Windows.Forms.Button btnAtYtIusacell;
        private System.Windows.Forms.Button btnUnefon;
        private System.Windows.Forms.Button btnNextel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVirginMobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbTelcelInternet;
        private System.Windows.Forms.RadioButton rbTelcelAmigoSinLimite;
        private System.Windows.Forms.RadioButton rbTelcelTae;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sku;
        private System.Windows.Forms.Button btnConsultar;
    }
}

