

public class Libro
{
    public string Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Año { get; set; }

    public Libro(string id, string titulo, string autor, string año)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        Año = año;
    }

    public override string ToString() => $"{Titulo} ({Autor})";
}