namespace TransportesCR2
{
    partial class MainForm
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
            this.tabMainForm = new System.Windows.Forms.TabControl();
            this.tabConductor = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnVerConductores = new System.Windows.Forms.Button();
            this.btnBuscarConductores = new System.Windows.Forms.Button();
            this.txtBuscarConductores = new System.Windows.Forms.TextBox();
            this.gvConductores = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRutaAsignada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarConductor = new System.Windows.Forms.Button();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.tabCamiones = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVerCamiones = new System.Windows.Forms.Button();
            this.btnBuscarCamiones = new System.Windows.Forms.Button();
            this.txtBuscarCamiones = new System.Windows.Forms.TextBox();
            this.gvCamiones = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.numModelo = new System.Windows.Forms.NumericUpDown();
            this.txtCapVolumen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardaCamion = new System.Windows.Forms.Button();
            this.txtCapKilos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabCamionesConductor = new System.Windows.Forms.TabPage();
            this.btnGuardarConductorxCamion = new System.Windows.Forms.Button();
            this.btnMoverIzquierda = new System.Windows.Forms.Button();
            this.btnMoverDerecha = new System.Windows.Forms.Button();
            this.listbAssigned = new System.Windows.Forms.ListBox();
            this.listbUnassigned = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRutaSeleccionado = new System.Windows.Forms.Label();
            this.lblPApellidoSeleccionado = new System.Windows.Forms.Label();
            this.lblNombreSeleccionado = new System.Windows.Forms.Label();
            this.lblIdentificacionSeleccionado = new System.Windows.Forms.Label();
            this.btnBuscarConductorxCamion = new System.Windows.Forms.Button();
            this.txtBuscarConductorSeleccionado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnFiltrarCamionesxConductor = new System.Windows.Forms.Button();
            this.txtBuscarConductorxCamion = new System.Windows.Forms.TextBox();
            this.btnVerTodosCamionesxConductor = new System.Windows.Forms.Button();
            this.gvConductorxCamion = new System.Windows.Forms.DataGridView();
            this.tabMainForm.SuspendLayout();
            this.tabConductor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConductores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabCamiones.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCamiones)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModelo)).BeginInit();
            this.tabCamionesConductor.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConductorxCamion)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMainForm
            // 
            this.tabMainForm.Controls.Add(this.tabConductor);
            this.tabMainForm.Controls.Add(this.tabCamiones);
            this.tabMainForm.Controls.Add(this.tabCamionesConductor);
            this.tabMainForm.Controls.Add(this.tabPage1);
            this.tabMainForm.Location = new System.Drawing.Point(3, 4);
            this.tabMainForm.Name = "tabMainForm";
            this.tabMainForm.SelectedIndex = 0;
            this.tabMainForm.Size = new System.Drawing.Size(616, 358);
            this.tabMainForm.TabIndex = 2;
            // 
            // tabConductor
            // 
            this.tabConductor.Controls.Add(this.groupBox2);
            this.tabConductor.Controls.Add(this.gvConductores);
            this.tabConductor.Controls.Add(this.groupBox1);
            this.tabConductor.Location = new System.Drawing.Point(4, 22);
            this.tabConductor.Name = "tabConductor";
            this.tabConductor.Padding = new System.Windows.Forms.Padding(3);
            this.tabConductor.Size = new System.Drawing.Size(608, 332);
            this.tabConductor.TabIndex = 0;
            this.tabConductor.Text = "1. Conductor";
            this.tabConductor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnVerConductores);
            this.groupBox2.Controls.Add(this.btnBuscarConductores);
            this.groupBox2.Controls.Add(this.txtBuscarConductores);
            this.groupBox2.Location = new System.Drawing.Point(6, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 38);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 1001;
            this.label10.Text = "Cedula";
            // 
            // btnVerConductores
            // 
            this.btnVerConductores.Location = new System.Drawing.Point(292, 8);
            this.btnVerConductores.Name = "btnVerConductores";
            this.btnVerConductores.Size = new System.Drawing.Size(75, 23);
            this.btnVerConductores.TabIndex = 12;
            this.btnVerConductores.Text = "Ver Todos";
            this.btnVerConductores.UseVisualStyleBackColor = true;
            this.btnVerConductores.Click += new System.EventHandler(this.btnVerConductores_Click);
            // 
            // btnBuscarConductores
            // 
            this.btnBuscarConductores.Location = new System.Drawing.Point(168, 9);
            this.btnBuscarConductores.Name = "btnBuscarConductores";
            this.btnBuscarConductores.Size = new System.Drawing.Size(118, 23);
            this.btnBuscarConductores.TabIndex = 11;
            this.btnBuscarConductores.Text = "Buscar Conductor";
            this.btnBuscarConductores.UseVisualStyleBackColor = true;
            this.btnBuscarConductores.Click += new System.EventHandler(this.btnBuscarConductores_Click);
            // 
            // txtBuscarConductores
            // 
            this.txtBuscarConductores.Location = new System.Drawing.Point(62, 11);
            this.txtBuscarConductores.MaxLength = 10;
            this.txtBuscarConductores.Name = "txtBuscarConductores";
            this.txtBuscarConductores.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarConductores.TabIndex = 10;
            this.txtBuscarConductores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarConductores_KeyDown);
            // 
            // gvConductores
            // 
            this.gvConductores.AllowUserToAddRows = false;
            this.gvConductores.AllowUserToDeleteRows = false;
            this.gvConductores.AllowUserToResizeColumns = false;
            this.gvConductores.AllowUserToResizeRows = false;
            this.gvConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvConductores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvConductores.Location = new System.Drawing.Point(6, 127);
            this.gvConductores.Name = "gvConductores";
            this.gvConductores.Size = new System.Drawing.Size(573, 196);
            this.gvConductores.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRutaAsignada);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnGuardarConductor);
            this.groupBox1.Controls.Add(this.txtApellido2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApellido1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.lblCedula);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtRutaAsignada
            // 
            this.txtRutaAsignada.Location = new System.Drawing.Point(382, 13);
            this.txtRutaAsignada.MaxLength = 200;
            this.txtRutaAsignada.Name = "txtRutaAsignada";
            this.txtRutaAsignada.Size = new System.Drawing.Size(185, 20);
            this.txtRutaAsignada.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ruta";
            // 
            // btnGuardarConductor
            // 
            this.btnGuardarConductor.Location = new System.Drawing.Point(382, 37);
            this.btnGuardarConductor.Name = "btnGuardarConductor";
            this.btnGuardarConductor.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarConductor.TabIndex = 6;
            this.btnGuardarConductor.Text = "Guardar";
            this.btnGuardarConductor.UseVisualStyleBackColor = true;
            this.btnGuardarConductor.Click += new System.EventHandler(this.btnGuardarConductor_Click);
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(236, 39);
            this.txtApellido2.MaxLength = 50;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(100, 20);
            this.txtApellido2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido 2";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(236, 13);
            this.txtApellido1.MaxLength = 50;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(100, 20);
            this.txtApellido1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellido 1";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 39);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(62, 13);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 0;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(6, 16);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 1000;
            this.lblCedula.Text = "Cedula";
            // 
            // tabCamiones
            // 
            this.tabCamiones.Controls.Add(this.groupBox3);
            this.tabCamiones.Controls.Add(this.gvCamiones);
            this.tabCamiones.Controls.Add(this.groupBox4);
            this.tabCamiones.Location = new System.Drawing.Point(4, 22);
            this.tabCamiones.Name = "tabCamiones";
            this.tabCamiones.Padding = new System.Windows.Forms.Padding(3);
            this.tabCamiones.Size = new System.Drawing.Size(608, 332);
            this.tabCamiones.TabIndex = 1;
            this.tabCamiones.Text = "2. Camiones";
            this.tabCamiones.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnVerCamiones);
            this.groupBox3.Controls.Add(this.btnBuscarCamiones);
            this.groupBox3.Controls.Add(this.txtBuscarCamiones);
            this.groupBox3.Location = new System.Drawing.Point(6, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(573, 38);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Placa";
            // 
            // btnVerCamiones
            // 
            this.btnVerCamiones.Location = new System.Drawing.Point(293, 9);
            this.btnVerCamiones.Name = "btnVerCamiones";
            this.btnVerCamiones.Size = new System.Drawing.Size(75, 23);
            this.btnVerCamiones.TabIndex = 12;
            this.btnVerCamiones.Text = "Ver Todos";
            this.btnVerCamiones.UseVisualStyleBackColor = true;
            this.btnVerCamiones.Click += new System.EventHandler(this.btnVerCamiones_Click);
            // 
            // btnBuscarCamiones
            // 
            this.btnBuscarCamiones.Location = new System.Drawing.Point(169, 10);
            this.btnBuscarCamiones.Name = "btnBuscarCamiones";
            this.btnBuscarCamiones.Size = new System.Drawing.Size(118, 23);
            this.btnBuscarCamiones.TabIndex = 11;
            this.btnBuscarCamiones.Text = "Buscar Camion";
            this.btnBuscarCamiones.UseVisualStyleBackColor = true;
            this.btnBuscarCamiones.Click += new System.EventHandler(this.btnBuscarCamiones_Click);
            // 
            // txtBuscarCamiones
            // 
            this.txtBuscarCamiones.Location = new System.Drawing.Point(63, 12);
            this.txtBuscarCamiones.MaxLength = 8;
            this.txtBuscarCamiones.Name = "txtBuscarCamiones";
            this.txtBuscarCamiones.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarCamiones.TabIndex = 10;
            this.txtBuscarCamiones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarCamiones_KeyDown);
            // 
            // gvCamiones
            // 
            this.gvCamiones.AllowUserToAddRows = false;
            this.gvCamiones.AllowUserToDeleteRows = false;
            this.gvCamiones.AllowUserToResizeColumns = false;
            this.gvCamiones.AllowUserToResizeRows = false;
            this.gvCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCamiones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvCamiones.Location = new System.Drawing.Point(6, 127);
            this.gvCamiones.Name = "gvCamiones";
            this.gvCamiones.Size = new System.Drawing.Size(573, 196);
            this.gvCamiones.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbMarca);
            this.groupBox4.Controls.Add(this.numModelo);
            this.groupBox4.Controls.Add(this.txtCapVolumen);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnGuardaCamion);
            this.groupBox4.Controls.Add(this.txtCapKilos);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtPlaca);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(573, 71);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Acura",
            "Alfa Romeo",
            "AMC",
            "Aro",
            "Asia",
            "Aston Martin",
            "Audi",
            "Austin",
            "Baw",
            "Bentley",
            "Bluebird",
            "BMW",
            "Brilliance",
            "Buick",
            "BYD",
            "Cadillac",
            "Chana",
            "Changan",
            "Chery",
            "Chevrolet",
            "Chrysler",
            "Citroen",
            "Dacia",
            "Daewoo",
            "Daihatsu",
            "Datsun",
            "Dodge/RAM",
            "Donfeng (ZNA)",
            "Eagle",
            "Faw",
            "Ferrari",
            "Fiat",
            "Ford",
            "Foton",
            "Freightliner",
            "Geely",
            "Genesis",
            "Geo",
            "GMC",
            "Gonow",
            "Great Wall",
            "Hafei",
            "Haima",
            "Heibao",
            "Higer",
            "Hino",
            "Honda",
            "Hummer",
            "Hyundai",
            "Infiniti",
            "International",
            "Isuzu",
            "Iveco",
            "JAC",
            "Jaguar",
            "Jeep",
            "Jinbei",
            "JMC",
            "Jonway",
            "Kenworth",
            "Kia",
            "Lada",
            "Lamborghini",
            "Lancia",
            "Land Rover",
            "Lexus",
            "Lifan",
            "Lincoln",
            "Lotus",
            "Mack",
            "Magiruz",
            "Mahindra",
            "Maserati",
            "Mazda",
            "Mercedes Benz",
            "Mercury",
            "MG",
            "Mini",
            "Mitsubishi\t",
            "Nissan",
            "Oldsmobile",
            "Opel",
            "Peterbilt",
            "Peugeot",
            "Plymouth",
            "Polarsun",
            "Pontiac",
            "Porsche",
            "Proton",
            "Rambler",
            "Renault",
            "Reva",
            "Rolls Royce",
            "Rover",
            "Saab",
            "Samsung",
            "Saturn",
            "Scania",
            "Scion",
            "Seat",
            "Skoda",
            "Smart",
            "Soueast",
            "Ssang Yong",
            "Subaru",
            "Suzuki",
            "Tianma",
            "Tiger Truck",
            "Toyota",
            "Volkswagen",
            "Volvo",
            "Western Star",
            "Yugo",
            "Zotye"});
            this.cbMarca.Location = new System.Drawing.Point(236, 13);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(100, 21);
            this.cbMarca.TabIndex = 3;
            // 
            // numModelo
            // 
            this.numModelo.Location = new System.Drawing.Point(62, 42);
            this.numModelo.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numModelo.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numModelo.Name = "numModelo";
            this.numModelo.ReadOnly = true;
            this.numModelo.Size = new System.Drawing.Size(56, 20);
            this.numModelo.TabIndex = 2;
            this.numModelo.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // txtCapVolumen
            // 
            this.txtCapVolumen.Location = new System.Drawing.Point(425, 13);
            this.txtCapVolumen.Name = "txtCapVolumen";
            this.txtCapVolumen.Size = new System.Drawing.Size(100, 20);
            this.txtCapVolumen.TabIndex = 5;
            this.txtCapVolumen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapVolumen_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cap. Volumen";
            // 
            // btnGuardaCamion
            // 
            this.btnGuardaCamion.Location = new System.Drawing.Point(425, 37);
            this.btnGuardaCamion.Name = "btnGuardaCamion";
            this.btnGuardaCamion.Size = new System.Drawing.Size(75, 23);
            this.btnGuardaCamion.TabIndex = 6;
            this.btnGuardaCamion.Text = "Guardar";
            this.btnGuardaCamion.UseVisualStyleBackColor = true;
            this.btnGuardaCamion.Click += new System.EventHandler(this.btnGuardaCamion_Click);
            // 
            // txtCapKilos
            // 
            this.txtCapKilos.Location = new System.Drawing.Point(236, 39);
            this.txtCapKilos.Name = "txtCapKilos";
            this.txtCapKilos.Size = new System.Drawing.Size(100, 20);
            this.txtCapKilos.TabIndex = 4;
            this.txtCapKilos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapKilos_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cap. Kilos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Marca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Modelo";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(62, 13);
            this.txtPlaca.MaxLength = 8;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Placa";
            // 
            // tabCamionesConductor
            // 
            this.tabCamionesConductor.Controls.Add(this.btnGuardarConductorxCamion);
            this.tabCamionesConductor.Controls.Add(this.btnMoverIzquierda);
            this.tabCamionesConductor.Controls.Add(this.btnMoverDerecha);
            this.tabCamionesConductor.Controls.Add(this.listbAssigned);
            this.tabCamionesConductor.Controls.Add(this.listbUnassigned);
            this.tabCamionesConductor.Controls.Add(this.groupBox5);
            this.tabCamionesConductor.Location = new System.Drawing.Point(4, 22);
            this.tabCamionesConductor.Name = "tabCamionesConductor";
            this.tabCamionesConductor.Padding = new System.Windows.Forms.Padding(3);
            this.tabCamionesConductor.Size = new System.Drawing.Size(608, 332);
            this.tabCamionesConductor.TabIndex = 2;
            this.tabCamionesConductor.Text = "3. Asignar Camiones";
            this.tabCamionesConductor.UseVisualStyleBackColor = true;
            // 
            // btnGuardarConductorxCamion
            // 
            this.btnGuardarConductorxCamion.Location = new System.Drawing.Point(91, 291);
            this.btnGuardarConductorxCamion.Name = "btnGuardarConductorxCamion";
            this.btnGuardarConductorxCamion.Size = new System.Drawing.Size(186, 23);
            this.btnGuardarConductorxCamion.TabIndex = 9;
            this.btnGuardarConductorxCamion.Text = "Guardar Camiones Asignados";
            this.btnGuardarConductorxCamion.UseVisualStyleBackColor = true;
            this.btnGuardarConductorxCamion.Click += new System.EventHandler(this.btnGuardarConductorxCamion_Click);
            // 
            // btnMoverIzquierda
            // 
            this.btnMoverIzquierda.Location = new System.Drawing.Point(201, 262);
            this.btnMoverIzquierda.Name = "btnMoverIzquierda";
            this.btnMoverIzquierda.Size = new System.Drawing.Size(144, 23);
            this.btnMoverIzquierda.TabIndex = 8;
            this.btnMoverIzquierda.Text = "<<< Remover Camion";
            this.btnMoverIzquierda.UseVisualStyleBackColor = true;
            this.btnMoverIzquierda.Click += new System.EventHandler(this.btnMoverIzquierda_Click);
            // 
            // btnMoverDerecha
            // 
            this.btnMoverDerecha.Location = new System.Drawing.Point(6, 262);
            this.btnMoverDerecha.Name = "btnMoverDerecha";
            this.btnMoverDerecha.Size = new System.Drawing.Size(144, 23);
            this.btnMoverDerecha.TabIndex = 7;
            this.btnMoverDerecha.Text = "Asignar Camion >>>";
            this.btnMoverDerecha.UseVisualStyleBackColor = true;
            this.btnMoverDerecha.Click += new System.EventHandler(this.btnMoverDerecha_Click);
            // 
            // listbAssigned
            // 
            this.listbAssigned.FormattingEnabled = true;
            this.listbAssigned.Location = new System.Drawing.Point(201, 102);
            this.listbAssigned.Name = "listbAssigned";
            this.listbAssigned.Size = new System.Drawing.Size(144, 147);
            this.listbAssigned.TabIndex = 6;
            // 
            // listbUnassigned
            // 
            this.listbUnassigned.FormattingEnabled = true;
            this.listbUnassigned.Location = new System.Drawing.Point(6, 102);
            this.listbUnassigned.Name = "listbUnassigned";
            this.listbUnassigned.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listbUnassigned.Size = new System.Drawing.Size(144, 147);
            this.listbUnassigned.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.lblRutaSeleccionado);
            this.groupBox5.Controls.Add(this.lblPApellidoSeleccionado);
            this.groupBox5.Controls.Add(this.lblNombreSeleccionado);
            this.groupBox5.Controls.Add(this.lblIdentificacionSeleccionado);
            this.groupBox5.Controls.Add(this.btnBuscarConductorxCamion);
            this.groupBox5.Controls.Add(this.txtBuscarConductorSeleccionado);
            this.groupBox5.Location = new System.Drawing.Point(6, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(563, 93);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 1005;
            this.label9.Text = "Cedula";
            // 
            // lblRutaSeleccionado
            // 
            this.lblRutaSeleccionado.AutoSize = true;
            this.lblRutaSeleccionado.Location = new System.Drawing.Point(9, 64);
            this.lblRutaSeleccionado.Name = "lblRutaSeleccionado";
            this.lblRutaSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.lblRutaSeleccionado.TabIndex = 1003;
            // 
            // lblPApellidoSeleccionado
            // 
            this.lblPApellidoSeleccionado.AutoSize = true;
            this.lblPApellidoSeleccionado.Location = new System.Drawing.Point(192, 42);
            this.lblPApellidoSeleccionado.Name = "lblPApellidoSeleccionado";
            this.lblPApellidoSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.lblPApellidoSeleccionado.TabIndex = 1002;
            // 
            // lblNombreSeleccionado
            // 
            this.lblNombreSeleccionado.AutoSize = true;
            this.lblNombreSeleccionado.Location = new System.Drawing.Point(82, 42);
            this.lblNombreSeleccionado.Name = "lblNombreSeleccionado";
            this.lblNombreSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.lblNombreSeleccionado.TabIndex = 1001;
            // 
            // lblIdentificacionSeleccionado
            // 
            this.lblIdentificacionSeleccionado.AutoSize = true;
            this.lblIdentificacionSeleccionado.Location = new System.Drawing.Point(9, 42);
            this.lblIdentificacionSeleccionado.Name = "lblIdentificacionSeleccionado";
            this.lblIdentificacionSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.lblIdentificacionSeleccionado.TabIndex = 1004;
            // 
            // btnBuscarConductorxCamion
            // 
            this.btnBuscarConductorxCamion.Location = new System.Drawing.Point(155, 10);
            this.btnBuscarConductorxCamion.Name = "btnBuscarConductorxCamion";
            this.btnBuscarConductorxCamion.Size = new System.Drawing.Size(116, 23);
            this.btnBuscarConductorxCamion.TabIndex = 11;
            this.btnBuscarConductorxCamion.Text = "Buscar Conductor";
            this.btnBuscarConductorxCamion.UseVisualStyleBackColor = true;
            this.btnBuscarConductorxCamion.Click += new System.EventHandler(this.btnBuscarConductorxCamion_Click);
            // 
            // txtBuscarConductorSeleccionado
            // 
            this.txtBuscarConductorSeleccionado.Location = new System.Drawing.Point(49, 12);
            this.txtBuscarConductorSeleccionado.MaxLength = 10;
            this.txtBuscarConductorSeleccionado.Name = "txtBuscarConductorSeleccionado";
            this.txtBuscarConductorSeleccionado.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarConductorSeleccionado.TabIndex = 10;
            this.txtBuscarConductorSeleccionado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarConductorSeleccionado_KeyDown);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(7, 361);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(456, 48);
            this.lblResultado.TabIndex = 15;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(491, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 41);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gvConductorxCamion);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(608, 332);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "4. Conductor x Camion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnVerTodosCamionesxConductor);
            this.groupBox6.Controls.Add(this.btnFiltrarCamionesxConductor);
            this.groupBox6.Controls.Add(this.txtBuscarConductorxCamion);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(573, 42);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // btnFiltrarCamionesxConductor
            // 
            this.btnFiltrarCamionesxConductor.Location = new System.Drawing.Point(155, 10);
            this.btnFiltrarCamionesxConductor.Name = "btnFiltrarCamionesxConductor";
            this.btnFiltrarCamionesxConductor.Size = new System.Drawing.Size(116, 23);
            this.btnFiltrarCamionesxConductor.TabIndex = 11;
            this.btnFiltrarCamionesxConductor.Text = "Filtrar";
            this.btnFiltrarCamionesxConductor.UseVisualStyleBackColor = true;
            this.btnFiltrarCamionesxConductor.Click += new System.EventHandler(this.btnFiltrarCamionesxConductor_Click);
            // 
            // txtBuscarConductorxCamion
            // 
            this.txtBuscarConductorxCamion.Location = new System.Drawing.Point(49, 12);
            this.txtBuscarConductorxCamion.MaxLength = 10;
            this.txtBuscarConductorxCamion.Name = "txtBuscarConductorxCamion";
            this.txtBuscarConductorxCamion.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarConductorxCamion.TabIndex = 10;
            this.txtBuscarConductorxCamion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarConductorxCamion_KeyDown);
            // 
            // btnVerTodosCamionesxConductor
            // 
            this.btnVerTodosCamionesxConductor.Location = new System.Drawing.Point(277, 10);
            this.btnVerTodosCamionesxConductor.Name = "btnVerTodosCamionesxConductor";
            this.btnVerTodosCamionesxConductor.Size = new System.Drawing.Size(75, 23);
            this.btnVerTodosCamionesxConductor.TabIndex = 13;
            this.btnVerTodosCamionesxConductor.Text = "Ver Todos";
            this.btnVerTodosCamionesxConductor.UseVisualStyleBackColor = true;
            this.btnVerTodosCamionesxConductor.Click += new System.EventHandler(this.btnVerTodosCamionesxConductor_Click);
            // 
            // gvConductorxCamion
            // 
            this.gvConductorxCamion.AllowUserToAddRows = false;
            this.gvConductorxCamion.AllowUserToDeleteRows = false;
            this.gvConductorxCamion.AllowUserToResizeColumns = false;
            this.gvConductorxCamion.AllowUserToResizeRows = false;
            this.gvConductorxCamion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvConductorxCamion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvConductorxCamion.Location = new System.Drawing.Point(3, 41);
            this.gvConductorxCamion.Name = "gvConductorxCamion";
            this.gvConductorxCamion.Size = new System.Drawing.Size(573, 285);
            this.gvConductorxCamion.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 424);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.tabMainForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabMainForm.ResumeLayout(false);
            this.tabConductor.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConductores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCamiones.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCamiones)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModelo)).EndInit();
            this.tabCamionesConductor.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConductorxCamion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMainForm;
        private System.Windows.Forms.TabPage tabConductor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarConductores;
        private System.Windows.Forms.TextBox txtBuscarConductores;
        private System.Windows.Forms.DataGridView gvConductores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardarConductor;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TabPage tabCamiones;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtRutaAsignada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerConductores;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVerCamiones;
        private System.Windows.Forms.Button btnBuscarCamiones;
        private System.Windows.Forms.TextBox txtBuscarCamiones;
        private System.Windows.Forms.DataGridView gvCamiones;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.NumericUpDown numModelo;
        private System.Windows.Forms.TextBox txtCapVolumen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardaCamion;
        private System.Windows.Forms.TextBox txtCapKilos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabCamionesConductor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox listbAssigned;
        private System.Windows.Forms.ListBox listbUnassigned;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblRutaSeleccionado;
        private System.Windows.Forms.Label lblPApellidoSeleccionado;
        private System.Windows.Forms.Label lblNombreSeleccionado;
        private System.Windows.Forms.Label lblIdentificacionSeleccionado;
        private System.Windows.Forms.Button btnBuscarConductorxCamion;
        private System.Windows.Forms.TextBox txtBuscarConductorSeleccionado;
        private System.Windows.Forms.Button btnMoverDerecha;
        private System.Windows.Forms.Button btnMoverIzquierda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardarConductorxCamion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gvConductorxCamion;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnVerTodosCamionesxConductor;
        private System.Windows.Forms.Button btnFiltrarCamionesxConductor;
        private System.Windows.Forms.TextBox txtBuscarConductorxCamion;
    }
}

