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

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class AgregarTrabajoForm : Form
    {
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
            this.label1.Left = (Width - label1.Width) - 20;
        }

        private void AgregarTrabajoForm_Resize(object sender, EventArgs e)
        {
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string nombreCliente = this.txtNombreCliente.Text;
            string lugarProyecto = this.txtLugarProyecto.Text;
            DateTime fecha = this.dateTimePicker1.Value;
            string descripcion = this.textBox1.Text;

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
            HomeForm frm = new HomeForm();
            frm.Show();
            this.Hide();
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
            Button btn = sender as Button;
            btn.BackColor = Color.White; // Volver al color original
            btn.ForeColor = ColorTranslator.FromHtml("#284b63"); // Volver al color original del texto
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
