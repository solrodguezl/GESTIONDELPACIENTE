namespace WindowsFormsApp1
{
    partial class EvaluacionFamiliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluacionFamiliar));
            this.LblEvaluacionFamiliar = new System.Windows.Forms.Label();
            this.GroupBoxFamiliar = new System.Windows.Forms.GroupBox();
            this.ComBoxParentesco4 = new System.Windows.Forms.ComboBox();
            this.TxtApellidos4 = new System.Windows.Forms.TextBox();
            this.TxtNombres4 = new System.Windows.Forms.TextBox();
            this.LblParentesco = new System.Windows.Forms.Label();
            this.LblApellidosFamiliar = new System.Windows.Forms.Label();
            this.LblNombresFamiliar = new System.Windows.Forms.Label();
            this.LblEdadFamiliar = new System.Windows.Forms.Label();
            this.LblEtapaFamiliar = new System.Windows.Forms.Label();
            this.LblNiveldeEscolaridadFam = new System.Windows.Forms.Label();
            this.LblOcupacionFamiliar = new System.Windows.Forms.Label();
            this.LblRedCuidado = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.ComBoxEtapa4 = new System.Windows.Forms.ComboBox();
            this.ComBoxNivelEscolaridad = new System.Windows.Forms.ComboBox();
            this.ComBoxOcupacion = new System.Windows.Forms.ComboBox();
            this.CkBoxNoCuidado = new System.Windows.Forms.CheckBox();
            this.CkBoxSiCuidado = new System.Windows.Forms.CheckBox();
            this.GroupBoxEDAD = new System.Windows.Forms.GroupBox();
            this.GroupBoxEscolaridadFam = new System.Windows.Forms.GroupBox();
            this.GroupBoxRedCuidado = new System.Windows.Forms.GroupBox();
            this.LblCorreoFam = new System.Windows.Forms.Label();
            this.LblContactoFam = new System.Windows.Forms.Label();
            this.TxtCorreo4 = new System.Windows.Forms.TextBox();
            this.TxtCelular4 = new System.Windows.Forms.TextBox();
            this.BtnContinuar3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.erpEvaluacionF = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBoxFamiliar.SuspendLayout();
            this.GroupBoxEDAD.SuspendLayout();
            this.GroupBoxEscolaridadFam.SuspendLayout();
            this.GroupBoxRedCuidado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpEvaluacionF)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEvaluacionFamiliar
            // 
            this.LblEvaluacionFamiliar.AutoSize = true;
            this.LblEvaluacionFamiliar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEvaluacionFamiliar.Location = new System.Drawing.Point(45, 39);
            this.LblEvaluacionFamiliar.Name = "LblEvaluacionFamiliar";
            this.LblEvaluacionFamiliar.Size = new System.Drawing.Size(198, 26);
            this.LblEvaluacionFamiliar.TabIndex = 0;
            this.LblEvaluacionFamiliar.Text = "Evaluación Familiar";
            this.LblEvaluacionFamiliar.Click += new System.EventHandler(this.LblEvaluacionFamiliar_Click);
            // 
            // GroupBoxFamiliar
            // 
            this.GroupBoxFamiliar.Controls.Add(this.ComBoxParentesco4);
            this.GroupBoxFamiliar.Controls.Add(this.TxtApellidos4);
            this.GroupBoxFamiliar.Controls.Add(this.TxtNombres4);
            this.GroupBoxFamiliar.Controls.Add(this.LblParentesco);
            this.GroupBoxFamiliar.Controls.Add(this.LblApellidosFamiliar);
            this.GroupBoxFamiliar.Controls.Add(this.LblNombresFamiliar);
            this.GroupBoxFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxFamiliar.Location = new System.Drawing.Point(50, 90);
            this.GroupBoxFamiliar.Name = "GroupBoxFamiliar";
            this.GroupBoxFamiliar.Size = new System.Drawing.Size(710, 132);
            this.GroupBoxFamiliar.TabIndex = 1;
            this.GroupBoxFamiliar.TabStop = false;
            this.GroupBoxFamiliar.Text = "DATOS FAMILIAR";
            // 
            // ComBoxParentesco4
            // 
            this.ComBoxParentesco4.FormattingEnabled = true;
            this.ComBoxParentesco4.Location = new System.Drawing.Point(106, 90);
            this.ComBoxParentesco4.Name = "ComBoxParentesco4";
            this.ComBoxParentesco4.Size = new System.Drawing.Size(188, 24);
            this.ComBoxParentesco4.TabIndex = 12;
            // 
            // TxtApellidos4
            // 
            this.TxtApellidos4.Location = new System.Drawing.Point(442, 42);
            this.TxtApellidos4.Name = "TxtApellidos4";
            this.TxtApellidos4.Size = new System.Drawing.Size(253, 22);
            this.TxtApellidos4.TabIndex = 9;
            // 
            // TxtNombres4
            // 
            this.TxtNombres4.Location = new System.Drawing.Point(94, 42);
            this.TxtNombres4.Name = "TxtNombres4";
            this.TxtNombres4.Size = new System.Drawing.Size(253, 22);
            this.TxtNombres4.TabIndex = 8;
            // 
            // LblParentesco
            // 
            this.LblParentesco.AutoSize = true;
            this.LblParentesco.Location = new System.Drawing.Point(22, 93);
            this.LblParentesco.Name = "LblParentesco";
            this.LblParentesco.Size = new System.Drawing.Size(79, 16);
            this.LblParentesco.TabIndex = 2;
            this.LblParentesco.Text = "Parentesco:";
            // 
            // LblApellidosFamiliar
            // 
            this.LblApellidosFamiliar.AutoSize = true;
            this.LblApellidosFamiliar.Location = new System.Drawing.Point(369, 45);
            this.LblApellidosFamiliar.Name = "LblApellidosFamiliar";
            this.LblApellidosFamiliar.Size = new System.Drawing.Size(67, 16);
            this.LblApellidosFamiliar.TabIndex = 1;
            this.LblApellidosFamiliar.Text = "Apellidos:";
            // 
            // LblNombresFamiliar
            // 
            this.LblNombresFamiliar.AutoSize = true;
            this.LblNombresFamiliar.Location = new System.Drawing.Point(22, 45);
            this.LblNombresFamiliar.Name = "LblNombresFamiliar";
            this.LblNombresFamiliar.Size = new System.Drawing.Size(66, 16);
            this.LblNombresFamiliar.TabIndex = 0;
            this.LblNombresFamiliar.Text = "Nombres:";
            // 
            // LblEdadFamiliar
            // 
            this.LblEdadFamiliar.AutoSize = true;
            this.LblEdadFamiliar.Location = new System.Drawing.Point(22, 26);
            this.LblEdadFamiliar.Name = "LblEdadFamiliar";
            this.LblEdadFamiliar.Size = new System.Drawing.Size(0, 13);
            this.LblEdadFamiliar.TabIndex = 3;
            // 
            // LblEtapaFamiliar
            // 
            this.LblEtapaFamiliar.AutoSize = true;
            this.LblEtapaFamiliar.Location = new System.Drawing.Point(126, 40);
            this.LblEtapaFamiliar.Name = "LblEtapaFamiliar";
            this.LblEtapaFamiliar.Size = new System.Drawing.Size(38, 13);
            this.LblEtapaFamiliar.TabIndex = 4;
            this.LblEtapaFamiliar.Text = "Etapa:";
            // 
            // LblNiveldeEscolaridadFam
            // 
            this.LblNiveldeEscolaridadFam.AutoSize = true;
            this.LblNiveldeEscolaridadFam.Location = new System.Drawing.Point(81, 42);
            this.LblNiveldeEscolaridadFam.Name = "LblNiveldeEscolaridadFam";
            this.LblNiveldeEscolaridadFam.Size = new System.Drawing.Size(37, 13);
            this.LblNiveldeEscolaridadFam.TabIndex = 5;
            this.LblNiveldeEscolaridadFam.Text = "Nivel: ";
            // 
            // LblOcupacionFamiliar
            // 
            this.LblOcupacionFamiliar.AutoSize = true;
            this.LblOcupacionFamiliar.Location = new System.Drawing.Point(56, 83);
            this.LblOcupacionFamiliar.Name = "LblOcupacionFamiliar";
            this.LblOcupacionFamiliar.Size = new System.Drawing.Size(62, 13);
            this.LblOcupacionFamiliar.TabIndex = 6;
            this.LblOcupacionFamiliar.Text = "Ocupacion:";
            // 
            // LblRedCuidado
            // 
            this.LblRedCuidado.AutoSize = true;
            this.LblRedCuidado.Location = new System.Drawing.Point(22, 39);
            this.LblRedCuidado.Name = "LblRedCuidado";
            this.LblRedCuidado.Size = new System.Drawing.Size(206, 13);
            this.LblRedCuidado.TabIndex = 7;
            this.LblRedCuidado.Text = "¿El paciente cuenta con red de cuidado? ";
            this.LblRedCuidado.Click += new System.EventHandler(this.label8_Click);
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(26, 40);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(80, 20);
            this.TxtEdad.TabIndex = 10;
            // 
            // ComBoxEtapa4
            // 
            this.ComBoxEtapa4.FormattingEnabled = true;
            this.ComBoxEtapa4.Location = new System.Drawing.Point(174, 37);
            this.ComBoxEtapa4.Name = "ComBoxEtapa4";
            this.ComBoxEtapa4.Size = new System.Drawing.Size(121, 21);
            this.ComBoxEtapa4.TabIndex = 11;
            // 
            // ComBoxNivelEscolaridad
            // 
            this.ComBoxNivelEscolaridad.FormattingEnabled = true;
            this.ComBoxNivelEscolaridad.Location = new System.Drawing.Point(140, 37);
            this.ComBoxNivelEscolaridad.Name = "ComBoxNivelEscolaridad";
            this.ComBoxNivelEscolaridad.Size = new System.Drawing.Size(121, 21);
            this.ComBoxNivelEscolaridad.TabIndex = 13;
            // 
            // ComBoxOcupacion
            // 
            this.ComBoxOcupacion.FormattingEnabled = true;
            this.ComBoxOcupacion.Location = new System.Drawing.Point(140, 83);
            this.ComBoxOcupacion.Name = "ComBoxOcupacion";
            this.ComBoxOcupacion.Size = new System.Drawing.Size(121, 21);
            this.ComBoxOcupacion.TabIndex = 14;
            // 
            // CkBoxNoCuidado
            // 
            this.CkBoxNoCuidado.AutoSize = true;
            this.CkBoxNoCuidado.Location = new System.Drawing.Point(243, 71);
            this.CkBoxNoCuidado.Name = "CkBoxNoCuidado";
            this.CkBoxNoCuidado.Size = new System.Drawing.Size(45, 17);
            this.CkBoxNoCuidado.TabIndex = 15;
            this.CkBoxNoCuidado.Text = "NO.";
            this.CkBoxNoCuidado.UseVisualStyleBackColor = true;
            // 
            // CkBoxSiCuidado
            // 
            this.CkBoxSiCuidado.AutoSize = true;
            this.CkBoxSiCuidado.Location = new System.Drawing.Point(243, 39);
            this.CkBoxSiCuidado.Name = "CkBoxSiCuidado";
            this.CkBoxSiCuidado.Size = new System.Drawing.Size(40, 17);
            this.CkBoxSiCuidado.TabIndex = 16;
            this.CkBoxSiCuidado.Text = "Sí.";
            this.CkBoxSiCuidado.UseVisualStyleBackColor = true;
            // 
            // GroupBoxEDAD
            // 
            this.GroupBoxEDAD.Controls.Add(this.LblEdadFamiliar);
            this.GroupBoxEDAD.Controls.Add(this.TxtEdad);
            this.GroupBoxEDAD.Controls.Add(this.LblEtapaFamiliar);
            this.GroupBoxEDAD.Controls.Add(this.ComBoxEtapa4);
            this.GroupBoxEDAD.Location = new System.Drawing.Point(50, 249);
            this.GroupBoxEDAD.Name = "GroupBoxEDAD";
            this.GroupBoxEDAD.Size = new System.Drawing.Size(332, 91);
            this.GroupBoxEDAD.TabIndex = 17;
            this.GroupBoxEDAD.TabStop = false;
            this.GroupBoxEDAD.Text = "EDAD";
            // 
            // GroupBoxEscolaridadFam
            // 
            this.GroupBoxEscolaridadFam.Controls.Add(this.ComBoxNivelEscolaridad);
            this.GroupBoxEscolaridadFam.Controls.Add(this.LblNiveldeEscolaridadFam);
            this.GroupBoxEscolaridadFam.Controls.Add(this.ComBoxOcupacion);
            this.GroupBoxEscolaridadFam.Controls.Add(this.LblOcupacionFamiliar);
            this.GroupBoxEscolaridadFam.Location = new System.Drawing.Point(422, 249);
            this.GroupBoxEscolaridadFam.Name = "GroupBoxEscolaridadFam";
            this.GroupBoxEscolaridadFam.Size = new System.Drawing.Size(338, 116);
            this.GroupBoxEscolaridadFam.TabIndex = 18;
            this.GroupBoxEscolaridadFam.TabStop = false;
            this.GroupBoxEscolaridadFam.Text = "ESCOLARIDAD";
            // 
            // GroupBoxRedCuidado
            // 
            this.GroupBoxRedCuidado.Controls.Add(this.LblCorreoFam);
            this.GroupBoxRedCuidado.Controls.Add(this.LblContactoFam);
            this.GroupBoxRedCuidado.Controls.Add(this.TxtCorreo4);
            this.GroupBoxRedCuidado.Controls.Add(this.TxtCelular4);
            this.GroupBoxRedCuidado.Controls.Add(this.LblRedCuidado);
            this.GroupBoxRedCuidado.Controls.Add(this.CkBoxSiCuidado);
            this.GroupBoxRedCuidado.Controls.Add(this.CkBoxNoCuidado);
            this.GroupBoxRedCuidado.Location = new System.Drawing.Point(50, 371);
            this.GroupBoxRedCuidado.Name = "GroupBoxRedCuidado";
            this.GroupBoxRedCuidado.Size = new System.Drawing.Size(710, 124);
            this.GroupBoxRedCuidado.TabIndex = 19;
            this.GroupBoxRedCuidado.TabStop = false;
            this.GroupBoxRedCuidado.Text = "RED DE CUIDADO";
            // 
            // LblCorreoFam
            // 
            this.LblCorreoFam.AutoSize = true;
            this.LblCorreoFam.Location = new System.Drawing.Point(322, 69);
            this.LblCorreoFam.Name = "LblCorreoFam";
            this.LblCorreoFam.Size = new System.Drawing.Size(99, 13);
            this.LblCorreoFam.TabIndex = 20;
            this.LblCorreoFam.Text = "Correo electrónico: ";
            // 
            // LblContactoFam
            // 
            this.LblContactoFam.AutoSize = true;
            this.LblContactoFam.Location = new System.Drawing.Point(310, 43);
            this.LblContactoFam.Name = "LblContactoFam";
            this.LblContactoFam.Size = new System.Drawing.Size(111, 13);
            this.LblContactoFam.TabIndex = 19;
            this.LblContactoFam.Text = "Número de Contacto: ";
            // 
            // TxtCorreo4
            // 
            this.TxtCorreo4.Location = new System.Drawing.Point(442, 69);
            this.TxtCorreo4.Name = "TxtCorreo4";
            this.TxtCorreo4.Size = new System.Drawing.Size(253, 20);
            this.TxtCorreo4.TabIndex = 18;
            // 
            // TxtCelular4
            // 
            this.TxtCelular4.Location = new System.Drawing.Point(442, 40);
            this.TxtCelular4.Name = "TxtCelular4";
            this.TxtCelular4.Size = new System.Drawing.Size(202, 20);
            this.TxtCelular4.TabIndex = 17;
            // 
            // BtnContinuar3
            // 
            this.BtnContinuar3.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnContinuar3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinuar3.Location = new System.Drawing.Point(790, 516);
            this.BtnContinuar3.Name = "BtnContinuar3";
            this.BtnContinuar3.Size = new System.Drawing.Size(93, 36);
            this.BtnContinuar3.TabIndex = 20;
            this.BtnContinuar3.Text = "Continuar";
            this.BtnContinuar3.UseVisualStyleBackColor = false;
            this.BtnContinuar3.Click += new System.EventHandler(this.BtnContinuar3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(596, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Agregar familiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // erpEvaluacionF
            // 
            this.erpEvaluacionF.ContainerControl = this;
            // 
            // EvaluacionFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(908, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnContinuar3);
            this.Controls.Add(this.GroupBoxRedCuidado);
            this.Controls.Add(this.GroupBoxEscolaridadFam);
            this.Controls.Add(this.GroupBoxEDAD);
            this.Controls.Add(this.GroupBoxFamiliar);
            this.Controls.Add(this.LblEvaluacionFamiliar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EvaluacionFamiliar";
            this.Text = "F04 Evaluación Familiar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxFamiliar.ResumeLayout(false);
            this.GroupBoxFamiliar.PerformLayout();
            this.GroupBoxEDAD.ResumeLayout(false);
            this.GroupBoxEDAD.PerformLayout();
            this.GroupBoxEscolaridadFam.ResumeLayout(false);
            this.GroupBoxEscolaridadFam.PerformLayout();
            this.GroupBoxRedCuidado.ResumeLayout(false);
            this.GroupBoxRedCuidado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpEvaluacionF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEvaluacionFamiliar;
        private System.Windows.Forms.GroupBox GroupBoxFamiliar;
        private System.Windows.Forms.ComboBox ComBoxParentesco4;
        private System.Windows.Forms.ComboBox ComBoxEtapa4;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtApellidos4;
        private System.Windows.Forms.TextBox TxtNombres4;
        private System.Windows.Forms.Label LblRedCuidado;
        private System.Windows.Forms.Label LblOcupacionFamiliar;
        private System.Windows.Forms.Label LblNiveldeEscolaridadFam;
        private System.Windows.Forms.Label LblEtapaFamiliar;
        private System.Windows.Forms.Label LblEdadFamiliar;
        private System.Windows.Forms.Label LblParentesco;
        private System.Windows.Forms.Label LblApellidosFamiliar;
        private System.Windows.Forms.Label LblNombresFamiliar;
        private System.Windows.Forms.CheckBox CkBoxSiCuidado;
        private System.Windows.Forms.CheckBox CkBoxNoCuidado;
        private System.Windows.Forms.ComboBox ComBoxOcupacion;
        private System.Windows.Forms.ComboBox ComBoxNivelEscolaridad;
        private System.Windows.Forms.GroupBox GroupBoxEDAD;
        private System.Windows.Forms.GroupBox GroupBoxEscolaridadFam;
        private System.Windows.Forms.GroupBox GroupBoxRedCuidado;
        private System.Windows.Forms.Button BtnContinuar3;
        private System.Windows.Forms.Label LblCorreoFam;
        private System.Windows.Forms.Label LblContactoFam;
        private System.Windows.Forms.TextBox TxtCorreo4;
        private System.Windows.Forms.TextBox TxtCelular4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider erpEvaluacionF;
    }
}