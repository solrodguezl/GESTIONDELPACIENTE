namespace WindowsFormsApp1
{
    partial class DatosGeneralesPaciente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosGeneralesPaciente));
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxInformacionPersonal = new System.Windows.Forms.GroupBox();
            this.RbtnPasaporte = new System.Windows.Forms.RadioButton();
            this.RbtnTarjetaIdentidad = new System.Windows.Forms.RadioButton();
            this.RbtnCedula = new System.Windows.Forms.RadioButton();
            this.PickFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ComBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.ComBoxGenero = new System.Windows.Forms.ComboBox();
            this.TxtSegundoApellido = new System.Windows.Forms.TextBox();
            this.TxtPrimerApellido = new System.Windows.Forms.TextBox();
            this.TxtSegundoNombre = new System.Windows.Forms.TextBox();
            this.TxtPrimerNombre = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.GroupBoxDatosEconomicos = new System.Windows.Forms.GroupBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.ComBoxTipoVivienda = new System.Windows.Forms.ComboBox();
            this.ComBoxReduccionAutonomia = new System.Windows.Forms.ComboBox();
            this.ComBoxRecursosEconomicos = new System.Windows.Forms.ComboBox();
            this.ComBoxSituacionLaboral = new System.Windows.Forms.ComboBox();
            this.LblReduccionAutonomia = new System.Windows.Forms.Label();
            this.LblDirecciónResidencia = new System.Windows.Forms.Label();
            this.LblTipoVivienda = new System.Windows.Forms.Label();
            this.LblRecursosEconomicos = new System.Windows.Forms.Label();
            this.LblSituacionLaboral = new System.Windows.Forms.Label();
            this.RbtnSI = new System.Windows.Forms.RadioButton();
            this.RbtnNO = new System.Windows.Forms.RadioButton();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.BtnAceptar1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBoxInformacionPersonal.SuspendLayout();
            this.GroupBoxDatosEconomicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS GENERALES DEL PACIENTE";
            // 
            // GroupBoxInformacionPersonal
            // 
            this.GroupBoxInformacionPersonal.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.GroupBoxInformacionPersonal.AutoSize = true;
            this.GroupBoxInformacionPersonal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GroupBoxInformacionPersonal.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxInformacionPersonal.Controls.Add(this.RbtnPasaporte);
            this.GroupBoxInformacionPersonal.Controls.Add(this.RbtnTarjetaIdentidad);
            this.GroupBoxInformacionPersonal.Controls.Add(this.RbtnCedula);
            this.GroupBoxInformacionPersonal.Controls.Add(this.PickFechaNacimiento);
            this.GroupBoxInformacionPersonal.Controls.Add(this.ComBoxDepartamento);
            this.GroupBoxInformacionPersonal.Controls.Add(this.ComBoxGenero);
            this.GroupBoxInformacionPersonal.Controls.Add(this.TxtSegundoApellido);
            this.GroupBoxInformacionPersonal.Controls.Add(this.TxtPrimerApellido);
            this.GroupBoxInformacionPersonal.Controls.Add(this.TxtSegundoNombre);
            this.GroupBoxInformacionPersonal.Controls.Add(this.TxtPrimerNombre);
            this.GroupBoxInformacionPersonal.Controls.Add(this.lblDepartamento);
            this.GroupBoxInformacionPersonal.Controls.Add(this.lblDocumento);
            this.GroupBoxInformacionPersonal.Controls.Add(this.lblFechaNacimiento);
            this.GroupBoxInformacionPersonal.Controls.Add(this.lblGenero);
            this.GroupBoxInformacionPersonal.Controls.Add(this.lblSegundoApellido);
            this.GroupBoxInformacionPersonal.Controls.Add(this.lblSegundoNombre);
            this.GroupBoxInformacionPersonal.Controls.Add(this.lblPrimerApellido);
            this.GroupBoxInformacionPersonal.Controls.Add(this.lblPrimerNombre);
            this.GroupBoxInformacionPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupBoxInformacionPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxInformacionPersonal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBoxInformacionPersonal.Location = new System.Drawing.Point(25, 70);
            this.GroupBoxInformacionPersonal.Name = "GroupBoxInformacionPersonal";
            this.GroupBoxInformacionPersonal.Size = new System.Drawing.Size(732, 210);
            this.GroupBoxInformacionPersonal.TabIndex = 1;
            this.GroupBoxInformacionPersonal.TabStop = false;
            this.GroupBoxInformacionPersonal.Text = "INFORMACIÓN PERSONAL";
            this.GroupBoxInformacionPersonal.Enter += new System.EventHandler(this.GroupBoxInformacionPersonal_Enter);
            // 
            // RbtnPasaporte
            // 
            this.RbtnPasaporte.AutoSize = true;
            this.RbtnPasaporte.Location = new System.Drawing.Point(581, 171);
            this.RbtnPasaporte.Name = "RbtnPasaporte";
            this.RbtnPasaporte.Size = new System.Drawing.Size(76, 17);
            this.RbtnPasaporte.TabIndex = 21;
            this.RbtnPasaporte.TabStop = true;
            this.RbtnPasaporte.Text = "Pasaporte.";
            this.RbtnPasaporte.UseVisualStyleBackColor = true;
            // 
            // RbtnTarjetaIdentidad
            // 
            this.RbtnTarjetaIdentidad.AutoSize = true;
            this.RbtnTarjetaIdentidad.Location = new System.Drawing.Point(581, 143);
            this.RbtnTarjetaIdentidad.Name = "RbtnTarjetaIdentidad";
            this.RbtnTarjetaIdentidad.Size = new System.Drawing.Size(122, 17);
            this.RbtnTarjetaIdentidad.TabIndex = 20;
            this.RbtnTarjetaIdentidad.TabStop = true;
            this.RbtnTarjetaIdentidad.Text = "Tarjeta de identidad.";
            this.RbtnTarjetaIdentidad.UseVisualStyleBackColor = true;
            // 
            // RbtnCedula
            // 
            this.RbtnCedula.AutoSize = true;
            this.RbtnCedula.Location = new System.Drawing.Point(581, 120);
            this.RbtnCedula.Name = "RbtnCedula";
            this.RbtnCedula.Size = new System.Drawing.Size(61, 17);
            this.RbtnCedula.TabIndex = 19;
            this.RbtnCedula.TabStop = true;
            this.RbtnCedula.Text = "Cédula.";
            this.RbtnCedula.UseVisualStyleBackColor = true;
            // 
            // PickFechaNacimiento
            // 
            this.PickFechaNacimiento.Location = new System.Drawing.Point(136, 120);
            this.PickFechaNacimiento.Name = "PickFechaNacimiento";
            this.PickFechaNacimiento.Size = new System.Drawing.Size(224, 20);
            this.PickFechaNacimiento.TabIndex = 18;
            // 
            // ComBoxDepartamento
            // 
            this.ComBoxDepartamento.FormattingEnabled = true;
            this.ComBoxDepartamento.Items.AddRange(new object[] {
            "Antioquia",
            "Amazonas",
            "Arauca",
            "Atlántico",
            "Manizales",
            "Caldas",
            "Caquetá",
            "Casanare",
            "Córdoba",
            "Guainía",
            "Guaviare",
            "Huila",
            "Risaralda",
            "Tolima",
            "Santander",
            "Sucre",
            "San Andrés",
            "Valle del cauca"});
            this.ComBoxDepartamento.Location = new System.Drawing.Point(111, 170);
            this.ComBoxDepartamento.Name = "ComBoxDepartamento";
            this.ComBoxDepartamento.Size = new System.Drawing.Size(201, 21);
            this.ComBoxDepartamento.TabIndex = 17;
            // 
            // ComBoxGenero
            // 
            this.ComBoxGenero.FormattingEnabled = true;
            this.ComBoxGenero.Items.AddRange(new object[] {
            "Mujer",
            "Hombre",
            "Otro"});
            this.ComBoxGenero.Location = new System.Drawing.Point(594, 36);
            this.ComBoxGenero.Name = "ComBoxGenero";
            this.ComBoxGenero.Size = new System.Drawing.Size(132, 21);
            this.ComBoxGenero.TabIndex = 16;
            // 
            // TxtSegundoApellido
            // 
            this.TxtSegundoApellido.Location = new System.Drawing.Point(375, 81);
            this.TxtSegundoApellido.Name = "TxtSegundoApellido";
            this.TxtSegundoApellido.Size = new System.Drawing.Size(161, 20);
            this.TxtSegundoApellido.TabIndex = 11;
            // 
            // TxtPrimerApellido
            // 
            this.TxtPrimerApellido.Location = new System.Drawing.Point(92, 80);
            this.TxtPrimerApellido.Name = "TxtPrimerApellido";
            this.TxtPrimerApellido.Size = new System.Drawing.Size(174, 20);
            this.TxtPrimerApellido.TabIndex = 10;
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.Location = new System.Drawing.Point(375, 36);
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(161, 20);
            this.TxtSegundoNombre.TabIndex = 9;
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.Location = new System.Drawing.Point(92, 37);
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.Size = new System.Drawing.Size(174, 20);
            this.TxtPrimerNombre.TabIndex = 8;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(10, 173);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(552, 88);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(104, 13);
            this.lblDocumento.TabIndex = 6;
            this.lblDocumento.Text = "Tipo de Documento:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(10, 126);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 5;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(552, 40);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Género:";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(281, 86);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(92, 13);
            this.lblSegundoApellido.TabIndex = 3;
            this.lblSegundoApellido.Text = "Segundo apellido:";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Location = new System.Drawing.Point(281, 40);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(91, 13);
            this.lblSegundoNombre.TabIndex = 2;
            this.lblSegundoNombre.Text = "Segundo nombre:";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(10, 86);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(78, 13);
            this.lblPrimerApellido.TabIndex = 1;
            this.lblPrimerApellido.Text = "Primer apellido:";
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Location = new System.Drawing.Point(10, 40);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(77, 13);
            this.lblPrimerNombre.TabIndex = 0;
            this.lblPrimerNombre.Text = "Primer nombre:";
            this.lblPrimerNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // GroupBoxDatosEconomicos
            // 
            this.GroupBoxDatosEconomicos.Controls.Add(this.TxtDireccion);
            this.GroupBoxDatosEconomicos.Controls.Add(this.ComBoxTipoVivienda);
            this.GroupBoxDatosEconomicos.Controls.Add(this.ComBoxReduccionAutonomia);
            this.GroupBoxDatosEconomicos.Controls.Add(this.ComBoxRecursosEconomicos);
            this.GroupBoxDatosEconomicos.Controls.Add(this.ComBoxSituacionLaboral);
            this.GroupBoxDatosEconomicos.Controls.Add(this.LblReduccionAutonomia);
            this.GroupBoxDatosEconomicos.Controls.Add(this.LblDirecciónResidencia);
            this.GroupBoxDatosEconomicos.Controls.Add(this.LblTipoVivienda);
            this.GroupBoxDatosEconomicos.Controls.Add(this.LblRecursosEconomicos);
            this.GroupBoxDatosEconomicos.Controls.Add(this.LblSituacionLaboral);
            this.GroupBoxDatosEconomicos.Controls.Add(this.RbtnSI);
            this.GroupBoxDatosEconomicos.Controls.Add(this.RbtnNO);
            this.GroupBoxDatosEconomicos.Controls.Add(this.LblProveedor);
            this.GroupBoxDatosEconomicos.Location = new System.Drawing.Point(25, 314);
            this.GroupBoxDatosEconomicos.Name = "GroupBoxDatosEconomicos";
            this.GroupBoxDatosEconomicos.Size = new System.Drawing.Size(879, 201);
            this.GroupBoxDatosEconomicos.TabIndex = 2;
            this.GroupBoxDatosEconomicos.TabStop = false;
            this.GroupBoxDatosEconomicos.Text = "DATOS ECONÓMICOS";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(508, 114);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(274, 20);
            this.TxtDireccion.TabIndex = 12;
            this.TxtDireccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ComBoxTipoVivienda
            // 
            this.ComBoxTipoVivienda.FormattingEnabled = true;
            this.ComBoxTipoVivienda.Items.AddRange(new object[] {
            "Propia",
            "Familiar",
            "Arrendada",
            "Institucionalizado/a",
            "Otro"});
            this.ComBoxTipoVivienda.Location = new System.Drawing.Point(508, 77);
            this.ComBoxTipoVivienda.Name = "ComBoxTipoVivienda";
            this.ComBoxTipoVivienda.Size = new System.Drawing.Size(183, 21);
            this.ComBoxTipoVivienda.TabIndex = 11;
            // 
            // ComBoxReduccionAutonomia
            // 
            this.ComBoxReduccionAutonomia.FormattingEnabled = true;
            this.ComBoxReduccionAutonomia.Items.AddRange(new object[] {
            "Ninguna",
            "Leve",
            "Grave",
            "Total"});
            this.ComBoxReduccionAutonomia.Location = new System.Drawing.Point(352, 154);
            this.ComBoxReduccionAutonomia.Name = "ComBoxReduccionAutonomia";
            this.ComBoxReduccionAutonomia.Size = new System.Drawing.Size(220, 21);
            this.ComBoxReduccionAutonomia.TabIndex = 10;
            // 
            // ComBoxRecursosEconomicos
            // 
            this.ComBoxRecursosEconomicos.FormattingEnabled = true;
            this.ComBoxRecursosEconomicos.Items.AddRange(new object[] {
            "Inferior a un SMMLV",
            "1 SMMLV",
            "Superior a 1 SMMLV",
            "Subsidios",
            "Aportes familiares",
            "Sin ingresos económicos",
            "Otro"});
            this.ComBoxRecursosEconomicos.Location = new System.Drawing.Point(140, 111);
            this.ComBoxRecursosEconomicos.Name = "ComBoxRecursosEconomicos";
            this.ComBoxRecursosEconomicos.Size = new System.Drawing.Size(220, 21);
            this.ComBoxRecursosEconomicos.TabIndex = 9;
            // 
            // ComBoxSituacionLaboral
            // 
            this.ComBoxSituacionLaboral.FormattingEnabled = true;
            this.ComBoxSituacionLaboral.Items.AddRange(new object[] {
            "Desempleado",
            "Trabajador informal",
            "Pensionado",
            "Independiente",
            "Empleado",
            "Ama/o de casa",
            "Cuidador principal ",
            "Incapacidad laboral prolongada",
            "Otro"});
            this.ComBoxSituacionLaboral.Location = new System.Drawing.Point(140, 77);
            this.ComBoxSituacionLaboral.Name = "ComBoxSituacionLaboral";
            this.ComBoxSituacionLaboral.Size = new System.Drawing.Size(220, 21);
            this.ComBoxSituacionLaboral.TabIndex = 8;
            // 
            // LblReduccionAutonomia
            // 
            this.LblReduccionAutonomia.AutoSize = true;
            this.LblReduccionAutonomia.Location = new System.Drawing.Point(22, 154);
            this.LblReduccionAutonomia.Name = "LblReduccionAutonomia";
            this.LblReduccionAutonomia.Size = new System.Drawing.Size(324, 13);
            this.LblReduccionAutonomia.TabIndex = 7;
            this.LblReduccionAutonomia.Text = "Nivel de reducción en la autonomía física y psíquica del paciente: ";
            // 
            // LblDirecciónResidencia
            // 
            this.LblDirecciónResidencia.AutoSize = true;
            this.LblDirecciónResidencia.Location = new System.Drawing.Point(378, 114);
            this.LblDirecciónResidencia.Name = "LblDirecciónResidencia";
            this.LblDirecciónResidencia.Size = new System.Drawing.Size(124, 13);
            this.LblDirecciónResidencia.TabIndex = 6;
            this.LblDirecciónResidencia.Text = "Dirección de residencia: ";
            // 
            // LblTipoVivienda
            // 
            this.LblTipoVivienda.AutoSize = true;
            this.LblTipoVivienda.Location = new System.Drawing.Point(410, 80);
            this.LblTipoVivienda.Name = "LblTipoVivienda";
            this.LblTipoVivienda.Size = new System.Drawing.Size(92, 13);
            this.LblTipoVivienda.TabIndex = 5;
            this.LblTipoVivienda.Text = "Tipo de vivienda: ";
            // 
            // LblRecursosEconomicos
            // 
            this.LblRecursosEconomicos.AutoSize = true;
            this.LblRecursosEconomicos.Location = new System.Drawing.Point(22, 114);
            this.LblRecursosEconomicos.Name = "LblRecursosEconomicos";
            this.LblRecursosEconomicos.Size = new System.Drawing.Size(115, 13);
            this.LblRecursosEconomicos.TabIndex = 4;
            this.LblRecursosEconomicos.Text = "Recursos económicos:";
            // 
            // LblSituacionLaboral
            // 
            this.LblSituacionLaboral.AutoSize = true;
            this.LblSituacionLaboral.Location = new System.Drawing.Point(36, 80);
            this.LblSituacionLaboral.Name = "LblSituacionLaboral";
            this.LblSituacionLaboral.Size = new System.Drawing.Size(88, 13);
            this.LblSituacionLaboral.TabIndex = 3;
            this.LblSituacionLaboral.Text = "Situación laboral:";
            this.LblSituacionLaboral.Click += new System.EventHandler(this.LblSituacionLaboral_Click);
            // 
            // RbtnSI
            // 
            this.RbtnSI.AutoSize = true;
            this.RbtnSI.Location = new System.Drawing.Point(316, 37);
            this.RbtnSI.Name = "RbtnSI";
            this.RbtnSI.Size = new System.Drawing.Size(39, 17);
            this.RbtnSI.TabIndex = 2;
            this.RbtnSI.TabStop = true;
            this.RbtnSI.Text = "Sí.";
            this.RbtnSI.UseVisualStyleBackColor = true;
            // 
            // RbtnNO
            // 
            this.RbtnNO.AutoSize = true;
            this.RbtnNO.Location = new System.Drawing.Point(361, 37);
            this.RbtnNO.Name = "RbtnNO";
            this.RbtnNO.Size = new System.Drawing.Size(42, 17);
            this.RbtnNO.TabIndex = 1;
            this.RbtnNO.TabStop = true;
            this.RbtnNO.Text = "No.";
            this.RbtnNO.UseVisualStyleBackColor = true;
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Location = new System.Drawing.Point(33, 37);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(257, 13);
            this.LblProveedor.TabIndex = 0;
            this.LblProveedor.Text = "¿El paciente es/era el proveedor principal del hogar?";
            this.LblProveedor.Click += new System.EventHandler(this.LblProveedor_Click);
            // 
            // BtnAceptar1
            // 
            this.BtnAceptar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAceptar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar1.Location = new System.Drawing.Point(626, 533);
            this.BtnAceptar1.Name = "BtnAceptar1";
            this.BtnAceptar1.Size = new System.Drawing.Size(102, 44);
            this.BtnAceptar1.TabIndex = 3;
            this.BtnAceptar1.Text = "Aceptar";
            this.BtnAceptar1.UseVisualStyleBackColor = false;
            this.BtnAceptar1.Click += new System.EventHandler(this.BtnAceptar1_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DatosGeneralesPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(916, 589);
            this.Controls.Add(this.BtnAceptar1);
            this.Controls.Add(this.GroupBoxDatosEconomicos);
            this.Controls.Add(this.GroupBoxInformacionPersonal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatosGeneralesPaciente";
            this.Text = "F02 Datos Generales Paciente";
            this.Load += new System.EventHandler(this.DatosGeneralesPaciente_Load);
            this.GroupBoxInformacionPersonal.ResumeLayout(false);
            this.GroupBoxInformacionPersonal.PerformLayout();
            this.GroupBoxDatosEconomicos.ResumeLayout(false);
            this.GroupBoxDatosEconomicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupBoxInformacionPersonal;
        private System.Windows.Forms.TextBox TxtSegundoApellido;
        private System.Windows.Forms.TextBox TxtPrimerApellido;
        private System.Windows.Forms.TextBox TxtSegundoNombre;
        private System.Windows.Forms.TextBox TxtPrimerNombre;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.DateTimePicker PickFechaNacimiento;
        private System.Windows.Forms.ComboBox ComBoxDepartamento;
        private System.Windows.Forms.ComboBox ComBoxGenero;
        private System.Windows.Forms.GroupBox GroupBoxDatosEconomicos;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.RadioButton RbtnPasaporte;
        private System.Windows.Forms.RadioButton RbtnTarjetaIdentidad;
        private System.Windows.Forms.RadioButton RbtnCedula;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.ComboBox ComBoxTipoVivienda;
        private System.Windows.Forms.ComboBox ComBoxReduccionAutonomia;
        private System.Windows.Forms.ComboBox ComBoxRecursosEconomicos;
        private System.Windows.Forms.ComboBox ComBoxSituacionLaboral;
        private System.Windows.Forms.Label LblReduccionAutonomia;
        private System.Windows.Forms.Label LblDirecciónResidencia;
        private System.Windows.Forms.Label LblTipoVivienda;
        private System.Windows.Forms.Label LblRecursosEconomicos;
        private System.Windows.Forms.Label LblSituacionLaboral;
        private System.Windows.Forms.RadioButton RbtnSI;
        private System.Windows.Forms.RadioButton RbtnNO;
        private System.Windows.Forms.Button BtnAceptar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}