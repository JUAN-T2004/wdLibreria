using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Autores: Juan Manuel Torres Maguirre, Jose Julian Berrio Arroyave, Zlatan David Ramos Calzada
/// Fecha: Miercoles 27 - abril / 2022
/// Descripcion: Formulario de servicio de una libreria
/// </summary>
namespace wdLibreria
{
    public partial class FrmHijo : Form
    {
        public FrmHijo()
        {
            InitializeComponent();

            cmbSexo.Items.Add("femenino");
            cmbSexo.Items.Add("masculino");
            cmbSexo.Items.Add("lgbti");
            cmbNombreLibro.Items.Add("Doce de octubre");
            cmbNombreLibro.Items.Add("Kamasutra ");
            cmbNombreLibro.Items.Add("la cuadra ");
            cmbNombreLibro.Items.Add("Fuck putin ");
            cmbNombreLibro.Items.Add("Elon musk ");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Realmente deseas salir?", "confirmar",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
            txtEdad.Text = "";
            txtEmail.Text = "";
            txtIVA.Text = "";
            txtTelefono.Text = "";
            txtValorPagar.Text = "";
            txtValorLibro.Text = "";


            cmbNombreLibro.Text = "";
            cmbSexo.Text = "";

            rdoPrestamo.Checked = false;
            rdoVenta.Checked = false;
            grpValor.Enabled = true;
        }

        private void rdoPrestamo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPrestamo.Checked == true)
            {
                grpValor.Enabled = false;
                txtValorLibro.Text = "";
                txtIVA.Text = "";
                txtValorPagar.Text = "";
            }
            else
            {
                if (rdoVenta.Checked == true)
                {
                    grpValor.Enabled = true;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var ClsUsuario = new ClsUsuario();
            ClsUsuario.ValorLibro = Convert.ToDouble(txtValorLibro.Text);
            ClsUsuario.IVA = (ClsUsuario.ValorLibro * 19) / 100;
            Double Resultado = ClsUsuario.ValorLibro + ClsUsuario.IVA;

            txtIVA.Text = Convert.ToString(ClsUsuario.IVA);
            txtValorPagar.Text = Convert.ToString(Resultado);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var ClsUsuario = new ClsUsuario();

            ClsUsuario.Nombre = txtNombre.Text;
            ClsUsuario.Apellido = txtApellido.Text;
            ClsUsuario.Direccion = txtDireccion.Text;
            ClsUsuario.Email = txtEmail.Text;
            ClsUsuario.Telefono = txtTelefono.Text;
            ClsUsuario.Cedula = txtCedula.Text;
            ClsUsuario.Edad = Convert.ToInt16(txtEdad.Text);
            ClsUsuario.Libro = cmbNombreLibro.Text;
           

            if (rdoVenta.Checked == true)
            {
                ClsUsuario.ValorLibro = Convert.ToDouble(txtValorLibro.Text);
                ClsUsuario.IVA = Convert.ToDouble(txtIVA.Text);
                ClsUsuario.ValorPagar = Convert.ToDouble(txtValorPagar.Text);
                MessageBox.Show($"Recibo de venta \r\r\r Datos Personales \r\r Nombre: {ClsUsuario.Nombre} \r Apellido: {ClsUsuario.Apellido}\r Cedula: {ClsUsuario.Cedula} \r Edad: {ClsUsuario.Edad} \r Direccion: {ClsUsuario.Direccion} \r Telefono: {ClsUsuario.Telefono} \r Email:{ClsUsuario.Email}\r\r\r" +
                    $" Articulo Vendido:\r Nombre del libro: {ClsUsuario.Libro}\r Valor del libro: {ClsUsuario.ValorLibro} \r IVA: {ClsUsuario.IVA} \r Valor total a pagar: {ClsUsuario.ValorPagar} \r\r\r Feliz día...");
            }
            if (rdoPrestamo.Checked == true)
            {
                MessageBox.Show($"Prestamo de libro \r\r\r Datos Personales \r\r Nombre: {ClsUsuario.Nombre} \r Apellido: {ClsUsuario.Apellido}\r Cedula: {ClsUsuario.Cedula} \r Edad: {ClsUsuario.Edad} \r Direccion: {ClsUsuario.Direccion} \r Telefono: {ClsUsuario.Telefono} \r Email: {ClsUsuario.Email}\r\r\r" +
                    $" Articulo Prestado:\r Nombre del libro: {ClsUsuario.Libro}\r El libro será prestado por 15 días \r\r\r Feliz día...");
            }
        }
    }
}
