using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wdLibreria
{
    class ClsUsuario
    {
        private string nombre, cedula, apellido, direccion, email, sexo, nombrelibro, telefono, libro;
        private double valorlibro, iva, valorpagar;
        private int edad;

        public string Libro
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string NombreLibro
        {
            get { return nombrelibro; }
            set { nombrelibro = value;}
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public double ValorLibro
        {
            get { return valorlibro; }
            set { valorlibro = value; }
        }
        public double IVA
        {
            get { return iva; }
            set { iva = value; }
        }
        public double ValorPagar
        {
            get { return valorpagar; }
            set { valorpagar = value;}
        }
    }
}
