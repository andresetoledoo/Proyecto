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
    public partial class FormatoAdopcion : Form
    {
        static ErrorProvider ErrorProvider1 = new ErrorProvider();
        
        int sifunciona;
        Usuario UsarioEmpleado;
        Animal AnimalAdoptado;
        public FormatoAdopcion(int id, Usuario UsarioAtendiendo)
        {

            InitializeComponent();

            this.TopMost = true;

            UsarioEmpleado = UsarioAtendiendo;
            sifunciona = id;
            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
            Animal registro = datos.Animal.SingleOrDefault(p => p.id_animal == sifunciona);
            AnimalAdoptado = registro;

            //si el registro existe lo elimina
            if (registro != null)
            {
                
                tbId_animal.Text = Convert.ToString(registro.id_animal);
                tbNombre.Text = registro.nombre;
                tbRaza.Text = registro.raza;
                tbTipo.Text = registro.tipo;
                tbColor.Text = registro.color;
                tbSexo.Text = registro.sexo;
                tbEdad.Text = Convert.ToString(registro.edad);
                tbTamaño.Text = registro.tamaño;
                tbDetalles.Text = registro.detalles;
                tbNombreDeEmpleado.Text = UsarioEmpleado.Nombre;
                try
                {
                    if (registro.foto.ToString() != "openFileDialog1")
                    {
                        pictureBoxFoto.Image = Image.FromFile(registro.foto);
                    }
                    else
                    {
                        pictureBoxFoto.Image = Image.FromFile(@"C:\Users\Joel\source\repos\Proyecto\Proyecto\Imagenes\no-image.png");
                    }
                }
                catch (Exception ex)
                {

                }


                //dgvBaja.Refresh();

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNombreA.Text) == true & !String.IsNullOrEmpty(tbDireccionA.Text) == true & !String.IsNullOrEmpty(tbCorreo.Text) == true & !String.IsNullOrEmpty(tbEdadA.Text) == true & !String.IsNullOrEmpty(tbTelA.Text) == true & !String.IsNullOrEmpty(tbP1.Text) == true & !String.IsNullOrEmpty(tbP2.Text) == true & !String.IsNullOrEmpty(tbP3.Text) == true & !String.IsNullOrEmpty(tbP4.Text) == true & !String.IsNullOrEmpty(tbDonacion.Text) == true)
            {


                    if (email_bien_escrito(tbCorreo.Text) == false)
                {
                    MessageBox.Show("Correo invalido");
                
                    return;
                }
            
                AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
                Adopcion newRegistro = new Adopcion();
                {
                    newRegistro.Nombre = tbNombreA.Text;
                    newRegistro.direccion = tbDireccionA.Text;
                    newRegistro.edad = Convert.ToInt32(tbEdadA.Text);
                    newRegistro.tel = tbTelA.Text;
                    newRegistro.r1 = tbP1.Text;
                    newRegistro.r2 = tbP2.Text;
                    newRegistro.r3 = tbP3.Text;
                    newRegistro.r4 = tbP4.Text;
                    newRegistro.correo = tbCorreo.Text;
                    newRegistro.Donacion = Convert.ToInt32(tbDonacion.Text);
                    newRegistro.fecha_registro = dateTimePicker1.Text;
                    newRegistro.id_usuario = UsarioEmpleado.id_usuario;
                    newRegistro.id_animal = AnimalAdoptado.id_animal;

                };
                //Agrega el registro
                datos.Adopcion.Add(newRegistro);
                //Guarda los cambios
                datos.SaveChanges();






                ///////////////////////
                //tomamos el id que queremos modificar
                int id = AnimalAdoptado.id_animal;
                AdopcionDAJEntities1 datos2 = new AdopcionDAJEntities1();
                //si existe el registro regresara los datos existentes
                //y vamos a sobreescribir
                Animal registro = datos2.Animal.SingleOrDefault(p => p.id_animal == id);
                registro.estado_adopcion = "Adoptado";
                //guardar cambios
                datos2.SaveChanges();
                MessageBox.Show("Bien hecho, has adoptado a un animal");
                this.Close();

            }
            else
            {
                MessageBox.Show("Faltan datos por llenar");
            }

        }

        private void FormatoAdopcion_Load(object sender, EventArgs e)
        {

        }

        private void tbNombreA_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void tbCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEspacios(sender, e);
        }

        private void tbEdadA_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void tbTelA_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void tbDonacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
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

        private void tbP2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
