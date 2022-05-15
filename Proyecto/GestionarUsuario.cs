using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class GestionarUsuario : Form
    {
        static ErrorProvider ErrorProvider1 = new ErrorProvider();
        public GestionarUsuario()
        {
            InitializeComponent(); 
        }

        private void tbNombreBaja_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBaja_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbIdBaja.Text);
            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
            Usuario registro = datos.Usuario.SingleOrDefault(p => p.id_usuario == id);

            //si el registro existe lo elimina
            if (registro != null)
            {
                datos.Usuario.Remove(registro);
                datos.SaveChanges();
                MessageBox.Show("Se ha dado de baja correctamente al usuario");

               
                tbNombreBaja.Text = "";
                tbRFCBaja.Text = "";
               
                tbCorreoBaja.Text = "";
                tbTelBaja.Text = "";
               
                tbRolBaja.Text = "";
            }

            this.usuarioTableAdapter.Fill(this.adopcionDAJDataSet3.Usuario);

        }

        private void tbNombreMod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btMod_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNombreMod.Text) == true & !String.IsNullOrEmpty(tbRFCMod.Text) == true & !String.IsNullOrEmpty(tbClaveMod.Text) == true & !String.IsNullOrEmpty(tbCorreoMod.Text) == true & !String.IsNullOrEmpty(tbTelMod.Text) == true & !String.IsNullOrEmpty(tbDireccionMod.Text) == true & !String.IsNullOrEmpty(cbRolMod.Text))
            {

                if (email_bien_escrito(tbCorreoMod.Text) == false)
                {
                    MessageBox.Show("Correo invalido");

                    return;
                }

                int id = Convert.ToInt32(cbIdModificar.SelectedValue);
                AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
                //si existe el registro regresara los datos existentes
                //y vamos a sobreescribir
                Usuario registro = datos.Usuario.SingleOrDefault(p => p.id_usuario == id);

                registro.Nombre = tbNombreMod.Text;
                registro.RFC = tbRFCMod.Text;
                registro.clave = tbClaveMod.Text;
                registro.correo = tbCorreoMod.Text;
                registro.tel = tbTelMod.Text;
                registro.direccion = tbDireccionMod.Text;
                registro.Rol = cbRolMod.SelectedItem.ToString();
                //guardar cambios
                datos.SaveChanges();
                MessageBox.Show("Se han realizado las modificaciones correspondientes al usuario");

                tbNombreMod.Text = "";
                tbRFCMod.Text = "";
                tbClaveMod.Text = "";
                tbCorreoMod.Text = "";
                tbTelMod.Text = "";
                tbDireccionMod.Text = "";
                cbRolMod.SelectedIndex = -1;

                this.usuarioTableAdapter.Fill(this.adopcionDAJDataSet3.Usuario);
            }
            else
            {
                MessageBox.Show("Faltan datos por llenar");
            }
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNombreAlta.Text) == true & !String.IsNullOrEmpty(tbRFCAlta.Text) == true & !String.IsNullOrEmpty(tbClaveAlta.Text) == true & !String.IsNullOrEmpty(tbCorreoAlta.Text) == true & !String.IsNullOrEmpty(tbTelAlta.Text) == true & !String.IsNullOrEmpty(tbDireccionAlta.Text) == true & !String.IsNullOrEmpty(cbRolAlta.Text))
            {
                if (email_bien_escrito(tbCorreoAlta.Text) == false)
                {
                    MessageBox.Show("Correo invalido");

                    return;
                }

                AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
                Usuario newRegistro = new Usuario();
                {

                    newRegistro.Nombre = tbNombreAlta.Text;
                    newRegistro.RFC = tbRFCAlta.Text;
                    newRegistro.clave = tbClaveAlta.Text;
                    newRegistro.correo = tbCorreoAlta.Text;
                    newRegistro.tel = tbTelAlta.Text;
                    newRegistro.direccion = tbDireccionAlta.Text;
                    newRegistro.Rol = cbRolAlta.SelectedItem.ToString();
                    MessageBox.Show("Se ha dado de alta correctamente al usuario");
                };
                //Agrega el registro
                datos.Usuario.Add(newRegistro);
                //Guarda los cambios
                datos.SaveChanges();
                tbNombreAlta.Text = "";
                tbRFCAlta.Text = "";
                tbClaveAlta.Text = "";
                tbCorreoAlta.Text = "";
                tbTelAlta.Text = "";
                tbDireccionAlta.Text = "";
                cbRolAlta.SelectedIndex = -1;
            
                this.usuarioTableAdapter.Fill(this.adopcionDAJDataSet3.Usuario);

            }
            else
            {
                MessageBox.Show("Faltan datos por llenar");
            }
        }

        private void tbIdBaja_TextChanged(object sender, EventArgs e)
        {
            int id = -1;
            try
            {
                id = Convert.ToInt32(cbIdBaja.Text);
            }
            catch (Exception Ex)
            {
                tbNombreBaja.Text = "";
                tbRFCBaja.Text = "";
              
                tbCorreoBaja.Text = "";
                tbTelBaja.Text = "";
                
                tbRolBaja.Text = "";
            }


            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
            Usuario registro = datos.Usuario.SingleOrDefault(p => p.id_usuario == id);
            if (registro != null)
            {
                tbNombreBaja.Text = registro.Nombre;
                tbRFCBaja.Text = registro.RFC;
                
                tbCorreoBaja.Text = registro.correo;
                tbTelBaja.Text = registro.tel;
                
                tbRolBaja.Text = registro.Rol;
            }

        }

        private void tbIdMod_TextChanged(object sender, EventArgs e)
        {
            int id = -1;
            try
            {
                id = Convert.ToInt32(cbIdModificar.SelectedValue);
            }
            catch (Exception Ex)
            {
                tbNombreMod.Text = "";
                tbRFCMod.Text = "";
                tbClaveMod.Text = "";
                tbCorreoMod.Text = "";
                tbTelMod.Text = "";
                tbDireccionMod.Text = "";
                cbRolMod.SelectedIndex = -1;
                tbNombreMod.Enabled = false;
                tbRFCMod.Enabled = false;
                tbClaveMod.Enabled = false;
                tbCorreoMod.Enabled = false;
                tbTelMod.Enabled = false;
                tbDireccionMod.Enabled = false;
                cbRolMod.Enabled = false;
            }


            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
            Usuario registro = datos.Usuario.SingleOrDefault(p => p.id_usuario == id);
            if (registro != null)
            {
                tbNombreMod.Text = registro.Nombre;
                tbRFCMod.Text = registro.RFC;
                tbClaveMod.Text = registro.clave;
                tbCorreoMod.Text = registro.correo;
                tbTelMod.Text = registro.tel;
                tbDireccionMod.Text = registro.direccion;
                cbRolMod.SelectedItem = registro.Rol;
                tbNombreMod.Text = registro.Nombre;
                tbNombreMod.Enabled = true;
                tbRFCMod.Enabled = true;
                tbClaveMod.Enabled = true;
                tbCorreoMod.Enabled = true;
                tbTelMod.Enabled = true;
                tbDireccionMod.Enabled = true;
                cbRolMod.Enabled = true;
            }
        }

        private void GestionarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'adopcionDAJDataSet3.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.adopcionDAJDataSet3.Usuario);
            cbIdModificar.SelectedIndex = -1;
            cbIdBaja.SelectedIndex = -1;
        }

        private void cbIdBaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = -1;
            try
            {
                id = Convert.ToInt32(cbIdBaja.SelectedValue);
            }
            catch (Exception Ex)
            {
                tbNombreBaja.Text = "";
                tbRFCBaja.Text = "";
               
                tbCorreoBaja.Text = "";
                tbTelBaja.Text = "";
                
                tbRolBaja.Text = "";
            }
            

            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
            Usuario registro = datos.Usuario.SingleOrDefault(p => p.id_usuario == id);
            if (registro != null)
            {
                tbNombreBaja.Text = registro.Nombre;
                tbRFCBaja.Text = registro.RFC; 
                tbCorreoBaja.Text = registro.correo;
                tbTelBaja.Text = registro.tel; 
                tbRolBaja.Text = registro.Rol;
            }
        }

        private void cbIdModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = -1;
            try
            {
                id = Convert.ToInt32(cbIdModificar.SelectedValue);
            }
            catch (Exception Ex)
            {
                tbNombreMod.Text = "";
                tbRFCMod.Text = "";
                tbClaveMod.Text = "";
                tbCorreoMod.Text = "";
                tbTelMod.Text = "";
                tbDireccionMod.Text = "";
                cbRolMod.SelectedIndex = -1;
                tbNombreMod.Enabled = false;
                tbRFCMod.Enabled = false;
                tbClaveMod.Enabled = false;
                tbCorreoMod.Enabled = false;
                tbTelMod.Enabled = false;
                tbDireccionMod.Enabled = false;
                cbRolMod.Enabled = false;
                
            }


            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
            Usuario registro = datos.Usuario.SingleOrDefault(p => p.id_usuario == id);
            if (registro != null)
            {
                tbNombreMod.Text = registro.Nombre;
                tbRFCMod.Text = registro.RFC;
                tbClaveMod.Text = registro.clave;
                tbCorreoMod.Text = registro.correo;
                tbTelMod.Text = registro.tel;
                tbDireccionMod.Text = registro.direccion;
                cbRolMod.SelectedItem = registro.Rol;
                tbNombreMod.Text = registro.Nombre;
                tbNombreMod.Enabled = true;
                tbRFCMod.Enabled = true;
                tbClaveMod.Enabled = true;
                tbCorreoMod.Enabled = true;
                tbTelMod.Enabled = true;
                tbDireccionMod.Enabled = true;
                cbRolMod.Enabled = true;
            }
        }

        private void tbNombreAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);

        }

        private void tbRFCAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEspacios(sender, e);
        }

        private void tbClaveAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEspacios(sender, e);
        }

        private void tbCorreoAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEspacios(sender, e);
        }

        private void tbTelAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void tbDireccionAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbNombreMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void tbRFCMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEspacios(sender, e);
        }

        private void tbClaveMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEspacios(sender, e);
        }

        private void tbCorreoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEspacios(sender, e);
        }

        private void tbTelMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void tbDireccionMod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void soloLetras(object sender, KeyPressEventArgs e)
        {
            ErrorProvider1.Clear();
            if (!char.IsLetter(e.KeyChar) & !char.IsWhiteSpace(e.KeyChar) & !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                var controlenviado = sender as Control;
                ErrorProvider1.SetError(controlenviado, "¡Sólo puedes ingresar letras!");

                //MessageBox.Show("Solo Letras!");
            }
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            ErrorProvider1.Clear();
            //Si es diferente a numero
            if (!char.IsDigit(e.KeyChar) & !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                var controlenviado = sender as Control;
                ErrorProvider1.SetError(controlenviado, "¡Sólo puedes ingresar numeros!");

                //MessageBox.Show("Solo Letras!");

            }
        }

        private void noEspacios(object sender, KeyPressEventArgs e)
        {
            ErrorProvider1.Clear();
            if (char.IsWhiteSpace(e.KeyChar) & !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                var controlenviado = sender as Control;
                ErrorProvider1.SetError(controlenviado, "¡No puedes usar espacios!");

                //MessageBox.Show("Solo Letras!");
            }
        }

        private bool email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void tbTelMod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
