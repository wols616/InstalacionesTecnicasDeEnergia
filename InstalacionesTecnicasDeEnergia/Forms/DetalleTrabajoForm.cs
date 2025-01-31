using InstalacionesTecnicasDeEnergia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class DetalleTrabajoForm : Form
    {
        Conexion conexion = new Conexion();
        public DetalleTrabajoForm()
        {
            InitializeComponent();
            //Ancho de la pantalla
            int widthDisplay = (int)(Screen.PrimaryScreen.Bounds.Width * 0.40);
            int heighDisplay = (int)(Screen.PrimaryScreen.Bounds.Height * 0.60);

            //Ajustar el formulario para ocupar un porcentaje de la pantalla
            this.Width = widthDisplay;
            this.Height = heighDisplay;

            //Centrarlo
            this.StartPosition = FormStartPosition.CenterScreen;

            //Adaptar el panel a todo el ancho
            this.panel1.Width = Width;
            this.label1.Left = (Width - label1.Width) - 20;

            //Adaptar a todo el ancho del datagridview
            this.TablaManoObra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaEncargados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void CargarTablas()
        {
            List<Trabajo> ListaTrabajos = conexion.TrabajoDb.Find(d => true).ToList();

            List<Empleado> ListaEmpleado = conexion.EmpleadoDb.Find(d => true).ToList();
            List<TipoContrato_Empleado_> ListaTipoEmpleado = conexion.TipoEmpleadoDb.Find(d => true).ToList();

            List<ManoObra> ListaManoObra = conexion.ManoObraDb.Find(d => true).ToList();
            List<CategoriaManoObra> ListaCategoriaManoObra = conexion.CategoriaManoObraDb.Find(d => true).ToList();

            List<Material> ListaMateriales = conexion.MaterialDb.Find(d => true).ToList();
            List<CategoriaMaterial> ListaCategoriaMaterial = conexion.CategoriaMaterialDb.Find(d => true).ToList();

         //   List<MaterialUsado> ListaMaterialUsado = conexion.MaterialDb.Find(d => true).ToList();

            var Encargados = ListaEmpleado.Select(e => new
            { 
                e.Nombres,
                e.Apellidos,
                e.Dui,
                e.TelefonoCelular, 
                e.TelefonoCasa,
                TipoContrato = ListaTipoEmpleado.FirstOrDefault(t => t.Id == e.TipoContrato)?.Nombre ?? "Desconocido",
                e.Salario
            }).ToList();

            var Materiales = ListaMateriales.Select(e => new
            {
                e.Nombre,
                Categoria = ListaCategoriaMaterial.FirstOrDefault(t => t.Id == e.CategoriaId)?.Nombre ?? "Desconocido",
                e.Marca,
                //Cantidad = ListaCategoriaMaterial.FirstOrDefault(t => t.Id == e.Cantidad)?.Cantidad ?? "Desconocido"

            }).ToList();

            var ManoObras = ListaManoObra.Select(e => new { 
                e.Nombre,
                e.Descripcion,
                e.Precio,
                TipoManoObra = ListaCategoriaManoObra.FirstOrDefault(t => t.Id == e.CategoriaId)?.Nombre ?? "Desconocido"
            }).ToList();

            //var Trabajos = ListaTrabajos.Select(e => new
            //{
            //    Cantidad = ListaTrabajos.FirstOrDefault(t => t.Materiales == e.cantidad

            //}).ToList();
            // Tabla.DataSource = empleadosConTipoContrato;

            TablaEncargados.DataSource = Encargados;
            TablaMateriales.DataSource = Materiales;
            TablaManoObra.DataSource = ManoObras;            
        }

        private void DetalleTrabajoForm_Load(object sender, EventArgs e)
        {
            CargarTablas();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            TrabajosPendientesForm form = new TrabajosPendientesForm();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
