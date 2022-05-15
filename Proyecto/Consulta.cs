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
    public partial class Consulta : Form
    {
        static ErrorProvider ErrorProvider1 = new ErrorProvider();
        Usuario UsarioAtendiendo;
        public Consulta(Usuario UsarioActivo)
        {
            InitializeComponent();
            UsarioAtendiendo = UsarioActivo;
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'adopcionDAJDataSet3.Animal' Puede moverla o quitarla según sea necesario.
            this.animalTableAdapter1.Fill(this.adopcionDAJDataSet3.Animal);
            // TODO: esta línea de código carga datos en la tabla 'adopcionDAJDataSet1.Animal' Puede moverla o quitarla según sea necesario.
            //this.animalTableAdapter2.Fill(this.adopcionDAJDataSet1.Animal);
            // TODO: esta línea de código carga datos en la tabla 'adopcionDAJDataSet2.Animal' Puede moverla o quitarla según sea necesario.
            //this.animalTableAdapter1.Fill(this.adopcionDAJDataSet2.Animal);
            // TODO: esta línea de código carga datos en la tabla 'adopcionDAJDataSet.Animal' Puede moverla o quitarla según sea necesario.
            //this.animalTableAdapter.Fill(this.adopcionDAJDataSet.Animal);
            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();

            var db = (
                from a in datos.Animal
                where  a.estado_adopcion == "Registrado"
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                string indexTipo = cbTipo.SelectedItem.ToString();
                AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();


                var db = (
                    from a in datos.Animal
                    where a.tipo == indexTipo && a.estado_adopcion == "Registrado"
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

            tbID.Text = "";
            cbSexo.SelectedIndex = 0;
            CbTamaño.SelectedIndex = 0;
            cbTipo.SelectedItem = indexTipo;

            dataGridView1.DataSource = db;
                dataGridView1.Refresh();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.animalTableAdapter.Fill(this.adopcionDAJDataSet.Animal);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fill1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.animalTableAdapter.Fill(this.adopcionDAJDataSet.Animal);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.animalTableAdapter1.FillBy(this.adopcionDAJDataSet3.Animal);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                string indexSexo = cbSexo.SelectedItem.ToString();
                AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();


                var db = (
                    from a in datos.Animal
                    where a.sexo == indexSexo && a.estado_adopcion == "Registrado"
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

            tbID.Text = "";
            cbTipo.SelectedIndex = 0;
            CbTamaño.SelectedIndex = 0;
            cbSexo.SelectedItem = indexSexo;

            dataGridView1.DataSource = db;
                dataGridView1.Refresh();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
                string indexTamaño = CbTamaño.SelectedItem.ToString();
                AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
                
                

                var db = (
                    from a in datos.Animal
                    where a.tamaño == indexTamaño && a.estado_adopcion == "Registrado"
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

            tbID.Text = "";
            cbTipo.SelectedIndex = 0;
            cbSexo.SelectedIndex = 0;
            CbTamaño.SelectedItem = indexTamaño;

            dataGridView1.DataSource = db;
                dataGridView1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int indexID ;// = Convert.ToInt32(textBox1.Text);
            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();

            try
            {
                 indexID = Convert.ToInt32(tbID.Text);
           

                var db = (
                from a in datos.Animal
                where a.id_animal == indexID && a.estado_adopcion == "Registrado"
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

                cbTipo.SelectedIndex = 0;
                cbSexo.SelectedIndex = 0;
                CbTamaño.SelectedIndex = 0;
                tbID.Text = indexID.ToString();
                dataGridView1.DataSource = db;
                dataGridView1.Refresh();
            }
            catch (Exception Ex)
            {

            }

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
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

           

            tbID.Text = "";
            cbTipo.SelectedIndex = 0;
            cbSexo.SelectedIndex = 0;
            CbTamaño.SelectedIndex = 0;

            dataGridView1.DataSource = db;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = dataGridView1.CurrentRow;

            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells[1].Value);
                //label1.Text = id.ToString();
                                                    //mandar al animal
                FormatoAdopcion adopcion = new FormatoAdopcion(id, UsarioAtendiendo);
                
               
                adopcion.Show();
                
            }
            this.Close();
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
