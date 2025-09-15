
public abstract class Persona
{
    public string Nombre { get; set; }
    public abstract string ObtenerTipo();
}

public class Usuario : Persona
{
    public int Id { get; set; }
    public string Email { get; set; }

    public Usuario(int id, string nombre, string email)
    {
        Id = id;
        Nombre = nombre;
        Email = email;
    }

    public override string ObtenerTipo() => "Usuario";
}
