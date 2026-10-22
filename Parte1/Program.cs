using System;

string texto = "Existio por 17 años y solo vivio por 50 dias";

Console.WriteLine("Texto original: " + texto);

// Extraer
string subcadena = texto.Substring(15, 4);
Console.WriteLine("Subcadena: " + subcadena);

//Buscar
int posicion = texto.IndexOf("vivio");
Console.WriteLine("Posición de 'vivio': " + posicion);

// Reemplazar
string Reemplazado = texto.Replace("50", "55");
Console.WriteLine("Texto reemplazado: " + Reemplazado);

// Separar
string[] palabras = texto.Split(' ');

Console.WriteLine("Palabras separadas:");
foreach (string palabra in palabras)
{
    Console.WriteLine(palabra);
}
