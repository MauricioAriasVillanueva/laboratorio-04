using System;

string[] nombres = { "Erick", "Mauricio", "Aylin", "Massiel" };
int[] edades = { 20, 20, 20, 19 };

Console.WriteLine("LISTA DE PERSONAS");

// MOSTRAR PERSONAS
for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine(nombres[i] + " - " + edades[i] + " años");
}
//BUSCAR PERSONA
Console.WriteLine("Ingrese el nombre de la persona a buscar: ");
string busqueda = Console.ReadLine();

bool encontrado = false;

for (int i = 0; i < nombres.Length; i++)
{
    if (nombres[i].Equals(busqueda.Trim(), StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Persona encontrada: " + nombres[i] + " tiene " + edades[i] + " años");
        encontrado = true;
        break;
    }
}


if (!encontrado)
{
    Console.WriteLine("Persona no encontrada.");
}