using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NProductos
    {
        public static DataTable ListaProductos()
        {
            return new DProductos().ListaProductos();
        }

        public static decimal PrecioProducto(int parIdProducto)
        {
            if (parIdProducto <= 0)
            {
                return 0m;
            }
            return new DProductos().PrecioProducto(parIdProducto);
        }

        public static DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            if (parNumeroPagina < 1) parNumeroPagina = 1;
            if (parRegistrosPorPagina < 1) parRegistrosPorPagina = 10;
            return new DProductos().Mostrar(parNumeroPagina, parRegistrosPorPagina);
        }

        public static int Tamaño(int parRegistrosPorPagina)
        {
            if (parRegistrosPorPagina < 1) parRegistrosPorPagina = 10;
            return new DProductos().Tamaño(parRegistrosPorPagina);
        }

        public static DataTable Buscar(string parNombre_Buscado)
        {
            DProductos productos = new DProductos();
            productos.Nombre_Buscado = (parNombre_Buscado ?? string.Empty).Trim();
            return productos.Buscar(productos);
        }

        public static string Eliminar(int parId_Producto)
        {
            if (parId_Producto <= 0)
            {
                return "El identificador del producto debe ser mayor que cero.";
            }

            DProductos productos = new DProductos();
            productos.Id_Producto = parId_Producto;
            return productos.Eliminar(productos);
        }

        public static string Insertar(string parNombre_Producto, string parNombre_Categoria,
            decimal parPrecio_Unitario, string parDetalles)
        {
            string nombre = (parNombre_Producto ?? string.Empty).Trim();
            string categoria = (parNombre_Categoria ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                return "El nombre del producto es obligatorio.";
            }
            if (string.IsNullOrEmpty(categoria))
            {
                return "La categoría del producto es obligatoria.";
            }
            if (parPrecio_Unitario < 0m)
            {
                return "El precio unitario no puede ser negativo.";
            }

            DProductos productos = new DProductos();
            productos.Nombre_Producto = nombre;
            productos.Nombre_Categoria = categoria;
            productos.Precio_Unitario = parPrecio_Unitario;
            productos.Detalles = (parDetalles ?? string.Empty).Trim();
            return productos.Insertar(productos);
        }

        public static string Editar(int parId_Producto, string parNombre_Producto,
            string parNombre_Categoria, decimal parPrecio_Unitario, string parDetalles)
        {
            if (parId_Producto <= 0)
            {
                return "El identificador del producto debe ser mayor que cero.";
            }

            string nombre = (parNombre_Producto ?? string.Empty).Trim();
            string categoria = (parNombre_Categoria ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                return "El nombre del producto es obligatorio.";
            }
            if (string.IsNullOrEmpty(categoria))
            {
                return "La categoría del producto es obligatoria.";
            }
            if (parPrecio_Unitario < 0m)
            {
                return "El precio unitario no puede ser negativo.";
            }

            DProductos productos = new DProductos();
            productos.Id_Producto = parId_Producto;
            productos.Nombre_Producto = nombre;
            productos.Nombre_Categoria = categoria;
            productos.Precio_Unitario = parPrecio_Unitario;
            productos.Detalles = (parDetalles ?? string.Empty).Trim();
            return productos.Editar(productos);
        }
    }
}
