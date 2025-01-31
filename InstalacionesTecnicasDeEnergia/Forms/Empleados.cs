using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstalacionesTecnicasDeEnergia.Models;
using MongoDB.Driver;

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Empleados_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
     
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                MessageBox.Show("El campo 'Nombres' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nombre.Focus();
            }
            if (string.IsNullOrWhiteSpace(txt_Apellidos.Text))
            {
                MessageBox.Show("El campo 'Apellidos' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Apellidos.Focus();
            }
            if (string.IsNullOrWhiteSpace(txt_Direccion.Text))
            {
                MessageBox.Show("El campo 'Dirección' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Direccion.Focus();
            }
            if (string.IsNullOrWhiteSpace(txt_telefonoCelular.Text))
            {
                MessageBox.Show("El campo 'Teléfono Celular' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_telefonoCelular.Focus();
            }
            if (string.IsNullOrWhiteSpace(txt_telefonoCasa.Text))
            {
                MessageBox.Show("El campo 'Teléfono de Casa' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_telefonoCasa.Focus();
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


            string nombres = this.txt_Nombre.Text;
            string apellidos = this.txt_Apellidos.Text;
            string dui = this.txt_Apellidos.Text;
            string direccion = this.txt_Direccion.Text;
            string telefonoCelular = this.txt_telefonoCelular.Text;
            string telefonoCasa = this.txt_telefonoCasa.Text;
            string correo = this.txt_Correo.Text;
            string tipoContrato = this.txt_TipoContrato.Text;
            string fechaContratacion = this.txt_FechaContratacion.Text;
            string fechaDespido = this.txt_FechaDespido.Text;
            string salario = this.txt_Salario.Text;
            string comentariosPersonales = this.txt_ComentariosPersonales.Text;


            Empleado empleado = new Empleado(nombres, apellidos, dui, direccion, telefonoCelular, telefonoCasa, correo,);
        }
    }
}
