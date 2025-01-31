using InstalacionesTecnicasDeEnergia.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class ControlAsistencia : Form
    {
        Conexion conexion = new Conexion();

        public ControlAsistencia()
        {
            InitializeComponent();
            tablaAsistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cargarEmpleados()
        {
            try
            {
                List<Empleado> empleados = conexion.EmpleadoDb.Find(d => true).ToList();
                cbxEmpleado.DataSource = empleados;
                cbxEmpleado.DisplayMember = "FullName";
                cbxEmpleado.ValueMember = "Id";

                List<Asistencia> asistencias = conexion.AsistenciaDb.Find(d => true).ToList();

            }
            catch { }
        }

        private void cargarAsistencias(DateTime fecha)
        {
            try
            {
                // Normaliza la fecha a la medianoche (hora 00:00:00)
                DateTime fechaInicio = fecha.Date;
                DateTime fechaFin = fecha.Date.AddDays(1); // El final de ese día es 23:59:59

                List<Empleado> empleados = conexion.EmpleadoDb.Find(d => true).ToList();

                // Busca las asistencias del día seleccionando registros entre la fecha de inicio y la fecha final
                List<Asistencia> asistencias = conexion.AsistenciaDb
                    .Find(d => d.Fecha >= fechaInicio && d.Fecha < fechaFin)
                    .ToList();

                var asistenciasFormateadas = asistencias.Select(e => new
                {
                    Nombre = empleados.FirstOrDefault(d => d.Id == e.EmpleadoId)?.Nombres,
                    Apellido = empleados.FirstOrDefault(d => d.Id == e.EmpleadoId)?.Apellidos,
                    e.Estado,
                }).ToList();

                tablaAsistencias.DataSource = asistenciasFormateadas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las asistencias: " + ex.Message);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxEmpleado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cbxAsistencia.Text))
            {
                MessageBox.Show("Seleccione un estado de asistencia.");
                return;
            }

            string estadoSeleccionado = cbxAsistencia.Text;
            string empleadoId = ((Empleado)cbxEmpleado.SelectedItem).Id;
            DateTime fechaHoy = DateTime.Now.Date; // Solo la fecha, sin la hora

            // Verificar si el empleado ya tiene un registro de asistencia hoy
            var asistenciaExistente = conexion.AsistenciaDb
                .Find(a => a.EmpleadoId == empleadoId && a.Fecha >= fechaHoy && a.Fecha < fechaHoy.AddDays(1))
                .FirstOrDefault();

            if (asistenciaExistente != null)
            {
                // Si ya existe un registro, actualizarlo con el nuevo estado
                var filter = Builders<Asistencia>.Filter.Eq(a => a.Id, asistenciaExistente.Id);
                var update = Builders<Asistencia>.Update.Set(a => a.Estado, estadoSeleccionado);

                conexion.AsistenciaDb.UpdateOne(filter, update);
                MessageBox.Show($"Asistencia actualizada con éxito a '{estadoSeleccionado}'.");
            }
            else
            {
                // Si no existe, se crea una nueva asistencia
                var nuevaAsistencia = new Asistencia
                {
                    EmpleadoId = empleadoId,
                    Fecha = DateTime.Now.Date,
                    Estado = estadoSeleccionado
                };

                conexion.AsistenciaDb.InsertOne(nuevaAsistencia);
                MessageBox.Show($"Asistencia registrada con éxito: {estadoSeleccionado}");
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ControlAsistencia_Load(object sender, EventArgs e)
        {
            cargarEmpleados();
            cargarAsistencias(DateTime.Now.Date);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cargarAsistencias(dateTimePicker1.Value);
        }
    }
}
