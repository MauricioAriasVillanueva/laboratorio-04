using System;

string[] nombres = { "Erick", "Mauricio", "Aylin", "Massiel" };

//MOSTRAR
Console.WriteLine("NOMBRES ORIGINALES");

foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}

//ORDENAR
Array.Sort(nombres);

//RESULTADO
Console.WriteLine("\nNOMBRES ORDENADOS ALFABETICAMENTE");

foreach (string nombre in nombres)
{
    System.Console.WriteLine(nombre);
}