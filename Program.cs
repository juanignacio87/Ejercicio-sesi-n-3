using System.Threading.Channels;

namespace Estructura_de_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(/*Inserte aquí los datos del cliente, cada uno entre comillas, separados por una coma*/);

            Console.WriteLine(cliente);
        }
    }

    public struct Cliente
    {
        public string nombreCompleto, telefono, direccion;
        public string? email;
        public bool clienteNuevo;

        public Cliente(string nombreCompleto, string telefono, string direccion, string? email, bool clienteNuevo)
        {
            this.telefono = telefono;

            this.nombreCompleto = nombreCompleto;

            this.direccion = direccion;

            this.email = email;

            this.clienteNuevo = clienteNuevo;
        }

        public override string ToString()
        {
            return string.Format(" Nombre completo: " + nombreCompleto + "\nTeléfono: " + telefono + "\nDirección: " + direccion + "\nEmail: " + email + "\nCliente nuevo: " + clienteNuevo);
        }
    }

}