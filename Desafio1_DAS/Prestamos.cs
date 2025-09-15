﻿using System;

public class Prestamo
{
    public int Id { get; set; }
    public Usuario Usuario { get; set; }
    public Libro Libro { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime? FechaDevolucion { get; set; }

    public Prestamo(int id, Usuario usuario, Libro libro)
    {
        Id = id;
        Usuario = usuario;
        Libro = libro;
        FechaPrestamo = DateTime.Now;
        FechaDevolucion = null;
    }

    public void Devolver()
    {
        FechaDevolucion = DateTime.Now;
    }
}