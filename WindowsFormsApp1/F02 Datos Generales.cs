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
    public partial class DatosGeneralesPaciente : Form
    {
        public DatosGeneralesPaciente()
        {
            InitializeComponent();
        }

        private bool ValidarComboBox(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedIndex == -1 || comboBox.SelectedItem == null)
            {
                errorProvider.SetError(comboBox, "Debe seleccionar una opción");
                return false;
            }

            errorProvider.Clear();
            return true;
        }

        private bool ValidarSoloLetras(TextBox textBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "El campo no puede estar vacío");
                return false;
            }

            foreach (char caracter in textBox.Text)
            {
                if (char.IsDigit(caracter))
                {
                    errorProvider.SetError(textBox, "No se permiten números");
                    return false;
                }
            }

            errorProvider.Clear();
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarSoloLetras(TxtPrimerNombre, errorProvider1) ||
                !ValidarSoloLetras(TxtSegundoNombre, errorProvider1) ||
                !ValidarSoloLetras(TxtPrimerApellido, errorProvider1) ||
                !ValidarSoloLetras(TxtSegundoApellido, errorProvider1))
            {
                MessageBox.Show("Corrija los errores antes de continuar y verifique que todos los campos estén diligenciados");
                return;
            }

            bool radiobutton = (RbtnCedula.Checked || RbtnPasaporte.Checked || RbtnTarjetaIdentidad.Checked) && (RbtnSI.Checked || RbtnNO.Checked);
            if (!radiobutton)
            {
                MessageBox.Show("Debe ingresar una opción");
                return;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void LblProveedor_Click(object sender, EventArgs e)
        {
        }

        private void LblSituacionLaboral_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void DatosGeneralesPaciente_Load(object sender, EventArgs e)
        {
        }

        private void ComBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
