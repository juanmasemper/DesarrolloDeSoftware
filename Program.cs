// Trabajo Practico N°1

namespace Menu 
{
    class Programa
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("*** Bienvenid@ ***");
                Console.WriteLine("");
                Console.WriteLine("1. Realizar una operación matemática");
                Console.WriteLine("2. Realizar una operación lógica");
                Console.WriteLine("3. Realizar una operación de cadenas de caracteres");
                Console.WriteLine("4. Salir");
                Console.WriteLine("");
                Console.WriteLine("Elija una opción: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        RealizarOperacionesMatemáticas();
                        break;
                    case 2:
                        RealizarOperacionesLógicas();
                        break;
                    case 3:
                        RealizarOperacionesDeCadenas();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opcion no válida. Intente nuevamente.");
                        break;
                }
            }
        }

        
        static void RealizarOperacionesMatemáticas()
        {
            Console.WriteLine("");
            Console.WriteLine("Calculadora de operaciones matemáticas");
            Console.WriteLine("");
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Operaciones:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Elija una opción:");

            int choice = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (choice)
            {
                case 1:
                    resultado = num1 + num2; // SUMA
                    break;
                case 2:
                    resultado = num1 - num2; // RESTA
                    break;
                case 3:
                    resultado = num1 * num2;  // MULTIPLICACIÓN
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;  // DIVISIÓN
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                        return;
                    }
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            Console.WriteLine($"El resultado es: {resultado}");
        }

        static void RealizarOperacionesLógicas()
        {
            Console.WriteLine("");
            Console.WriteLine("Calculadora de operaciones lógicas");
            Console.WriteLine("");
            Console.Write("Ingrese el primer valor (true/false): ");
            bool valor1 = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Ingrese el segundo valor (true/false): ");
            bool valor2 = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Operacionens:");
            Console.WriteLine("1. AND");
            Console.WriteLine("2. OR");
            Console.WriteLine("3. NOT");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Elija una opción:");

            int choice = Convert.ToInt32(Console.ReadLine());

            bool resultado = false;

            switch (choice)
            {
                case 1:
                    resultado = valor1 && valor2; // Operación AND
                    break;
                case 2:
                    resultado = valor1 || valor2; // Operación OR
                    break;
                case 3:
                    resultado = !valor1; // Operación NOT
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            Console.WriteLine($"El resultado es: {resultado}");

        }

        static void RealizarOperacionesDeCadenas()
        {
            Console.WriteLine("");
            Console.WriteLine("Calculadora de operaciones de cadenas de caracteres");
            Console.WriteLine("");
            Console.Write("Ingrese la primera cadena: ");
            string cadena1 = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Ingrese la segunda cadena: ");
            string cadena2 = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Operaciones:");
            Console.WriteLine("1. Concatenar");
            Console.WriteLine("2. Obtener longitud");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Elija una opción:");

            int choice = Convert.ToInt32(Console.ReadLine());

            string resultado = "";

            switch (choice)
            {
                case 1:
                    resultado = cadena1 + cadena2; // Concatenación
                    break;
                case 2:
                    int longitudCadena1 = cadena1.Length;
                    int longitudCadena2 = cadena2.Length;
                    resultado = $"Longitud de cadena 1: {longitudCadena1}, Longitud de cadena 2: {longitudCadena2}";
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            Console.WriteLine($"El resultado es: {resultado}");
        }

    }
}