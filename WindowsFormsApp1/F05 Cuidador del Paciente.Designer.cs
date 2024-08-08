﻿namespace WindowsFormsApp1
{
    partial class CuidadorPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuidadorPaciente));
            this.LblCuidadorPaciente = new System.Windows.Forms.Label();
            this.LblNombresCuidador = new System.Windows.Forms.Label();
            this.LblApellidosCuidador = new System.Windows.Forms.Label();
            this.LblTipoDocCuidador = new System.Windows.Forms.Label();
            this.LblNumeroDocumentoCuidador = new System.Windows.Forms.Label();
            this.LblEdadCuidador = new System.Windows.Forms.Label();
            this.LblEnfermedadCuidador = new System.Windows.Forms.Label();
            this.LblCelularCuidador = new System.Windows.Forms.Label();
            this.LblCorreoCuidador = new System.Windows.Forms.Label();
            this.LblParentescoCuidador = new System.Windows.Forms.Label();
            this.CkBoxHipertensionCuidador = new System.Windows.Forms.CheckBox();
            this.CkBoxEnfermedadRenal = new System.Windows.Forms.CheckBox();
            this.CkBoxEnfermedadPulmonarCuidador = new System.Windows.Forms.CheckBox();
            this.CkBoxTrastornoNeuroCuidador = new System.Windows.Forms.CheckBox();
            this.CkBoxDiabetesCuidador = new System.Windows.Forms.CheckBox();
            this.GroupBoxEnfermedadesCuidador = new System.Windows.Forms.GroupBox();
            this.GroupBoxAfiliacionCuidador = new System.Windows.Forms.GroupBox();
            this.CkBoxNoAfiliado = new System.Windows.Forms.CheckBox();
            this.CkBoxSiAfiliado = new System.Windows.Forms.CheckBox();
            this.LblAfiliacionCuidador = new System.Windows.Forms.Label();
            this.TxtNombres5 = new System.Windows.Forms.TextBox();
            this.TxtApellidos5 = new System.Windows.Forms.TextBox();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.TxtEdad5 = new System.Windows.Forms.TextBox();
            this.TxtCelular5 = new System.Windows.Forms.TextBox();
            this.TxtCorreo5 = new System.Windows.Forms.TextBox();
            this.ComBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.ComBoxParentesco5 = new System.Windows.Forms.ComboBox();
            this.GroupBoxControlesCuidador = new System.Windows.Forms.GroupBox();
            this.ComBoxProgramasDeCuidado = new System.Windows.Forms.ComboBox();
            this.ComBoxTest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblParticipaProgramasCuidador = new System.Windows.Forms.Label();
            this.CkBoxOtroCuidador = new System.Windows.Forms.CheckBox();
            this.CkBoxAfiliacionCuidador = new System.Windows.Forms.CheckBox();
            this.CkBoxAgotamiento = new System.Windows.Forms.CheckBox();
            this.CkBoxRelevo = new System.Windows.Forms.CheckBox();
            this.CkBoxNoquiere = new System.Windows.Forms.CheckBox();
            this.CkBoxTemor = new System.Windows.Forms.CheckBox();
            this.CkBoxTiempo = new System.Windows.Forms.CheckBox();
            this.LblControlesCuidador = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.erpCuidador = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBoxEnfermedadesCuidador.SuspendLayout();
            this.GroupBoxAfiliacionCuidador.SuspendLayout();
            this.GroupBoxControlesCuidador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCuidador)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCuidadorPaciente
            // 
            this.LblCuidadorPaciente.AutoSize = true;
            this.LblCuidadorPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCuidadorPaciente.Location = new System.Drawing.Point(41, 9);
            this.LblCuidadorPaciente.Name = "LblCuidadorPaciente";
            this.LblCuidadorPaciente.Size = new System.Drawing.Size(228, 26);
            this.LblCuidadorPaciente.TabIndex = 0;
            this.LblCuidadorPaciente.Text = "Cuidador del Paciente.";
            this.LblCuidadorPaciente.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblNombresCuidador
            // 
            this.LblNombresCuidador.AutoSize = true;
            this.LblNombresCuidador.Location = new System.Drawing.Point(43, 54);
            this.LblNombresCuidador.Name = "LblNombresCuidador";
            this.LblNombresCuidador.Size = new System.Drawing.Size(52, 13);
            this.LblNombresCuidador.TabIndex = 1;
            this.LblNombresCuidador.Text = "Nombres:";
            // 
            // LblApellidosCuidador
            // 
            this.LblApellidosCuidador.AutoSize = true;
            this.LblApellidosCuidador.Location = new System.Drawing.Point(327, 54);
            this.LblApellidosCuidador.Name = "LblApellidosCuidador";
            this.LblApellidosCuidador.Size = new System.Drawing.Size(52, 13);
            this.LblApellidosCuidador.TabIndex = 2;
            this.LblApellidosCuidador.Text = "Apellidos:";
            // 
            // LblTipoDocCuidador
            // 
            this.LblTipoDocCuidador.AutoSize = true;
            this.LblTipoDocCuidador.Location = new System.Drawing.Point(43, 106);
            this.LblTipoDocCuidador.Name = "LblTipoDocCuidador";
            this.LblTipoDocCuidador.Size = new System.Drawing.Size(102, 13);
            this.LblTipoDocCuidador.TabIndex = 3;
            this.LblTipoDocCuidador.Text = "Tipo de documento:";
            // 
            // LblNumeroDocumentoCuidador
            // 
            this.LblNumeroDocumentoCuidador.AutoSize = true;
            this.LblNumeroDocumentoCuidador.Location = new System.Drawing.Point(267, 106);
            this.LblNumeroDocumentoCuidador.Name = "LblNumeroDocumentoCuidador";
            this.LblNumeroDocumentoCuidador.Size = new System.Drawing.Size(121, 13);
            this.LblNumeroDocumentoCuidador.TabIndex = 4;
            this.LblNumeroDocumentoCuidador.Text = "Número de documento: ";
            // 
            // LblEdadCuidador
            // 
            this.LblEdadCuidador.AutoSize = true;
            this.LblEdadCuidador.Location = new System.Drawing.Point(636, 110);
            this.LblEdadCuidador.Name = "LblEdadCuidador";
            this.LblEdadCuidador.Size = new System.Drawing.Size(35, 13);
            this.LblEdadCuidador.TabIndex = 5;
            this.LblEdadCuidador.Text = "Edad:";
            // 
            // LblEnfermedadCuidador
            // 
            this.LblEnfermedadCuidador.AutoSize = true;
            this.LblEnfermedadCuidador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnfermedadCuidador.Location = new System.Drawing.Point(16, 36);
            this.LblEnfermedadCuidador.Name = "LblEnfermedadCuidador";
            this.LblEnfermedadCuidador.Size = new System.Drawing.Size(227, 16);
            this.LblEnfermedadCuidador.TabIndex = 6;
            this.LblEnfermedadCuidador.Text = "¿Sufre de alguna enfermedad? Cuál: ";
            // 
            // LblCelularCuidador
            // 
            this.LblCelularCuidador.AutoSize = true;
            this.LblCelularCuidador.Location = new System.Drawing.Point(46, 160);
            this.LblCelularCuidador.Name = "LblCelularCuidador";
            this.LblCelularCuidador.Size = new System.Drawing.Size(45, 13);
            this.LblCelularCuidador.TabIndex = 7;
            this.LblCelularCuidador.Text = "Celular: ";
            // 
            // LblCorreoCuidador
            // 
            this.LblCorreoCuidador.AutoSize = true;
            this.LblCorreoCuidador.Location = new System.Drawing.Point(280, 160);
            this.LblCorreoCuidador.Name = "LblCorreoCuidador";
            this.LblCorreoCuidador.Size = new System.Drawing.Size(99, 13);
            this.LblCorreoCuidador.TabIndex = 8;
            this.LblCorreoCuidador.Text = "Correo electrónico: ";
            // 
            // LblParentescoCuidador
            // 
            this.LblParentescoCuidador.AutoSize = true;
            this.LblParentescoCuidador.Location = new System.Drawing.Point(43, 209);
            this.LblParentescoCuidador.Name = "LblParentescoCuidador";
            this.LblParentescoCuidador.Size = new System.Drawing.Size(67, 13);
            this.LblParentescoCuidador.TabIndex = 9;
            this.LblParentescoCuidador.Text = "Parentesco: ";
            // 
            // CkBoxHipertensionCuidador
            // 
            this.CkBoxHipertensionCuidador.AutoSize = true;
            this.CkBoxHipertensionCuidador.Location = new System.Drawing.Point(55, 77);
            this.CkBoxHipertensionCuidador.Name = "CkBoxHipertensionCuidador";
            this.CkBoxHipertensionCuidador.Size = new System.Drawing.Size(122, 17);
            this.CkBoxHipertensionCuidador.TabIndex = 10;
            this.CkBoxHipertensionCuidador.Text = "Hipertensión arterial.";
            this.CkBoxHipertensionCuidador.UseVisualStyleBackColor = true;
            // 
            // CkBoxEnfermedadRenal
            // 
            this.CkBoxEnfermedadRenal.AutoSize = true;
            this.CkBoxEnfermedadRenal.Location = new System.Drawing.Point(55, 127);
            this.CkBoxEnfermedadRenal.Name = "CkBoxEnfermedadRenal";
            this.CkBoxEnfermedadRenal.Size = new System.Drawing.Size(174, 17);
            this.CkBoxEnfermedadRenal.TabIndex = 11;
            this.CkBoxEnfermedadRenal.Text = "Enfermedad renal Crónica I y II.";
            this.CkBoxEnfermedadRenal.UseVisualStyleBackColor = true;
            // 
            // CkBoxEnfermedadPulmonarCuidador
            // 
            this.CkBoxEnfermedadPulmonarCuidador.AutoSize = true;
            this.CkBoxEnfermedadPulmonarCuidador.Location = new System.Drawing.Point(293, 77);
            this.CkBoxEnfermedadPulmonarCuidador.Name = "CkBoxEnfermedadPulmonarCuidador";
            this.CkBoxEnfermedadPulmonarCuidador.Size = new System.Drawing.Size(132, 17);
            this.CkBoxEnfermedadPulmonarCuidador.TabIndex = 12;
            this.CkBoxEnfermedadPulmonarCuidador.Text = "Enfermedad pulmonar.";
            this.CkBoxEnfermedadPulmonarCuidador.UseVisualStyleBackColor = true;
            // 
            // CkBoxTrastornoNeuroCuidador
            // 
            this.CkBoxTrastornoNeuroCuidador.AutoSize = true;
            this.CkBoxTrastornoNeuroCuidador.Location = new System.Drawing.Point(293, 104);
            this.CkBoxTrastornoNeuroCuidador.Name = "CkBoxTrastornoNeuroCuidador";
            this.CkBoxTrastornoNeuroCuidador.Size = new System.Drawing.Size(147, 17);
            this.CkBoxTrastornoNeuroCuidador.TabIndex = 13;
            this.CkBoxTrastornoNeuroCuidador.Text = "Trastorno neurocognitivo.";
            this.CkBoxTrastornoNeuroCuidador.UseVisualStyleBackColor = true;
            // 
            // CkBoxDiabetesCuidador
            // 
            this.CkBoxDiabetesCuidador.AutoSize = true;
            this.CkBoxDiabetesCuidador.Location = new System.Drawing.Point(55, 104);
            this.CkBoxDiabetesCuidador.Name = "CkBoxDiabetesCuidador";
            this.CkBoxDiabetesCuidador.Size = new System.Drawing.Size(109, 17);
            this.CkBoxDiabetesCuidador.TabIndex = 14;
            this.CkBoxDiabetesCuidador.Text = "Diabetes Mielitus.";
            this.CkBoxDiabetesCuidador.UseVisualStyleBackColor = true;
            // 
            // GroupBoxEnfermedadesCuidador
            // 
            this.GroupBoxEnfermedadesCuidador.Controls.Add(this.LblEnfermedadCuidador);
            this.GroupBoxEnfermedadesCuidador.Controls.Add(this.CkBoxDiabetesCuidador);
            this.GroupBoxEnfermedadesCuidador.Controls.Add(this.CkBoxHipertensionCuidador);
            this.GroupBoxEnfermedadesCuidador.Controls.Add(this.CkBoxEnfermedadRenal);
            this.GroupBoxEnfermedadesCuidador.Controls.Add(this.CkBoxTrastornoNeuroCuidador);
            this.GroupBoxEnfermedadesCuidador.Controls.Add(this.CkBoxEnfermedadPulmonarCuidador);
            this.GroupBoxEnfermedadesCuidador.Location = new System.Drawing.Point(46, 238);
            this.GroupBoxEnfermedadesCuidador.Name = "GroupBoxEnfermedadesCuidador";
            this.GroupBoxEnfermedadesCuidador.Size = new System.Drawing.Size(476, 165);
            this.GroupBoxEnfermedadesCuidador.TabIndex = 16;
            this.GroupBoxEnfermedadesCuidador.TabStop = false;
            this.GroupBoxEnfermedadesCuidador.Text = "ENFERMEDADES CRÓNICAS DEL CUIDADOR";
            // 
            // GroupBoxAfiliacionCuidador
            // 
            this.GroupBoxAfiliacionCuidador.Controls.Add(this.CkBoxNoAfiliado);
            this.GroupBoxAfiliacionCuidador.Controls.Add(this.CkBoxSiAfiliado);
            this.GroupBoxAfiliacionCuidador.Controls.Add(this.LblAfiliacionCuidador);
            this.GroupBoxAfiliacionCuidador.Location = new System.Drawing.Point(554, 238);
            this.GroupBoxAfiliacionCuidador.Name = "GroupBoxAfiliacionCuidador";
            this.GroupBoxAfiliacionCuidador.Size = new System.Drawing.Size(299, 165);
            this.GroupBoxAfiliacionCuidador.TabIndex = 17;
            this.GroupBoxAfiliacionCuidador.TabStop = false;
            this.GroupBoxAfiliacionCuidador.Text = "AFILIACIÓN";
            // 
            // CkBoxNoAfiliado
            // 
            this.CkBoxNoAfiliado.AutoSize = true;
            this.CkBoxNoAfiliado.Location = new System.Drawing.Point(53, 113);
            this.CkBoxNoAfiliado.Name = "CkBoxNoAfiliado";
            this.CkBoxNoAfiliado.Size = new System.Drawing.Size(43, 17);
            this.CkBoxNoAfiliado.TabIndex = 2;
            this.CkBoxNoAfiliado.Text = "No.";
            this.CkBoxNoAfiliado.UseVisualStyleBackColor = true;
            // 
            // CkBoxSiAfiliado
            // 
            this.CkBoxSiAfiliado.AutoSize = true;
            this.CkBoxSiAfiliado.Location = new System.Drawing.Point(53, 77);
            this.CkBoxSiAfiliado.Name = "CkBoxSiAfiliado";
            this.CkBoxSiAfiliado.Size = new System.Drawing.Size(40, 17);
            this.CkBoxSiAfiliado.TabIndex = 1;
            this.CkBoxSiAfiliado.Text = "Sí.";
            this.CkBoxSiAfiliado.UseVisualStyleBackColor = true;
            // 
            // LblAfiliacionCuidador
            // 
            this.LblAfiliacionCuidador.AutoSize = true;
            this.LblAfiliacionCuidador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAfiliacionCuidador.Location = new System.Drawing.Point(24, 36);
            this.LblAfiliacionCuidador.Name = "LblAfiliacionCuidador";
            this.LblAfiliacionCuidador.Size = new System.Drawing.Size(179, 16);
            this.LblAfiliacionCuidador.TabIndex = 0;
            this.LblAfiliacionCuidador.Text = "¿Está afiliado a Nueva EPS?";
            // 
            // TxtNombres5
            // 
            this.TxtNombres5.Location = new System.Drawing.Point(101, 51);
            this.TxtNombres5.Name = "TxtNombres5";
            this.TxtNombres5.Size = new System.Drawing.Size(220, 20);
            this.TxtNombres5.TabIndex = 18;
            // 
            // TxtApellidos5
            // 
            this.TxtApellidos5.Location = new System.Drawing.Point(397, 51);
            this.TxtApellidos5.Name = "TxtApellidos5";
            this.TxtApellidos5.Size = new System.Drawing.Size(257, 20);
            this.TxtApellidos5.TabIndex = 19;
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(397, 103);
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(204, 20);
            this.TxtNumeroDocumento.TabIndex = 20;
            // 
            // TxtEdad5
            // 
            this.TxtEdad5.Location = new System.Drawing.Point(677, 106);
            this.TxtEdad5.Name = "TxtEdad5";
            this.TxtEdad5.Size = new System.Drawing.Size(55, 20);
            this.TxtEdad5.TabIndex = 21;
            // 
            // TxtCelular5
            // 
            this.TxtCelular5.Location = new System.Drawing.Point(97, 157);
            this.TxtCelular5.Name = "TxtCelular5";
            this.TxtCelular5.Size = new System.Drawing.Size(143, 20);
            this.TxtCelular5.TabIndex = 22;
            // 
            // TxtCorreo5
            // 
            this.TxtCorreo5.Location = new System.Drawing.Point(394, 152);
            this.TxtCorreo5.Name = "TxtCorreo5";
            this.TxtCorreo5.Size = new System.Drawing.Size(260, 20);
            this.TxtCorreo5.TabIndex = 23;
            // 
            // ComBoxTipoDocumento
            // 
            this.ComBoxTipoDocumento.FormattingEnabled = true;
            this.ComBoxTipoDocumento.Items.AddRange(new object[] {
            "CC",
            "TI",
            "PASAPORTE"});
            this.ComBoxTipoDocumento.Location = new System.Drawing.Point(151, 102);
            this.ComBoxTipoDocumento.Name = "ComBoxTipoDocumento";
            this.ComBoxTipoDocumento.Size = new System.Drawing.Size(89, 21);
            this.ComBoxTipoDocumento.TabIndex = 24;
            // 
            // ComBoxParentesco5
            // 
            this.ComBoxParentesco5.FormattingEnabled = true;
            this.ComBoxParentesco5.Items.AddRange(new object[] {
            "Hijo/a",
            "Hermano/a",
            "Padre/madre",
            "Nieto/a",
            "Sobrino/a",
            "Tío/a",
            "Ninguno",
            "Otro"});
            this.ComBoxParentesco5.Location = new System.Drawing.Point(116, 206);
            this.ComBoxParentesco5.Name = "ComBoxParentesco5";
            this.ComBoxParentesco5.Size = new System.Drawing.Size(187, 21);
            this.ComBoxParentesco5.TabIndex = 25;
            // 
            // GroupBoxControlesCuidador
            // 
            this.GroupBoxControlesCuidador.Controls.Add(this.ComBoxProgramasDeCuidado);
            this.GroupBoxControlesCuidador.Controls.Add(this.ComBoxTest);
            this.GroupBoxControlesCuidador.Controls.Add(this.label2);
            this.GroupBoxControlesCuidador.Controls.Add(this.LblParticipaProgramasCuidador);
            this.GroupBoxControlesCuidador.Controls.Add(this.CkBoxOtroCuidador);
            this.GroupBoxControlesCuidador.Controls.Add(this.CkBoxAfiliacionCuidador);
            this.GroupBoxControlesCuidador.Controls.Add(this.CkBoxAgotamiento);
            this.GroupBoxControlesCuidador.Controls.Add(this.CkBoxRelevo);
            this.GroupBoxControlesCuidador.Controls.Add(this.CkBoxNoquiere);
            this.GroupBoxControlesCuidador.Controls.Add(this.CkBoxTemor);
            this.GroupBoxControlesCuidador.Controls.Add(this.CkBoxTiempo);
            this.GroupBoxControlesCuidador.Controls.Add(this.LblControlesCuidador);
            this.GroupBoxControlesCuidador.Location = new System.Drawing.Point(46, 419);
            this.GroupBoxControlesCuidador.Name = "GroupBoxControlesCuidador";
            this.GroupBoxControlesCuidador.Size = new System.Drawing.Size(807, 231);
            this.GroupBoxControlesCuidador.TabIndex = 26;
            this.GroupBoxControlesCuidador.TabStop = false;
            this.GroupBoxControlesCuidador.Text = "SEGUIMIENTO CUIDADOR";
            // 
            // ComBoxProgramasDeCuidado
            // 
            this.ComBoxProgramasDeCuidado.FormattingEnabled = true;
            this.ComBoxProgramasDeCuidado.Items.AddRange(new object[] {
            "SI",
            "NO",
            "NO APLICA"});
            this.ComBoxProgramasDeCuidado.Location = new System.Drawing.Point(429, 69);
            this.ComBoxProgramasDeCuidado.Name = "ComBoxProgramasDeCuidado";
            this.ComBoxProgramasDeCuidado.Size = new System.Drawing.Size(121, 21);
            this.ComBoxProgramasDeCuidado.TabIndex = 11;
            // 
            // ComBoxTest
            // 
            this.ComBoxTest.FormattingEnabled = true;
            this.ComBoxTest.Items.AddRange(new object[] {
            "Ausencia de sobrecarga",
            "Sobrecarga ligera",
            "Sobrecarga intensa"});
            this.ComBoxTest.Location = new System.Drawing.Point(429, 161);
            this.ComBoxTest.Name = "ComBoxTest";
            this.ComBoxTest.Size = new System.Drawing.Size(121, 21);
            this.ComBoxTest.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Test de Zarit: ";
            // 
            // LblParticipaProgramasCuidador
            // 
            this.LblParticipaProgramasCuidador.AutoSize = true;
            this.LblParticipaProgramasCuidador.Location = new System.Drawing.Point(426, 42);
            this.LblParticipaProgramasCuidador.Name = "LblParticipaProgramasCuidador";
            this.LblParticipaProgramasCuidador.Size = new System.Drawing.Size(321, 13);
            this.LblParticipaProgramasCuidador.TabIndex = 8;
            this.LblParticipaProgramasCuidador.Text = "¿Participa de programas de cuidado al cuidador en su IPS básica?";
            // 
            // CkBoxOtroCuidador
            // 
            this.CkBoxOtroCuidador.AutoSize = true;
            this.CkBoxOtroCuidador.Location = new System.Drawing.Point(37, 207);
            this.CkBoxOtroCuidador.Name = "CkBoxOtroCuidador";
            this.CkBoxOtroCuidador.Size = new System.Drawing.Size(49, 17);
            this.CkBoxOtroCuidador.TabIndex = 7;
            this.CkBoxOtroCuidador.Text = "Otro.";
            this.CkBoxOtroCuidador.UseVisualStyleBackColor = true;
            // 
            // CkBoxAfiliacionCuidador
            // 
            this.CkBoxAfiliacionCuidador.AutoSize = true;
            this.CkBoxAfiliacionCuidador.Location = new System.Drawing.Point(37, 184);
            this.CkBoxAfiliacionCuidador.Name = "CkBoxAfiliacionCuidador";
            this.CkBoxAfiliacionCuidador.Size = new System.Drawing.Size(113, 17);
            this.CkBoxAfiliacionCuidador.TabIndex = 6;
            this.CkBoxAfiliacionCuidador.Text = "No tiene afiliación.";
            this.CkBoxAfiliacionCuidador.UseVisualStyleBackColor = true;
            // 
            // CkBoxAgotamiento
            // 
            this.CkBoxAgotamiento.AutoSize = true;
            this.CkBoxAgotamiento.Location = new System.Drawing.Point(37, 161);
            this.CkBoxAgotamiento.Name = "CkBoxAgotamiento";
            this.CkBoxAgotamiento.Size = new System.Drawing.Size(92, 17);
            this.CkBoxAgotamiento.TabIndex = 5;
            this.CkBoxAgotamiento.Text = "Está agotado.";
            this.CkBoxAgotamiento.UseVisualStyleBackColor = true;
            // 
            // CkBoxRelevo
            // 
            this.CkBoxRelevo.AutoSize = true;
            this.CkBoxRelevo.Location = new System.Drawing.Point(37, 138);
            this.CkBoxRelevo.Name = "CkBoxRelevo";
            this.CkBoxRelevo.Size = new System.Drawing.Size(157, 17);
            this.CkBoxRelevo.TabIndex = 4;
            this.CkBoxRelevo.Text = "No tiene relevo en el cargo.";
            this.CkBoxRelevo.UseVisualStyleBackColor = true;
            // 
            // CkBoxNoquiere
            // 
            this.CkBoxNoquiere.AutoSize = true;
            this.CkBoxNoquiere.Location = new System.Drawing.Point(37, 115);
            this.CkBoxNoquiere.Name = "CkBoxNoquiere";
            this.CkBoxNoquiere.Size = new System.Drawing.Size(75, 17);
            this.CkBoxNoquiere.TabIndex = 3;
            this.CkBoxNoquiere.Text = "No quiere.";
            this.CkBoxNoquiere.UseVisualStyleBackColor = true;
            // 
            // CkBoxTemor
            // 
            this.CkBoxTemor.AutoSize = true;
            this.CkBoxTemor.Location = new System.Drawing.Point(37, 92);
            this.CkBoxTemor.Name = "CkBoxTemor";
            this.CkBoxTemor.Size = new System.Drawing.Size(252, 17);
            this.CkBoxTemor.TabIndex = 2;
            this.CkBoxTemor.Text = "Temor de no poder seguir cuidando al paciente.";
            this.CkBoxTemor.UseVisualStyleBackColor = true;
            // 
            // CkBoxTiempo
            // 
            this.CkBoxTiempo.AutoSize = true;
            this.CkBoxTiempo.Location = new System.Drawing.Point(37, 69);
            this.CkBoxTiempo.Name = "CkBoxTiempo";
            this.CkBoxTiempo.Size = new System.Drawing.Size(206, 17);
            this.CkBoxTiempo.TabIndex = 1;
            this.CkBoxTiempo.Text = "Falta de tiempo por cuidar al paciente.";
            this.CkBoxTiempo.UseVisualStyleBackColor = true;
            // 
            // LblControlesCuidador
            // 
            this.LblControlesCuidador.AutoSize = true;
            this.LblControlesCuidador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControlesCuidador.Location = new System.Drawing.Point(16, 39);
            this.LblControlesCuidador.Name = "LblControlesCuidador";
            this.LblControlesCuidador.Size = new System.Drawing.Size(276, 16);
            this.LblControlesCuidador.TabIndex = 0;
            this.LblControlesCuidador.Text = "¿El cuidador asiste a sus controles médicos?";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(725, 669);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(113, 52);
            this.BtnGuardar.TabIndex = 27;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // erpCuidador
            // 
            this.erpCuidador.ContainerControl = this;
            // 
            // CuidadorPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1003, 749);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GroupBoxControlesCuidador);
            this.Controls.Add(this.ComBoxParentesco5);
            this.Controls.Add(this.ComBoxTipoDocumento);
            this.Controls.Add(this.TxtCorreo5);
            this.Controls.Add(this.TxtCelular5);
            this.Controls.Add(this.TxtEdad5);
            this.Controls.Add(this.TxtNumeroDocumento);
            this.Controls.Add(this.TxtApellidos5);
            this.Controls.Add(this.TxtNombres5);
            this.Controls.Add(this.GroupBoxAfiliacionCuidador);
            this.Controls.Add(this.GroupBoxEnfermedadesCuidador);
            this.Controls.Add(this.LblParentescoCuidador);
            this.Controls.Add(this.LblCorreoCuidador);
            this.Controls.Add(this.LblCelularCuidador);
            this.Controls.Add(this.LblEdadCuidador);
            this.Controls.Add(this.LblNumeroDocumentoCuidador);
            this.Controls.Add(this.LblTipoDocCuidador);
            this.Controls.Add(this.LblApellidosCuidador);
            this.Controls.Add(this.LblNombresCuidador);
            this.Controls.Add(this.LblCuidadorPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CuidadorPaciente";
            this.Text = "F05 Cuidador del Paciente";
            this.Load += new System.EventHandler(this.CuidadorPaciente_Load);
            this.GroupBoxEnfermedadesCuidador.ResumeLayout(false);
            this.GroupBoxEnfermedadesCuidador.PerformLayout();
            this.GroupBoxAfiliacionCuidador.ResumeLayout(false);
            this.GroupBoxAfiliacionCuidador.PerformLayout();
            this.GroupBoxControlesCuidador.ResumeLayout(false);
            this.GroupBoxControlesCuidador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCuidador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCuidadorPaciente;
        private System.Windows.Forms.Label LblNombresCuidador;
        private System.Windows.Forms.Label LblApellidosCuidador;
        private System.Windows.Forms.Label LblTipoDocCuidador;
        private System.Windows.Forms.Label LblNumeroDocumentoCuidador;
        private System.Windows.Forms.Label LblEdadCuidador;
        private System.Windows.Forms.Label LblEnfermedadCuidador;
        private System.Windows.Forms.Label LblCelularCuidador;
        private System.Windows.Forms.Label LblCorreoCuidador;
        private System.Windows.Forms.Label LblParentescoCuidador;
        private System.Windows.Forms.CheckBox CkBoxHipertensionCuidador;
        private System.Windows.Forms.CheckBox CkBoxEnfermedadRenal;
        private System.Windows.Forms.CheckBox CkBoxEnfermedadPulmonarCuidador;
        private System.Windows.Forms.CheckBox CkBoxTrastornoNeuroCuidador;
        private System.Windows.Forms.CheckBox CkBoxDiabetesCuidador;
        private System.Windows.Forms.GroupBox GroupBoxEnfermedadesCuidador;
        private System.Windows.Forms.GroupBox GroupBoxAfiliacionCuidador;
        private System.Windows.Forms.CheckBox CkBoxNoAfiliado;
        private System.Windows.Forms.CheckBox CkBoxSiAfiliado;
        private System.Windows.Forms.Label LblAfiliacionCuidador;
        private System.Windows.Forms.TextBox TxtNombres5;
        private System.Windows.Forms.TextBox TxtApellidos5;
        private System.Windows.Forms.TextBox TxtNumeroDocumento;
        private System.Windows.Forms.TextBox TxtEdad5;
        private System.Windows.Forms.TextBox TxtCelular5;
        private System.Windows.Forms.TextBox TxtCorreo5;
        private System.Windows.Forms.ComboBox ComBoxTipoDocumento;
        private System.Windows.Forms.ComboBox ComBoxParentesco5;
        private System.Windows.Forms.GroupBox GroupBoxControlesCuidador;
        private System.Windows.Forms.CheckBox CkBoxTemor;
        private System.Windows.Forms.CheckBox CkBoxTiempo;
        private System.Windows.Forms.Label LblControlesCuidador;
        private System.Windows.Forms.ComboBox ComBoxProgramasDeCuidado;
        private System.Windows.Forms.ComboBox ComBoxTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblParticipaProgramasCuidador;
        private System.Windows.Forms.CheckBox CkBoxOtroCuidador;
        private System.Windows.Forms.CheckBox CkBoxAfiliacionCuidador;
        private System.Windows.Forms.CheckBox CkBoxAgotamiento;
        private System.Windows.Forms.CheckBox CkBoxRelevo;
        private System.Windows.Forms.CheckBox CkBoxNoquiere;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ErrorProvider erpCuidador;
    }
}