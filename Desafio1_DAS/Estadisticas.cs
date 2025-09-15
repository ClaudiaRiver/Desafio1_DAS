using System.Collections.Generic;
using System.Linq;

public class Data
{
    public List<Libro> Libros = new List<Libro>();
    public List<Usuario> Usuarios = new List<Usuario>();
    public List<Prestamo> Prestamos = new List<Prestamo>();
    public Dictionary<string, int> EstadisticasLibros = new Dictionary<string, int>();
    //public string[,] MatrizSecciones = new string[5, 5]; // Ejemplo de matriz

    public void AgregarLibro(Libro libro) => Libros.Add(libro);
    public void AgregarUsuario(Usuario usuario) => Usuarios.Add(usuario);

    public void RegistrarPrestamo(int usuarioId, string isbn)
    {
        var usuario = Usuarios.FirstOrDefault(u => u.Id == usuarioId);
        var libro = Libros.FirstOrDefault(l => l.Id == isbn);
    }

    public void DevolverPrestamo(int prestamoId)
    {
        var prestamo = Prestamos.FirstOrDefault(p => p.Id == prestamoId && p.FechaDevolucion == null);
        prestamo?.Devolver();
    }
}
