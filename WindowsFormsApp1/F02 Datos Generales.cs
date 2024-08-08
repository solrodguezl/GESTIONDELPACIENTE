using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DatosGeneralesPaciente : Form
    {
        public DatosGeneralesPaciente()
        {
            InitializeComponent();
        }

        //Validar letras Text Box
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
                    errorProvider.SetError(textBox, "No se admiten números");
                    return false;
                }
            }

            errorProvider.Clear();
            return true;
        }

        //Validar números

        private bool ValidarSoloNumeros(TextBox textBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "El campo no puede estar vacío");
                return false;
            }
            foreach (char caracter in textBox.Text)
            {
                if (!char.IsDigit(caracter) && caracter != ',')
                {
                    errorProvider.SetError(textBox, "No se admiten letras");
                    return false;
                }
            }

            errorProvider.Clear();
            return true;
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

        private void GroupBoxInformacionPersonal_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupBoxDatosEconomicos_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAceptar1_Click_1(object sender, EventArgs e)
        {
            bool textBoxcheked = true;

            if (string.IsNullOrEmpty(TxtPrimerNombre.Text) || !ValidarSoloLetras(TxtPrimerNombre, errorProvider1))
            {
                errorProvider1.SetError(TxtPrimerNombre, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            if (string.IsNullOrEmpty(TxtSegundoNombre.Text) || !ValidarSoloLetras(TxtSegundoNombre, errorProvider1))
            {
                errorProvider1.SetError(TxtSegundoNombre, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            if (string.IsNullOrEmpty(TxtPrimerApellido.Text) || !ValidarSoloLetras(TxtPrimerApellido, errorProvider1))
            {
                errorProvider1.SetError(TxtPrimerApellido, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            if (string.IsNullOrEmpty(TxtSegundoApellido.Text) || !ValidarSoloLetras(TxtSegundoApellido, errorProvider1))
            {
                errorProvider1.SetError(TxtSegundoApellido, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            if (string.IsNullOrEmpty(TxtDireccion.Text) || !ValidarSoloLetras(TxtDireccion, errorProvider1))
            {
                errorProvider1.SetError(TxtDireccion, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            bool radioButtonChecked = true;
            // validar botones para alfabeta

            if (!(RbtnCedula.Checked || RbtnPasaporte.Checked || RbtnTarjetaIdentidad.Checked))
            {
                errorProvider1.SetError(RbtnCedula, "Debe seleccionar por lo menos una opción.");
                radioButtonChecked = false;
            }

            if (!(RbtnSI.Checked || RbtnNO.Checked))
            {
                errorProvider1.SetError(RbtnNO, "Debe seleccionar por lo menos una opción.");
                radioButtonChecked = false;
            }

            //Validar listas desplegables. 

                bool comboBoxSelected = true;
                errorProvider1.Clear();
              
                if (ComBoxDepartamento.SelectedIndex == -1)
                {
                    errorProvider1.SetError(ComBoxDepartamento, "Seleccione un elemento.");
                    comboBoxSelected = false;
                }

                if (ComBoxGenero.SelectedIndex == -1)
                {
                    errorProvider1.SetError(ComBoxGenero, "Seleccione un elemento.");
                    comboBoxSelected = false;
                }

                if (ComBoxTipoVivienda.SelectedIndex == -1)
                {
                    errorProvider1.SetError(ComBoxTipoVivienda, "Seleccione un elemento.");
                    comboBoxSelected = false;
                }

                if (ComBoxRecursosEconomicos.SelectedIndex == -1)
                {
                    errorProvider1.SetError(ComBoxRecursosEconomicos, "Seleccione un elemento.");
                    comboBoxSelected = false;
                }

                if (ComBoxReduccionAutonomia.SelectedIndex == -1)
                {
                    errorProvider1.SetError(ComBoxReduccionAutonomia, "Seleccione un elemento.");
                    comboBoxSelected = false;
                }

                if (ComBoxSituacionLaboral.SelectedIndex == -1)
                {
                    errorProvider1.SetError(ComBoxSituacionLaboral, "Seleccione un elemento.");
                    comboBoxSelected = false;
            }


            EnfermedadesReportadas ven3 = new EnfermedadesReportadas();
            ven3.Show();
            this.Hide();
            MessageBox.Show("El formulario fue diligenciado de forma exitosa.");

        }
    }
}
