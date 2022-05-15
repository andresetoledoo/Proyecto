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
    public partial class Interfaz : Plantilla
    {
        Usuario UsarioActivo;
        public Interfaz(Usuario Usuario)
            
        {
            this.TopMost = false;
            InitializeComponent();
            UsarioActivo = Usuario;
        }

        private void registrarAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(RegistroAnimal))
                {
                    formulario.Focus();
                    formulario.WindowState = FormWindowState.Normal;
                    return;
                }
            }

            RegistroAnimal FormularioHijo1 = new RegistroAnimal();
            FormularioHijo1.Text = "Registrar animal";
            FormularioHijo1.WindowState = FormWindowState.Normal;
            //FormularioHijo1.WindowState = FormWindowState.Maximized;
            FormularioHijo1.MdiParent = this;
            FormularioHijo1.Show();


        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(BajaAnimal))
                {
                    formulario.Focus();
                    formulario.WindowState = FormWindowState.Normal;
                    return;
                }
            }

            BajaAnimal FormularioHijo2 = new BajaAnimal();
            FormularioHijo2.Text = "Baja animal";
            FormularioHijo2.WindowState = FormWindowState.Normal;
            //FormularioHijo1.WindowState = FormWindowState.Maximized;
            FormularioHijo2.MdiParent = this;
            FormularioHijo2.Show();
        }

        private void consultaAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(Consulta))
                {
                    formulario.Focus();
                    formulario.WindowState = FormWindowState.Normal;
                    return;
                }
            }
            Consulta FormularioHijo3 = new Consulta(UsarioActivo);
            FormularioHijo3.Text = "Consulta animales";
            FormularioHijo3.WindowState = FormWindowState.Normal;
            //FormularioHijo1.WindowState = FormWindowState.Maximized;
            FormularioHijo3.MdiParent = this;
            FormularioHijo3.Show();
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {

            AdopcionDAJEntities1 datos = new AdopcionDAJEntities1();
            var db = (
                from a in datos.Animal
                where a.estado_adopcion == "Registrado"
                select new
                {
                    estado_adopcion = a.estado_adopcion

                }).ToList();
            

            AdopcionDAJEntities1 datos1 = new AdopcionDAJEntities1();
            var db1 = (
                from a in datos1.Animal
                where a.estado_adopcion == "Adoptado"
                select new
                {
                    estado_adopcion = a.estado_adopcion

                }).ToList();
            

            string rol = UsarioActivo.Rol;
            if (rol=="Administrador")
            {
                reportesToolStripMenuItem.Visible = true;
                gestionarEmpleadosToolStripMenuItem.Visible = true;
               
            }
            cerrarSesionToolStripMenuItem.Visible = true;

        }

        private void modificarDatosAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(ModificarAnimal))
                {
                    formulario.Focus();
                    formulario.WindowState = FormWindowState.Normal;
                    return;
                }
            }
            ModificarAnimal FormularioHijo4 = new ModificarAnimal();
            FormularioHijo4.Text = "Consulta animales";
            FormularioHijo4.WindowState = FormWindowState.Normal;
            //FormularioHijo1.WindowState = FormWindowState.Maximized;
            FormularioHijo4.MdiParent = this;
            FormularioHijo4.Show();
        }

        private void gestionarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(GestionarUsuario))
                {
                    formulario.Focus();
                    formulario.WindowState = FormWindowState.Normal;
                    return;
                }
            }
            GestionarUsuario FormularioHijo5 = new GestionarUsuario();
            FormularioHijo5.Text = "Gestionar usuario";
            FormularioHijo5.WindowState = FormWindowState.Normal;
            //FormularioHijo1.WindowState = FormWindowState.Maximized;
            FormularioHijo5.MdiParent = this;
            FormularioHijo5.Show();
        }

        private void consultarReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(ConsultaAdopcion))
                {
                    formulario.Focus();
                    formulario.WindowState = FormWindowState.Normal;
                    return;
                }
            }
            ConsultaAdopcion FormularioHijo6 = new ConsultaAdopcion();
            FormularioHijo6.Text = "Consulta de Adopciones";
            FormularioHijo6.WindowState = FormWindowState.Normal;
            //FormularioHijo1.WindowState = FormWindowState.Maximized;
            FormularioHijo6.MdiParent = this;
            FormularioHijo6.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Interfaz_MouseLeave(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

       
    }
}
