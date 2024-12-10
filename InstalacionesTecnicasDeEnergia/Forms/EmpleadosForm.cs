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

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class EmpleadosForm : Form
    {
        public EmpleadosForm()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            bool validacion = false;

            if (validacion == false)
            {
                if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
                {
                    MessageBox.Show("El campo 'Nombres' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Nombre.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_Apellido.Text))
                {
                    MessageBox.Show("El campo 'Apellidos' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Apellido.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_Direccion.Text))
                {
                    MessageBox.Show("El campo 'Dirección' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Direccion.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_TelefonoCelular.Text))
                {
                    MessageBox.Show("El campo 'Teléfono Celular' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TelefonoCelular.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_TelefonoCasa.Text))
                {
                    MessageBox.Show("El campo 'Teléfono de Casa' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TelefonoCasa.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_Correo.Text))
                {
                    MessageBox.Show("El campo 'Correo' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Correo.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_TipoContrato.Text))
                {
                    MessageBox.Show("El campo 'Tipo de Contrato' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TipoContrato.Focus();
                }
                // Validar DateTimePicker para que no tengan la fecha por defecto
                if (txt_FechaContratacion.Value == txt_FechaContratacion.MinDate)
                {
                    MessageBox.Show("Debe seleccionar una 'Fecha de Contratación' válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_FechaContratacion.Focus();
                }
                if (txt_FechaDespido.Value == txt_FechaDespido.MinDate)
                {
                    MessageBox.Show("Debe seleccionar una 'Fecha de Despido' válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_FechaDespido.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_Salario.Text))
                {
                    MessageBox.Show("El campo 'Salario' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Salario.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_ComentariosPersonales.Text))
                {
                    MessageBox.Show("El campo 'Comentarios Personales' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_ComentariosPersonales.Focus();
                }
                validacion = true;

            }




            if (validacion == true)
            {
                string nombres = this.txt_Nombre.Text;
                string apellidos = this.txt_Apellido.Text;
                string dui = this.txt_Dui.Text;
                string direccion = this.txt_Direccion.Text;
                string telefonoCelular = this.txt_TelefonoCelular.Text;
                string telefonoCasa = this.txt_TelefonoCasa.Text;
                string correo = this.txt_Correo.Text;
                string tipoContrato = this.txt_TipoContrato.Text;
                string fechaContratacion = this.txt_FechaContratacion.Text;
                string fechaDespido = this.txt_FechaDespido.Text;
                string salario = this.txt_Salario.Text;
                string comentariosPersonales = this.txt_ComentariosPersonales.Text;


                Empleado empleado = new Empleado();
                empleado.Nombres = nombres;
                empleado.Apellidos = apellidos;
                empleado.Dui = dui;
                empleado.Direccion = direccion;
                empleado.TelefonoCelular = telefonoCelular;
                empleado.TelefonoCasa = telefonoCasa;
                empleado.Correo = correo;
                empleado.TipoContrato = tipoContrato;
                empleado.FechaContratacion = fechaContratacion;
                empleado.FechaDespido = fechaDespido;
                empleado.Salario = salario;
                empleado.ComentariosPersonales = comentariosPersonales;


                try
                {
                    Conexion conexion = new Conexion();
                    conexion.EmpleadoDb.InsertOne(empleado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" +  ex);
                }



            }

        }
    }
}
