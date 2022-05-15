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
    public partial class ConsultaAdopcion : Form
    {
        public ConsultaAdopcion()
        {
            InitializeComponent();
        }

        private void ConsultaAdopcion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'adopcionDAJDataSet3.Adopcion' Puede moverla o quitarla según sea necesario.
            this.adopcionTableAdapter.Fill(this.adopcionDAJDataSet3.Adopcion);
            
            
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            int indexID;// = Convert.ToInt32(textBox1.Text);
            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();

            try
            {
                indexID = Convert.ToInt32(tbID.Text);


                var db = (
                from a in datos.Adopcion 
                where a.id_Adopcion==indexID
                select new
                {

                    id_Adopcion = a.id_Adopcion,
                    fecha_registro = a.fecha_registro,
                    Nombre = a.Nombre,
                    correo = a.correo,
                    tel = a.tel,
                    Donacion = a.Donacion
                   

                }).ToList();

               
                tbID.Text = indexID.ToString();
                dataGridView1.DataSource = db;
                dataGridView1.Refresh();
            }
            catch (Exception Ex)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(ReportesAdopcion))
                {
                    formulario.Focus();
                    formulario.WindowState = FormWindowState.Normal;
                    return;
                }
            }

                var filaSeleccionada = dataGridView1.CurrentRow;

            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells[1].Value);
                
                ReportesAdopcion adopcion = new ReportesAdopcion(id);
                
                adopcion.WindowState = FormWindowState.Normal;

                adopcion.Show();
                //adopcion.Focus();
               

            }
            this.Close();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();

            var db = (
                from a in datos.Adopcion
                select new
                {

                    id_Adopcion = a.id_Adopcion,
                    fecha_registro = a.fecha_registro,
                    Nombre = a.Nombre,
                    correo = a.correo,
                    tel = a.tel,
                    Donacion = a.Donacion

                }).ToList();



            tbID.Text = "";
            dataGridView1.DataSource = db;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
