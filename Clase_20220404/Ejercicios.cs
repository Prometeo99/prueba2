using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20220404
{
    internal class Ejercicios
    {
        public void Guia1Ej4A()
        {
            int materiasTotales;
            int materiasAprobadas;
            int materiasFaltantes;

            Console.Write("Por favor ingrese el total de las materias de la carrera: ");
            materiasTotales = Convert.ToInt32(Console.ReadLine());

            Console.Write("Por favor ingrese el total de las materias aprobadas: ");
            materiasAprobadas = Convert.ToInt32(Console.ReadLine());

            materiasFaltantes = materiasTotales - materiasAprobadas;

            Console.WriteLine("A usted le faltan " + materiasFaltantes + " materias para recibirse.");

        }

        public void Guia1Ej9SinBucle()
        {
            float acumulador = 0;

            Console.Write("Por favor ingrese un numero: ");
            acumulador += Convert.ToSingle(Console.ReadLine());
            Console.Write("Por favor ingrese un numero: ");
            acumulador += Convert.ToSingle(Console.ReadLine());
            Console.Write("Por favor ingrese un numero: ");
            acumulador += Convert.ToSingle(Console.ReadLine());
            Console.Write("Por favor ingrese un numero: ");
            acumulador += Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("La sumatoria de esos numeros es: " + acumulador);
        }

        public void Guia1Ej9ConBucle()
        {
            float acumulador = 0;
            int contador = 0;

            do
            {
                Console.Write("Por favor ingrese un numero: ");
                acumulador += Convert.ToSingle(Console.ReadLine());
                contador++;

            } while (contador < 4);

            Console.WriteLine("La sumatoria de esos numeros es: " + acumulador);

        }

        public void Guia1Ej10()
        {
            float materiasAprobadas;
            float materiasRendidas;
            float promedio;
            float ranking;

            Console.Write("Por favor ingrese la cantidad de la materias aprobadas: ");
            materiasAprobadas = Convert.ToSingle(Console.ReadLine());

            Console.Write("Por favor ingrese la cantidad de la materias rendidas: ");
            materiasRendidas = Convert.ToSingle(Console.ReadLine());

            Console.Write("Por favor ingrese su promedio: ");
            promedio = Convert.ToSingle(Console.ReadLine());

            ranking = (materiasAprobadas / materiasRendidas) * 100 + materiasAprobadas * 3 + promedio * 3;
            Console.WriteLine("El ranking del alumno es: " + ranking);
        }

        public void Guia2Ej3()
        {
            string opcion;
            bool flagDatoErroneo;

            do
            {
                flagDatoErroneo = false;
                Console.Write("Hola, quiere permanecer en el programa? (S/N): ");
                opcion = Console.ReadLine();

                if (opcion != "S" && opcion != "N")
                {
                    Console.WriteLine("Usted seleccionó un dato erróneo.");
                    flagDatoErroneo = true;
                }

            } while (opcion == "S" || flagDatoErroneo == true);

            Console.WriteLine("Hasta luego!");
        }

        public void Guia2Ej5()
        {
            string opcion;
            string mensaje;
            bool flagDatoErroneo;

            do
            {
                flagDatoErroneo = false;
                Console.WriteLine("Seleccione la operación a realizar:" + System.Environment.NewLine +
                "1 - Altas" + System.Environment.NewLine +
                "2 - Bajas" + System.Environment.NewLine +
                "3 - Modificaciones" + System.Environment.NewLine +
                "4 - Salir");

                opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    mensaje = "Usted seleccinó Altas";
                }
                else if (opcion == "2")
                {
                    mensaje = "Usted seleccionó Bajas";
                }
                else if (opcion == "3")
                {
                    mensaje = "Usted seleccionó Modificaciones";
                }
                else if (opcion == "4")
                {
                    mensaje = "Usted seleccionó Salir";
                }
                else
                {
                    mensaje = "Usted ingresó un dato erróneo. Deberá ingresarlo nuevamente.";
                    flagDatoErroneo = true;
                }

                Console.WriteLine(mensaje);
            } while (flagDatoErroneo == true); // while (flagDatoErroneo);

        }

        public void Guia2Ej6()
        {
            int numero1;
            int numero2;
            string mensaje;

            Console.Write("Por favor ingrese el primer numero: ");
            numero1 =  Convert.ToInt32(Console.ReadLine());

            Console.Write("Por favor ingrese el segundo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 == numero2)
            {
                mensaje = "Los numeros ingresados son iguales";
            }
            else
            {
                mensaje = "Los numeros ingresados son distintos";
            }

            Console.WriteLine(mensaje);
        }
    }
}
