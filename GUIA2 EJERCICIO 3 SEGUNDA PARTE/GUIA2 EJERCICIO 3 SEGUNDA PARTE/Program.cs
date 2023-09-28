using System;

class Split
{
    public static void Main(string[] args)
    {
        string frase = "MI MAMA ME MIMA, AMO A MI MAMA";
        string[] MAMA= frase.Split(' ');

        foreach (string palabra in MAMA)
        {
            Console.WriteLine(palabra);
        }
    }
}