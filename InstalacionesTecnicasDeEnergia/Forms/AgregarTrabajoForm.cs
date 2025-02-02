using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstalacionesTecnicasDeEnergia.Models;
using MongoDB.Driver;

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class AgregarTrabajoForm : Form
    {
        public string idTrabajo;
        Conexion conexion = new Conexion();


        public AgregarTrabajoForm()
        {
            InitializeComponent();
            //Ancho de la pantalla
            int widthDisplay = (int)(Screen.PrimaryScreen.Bounds.Width * 0.60);
            int heighDisplay = (int)(Screen.PrimaryScreen.Bounds.Height * 0.60);

            //Ajustar el formulario para ocupar un porcentaje de la pantalla
            this.Width = widthDisplay;
            this.Height = heighDisplay;

            //Centrarlo
            this.StartPosition = FormStartPosition.CenterScreen;

            //Adaptar el panel a todo el ancho
            this.panel1.Width = Width;
            this.txt_Titulo.Left = (Width - txt_Titulo.Width) - 20;
        }

        private void AgregarTrabajoForm_Resize(object sender, EventArgs e)
        {
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if(idTrabajo!=null)
            {
                try
                {
                    // Buscar el trabajo con el id especificado
                    Trabajo trabajo = conexion.TrabajoDb.Find(d => d.Id == idTrabajo).FirstOrDefault();

                    // Variables para verificar si hubo cambios
                    bool huboCambio = false;

                    // Comparar cada campo y verificar si hubo un cambio
                    if (!string.IsNullOrEmpty(txtNombreCliente.Text) && txtNombreCliente.Text != trabajo.NombreCliente)
                    {
                        trabajo.NombreCliente = txtNombreCliente.Text;
                        huboCambio = true;
                    }

                    if (!string.IsNullOrEmpty(txtLugarProyecto.Text) && txtLugarProyecto.Text != trabajo.Lugar)
                    {
                        trabajo.Lugar = txtLugarProyecto.Text;
                        huboCambio = true;
                    }

                    if (!string.IsNullOrEmpty(txtDescripcion.Text) && txtDescripcion.Text != trabajo.DescripcionProyecto)
                    {
                        trabajo.DescripcionProyecto = txtDescripcion.Text;
                        huboCambio = true;
                    }

                    if (fecha.Value != trabajo.Fecha)
                    {
                        trabajo.Fecha = fecha.Value;
                        huboCambio = true;
                    }

                    // Si hubo cambios, actualizamos la base de datos
                    if (huboCambio)
                    {
                        DialogResult resultadoDialogo = MessageBox.Show(
                            "¿Estás seguro de que deseas actualizar los datos?",
                            "Confirmación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (resultadoDialogo == DialogResult.Yes)
                        {
                            var actualizacion = Builders<Trabajo>.Update
                           .Set(p => p.NombreCliente, trabajo.NombreCliente)
                           .Set(p => p.Lugar, trabajo.Lugar)
                           .Set(p => p.DescripcionProyecto, trabajo.DescripcionProyecto)
                           .Set(p => p.Fecha, trabajo.Fecha);

                            // Realizar la actualización en la base de datos
                            var resultado = conexion.TrabajoDb.UpdateOne(t => t.Id == idTrabajo, actualizacion);
                            MessageBox.Show("Trabajo actualizado correctamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PresupuestoForm frm = new PresupuestoForm();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Actualización cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        PresupuestoForm frm = new PresupuestoForm();
                        frm.Show();
                        this.Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("No se ha podido actualizar");
                }
            }
            else
            {
                string nombreCliente = this.txtNombreCliente.Text;
                string lugarProyecto = this.txtLugarProyecto.Text;
                DateTime fecha = this.fecha.Value;
                string descripcion = this.txtDescripcion.Text;

                Trabajo trabajo = new Trabajo();
                trabajo.NombreCliente = nombreCliente;
                trabajo.Lugar = lugarProyecto;
                trabajo.Fecha = fecha;
                trabajo.DescripcionProyecto = descripcion;
                trabajo.Estado = "Pendiente";

                PresupuestoForm frm = new PresupuestoForm(trabajo);
                frm.Show();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
           
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            if (idTrabajo != null)
            {
                DialogResult resultadoDialogo = MessageBox.Show(
                           "¿Estás seguro de que quieres cancelar la actualización de datos?",
                           "Confirmación",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);

                if (resultadoDialogo == DialogResult.Yes)
                {
                    TrabajosPendientesForm frm = new TrabajosPendientesForm();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                HomeForm frm = new HomeForm();
                frm.Show();
                this.Hide();
            }
        }

        private void btnSiguiente_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            int borderRadius = 20; // Tamaño del radio de las esquinas
            int borderSize = 8; // Grosor del borde
            Color borderColor = ColorTranslator.FromHtml("#284b63"); // Color del borde

            Graphics gfx = e.Graphics;
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Crear un rectángulo redondeado
            using (GraphicsPath path = new GraphicsPath())
            {
                int arcSize = borderRadius * 2;
                path.AddArc(0, 0, arcSize, arcSize, 180, 90);
                path.AddArc(btn.Width - arcSize, 0, arcSize, arcSize, 270, 90);
                path.AddArc(btn.Width - arcSize, btn.Height - arcSize, arcSize, arcSize, 0, 90);
                path.AddArc(0, btn.Height - arcSize, arcSize, arcSize, 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path); // Aplica la forma al botón

                // Dibujar el borde
                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    gfx.DrawPath(pen, path);
                }
            }
        }

        private void btnSiguiente_MouseEnter(object sender, EventArgs e)
        {
           
            Button btn = sender as Button;
            btn.BackColor = ColorTranslator.FromHtml("#284b63"); // Cambiar color al pasar el mouse
            btn.ForeColor = Color.White; // Cambiar color del texto
        }

        private void btnSiguiente_MouseLeave(object sender, EventArgs e)
        {
            if(idTrabajo!= null)
            {
                Button btn = sender as Button;
                btn.BackColor = Color.White; // Volver al color original
                btn.ForeColor = ColorTranslator.FromHtml("#284b63"); // Volver al color original del texto
            }
            else
            {
                Button btn = sender as Button;
                btn.BackColor = Color.White; // Volver al color original
                btn.ForeColor = ColorTranslator.FromHtml("#284b63"); // Volver al color original del texto
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AgregarTrabajoForm_Load(object sender, EventArgs e)
        {
            if (idTrabajo != null) 
            {
                this.txt_Titulo.Text = "Editar Trabajo";
                Trabajo trabajo = conexion.TrabajoDb.Find(d => d.Id == idTrabajo).FirstOrDefault();
                this.txtNombreCliente.Text = trabajo.NombreCliente;
                this.txtLugarProyecto.Text = trabajo.Lugar;
                this.txtDescripcion.Text = trabajo.DescripcionProyecto;
                this.fecha.Value = trabajo.Fecha;
            }
            this.txt_Titulo.Text = "Agregar Trabajo";
        }
    }
}
