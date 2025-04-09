public class Dimensiones_Esfera
{
    public static void Ejecutar()
    {
        Console.WriteLine("Introduce el radio de la esfera:");
        double radio = Convert.ToSingle(Console.ReadLine());
        const double PI = 3.1416;

        double superficie = 4 * PI * (radio * radio);
        double volumen  = 4/3 * PI * (radio * radio * radio);

        Console.WriteLine($"La superficie de la esfera es = {superficie}");
        Console.WriteLine($"El volumen de la esfera es = {volumen}");
    }
}