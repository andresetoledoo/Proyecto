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
    public partial class ReportesAdopcion : Form
    {
        int sifunciona;
        public ReportesAdopcion(int id) 
        {
            InitializeComponent();
            this.TopMost = true;
            sifunciona = id;
            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
            Adopcion registro = datos.Adopcion.SingleOrDefault(p => p.id_Adopcion == sifunciona);
            Animal registroA = datos.Animal.SingleOrDefault(p => p.id_animal == registro.id_animal);
            Usuario registroE = datos.Usuario.SingleOrDefault(p => p.id_usuario == registro.id_usuario);

            //si el registro existe lo elimina
            if (registro != null)
            {
                //se rellna lo de la adopcion
                lbFechaRegistroR.Text = registro.fecha_registro;
                lbNombreAR.Text = registro.Nombre;
                lbEdadAR.Text = registro.edad.ToString();
                lbCorreoR.Text = registro.correo;
                lbDireccionAR.Text = registro.direccion;
                lbTelAR.Text = registro.tel;
                lbP1R.Text = registro.r1;
                lbP2R.Text = registro.r2;
                lbP3R.Text = registro.r3;
                lbP4R.Text = registro.r4;
                lbDonacionR.Text = registro.Donacion.ToString();
                //lleno datos del animal
                lbid_animalR.Text = registroA.id_animal.ToString();
                lbNombreR.Text = registroA.nombre;
                lbRazaR.Text = registroA.raza;
                lbTipoR.Text = registroA.tipo;
                lbColorR.Text = registroA.color;
                lbSexoR.Text = registroA.sexo;
                lbEdadR.Text = registroA.edad.ToString();
                lbTamañoR.Text = registroA.tamaño;
                tbDetallesR.Text = registroA.detalles;
                //llenar usaurio
                lbNombreEmpleadoR.Text = registroE.Nombre;
                //lleno foto
                try
                {
                    if (registroA.foto.ToString() != "openFileDialog1")
                    {
                        pictureBoxFoto.Image = Image.FromFile(registroA.foto);
                    }
                    else
                    {

                        pictureBoxFoto.Image = Image.FromFile(@"C:\Users\Joel\source\repos\Proyecto\Proyecto\Imagenes\no-image.png");
                    }
                }
                catch (Exception ex)
                {
                   
                }
            }
        }

        private void ReportesAdopcion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbDonacionR_Click(object sender, EventArgs e)
        {

        }

        private void lbP4R_Click(object sender, EventArgs e)
        {

        }

        private void lbP3R_Click(object sender, EventArgs e)
        {

        }

        private void lbP2R_Click(object sender, EventArgs e)
        {

        }

        private void lbP1R_Click(object sender, EventArgs e)
        {

        }

        private void lbEdadAR_Click(object sender, EventArgs e)
        {

        }

        private void lbTelAR_Click(object sender, EventArgs e)
        {

        }

        private void lbCorreoR_Click(object sender, EventArgs e)
        {

        }

        private void lbDireccionAR_Click(object sender, EventArgs e)
        {

        }

        private void lbNombreAR_Click(object sender, EventArgs e)
        {

        }

        private void lbNombreEmpleadoR_Click(object sender, EventArgs e)
        {

        }

        private void lbDonacion_Click(object sender, EventArgs e)
        {

        }

        private void lbP4_Click(object sender, EventArgs e)
        {

        }

        private void btAdoptar_Click(object sender, EventArgs e)
        {

        }

        private void lbP3_Click(object sender, EventArgs e)
        {

        }

        private void lbP2_Click(object sender, EventArgs e)
        {

        }

        private void lbP1_Click(object sender, EventArgs e)
        {

        }

        private void lbTelA_Click(object sender, EventArgs e)
        {

        }

        private void lbDireccionA_Click(object sender, EventArgs e)
        {

        }

        private void lbNombreA_Click(object sender, EventArgs e)
        {

        }

        private void lbEdadA_Click(object sender, EventArgs e)
        {

        }

        private void lbNombreEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void lbCorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
