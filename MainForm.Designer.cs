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
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // tabMainForm
            // 
            this.tabMainForm.Controls.Add(this.tabConductor);
            this.tabMainForm.Controls.Add(this.tabCamiones);
            this.tabMainForm.Controls.Add(this.tabCamionesConductor);
            this.tabMainForm.Controls.Add(this.tabReportes);
            this.tabMainForm.Location = new System.Drawing.Point(3, 4);
            this.tabMainForm.Name = "tabMainForm";
            this.tabMainForm.SelectedIndex = 0;
            this.tabMainForm.Size = new System.Drawing.Size(785, 358);
            this.tabMainForm.TabIndex = 2;
            this.tabMainForm.SelectedIndexChanged += new System.EventHandler(this.tabMainForm_SelectedIndexChanged);
            this.tabMainForm.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabMainForm_Selected);
            // 
            // tabConductor
            // 
            this.tabConductor.Controls.Add(this.groupBox2);
            this.tabConductor.Controls.Add(this.gvConductores);
            this.tabConductor.Controls.Add(this.groupBox1);
            this.tabConductor.Location = new System.Drawing.Point(4, 22);
            this.tabConductor.Name = "tabConductor";
            this.tabConductor.Padding = new System.Windows.Forms.Padding(3);
            this.tabConductor.Size = new System.Drawing.Size(777, 332);
            this.tabConductor.TabIndex = 0;
            this.tabConductor.Text = "1. Conductor";
            this.tabConductor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerTodos);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Location = new System.Drawing.Point(6, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 38);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(236, 9);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(75, 23);
            this.btnVerTodos.TabIndex = 12;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(112, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // gvConductores
            // 
            this.gvConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.tabCamiones.Size = new System.Drawing.Size(777, 332);
            this.tabCamiones.TabIndex = 1;
            this.tabCamiones.Text = "2. Camiones";
            this.tabCamiones.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 38);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ver Todos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // gvCamiones
            // 
            this.gvCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            "",
            "Acura\t",
            "Alfa Romeo",
            "AMC\t",
            "Aro\t",
            "Asia\t",
            "Aston Martin",
            "Audi\t",
            "Austin\t",
            "Baw\t",
            "Bentley\t",
            "Bluebird\t",
            "BMW\t",
            "Brilliance\t",
            "Buick\t",
            "BYD\t",
            "Cadillac\t",
            "Chana\t",
            "Changan\t",
            "Chery\t",
            "Chevrolet\t",
            "Chrysler\t",
            "Citroen\t",
            "Dacia\t",
            "Daewoo\t",
            "Daihatsu\t",
            "Datsun\t",
            "Dodge/RAM\t",
            "Donfeng (ZNA)",
            "Eagle\t",
            "Faw\t",
            "Ferrari\t",
            "Fiat\t",
            "Ford\t",
            "Foton\t",
            "Freightliner\t",
            "Geely\t",
            "Genesis\t",
            "Geo\t",
            "GMC\t",
            "Gonow\t",
            "Great Wall",
            "Hafei\t",
            "Haima\t",
            "Heibao\t",
            "Higer\t",
            "Hino\t",
            "Honda\t",
            "Hummer\t",
            "Hyundai\t",
            "Infiniti\t",
            "International\t",
            "Isuzu\t",
            "Iveco\t",
            "JAC\t",
            "Jaguar\t",
            "Jeep\t",
            "Jinbei\t",
            "JMC\t",
            "Jonway\t",
            "Kenworth\t",
            "Kia\t",
            "Lada\t",
            "Lamborghini\t",
            "Lancia\t",
            "Land Rover",
            "Lexus\t",
            "Lifan\t",
            "Lincoln\t",
            "Lotus\t",
            "Mack\t",
            "Magiruz\t",
            "Mahindra\t",
            "Maserati\t",
            "Mazda\t",
            "Mercedes Benz",
            "Mercury\t",
            "MG\t",
            "Mini\t",
            "Mitsubishi\t",
            "Nissan\t",
            "Oldsmobile\t",
            "Opel\t",
            "Peterbilt\t",
            "Peugeot\t",
            "Plymouth\t",
            "Polarsun\t",
            "Pontiac\t",
            "Porsche\t",
            "Proton\t",
            "Rambler\t",
            "Renault\t",
            "Reva\t",
            "Rolls Royce",
            "Rover\t",
            "Saab\t",
            "Samsung\t",
            "Saturn\t",
            "Scania\t",
            "Scion\t",
            "Seat\t",
            "Skoda\t",
            "Smart\t",
            "Soueast\t",
            "Ssang Yong",
            "Subaru\t",
            "Suzuki\t",
            "Tianma\t",
            "Tiger Truck",
            "Toyota\t",
            "Volkswagen\t",
            "Volvo\t",
            "Western Star",
            "Yugo\t",
            "Zotye\t"});
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
            this.tabCamionesConductor.Location = new System.Drawing.Point(4, 22);
            this.tabCamionesConductor.Name = "tabCamionesConductor";
            this.tabCamionesConductor.Padding = new System.Windows.Forms.Padding(3);
            this.tabCamionesConductor.Size = new System.Drawing.Size(777, 332);
            this.tabCamionesConductor.TabIndex = 2;
            this.tabCamionesConductor.Text = "3. Camiones x Conductor";
            this.tabCamionesConductor.UseVisualStyleBackColor = true;
            // 
            // tabReportes
            // 
            this.tabReportes.Location = new System.Drawing.Point(4, 22);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabReportes.Size = new System.Drawing.Size(777, 332);
            this.tabReportes.TabIndex = 3;
            this.tabReportes.Text = "4. Mostrar Datos";
            this.tabReportes.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(7, 361);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(579, 71);
            this.lblResultado.TabIndex = 15;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(592, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 41);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.tabMainForm);
            this.Name = "MainForm";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMainForm;
        private System.Windows.Forms.TabPage tabConductor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
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
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.TabPage tabReportes;
        private System.Windows.Forms.Button btnSalir;
    }
}

