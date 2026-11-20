using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NCategorias
    {
        public static DataTable ListaCategorias()
        {
            return new DCategorias().ListaCategorias();
        }

        public static DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            if (parNumeroPagina < 1) parNumeroPagina = 1;
            if (parRegistrosPorPagina < 1) parRegistrosPorPagina = 10;
            return new DCategorias().Mostrar(parNumeroPagina, parRegistrosPorPagina);
        }

        public static int Tamaño(int parRegistrosPorPagina)
        {
            if (parRegistrosPorPagina < 1) parRegistrosPorPagina = 10;
            return new DCategorias().Tamaño(parRegistrosPorPagina);
        }

        public static DataTable Buscar(string parNombre_Buscado)
        {
            DCategorias categorias = new DCategorias();
            categorias.Nombre_Buscado = (parNombre_Buscado ?? string.Empty).Trim();
            return categorias.Buscar(categorias);
        }

        public static string Eliminar(int parId_Categoria)
        {
            if (parId_Categoria <= 0)
            {
                return "El identificador de categoría debe ser mayor que cero.";
            }

            DCategorias categorias = new DCategorias();
            categorias.Id_Categoria = parId_Categoria;
            return categorias.Eliminar(categorias);
        }

        public static string Insertar(string parNombre_Categoria, string parDescripcion)
        {
            string nombre = (parNombre_Categoria ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                return "El nombre de la categoría es obligatorio.";
            }

            DCategorias categorias = new DCategorias();
            categorias.Nombre_Categoria = nombre;
            categorias.Descripcion = (parDescripcion ?? string.Empty).Trim();
            return categorias.Insertar(categorias);
        }

        public static string Editar(int parId_Categoria, string parNombre_Categoria, string parDescripcion)
        {
            if (parId_Categoria <= 0)
            {
                return "El identificador de categoría debe ser mayor que cero.";
            }

            string nombre = (parNombre_Categoria ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                return "El nombre de la categoría es obligatorio.";
            }

            DCategorias categorias = new DCategorias();
            categorias.Id_Categoria = parId_Categoria;
            categorias.Nombre_Categoria = nombre;
            categorias.Descripcion = (parDescripcion ?? string.Empty).Trim();
            return categorias.Editar(categorias);
        }
    }
}
