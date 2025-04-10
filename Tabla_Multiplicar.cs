class Tabla_Multiplicar
{
    public static void Ejecutar()
    {
        Console.WriteLine("Introduce un número para mostrar su tabla de multiplicar:");
        int x = Convert.ToInt32(Console.ReadLine());

        for (int i=0; i<=10; i++)
        {
            Console.WriteLine($"{x} x {i} = {x*i}");
        }
    }
}