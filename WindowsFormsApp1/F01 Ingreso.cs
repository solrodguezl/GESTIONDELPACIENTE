using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class RF01_Ingreso : Form
    {
        public RF01_Ingreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Sol Rodriguez" && txtContrasena.Text == "12345") 
            {
                MessageBox.Show("BIENVENIDO");
                DatosGeneralesPaciente ven2 = new DatosGeneralesPaciente();
                ven2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ACCESO DENEGADO");
                txtUsuario.Clear();
                txtContrasena.Clear();

            }
        }

        private void RF01_Ingreso_Load(object sender, EventArgs e)
        {

        }
    }
}
