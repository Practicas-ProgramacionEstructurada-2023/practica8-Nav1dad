using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opciones;
            do
            {
                Console.WriteLine("\nMenu de opciones");
                Console.WriteLine("1. Sumar dos numeros enteros.");
                Console.WriteLine("2. Calcular salario.");
                Console.WriteLine("3. Calcular salario neto.");
                Console.WriteLine("4. Salir.");
                Console.WriteLine("\nIngrese su opcion");

                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                    switch (opciones)
                    {
                        case 1:
                            Console.WriteLine("\nIngrese el primer numero: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nIngrese el segundo numero: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            SumarDosNumeros(num1, num2);
                            break;

                        case 2:
                            Console.WriteLine("\nIngrese el numero de horas trabajadas: ");
                            int horasTrabajadas = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nIngrese el precio por hora: ");
                            double precioPorHora = Convert.ToDouble(Console.ReadLine());

                            calcularSalario(horasTrabajadas, precioPorHora);
                            break;

                        case 3:
                            Console.WriteLine("\nIngrese el numero de horas trabajadas: ");
                            int hTrabajadas = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nIngrese el precio por hora: ");
                            double precioPHora = Convert.ToDouble(Console.ReadLine());

                            calcualSalarioNeto(hTrabajadas, precioPHora);
                            break;

                        case 4:
                            Console.WriteLine("\nSaliendo del programa....");
                            break;
                        default:
                        Console.WriteLine("\nOpcion no valida. Intente de nuevo");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("\nOpcion no valida. Intente de nuevo");
                }

            } while (opciones != 4);
        }

        static void SumarDosNumeros(int num1, int num2)
        {
            int suma = num1 + num2;
            Console.WriteLine("\nLa suma es: " + suma);
        }

        static void calcularSalario(int horasTrabajadas, double precioPorHora)
        {
            double salario = horasTrabajadas * precioPorHora;
            Console.WriteLine("\nEl salario es: $" + salario);
        }
        static void calcualSalarioNeto(int hTrabajadas ,double precioPHora)
        {
            double SalarioNeto = hTrabajadas * precioPHora;
            double limiteISSS = 30;

            if (SalarioNeto > 1000)
            {
                SalarioNeto -= limiteISSS;
            }
            Console.WriteLine("\nEl salario es: $" + SalarioNeto);
        }
    }
}
// NOMBRE: PEDRO ANTONIO ALVAREZ HERNANDEZ
// CODIGO: U20230697