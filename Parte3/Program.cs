using System;
using System.Collections.Generic;

List<Usuario> usuarios = new List<Usuario>
{
    new Usuario ("Erick", "erick@ejemplo.com", "Lima"),
    new Usuario ("Mauricio", "mauricio@ejemplo.com", "Lima"),
    new Usuario ("Aylin", "aylin@ejemplo.com", "Seúl"),
    new Usuario ("Massiel", "massiel@ejemplo.com", "Arequipa")
};

Console.WriteLine("LISTA DE USUARIOS");

foreach (var usuario in usuarios)
{
    Console.WriteLine($"Nombre: {usuario.Nombre}, Email: {usuario.Email}, Ciudad: {usuario.Ciudad}");
}

Console.WriteLine("Ingrese la ciudad a buscar: ");
string ciudad = Console.ReadLine();

bool encontrado = false;

foreach (var usuario in usuarios)
{
    if (usuario.Ciudad.Equals(ciudad.Trim(), StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Usuario encontrado: {usuario.Nombre} tiene el email {usuario.Email} y vive en {usuario.Ciudad}");
        encontrado = true;
    }
}

if (!encontrado)
{
    Console.WriteLine("Usuario no encontrado.");
}

class Usuario
{
    public string Nombre;
    public string Email;
    public string Ciudad;

    public Usuario(string nombre, string email, string ciudad)
    {
        Nombre = nombre;
        Email = email;
        Ciudad = ciudad;
    }
}


