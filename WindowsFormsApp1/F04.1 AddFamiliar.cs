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
    public partial class AddEvaluacionFamiliar : Form
    {
        public AddEvaluacionFamiliar()
        {
            InitializeComponent();
        }

        private static bool ValidarSoloLetras(TextBox textBox, ErrorProvider erpEvaluacionF)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                erpEvaluacionF.SetError(textBox, "El campo no puede estar vacío");
                return false;
            }
            foreach (char caracter in textBox.Text)
            {
                if (char.IsDigit(caracter))
                {
                    erpEvaluacionF.SetError(textBox, "No se admiten números");
                    return false;
                }
            }

            erpEvaluacionF.Clear();
            return true;
        }

        //Validar números

        private bool ValidarSoloNumeros(TextBox textBox, ErrorProvider erpEvaluacionF)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                erpEvaluacionF.SetError(textBox, "El campo no puede estar vacío");
                return false;
            }
            foreach (char caracter in textBox.Text)
            {
                if (!char.IsDigit(caracter) && caracter != ',')
                {
                    erpEvaluacionF.SetError(textBox, "No se admiten letras");
                    return false;
                }
            }

            erpEvaluacionF.Clear();
            return true;
        }

        private void BtnContinuar3_Click(object sender, EventArgs e)
        {

        }

        private void AddEvaluacionFamiliar_Load(object sender, EventArgs e)
        {
            bool textBoxcheked = true;

            if (string.IsNullOrEmpty(TxtNombres4.Text) || !ValidarSoloLetras(TxtNombres4, erpEvaluacionF))
            {
                erpEvaluacionF.SetError(TxtNombres4, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            if (string.IsNullOrEmpty(TxtApellidos4.Text) || !ValidarSoloLetras(TxtApellidos4, erpEvaluacionF))
            {
                erpEvaluacionF.SetError(TxtApellidos4, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            if (string.IsNullOrEmpty(TxtEdad.Text) || !ValidarSoloNumeros(TxtEdad, erpEvaluacionF))
            {
                erpEvaluacionF.SetError(TxtEdad, "Debe ingresar solo Números.");
                textBoxcheked = false;
            }

            if (string.IsNullOrEmpty(TxtCorreo4.Text) || !ValidarSoloLetras(TxtCorreo4, erpEvaluacionF))
            {
                erpEvaluacionF.SetError(TxtCorreo4, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            if (string.IsNullOrEmpty(TxtCelular4.Text) || !ValidarSoloNumeros(TxtCelular4, erpEvaluacionF))
            {
                erpEvaluacionF.SetError(TxtCelular4, "Debe ingresar solo números.");
                textBoxcheked = false;
            }

            //Validando listas

            bool comboBoxSelected = true;
            erpEvaluacionF.Clear();

            if (ComBoxParentesco4.SelectedIndex == -1)
            {
                erpEvaluacionF.SetError(ComBoxParentesco4, "Seleccione un elemento.");
                comboBoxSelected = false;
            }

            if (ComBoxNivelEscolaridad.SelectedIndex == -1)
            {
                erpEvaluacionF.SetError(ComBoxNivelEscolaridad, "Seleccione un elemento.");
                comboBoxSelected = false;
            }

            if (ComBoxEtapa4.SelectedIndex == -1)
            {
                erpEvaluacionF.SetError(ComBoxEtapa4, "Seleccione un elemento.");
                comboBoxSelected = false;
            }

            if (ComBoxOcupacion.SelectedIndex == -1)
            {
                erpEvaluacionF.SetError(ComBoxOcupacion, "Seleccione un elemento.");
                comboBoxSelected = false;
            }


            // validar botones 
            bool radioButtonChecked = true;
            if (!(CkBoxNoCuidado.Checked || CkBoxSiCuidado.Checked))
            {
                erpEvaluacionF.SetError(CkBoxSiCuidado, "Debe seleccionar por lo menos una opción.");
                radioButtonChecked = false;
            }


            // Mostrar mensaje de advertencia por errores antes de continuar

            if (!radioButtonChecked || !comboBoxSelected || !textBoxcheked)
            {
                MessageBox.Show("Corrija los errores antes de continuar, y verifique que todos los campos esten diligenciados");
                return;
            }
            else
            {
                CuidadorPaciente ven5 = new CuidadorPaciente();
                ven5.Show();
                this.Hide();
                MessageBox.Show("El formulario fue diligenciado de forma exitosa.");
            }
        }
    }
}
