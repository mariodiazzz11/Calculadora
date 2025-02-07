using System;

class Program
{
    // Métodos para las operaciones
    static double Sumar(double a, double b)
    {
        return a + b;
    }

    static double Restar(double a, double b)
    {
        return a - b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    static double Dividir(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return double.NaN; // Valor NaN para indicar error de división
        }
    }

    static void Main()
    {
        Console.WriteLine("Bienvenido al Calculador en C#");

        while (true)
        {
            // Mostrar el menú de opciones
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");

            // Pedir la opción al usuario
            Console.Write("Elige una opción (1/2/3/4/5): ");
            string opcion = Console.ReadLine();

            if (opcion == "5")
            {
                Console.WriteLine("¡Hasta luego!");
                break;
            }

            // Pedir los números al usuario
            double num1, num2;

            Console.Write("Introduce el primer número: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }

            Console.Write("Introduce el segundo número: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }

            // Realizar la operación seleccionada
            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"{num1} + {num2} = {Sumar(num1, num2)}");
                    break;
                case "2":
                    Console.WriteLine($"{num1} - {num2} = {Restar(num1, num2)}");
                    break;
                case "3":
                    Console.WriteLine($"{num1} * {num2} = {Multiplicar(num1, num2)}");
                    break;
                case "4":
                    Console.WriteLine($"{num1} / {num2} = {Dividir(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elige una opción entre 1 y 5.");
                    break;
            }
        }
    }
}
//Espero que te guste mi proyecto
