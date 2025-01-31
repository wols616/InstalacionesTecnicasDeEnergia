using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

            //Ancho de la pantalla
            int widthDisplay = (int)(Screen.PrimaryScreen.Bounds.Width * 0.50);
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

        private void btnManoObra_Click(object sender, EventArgs e)
        {
            ManodeObraForm form = new ManodeObraForm();
            form.Show();
            this.Hide();
        }

        private void HomeForm_Resize(object sender, EventArgs e)
        {
            //Esta función hace que el tamaño del panel y posición de los elementos cambie al momento de redimencionar la ventana
            this.panel1.Width = this.ClientSize.Width;
            this.label1.Left = (this.ClientSize.Width - label1.Width) - 20;
            this.pbLogo.Left = 20;
            this.btnAgregarTrabajo.Left = 100;
            this.btnBitacora.Left = 100;
            this.btnEmpleados.Left = 100;
            this.btnInventario.Left = 100;
            this.btnManoObra.Left = 100;
            this.btnTrabajosPendientes.Left = 100;
            this.btnTrabajosRealizados.Left = 100;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            EmpleadosForm empleados = new EmpleadosForm();
            empleados.Show();
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            InventarioForm frm = new InventarioForm();
            frm.Show();
            this.Hide();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            BitacoraForm frm = new BitacoraForm();
            frm.Show();
            this.Hide();
        }

        private void btnAgregarTrabajo_Click(object sender, EventArgs e)
        {
            AgregarTrabajoForm frm = new AgregarTrabajoForm();
            frm.Show();
            this.Hide();
        }

        private void btnTrabajosPendientes_Click(object sender, EventArgs e)
        {
            TrabajosPendientesForm frm = new TrabajosPendientesForm();
            frm.Show();
            this.Hide();
        }

        private void btnTrabajosRealizados_Click(object sender, EventArgs e)
        {
            TrabajosRealizadosForm frm = new TrabajosRealizadosForm();
            frm.Show();
            this.Hide();
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

       

        private void pb2_Resize(object sender, EventArgs e)
        {
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            btnAgregarTrabajo.MouseEnter += new EventHandler(btnAgregarTrabajo_MouseEnter_1);
            btnAgregarTrabajo.MouseLeave += new EventHandler(btnAgregarTrabajo_MouseLeave_1);
            btnAgregarTrabajo.Paint += new PaintEventHandler(btnAgregarTrabajo_Paint_1);

        }

        private bool isHovered = false;

        private void btnAgregarTrabajo_Paint_1(object sender, PaintEventArgs e)
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

        private void btnAgregarTrabajo_MouseEnter_1(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            btn.BackColor = ColorTranslator.FromHtml("#284b63"); // Cambiar color al pasar el mouse
            btn.ForeColor = Color.White; // Cambiar color del texto

        }

        private void btnAgregarTrabajo_MouseLeave_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White; // Volver al color original
            btn.ForeColor = ColorTranslator.FromHtml("#284b63"); // Volver al color original del texto

        }

        private void btnBitacora_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = ColorTranslator.FromHtml("#284b63"); // Cambiar color al pasar el mouse
            btn.ForeColor = Color.White; // Cambiar color del texto
        }

        private void btnBitacora_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White; // Volver al color original
            btn.ForeColor = ColorTranslator.FromHtml("#284b63"); // Volver al color original del texto
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
