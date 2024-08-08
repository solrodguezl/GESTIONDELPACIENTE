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
    public partial class CuidadorPaciente : Form
    {
        public CuidadorPaciente()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CuidadorPaciente_Load(object sender, EventArgs e)
        {


        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool textBoxcheked = true;

            if (string.IsNullOrEmpty(TxtNombres5.Text) || !ValidarSoloLetras(TxtNombres5, erpCuidador))
            {
                erpCuidador.SetError(TxtNombres5, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            if (string.IsNullOrEmpty(TxtApellidos5.Text) || !ValidarSoloLetras(TxtApellidos5, erpCuidador))
            {
                erpCuidador.SetError(TxtApellidos5, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            if (string.IsNullOrEmpty(TxtNumeroDocumento.Text) || !ValidarSoloLetras(TxtNumeroDocumento, erpCuidador))
            {
                erpCuidador.SetError(TxtNumeroDocumento, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            if (string.IsNullOrEmpty(TxtCorreo5.Text) || !ValidarSoloLetras(TxtCorreo5, erpCuidador))
            {
                erpCuidador.SetError(TxtCorreo5, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            //Numeros

            if (string.IsNullOrEmpty(TxtCelular5.Text) || !ValidarSoloNumeros(TxtCelular5, erpCuidador))
            {
                erpCuidador.SetError(TxtCelular5, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            if (string.IsNullOrEmpty(TxtNumeroDocumento.Text) || !ValidarSoloNumeros(TxtNumeroDocumento, erpCuidador))
            {
                erpCuidador.SetError(TxtNumeroDocumento, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }

            if (string.IsNullOrEmpty(TxtEdad5.Text) || !ValidarSoloNumeros(TxtEdad5, erpCuidador))
            {
                erpCuidador.SetError(TxtEdad5, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }


            //Validar listas despliegables

            bool comboBoxSelected = true;
            erpCuidador.Clear();

            if (ComBoxTipoDocumento.SelectedIndex == -1)
            {
                erpCuidador.SetError(ComBoxTipoDocumento, "Seleccione un elemento.");
                comboBoxSelected = false;
            }

            if (ComBoxParentesco5.SelectedIndex == -1)
            {
                erpCuidador.SetError(ComBoxParentesco5, "Seleccione un elemento.");
                comboBoxSelected = false;
            }

            if (ComBoxProgramasDeCuidado.SelectedIndex == -1)
            {
                erpCuidador.SetError(ComBoxProgramasDeCuidado, "Seleccione un elemento.");
                comboBoxSelected = false;
            }

            if (ComBoxTest.SelectedIndex == -1)
            {
                erpCuidador.SetError(ComBoxTest, "Seleccione un elemento.");
                comboBoxSelected = false;
            }

            //Validar botones

            bool radioButtonChecked = true;

            if (!(CkBoxTiempo.Checked || CkBoxTemor.Checked || CkBoxNoquiere.Checked || CkBoxRelevo.Checked || CkBoxAgotamiento.Checked
                || CkBoxAfiliacionCuidador.Checked || CkBoxOtroCuidador.Checked))
            {
                erpCuidador.SetError(CkBoxOtroCuidador, "Debe seleccionar por lo menos una opción.");
                radioButtonChecked = false;
            }

        }
    }
}


