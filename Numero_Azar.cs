public class Numero_Azar
{
    public static void Ejecutar()
    {
        Console.WriteLine("Introduce el límite inferior:");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce el límite superior:");
        int n2 = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int numero_azar = rnd.Next(n1, n2 + 1);
        Console.WriteLine($"Número aleatorio entre {n1} y {n2}: {numero_azar}");
    }
}