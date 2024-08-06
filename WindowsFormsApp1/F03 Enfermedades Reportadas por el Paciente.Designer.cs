namespace WindowsFormsApp1
{
    partial class EnfermedadesReportadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnfermedadesReportadas));
            this.LblEnfermedadesReportadas = new System.Windows.Forms.Label();
            this.GroupBoxEnfermedades = new System.Windows.Forms.GroupBox();
            this.LblEnfermedades = new System.Windows.Forms.Label();
            this.CkBoxHipertension = new System.Windows.Forms.CheckBox();
            this.CkBoxDiabetes = new System.Windows.Forms.CheckBox();
            this.CkBoxEnfermedadRenal = new System.Windows.Forms.CheckBox();
            this.CkBoxEnfermedadPulmonar = new System.Windows.Forms.CheckBox();
            this.CkBoxTrastornoNeurocognitivo = new System.Windows.Forms.CheckBox();
            this.BtnContinuar2 = new System.Windows.Forms.Button();
            this.GroupBoxEnfermedades.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblEnfermedadesReportadas
            // 
            this.LblEnfermedadesReportadas.AutoSize = true;
            this.LblEnfermedadesReportadas.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnfermedadesReportadas.Location = new System.Drawing.Point(27, 36);
            this.LblEnfermedadesReportadas.Name = "LblEnfermedadesReportadas";
            this.LblEnfermedadesReportadas.Size = new System.Drawing.Size(410, 22);
            this.LblEnfermedadesReportadas.TabIndex = 0;
            this.LblEnfermedadesReportadas.Text = "ENFERMEDADES REPORTADAS POR EL PACIENTE";
            // 
            // GroupBoxEnfermedades
            // 
            this.GroupBoxEnfermedades.Controls.Add(this.CkBoxTrastornoNeurocognitivo);
            this.GroupBoxEnfermedades.Controls.Add(this.CkBoxEnfermedadPulmonar);
            this.GroupBoxEnfermedades.Controls.Add(this.CkBoxEnfermedadRenal);
            this.GroupBoxEnfermedades.Controls.Add(this.CkBoxDiabetes);
            this.GroupBoxEnfermedades.Controls.Add(this.CkBoxHipertension);
            this.GroupBoxEnfermedades.Controls.Add(this.LblEnfermedades);
            this.GroupBoxEnfermedades.Location = new System.Drawing.Point(80, 97);
            this.GroupBoxEnfermedades.Name = "GroupBoxEnfermedades";
            this.GroupBoxEnfermedades.Size = new System.Drawing.Size(541, 228);
            this.GroupBoxEnfermedades.TabIndex = 1;
            this.GroupBoxEnfermedades.TabStop = false;
            this.GroupBoxEnfermedades.Text = "PATOLOGÍAS";
            // 
            // LblEnfermedades
            // 
            this.LblEnfermedades.AutoSize = true;
            this.LblEnfermedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnfermedades.Location = new System.Drawing.Point(41, 54);
            this.LblEnfermedades.Name = "LblEnfermedades";
            this.LblEnfermedades.Size = new System.Drawing.Size(280, 16);
            this.LblEnfermedades.TabIndex = 0;
            this.LblEnfermedades.Text = "Seleccione la enfermedad que usted padece:";
            // 
            // CkBoxHipertension
            // 
            this.CkBoxHipertension.AutoSize = true;
            this.CkBoxHipertension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkBoxHipertension.Location = new System.Drawing.Point(61, 88);
            this.CkBoxHipertension.Name = "CkBoxHipertension";
            this.CkBoxHipertension.Size = new System.Drawing.Size(149, 20);
            this.CkBoxHipertension.TabIndex = 1;
            this.CkBoxHipertension.Text = "Hipertensión arterial.";
            this.CkBoxHipertension.UseVisualStyleBackColor = true;
            // 
            // CkBoxDiabetes
            // 
            this.CkBoxDiabetes.AutoSize = true;
            this.CkBoxDiabetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkBoxDiabetes.Location = new System.Drawing.Point(61, 122);
            this.CkBoxDiabetes.Name = "CkBoxDiabetes";
            this.CkBoxDiabetes.Size = new System.Drawing.Size(132, 20);
            this.CkBoxDiabetes.TabIndex = 2;
            this.CkBoxDiabetes.Text = "Diabetes Mielitus.";
            this.CkBoxDiabetes.UseVisualStyleBackColor = true;
            // 
            // CkBoxEnfermedadRenal
            // 
            this.CkBoxEnfermedadRenal.AutoSize = true;
            this.CkBoxEnfermedadRenal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkBoxEnfermedadRenal.Location = new System.Drawing.Point(61, 157);
            this.CkBoxEnfermedadRenal.Name = "CkBoxEnfermedadRenal";
            this.CkBoxEnfermedadRenal.Size = new System.Drawing.Size(208, 20);
            this.CkBoxEnfermedadRenal.TabIndex = 3;
            this.CkBoxEnfermedadRenal.Text = "Enfermedad renal crónica I y II.";
            this.CkBoxEnfermedadRenal.UseVisualStyleBackColor = true;
            // 
            // CkBoxEnfermedadPulmonar
            // 
            this.CkBoxEnfermedadPulmonar.AutoSize = true;
            this.CkBoxEnfermedadPulmonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkBoxEnfermedadPulmonar.Location = new System.Drawing.Point(320, 100);
            this.CkBoxEnfermedadPulmonar.Name = "CkBoxEnfermedadPulmonar";
            this.CkBoxEnfermedadPulmonar.Size = new System.Drawing.Size(163, 20);
            this.CkBoxEnfermedadPulmonar.TabIndex = 4;
            this.CkBoxEnfermedadPulmonar.Text = "Enfermedad Pulmonar.";
            this.CkBoxEnfermedadPulmonar.UseVisualStyleBackColor = true;
            // 
            // CkBoxTrastornoNeurocognitivo
            // 
            this.CkBoxTrastornoNeurocognitivo.AutoSize = true;
            this.CkBoxTrastornoNeurocognitivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkBoxTrastornoNeurocognitivo.Location = new System.Drawing.Point(320, 135);
            this.CkBoxTrastornoNeurocognitivo.Name = "CkBoxTrastornoNeurocognitivo";
            this.CkBoxTrastornoNeurocognitivo.Size = new System.Drawing.Size(181, 20);
            this.CkBoxTrastornoNeurocognitivo.TabIndex = 5;
            this.CkBoxTrastornoNeurocognitivo.Text = "Trastorno Neurocognitivo.";
            this.CkBoxTrastornoNeurocognitivo.UseVisualStyleBackColor = true;
            // 
            // BtnContinuar2
            // 
            this.BtnContinuar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnContinuar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinuar2.ForeColor = System.Drawing.Color.Black;
            this.BtnContinuar2.Location = new System.Drawing.Point(524, 346);
            this.BtnContinuar2.Name = "BtnContinuar2";
            this.BtnContinuar2.Size = new System.Drawing.Size(97, 40);
            this.BtnContinuar2.TabIndex = 2;
            this.BtnContinuar2.Text = "Continuar";
            this.BtnContinuar2.UseVisualStyleBackColor = false;
            // 
            // EnfermedadesReportadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(665, 430);
            this.Controls.Add(this.BtnContinuar2);
            this.Controls.Add(this.GroupBoxEnfermedades);
            this.Controls.Add(this.LblEnfermedadesReportadas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnfermedadesReportadas";
            this.Text = "F03 Enfermedades Reportadas por el Paciente";
            this.GroupBoxEnfermedades.ResumeLayout(false);
            this.GroupBoxEnfermedades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEnfermedadesReportadas;
        private System.Windows.Forms.GroupBox GroupBoxEnfermedades;
        private System.Windows.Forms.Label LblEnfermedades;
        private System.Windows.Forms.CheckBox CkBoxTrastornoNeurocognitivo;
        private System.Windows.Forms.CheckBox CkBoxEnfermedadPulmonar;
        private System.Windows.Forms.CheckBox CkBoxEnfermedadRenal;
        private System.Windows.Forms.CheckBox CkBoxDiabetes;
        private System.Windows.Forms.CheckBox CkBoxHipertension;
        private System.Windows.Forms.Button BtnContinuar2;
    }
}