
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la primera cadena:");
        string cadena1 = Console.ReadLine();

        Console.WriteLine("Ingrese la segunda cadena:");
        string cadena2 = Console.ReadLine();

    
        int resultado = cadena1.CompareTo(cadena2);

        if (resultado == 0)
        {
            Console.WriteLine("Las cadenas son iguales según C");
        }
        else if (resultado < 0)
        {
            Console.WriteLine("La primera cadena es menor que la segunda ");
        }
        else
        {
            Console.WriteLine("No son  iguales ");
        }

       
    }
}




