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
using System.Security.Cryptography.X509Certificates;

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class DetalleTrabajoForm : Form
    {
        Conexion conexion = new Conexion();
        public string IdSeleccionado;
        public bool procedencia;


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

            Trabajo trabajo = conexion.TrabajoDb.Find(d => d.Id == IdSeleccionado).FirstOrDefault();

            List<string> encargadosIds = trabajo.Encargados.Select(e => e.EmpleadoId).ToList();
            List<Empleado> encargados = conexion.EmpleadoDb.Find(e => encargadosIds.Contains(e.Id))
                .ToList();

            List<TipoContrato_Empleado_> ListaTipoEmpleado = conexion.TipoEmpleadoDb.Find(d => true).ToList();
            List<CategoriaManoObra> ListaCategoriaManoObra = conexion.CategoriaManoObraDb.Find(d => true).ToList();
            List<CategoriaMaterial> ListaCategoriaMaterial = conexion.CategoriaMaterialDb.Find(d => true).ToList();


            List<string> manosObrasIds = trabajo.ManoObra.Select(e => e.ManoObraId).ToList();
            List<ManoObra> manosObras = conexion.ManoObraDb.Find(e => manosObrasIds.Contains(e.Id)).ToList();

            List<string> materialesIds = trabajo.Materiales.Select(e => e.MaterialId).ToList();
            List<Material> materiales = conexion.MaterialDb.Find(e => materialesIds.Contains(e.Id)).ToList();

            var Encargados = encargados.Select(e => new
            {
                e.Nombres,
                e.Apellidos,
                e.Dui,
                e.TelefonoCelular,
                e.TelefonoCasa,
                TipoContrato = ListaTipoEmpleado.FirstOrDefault(t => t.Id == e.TipoContrato)?.Nombre ?? "Desconocido",
                e.Salario
            }).ToList();

            var Materiales = materiales.Select(e => new
            {
                e.Nombre,
                Categoria = ListaCategoriaMaterial.FirstOrDefault(t => t.Id == e.CategoriaId)?.Nombre ?? "Desconocido",
                e.Marca,

            }).ToList();

            var ManoObras = manosObras.Select(e => new {
                e.Nombre,
                e.Descripcion,
                e.Precio,
                TipoManoObra = ListaCategoriaManoObra.FirstOrDefault(t => t.Id == e.CategoriaId)?.Nombre ?? "Desconocido"
            }).ToList();

            TablaEncargados.DataSource = Encargados;
            TablaMateriales.DataSource = Materiales;
            TablaManoObra.DataSource = ManoObras;
        }

        private void DetalleTrabajoForm_Load(object sender, EventArgs e)
        {
            CargarTablas();
            Trabajo trabajo = conexion.TrabajoDb.Find(d => d.Id == IdSeleccionado).FirstOrDefault();
            this.txtNombreCliente.Text = trabajo.NombreCliente;
            this.txtPresupuestoTotal.Text = trabajo.Presupuesto.ToString();
            this.txtFecha.Text = trabajo.Fecha.ToString();
            this.txtDescripcion.Text = trabajo.DescripcionProyecto;
            this.txtLugar.Text = trabajo.Lugar;
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            if(procedencia == true)
            {
                TrabajosPendientesForm form = new TrabajosPendientesForm();
                form.Show();
                this.Hide();
            }
            else
            {
                TrabajosRealizadosForm form = new TrabajosRealizadosForm();
                form.Show();
                this.Hide();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
