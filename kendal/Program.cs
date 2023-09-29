using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace kendal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- ejercicio 1");
                Console.WriteLine("2- ejercicio 2");
                Console.WriteLine("3- ejercicio 3");
                Console.WriteLine("4- salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine()); //2
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        ejercicio1();
                        break;
                    case 2:
                        Console.Clear();
                        ejercicio2();
                        break;
                    case 3:
                        Console.Clear();
                        ejercicio3();
                        break;
                    default:
                        break;
                }
            } while (opcion != 4); //siempre que la opcion sea diferente a 4

        }

        public static void ejercicio1()  // metodo 1
        {
            float precio = 0f;
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("Digite el precio de la camisa");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"total a pagar: {cantidad * precio}");
            }
            else if (cantidad > 1 && cantidad < 6)
            {
                total = (cantidad * precio) * 0.15f; // calcule el 15 precio
                total = (cantidad * precio) - total;
                Console.WriteLine($"total a pagar: {total} con descuento de 15%");
            }
            else if (cantidad >= 6)
            {
                total = (cantidad * precio) * 0.15f; // calcule el 15 precio
                total = (cantidad * precio) - total;
                Console.WriteLine($"total a pagar: {total} con descuento de 20%");
            }
        }

        public static void ejercicio2()  // metodo 2
        {
            Console.WriteLine("Ingrese los datos del estudiante:");

            // Leer datos del estudiante
            Console.Write("Carnet: ");
            string carnet = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Quiz 1: ");
            double quiz1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quiz 2: ");
            double quiz2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quiz 3: ");
            double quiz3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tarea 1: ");
            double tarea1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tarea 2: ");
            double tarea2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tarea 3: ");
            double tarea3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Examen 1: ");
            double examen1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Examen 2: ");
            double examen2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Examen 3: ");
            double examen3 = Convert.ToDouble(Console.ReadLine());

            // Calcular porcentajes
            double porcentajeQuices = (quiz1 + quiz2 + quiz3) / 3 * 0.25;
            double porcentajeTareas = (tarea1 + tarea2 + tarea3) / 3 * 0.3;
            double porcentajeExamenes = (examen1 + examen2 + examen3) / 3 * 0.45;

            // Calcular promedio final
            double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

            // Determinar la condición del estudiante
            string condicion;
            if (promedioFinal >= 70)
            {
                condicion = "Aprobado";
            }
            else if (promedioFinal >= 50)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }

            // Mostrar resultados
            Console.WriteLine("\nResultados:");
            Console.WriteLine("Carnet: " + carnet);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Porcentaje de Quices: " + porcentajeQuices.ToString("P2"));
            Console.WriteLine("Porcentaje de Tareas: " + porcentajeTareas.ToString("P2"));
            Console.WriteLine("Porcentaje de Examenes: " + porcentajeExamenes.ToString("P2"));
            Console.WriteLine("Promedio Final: " + promedioFinal.ToString("F2"));
            Console.WriteLine("Condición: " + condicion);
        }

        public static void ejercicio3() // metodo 3
        {
            // Pedir al usuario la cantidad de artículos
            Console.Write("Ingrese la cantidad de artículos: ");
            int cantidadArticulos = int.Parse(Console.ReadLine());

            // Definir el precio por artículo
            double precioPorArticulo;

            // Calcular el precio por artículo
            if (cantidadArticulos <= 10)
            {
                precioPorArticulo = 20.0;
            }
            else
            {
                precioPorArticulo = 15.0;
            }

            // Calcular el total
            double total = cantidadArticulos * precioPorArticulo;

            // Mostrar el precio y el total
            Console.WriteLine($"Precio por artículo: ${precioPorArticulo}");
            Console.WriteLine($"Total a pagar: ${total}");
        }
    }


}