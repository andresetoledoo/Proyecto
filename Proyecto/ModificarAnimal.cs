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
    public partial class ModificarAnimal : Form
    {
        static ErrorProvider ErrorProvider1 = new ErrorProvider();
        public ModificarAnimal()
        {
            InitializeComponent();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNombre.Text) == true & !String.IsNullOrEmpty(cbId.Text) == true & cbTipo.SelectedIndex != 0 & cbSexo.SelectedIndex != 0 )
            {
                //tomamos el id que queremos modificar
                int id = Convert.ToInt32(cbId.SelectedItem);
            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
            //si existe el registro regresara los datos existentes
            //y vamos a sobreescribir
            Animal registro = datos.Animal.SingleOrDefault(p => p.id_animal == id);

            registro.nombre = tbNombre.Text;
            registro.tipo = cbTipo.Text;
            registro.raza = tbRaza.Text;
            registro.sexo = cbSexo.Text;
            registro.color = cbColor.Text;
            registro.edad = Convert.ToInt32(tbEdad.Text);
            registro.tamaño = cbTamaño.Text;
            registro.detalles = tbDetalles.Text;
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
                




                //guardar cambios
                datos.SaveChanges();
            MessageBox.Show("Se han realizado las modificaciones correspondientes al animal");

            }
            else
            {
                if (!String.IsNullOrEmpty(cbId.Text) == false)
                {
                    MessageBox.Show("Debes seleccionar un ID ");
                }
            else {
                    MessageBox.Show("El animal debe tener un nombre, un tipo y un sexo");
                }
               
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ModificarAnimal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'adopcionDAJDataSet3.Animal' Puede moverla o quitarla según sea necesario.
            this.animalTableAdapter.Fill(this.adopcionDAJDataSet3.Animal);
            
            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();

            var db = (
                from a in datos.Animal
                where a.estado_adopcion == "Registrado"
                select new
                {
                    a.id_animal
                }).ToList();

            for (int i = 0; i < db.Count; i++)
            {
                string [] trozos = db[i].ToString().Split(' ');
                cbId.Items.Add(trozos[3]);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = -1;
            try
            {
                id = Convert.ToInt32(cbId.SelectedItem);
            }
            catch (Exception Ex)
            {
                tbNombre.Text = "";
                tbEdad.Text = "";
                tbRaza.Text = "";
                tbDetalles.Text = "";
                cbTipo.SelectedIndex = 0;
                cbSexo.SelectedIndex = 0;
                cbTamaño.SelectedIndex = 0;
                cbColor.SelectedIndex = 0;

                tbNombre.Enabled = false;
                cbTipo.Enabled = false;
                cbSexo.Enabled = false;
                cbColor.Enabled = false;
                tbRaza.Enabled = false;
                tbEdad.Enabled = false;
                cbTamaño.Enabled = false;
                tbDetalles.Enabled = false;
            }


            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
            Animal registro = datos.Animal.SingleOrDefault(p => p.id_animal == id);
            if (registro != null)
            {
                tbNombre.Text = registro.nombre;
                cbTipo.Text = registro.tipo;
                cbSexo.Text = registro.sexo;
                cbColor.Text = registro.color;
                tbRaza.Text = registro.raza;
                tbEdad.Text = registro.edad.ToString();
                cbTamaño.Text = registro.tamaño;
                tbDetalles.Text = registro.detalles;

                try {
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

                tbNombre.Enabled = true;
                cbTipo.Enabled = true;
                cbSexo.Enabled = true;
                cbColor.Enabled = true;
                tbRaza.Enabled = true;
                tbEdad.Enabled = true;
                cbTamaño.Enabled = true;
                tbDetalles.Enabled = true;

                //tbEstado.Text = registro.estado_adopcion;

            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void tbRaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonFoto_Click(object sender, EventArgs e)
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

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

