namespace CalculadoraConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool accesoPermitido = false;
            while (!accesoPermitido)
            {
                Console.Write("Ingrese su contraseña numérica: ");
                int contrasena = Convert.ToInt32(Console.ReadLine());
                if (contrasena == 1111)
                {
                    accesoPermitido = true;
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta. Inténtelo de nuevo.");
                }

                Console.WriteLine("Contraseña correcta. Acceso permitido.");
                Console.WriteLine("Ingrese su nombre");
                string nombre = Console.ReadLine();
                bool continuar = true;

                while (continuar)
                {
                    Console.WriteLine($"Hola, {nombre}, selecciona una operación:");
                    Console.WriteLine("1. Suma");
                    Console.WriteLine("2. Resta");
                    Console.WriteLine("3. Multiplicación");
                    Console.WriteLine("4. División");
                    Console.WriteLine("5. Convertir metros a millas");
                    Console.WriteLine("6. Convertir grados Celsius a Kelvin y Fahrenheit");
                    Console.WriteLine("7. Salir");

                    int opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion == 7)
                    {
                        continuar = false;
                        break;
                    }

                    double resultado = 0;

                    if (opcion >= 1 && opcion <= 4)
                    {
                        Console.WriteLine("Ingresa el primer número:");
                        double numero1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Ingresa el segundo número:");
                        double numero2 = Convert.ToDouble(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                resultado = Sumar(numero1, numero2);
                                break;
                            case 2:
                                resultado = Restar(numero1, numero2);
                                break;
                            case 3:
                                resultado = Multiplicar(numero1, numero2);
                                break;
                            case 4:
                                resultado = Dividir(numero1, numero2);
                                break;
                            default:
                                Console.WriteLine("Opción no válida.");
                                continue;
                        }

                        Console.WriteLine($"{nombre}, el resultado es: {resultado}");
                    }
                    else if (opcion == 5)
                    {
                        resultado = ConvertirMetrosAMillas(3000);
                        Console.WriteLine($"{nombre}, 3000 metros son equivalentes a {resultado} millas.");
                    }
                    else if (opcion == 6)
                    {
                        Console.Write("Ingrese la cantidad de grados Celsius: ");
                        double celsius = Convert.ToDouble(Console.ReadLine());

                        double kelvin = ConvertirACelsiusAKelvin(celsius);
                        double fahrenheit = ConvertirACelsiusAFahrenheit(celsius);

                        Console.Write("Grados Celsius: ");
                        Console.Write(celsius);
                        Console.Write(", Kelvin: ");
                        Console.Write(kelvin);
                        Console.Write(", Fahrenheit: ");
                        Console.WriteLine(fahrenheit);
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida.");
                    }
                }
            }
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
                    Console.WriteLine("Error: División por cero.");
                    return 0;
                }
            }
            static double ConvertirMetrosAMillas(double metros)
            {
                double metrosPorMilla = 1609;
                return metros / metrosPorMilla;
            }

            static double ConvertirACelsiusAKelvin(double celsius)
            {
                return celsius + 273;
            }

            static double ConvertirACelsiusAFahrenheit(double celsius)
            {
                return celsius * 18 / 10 + 32;
            }
        }
    }
}







