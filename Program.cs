using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Ejecutar Saludo HolaMundo");
            Console.WriteLine("2. Ejecutar Saludo En 2 Lineas");
            Console.WriteLine("3. Ejecuta Leer Entrada");
            Console.WriteLine("4. Ejecuta Almacenar Usuario");
            Console.WriteLine("5. Ejecuta Calcular dimensiones esfera");
            Console.WriteLine("6. Ejecuta Calculadora");
            Console.WriteLine("7. Ejecuta Caracteres al revés");
            Console.WriteLine("8. Ejecuta Tabla Multiplicar");
            Console.WriteLine("9. Ejecuta Número Aleatorio");
            Console.WriteLine("0. Salir");
            Console.Write("Selecciona una opción: ");
            
            // Leer opción y convertirla a entero
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }

            switch (opcion)
            {
                case 1:
                    HolaMundo.Ejecutar();
                    break;
                
                case 2: 
                    Saludo_2_Lineas.Ejecutar();
                    break;
                
                case 3:
                    Leer_Entrada.Ejecutar();
                    break;
                
                case 4:
                    Almacenar_Usuario.Ejecutar();
                    break;
                
                case 5:
                    Dimensiones_Esfera.Ejecutar();
                    break;
                
                case 6: 
                    Calculadora.Ejecutar();
                    break;
                
                case 7:
                    Caracteres_Al_Reves.Ejecutar();
                    break;
                
                case 8:
                    Tabla_Multiplicar.Ejecutar();
                    break;
                
                case 9:
                    Numero_Azar.Ejecutar();
                    break;
                
                
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresiona ENTER para continuar...");
                Console.ReadLine();
            }

        } while (opcion != 0);
    }
}
