using System;

class Program
{
    static void Main()
    {
        string frase = "MI MAMA ME MIMA, AMO A MI MAMA";
        string[] MAMA = frase.Split(' ');

        for (int i = 0; i < MAMA.Length; i++)
        {
            if (MAMA[i].Length < 3)
            {
                MAMA[i] += "%";
            }
        }

        string resultado = string.Join(" ", MAMA);
        Console.WriteLine(resultado);
    }
}
