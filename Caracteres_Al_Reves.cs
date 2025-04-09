public class Caracteres_Al_Reves
{
    public static void Ejecutar()
    {   
        Console.WriteLine("Por favor introduce el primer caracter:");
        char a = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Por favor introduce el segundo caracter:");
        char b = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Por favor introduce el tercer caracter:");
        char c = Convert.ToChar(Console.ReadLine());
        Console.WriteLine($"Los caracteres al revés son: {c}{b}{a}");

    }
     
}