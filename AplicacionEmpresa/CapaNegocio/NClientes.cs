using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NClientes
    {
        public static DataTable ListaClientes()
        {
            return new DClientes().ListaClientes();
        }

        public static DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            if (parNumeroPagina < 1) parNumeroPagina = 1;
            if (parRegistrosPorPagina < 1) parRegistrosPorPagina = 10;
            return new DClientes().Mostrar(parNumeroPagina, parRegistrosPorPagina);
        }

        public static int Tamaño(int parRegistrosPorPagina)
        {
            if (parRegistrosPorPagina < 1) parRegistrosPorPagina = 10;
            return new DClientes().Tamaño(parRegistrosPorPagina);
        }

        public static DataTable Buscar(string parNombre_Cliente_Buscado)
        {
            DClientes clientes = new DClientes();
            clientes.Nombre_Cliente_Buscado = (parNombre_Cliente_Buscado ?? string.Empty).Trim();
            return clientes.Buscar(clientes);
        }

        public static string Eliminar(int parId_Cliente)
        {
            if (parId_Cliente <= 0)
            {
                return "El identificador del cliente debe ser mayor que cero.";
            }

            DClientes clientes = new DClientes();
            clientes.Id_Cliente = parId_Cliente;
            return clientes.Eliminar(clientes);
        }

        private static bool IsValidEmailOrEmpty(string email)
        {
            string trimmed = (email ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(trimmed))
            {
                return true;
            }
            int at = trimmed.IndexOf('@');
            int dot = trimmed.LastIndexOf('.');
            return at > 0 && dot > at + 1 && dot < trimmed.Length - 1;
        }

        public static string Insertar(string parNombre_Cliente, string parNombre_Contacto,
            string parDireccion, string parCiudad, string parRegion, string parPais,
            string parTelefono, string parFax, string parEmail)
        {
            string nombre = (parNombre_Cliente ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                return "El nombre del cliente es obligatorio.";
            }
            if (!IsValidEmailOrEmpty(parEmail))
            {
                return "El formato del correo electrónico no es válido.";
            }

            DClientes clientes = new DClientes();
            clientes.Nombre_Cliente = nombre;
            clientes.Nombre_Contacto = (parNombre_Contacto ?? string.Empty).Trim();
            clientes.Direccion = (parDireccion ?? string.Empty).Trim();
            clientes.Ciudad = (parCiudad ?? string.Empty).Trim();
            clientes.Region = (parRegion ?? string.Empty).Trim();
            clientes.Pais = (parPais ?? string.Empty).Trim();
            clientes.Telefono = (parTelefono ?? string.Empty).Trim();
            clientes.Fax = (parFax ?? string.Empty).Trim();
            clientes.Email = (parEmail ?? string.Empty).Trim();

            return clientes.Insertar(clientes);
        }

        public static string Editar(int parId_Cliente, string parNombre_Cliente, string parNombre_Contacto,
            string parDireccion, string parCiudad, string parRegion, string parPais,
            string parTelefono, string parFax, string parEmail)
        {
            if (parId_Cliente <= 0)
            {
                return "El identificador del cliente debe ser mayor que cero.";
            }
            string nombre = (parNombre_Cliente ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                return "El nombre del cliente es obligatorio.";
            }
            if (!IsValidEmailOrEmpty(parEmail))
            {
                return "El formato del correo electrónico no es válido.";
            }

            DClientes clientes = new DClientes();
            clientes.Id_Cliente = parId_Cliente;
            clientes.Nombre_Cliente = nombre;
            clientes.Nombre_Contacto = (parNombre_Contacto ?? string.Empty).Trim();
            clientes.Direccion = (parDireccion ?? string.Empty).Trim();
            clientes.Ciudad = (parCiudad ?? string.Empty).Trim();
            clientes.Region = (parRegion ?? string.Empty).Trim();
            clientes.Pais = (parPais ?? string.Empty).Trim();
            clientes.Telefono = (parTelefono ?? string.Empty).Trim();
            clientes.Fax = (parFax ?? string.Empty).Trim();
            clientes.Email = (parEmail ?? string.Empty).Trim();

            return clientes.Editar(clientes);
        }
    }
}
