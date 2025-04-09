using System; 
public class Calculadora

{
    public static void Ejecutar()
    {
        Console.WriteLine("Por favor introduce el primer operando:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Por favor introduce el segundo operando:");
        double y = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine(@"Por favor introduce:
        Para Sumar: +
        Para restar: -
        Para multiplicar: *
        Para dividir: /
        Para calcular el resto: %" );

        string entrada = Console.ReadLine();
        double resultado;

         switch (entrada)
        {
            case "+":
                resultado = x + y;
                Console.WriteLine($"El resultado de la suma es: {resultado}");
                break;

            case "-":
                resultado = x - y;
                Console.WriteLine($"El resultado de la resta es: {resultado}");
                break;

            case "*":
                resultado = x * y;
                Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                break;

            case "/":
                if (y != 0)
                {
                    resultado = x / y;
                    Console.WriteLine($"El resultado de la división es: {resultado}");
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero.");
                }
                break;

            case "%":
                resultado = x % y;
                Console.WriteLine($"El resto de la división es: {resultado}");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }


        
    }
}