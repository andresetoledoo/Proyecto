using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); 
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            String usuario = tbUsuario.Text;
            String contraseña = tbContraseña.Text;

            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
            Usuario registro = datos.Usuario.SingleOrDefault(p => p.correo == usuario & p.clave == contraseña);
            if (registro != null)
            {
                MessageBox.Show("Usuario encontrado");
                Interfaz inicio = new Interfaz(registro);
                this.Hide();
                inicio.WindowState = FormWindowState.Normal;
                inicio.Show();
            }
            else
            {
                MessageBox.Show("El usuario no existe");
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbContraseña_Click(object sender, EventArgs e)
        {

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
