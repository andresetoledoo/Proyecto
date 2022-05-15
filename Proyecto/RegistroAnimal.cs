using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class RegistroAnimal : Form
    {
        static ErrorProvider ErrorProvider1 = new ErrorProvider();
        public RegistroAnimal()
        {
            InitializeComponent();
            
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(tbNombre.Text) == true & !String.IsNullOrEmpty(cbTipo.Text) == true & !String.IsNullOrEmpty(cbSexo.Text) == true)
            {

                AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
                Animal newRegistro = new Animal();
                {
                
                    newRegistro.nombre = tbNombre.Text;
                    newRegistro.tipo = cbTipo.Text;
                    newRegistro.raza = tbRaza.Text;
                    newRegistro.sexo = cbSexo.Text;
                    newRegistro.color = cbColor.Text;
                    if (tbEdad.Text != null)
                        {
                            newRegistro.edad = Convert.ToInt32(tbEdad.Text);
                        }
                
                    newRegistro.tamaño = cbTamaño.Text;
                    newRegistro.fecha_registro = dtpFechaR.Text;
                    newRegistro.detalles = tbDetalles.Text;
                    newRegistro.estado_adopcion = "Registrado";
                    newRegistro.foto = openFileDialog1.FileName;
                };
                //Agrega el registro
                datos.Animal.Add(newRegistro);
                //Guarda los cambios
                datos.SaveChanges();


                //try
                //{
                //    datos.SaveChanges();
                //    //DataContext.SaveChanges();
                //}
                //catch (DbEntityValidationException ex)
                //{
                //    // Retrieve the error messages as a list of strings.
                //    var errorMessages = ex.EntityValidationErrors
                //            .SelectMany(x => x.ValidationErrors)
                //            .Select(x => x.ErrorMessage);

                //    // Join the list to a single string.
                //    var fullErrorMessage = string.Join("; ", errorMessages);

                //    // Combine the original exception message with the new one.
                //    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                //    // Throw a new DbEntityValidationException with the improved exception message.
                //    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                //}


                MessageBox.Show("Se ha dado de alta correctamente al animal");

                tbNombre.Text="";
                cbTipo.SelectedIndex = -1;
                tbRaza.Text= "";
                cbSexo.SelectedIndex = -1;
                cbColor.SelectedIndex = -1;
                tbEdad.Text = "";
                cbTamaño.SelectedIndex = -1;
                dtpFechaR.Text = "";
                tbDetalles.Text = "";
                pictureBoxFoto.Image = Image.FromFile(@"C:\Users\Joel\source\repos\Proyecto\Proyecto\Imagenes\fondoanimal.png");
                //this.Close();



            }
            else
                {
                    MessageBox.Show("Debes seleccionar un nombre, tipo y sexo al animal para poder registrarlo");
                }
            }
        private void RegistroAnimal_Load(object sender, EventArgs e)
        {
            
            //cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string RUTA = openFileDialog1.FileName;
                    pictureBoxFoto.Image = Image.FromFile(RUTA);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender,e);
        }

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void soloLetras (object sender, KeyPressEventArgs e)
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

        private void tbRaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
