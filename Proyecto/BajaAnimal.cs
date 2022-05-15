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
    public partial class BajaAnimal : Form
    {
        public BajaAnimal()
        {
            InitializeComponent();
        }

        private void BajaAnimal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'adopcionDAJDataSet3.Animal' Puede moverla o quitarla según sea necesario.
            this.animalTableAdapter1.Fill(this.adopcionDAJDataSet3.Animal);
            // TODO: esta línea de código carga datos en la tabla 'adopcionDAJDataSet1.Animal' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'adopcionDAJDataSet1.Animal' Puede moverla o quitarla según sea necesario.
            //this.animalTableAdapter1.Fill(this.adopcionDAJDataSet1.Animal);
            // TODO: esta línea de código carga datos en la tabla 'adopcionDAJDataSet.Animal' Puede moverla o quitarla según sea necesario.
            //this.animalTableAdapter.Fill(this.adopcionDAJDataSet.Animal);
            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();

            var db = (
                from a in datos.Animal
                where a.estado_adopcion == "Registrado"
                select new
                {

                    id_animal = a.id_animal,
                    tipo = a.tipo,
                    nombre = a.nombre,
                    raza = a.raza,
                    sexo = a.sexo,
                    color = a.color,
                    edad = a.edad,
                    tamaño = a.tamaño,
                    foto = a.foto,
                    detalles = a.detalles,
                    fecha_registro = a.fecha_registro,
                    estado_adopcion = a.estado_adopcion
          

        }).ToList();

            dataGridView1.DataSource = db;
            dataGridView1.Refresh();


           

            var dbT = (
                from a in datos.Animal
                where a.estado_adopcion == "Registrado"
                select new
                {
                    a.id_animal
                }).ToList();

            for (int i = 0; i < dbT.Count; i++)
            {
                string[] trozos = dbT[i].ToString().Split(' ');
                cbBajaAnimal.Items.Add(trozos[3]);
            }



        }
    

        private void btBaja_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbBajaAnimal.Text) == true)
            {
                int id = Convert.ToInt32(cbBajaAnimal.SelectedItem);
                AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
                Animal registro = datos.Animal.SingleOrDefault(p => p.id_animal == id);
                
                //si el registro existe lo elimina
                if (registro != null)
                {
                    datos.Animal.Remove(registro);
                    datos.SaveChanges();
                    MessageBox.Show("El animal ha sido dado de baja.");
                    //dgvBaja.Refresh();
                    //this.animalTableAdapter.Fill(this.adopcionDAJDataSet.Animal);
                }
                AdopcionDAJEntities1 datos5 = new AdopcionDAJEntities1();

                var db = (
                    from a in datos5.Animal
                    where a.estado_adopcion == "Registrado"
                    select new
                    {

                        id_animal = a.id_animal,
                        tipo = a.tipo,
                        nombre = a.nombre,
                        raza = a.raza,
                        sexo = a.sexo,
                        color = a.color,
                        edad = a.edad,
                        tamaño = a.tamaño,
                        foto = a.foto,
                        detalles = a.detalles,
                        fecha_registro = a.fecha_registro,
                        estado_adopcion = a.estado_adopcion

                    }).ToList();

                dataGridView1.DataSource = db;
                dataGridView1.Refresh();


                cbBajaAnimal.Items.Clear();
                var dbT = (
                    from a in datos.Animal
                    where a.estado_adopcion == "Registrado"
                    select new
                    {
                        a.id_animal
                    }).ToList();

                for (int i = 0; i < dbT.Count; i++)
                {
                    string[] trozos = dbT[i].ToString().Split(' ');
                    cbBajaAnimal.Items.Add(trozos[3]);
                }
                cbBajaAnimal.Text = "";
                tbNombre.Text = "";
                tbTipo.Text = "";
                tbSexo.Text = "";
                tbColor.Text = "";
                tbEdad.Text = "";
                tbTamaño.Text = "";
                tbFechadeRegistro.Text = "";
                tbDetalles.Text = "";
                tbRaza.Text = "";
                pictureBoxFoto.Hide();
            }
        
            else
                {
                    MessageBox.Show("Debes seleccionar el ID del animal que deseas dar de baja");
                }
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbBajaAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = -1;
            pictureBoxFoto.Show();
            try
            {
                id = Convert.ToInt32(cbBajaAnimal.SelectedItem);
            }
            catch (Exception Ex)
            {
                tbNombre.Text = "";
                tbTipo.Text = "";
                tbSexo.Text = "";
                tbColor.Text = "";
                tbEdad.Text = "";
                tbTamaño.Text = "";
                tbFechadeRegistro.Text = "";
                tbDetalles.Text = "";
            }


            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
            Animal registro = datos.Animal.SingleOrDefault(p => p.id_animal == id);
            if (registro != null)
            {
                tbNombre.Text = registro.nombre;
                tbTipo.Text = registro.tipo;
                tbSexo.Text = registro.sexo;
                tbColor.Text = registro.color;
                tbEdad.Text = registro.edad.ToString();
                tbTamaño.Text = registro.tamaño;
                tbFechadeRegistro.Text = registro.fecha_registro;
                tbDetalles.Text = registro.detalles;
                tbRaza.Text = registro.raza;

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



                //tbEstado.Text = registro.estado_adopcion;
            }
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


