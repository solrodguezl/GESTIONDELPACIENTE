using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EnfermedadesReportadas : Form
    {
        public EnfermedadesReportadas()
        {
            InitializeComponent();
        }

        private void BtnContinuar2_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            bool CheckBoxChecked = true;
            if (!(CkBoxDiabetes.Checked || CkBoxEnfermedadPulmonar.Checked || CkBoxEnfermedadRenal.Checked || CkBoxHipertension.Checked || CkBoxTrastornoNeurocognitivo.Checked))
            {
                errorProvider2.SetError(LblEnfermedades, "Debe seleccionar por lo menos una opción.");
                CheckBoxChecked = false;
            }


            // Mostrar mensaje de advertencia por errores antes de continuar

            if (!CheckBoxChecked)
            {
                MessageBox.Show("Corrija los errores antes de continuar, y verifique que todos los campos esten diligenciados");
                return;
            }
            else
            {
                EvaluacionFamiliar ven4 = new EvaluacionFamiliar();
                ven4.Show();
                this.Hide();
                MessageBox.Show("El formulario fue diligenciado de forma exitosa.");
            }

        }
    }
}
