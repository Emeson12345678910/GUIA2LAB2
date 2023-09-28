using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una cadena de caracteres que sea menos o igual a 25 gracias: ");
        string cadena = Console.ReadLine();
        Console.WriteLine("");

        if (cadena.Length < 25)
        {
            int Cadena_reyeno = 25 - cadena.Length;
            string relleno = new string('$', Cadena_reyeno);
            cadena += relleno;
        }

        Console.WriteLine($"Resultado : {cadena}");
    }
}
