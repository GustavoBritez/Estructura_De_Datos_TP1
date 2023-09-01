using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Enunciado();
            int opcion= 15;
            do
            {
                opcion = Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 0:
                        Console.WriteLine(" Gracias vuelva pronto");
                        break;
                    case 1:
                        Ejercicio_1();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 2:
                        Ejercicio_2();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 3:
                        Ejercicio_3();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 4:
                        Ejercicio_4();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 5:
                        Ejercicio_5();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 6:
                        Ejercicio_6();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 7:
                        Ejercicio_7();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 8:
                        Ejercicio_8();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 9:
                        Ejercicio_9();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 10:
                        Ejercicio_10();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 11:
                        Ejercicio_11();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 12:
                        Ejercicio_12();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 13:
                        Ejercicio_13();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 14:
                        Ejercicio_14();
                        Console.Clear();
                        Enunciado();
                        break;
                    case 15:
                        Ejercicio_15();
                        Console.Clear();
                        Enunciado();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(" Opcion incorrecta \n\n");
                        Enunciado();
                        break;

                }

            } while ( opcion != 0);
        }
        static void Enunciado()
        {
            Console.WriteLine("Elije un ejercicio del 1 al 15");
            for(int i = 1; i < 16; i++)
            {
                if( i == 1) { Console.WriteLine("[0] Salir"); }
                Console.WriteLine("[{0}] Ejercicio {0}", i);
            }

        }
        static void Ejercicio_1()
        {
            int suma = 0;
            Console.WriteLine("Ingrese dos valores");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Valor [{0}] = ", i + 1);
                suma += Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Suma = {suma}");
            Console.ReadKey();
        }
        static void Ejercicio_2()
        {
            Console.WriteLine("Ingrese dos valores");
            int[] array = new int[3];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Valor [{0}] = ", i + 1);
                array[i] = Int32.Parse(Console.ReadLine());
            }
            /// En Posicion 1, guardamos el mayor y en Posicion 0 es menor.
            if (array[0] > array[1])
            {
                (array[0], array[1]) = (array[1], array[0]);
            }

            int resultado = array[1] - array[0];

            Console.WriteLine($"La distancia entre {array[1]} y {array[0]} es = {resultado}");
            Console.ReadKey();
        }
        static void Ejercicio_3()
        {
            double lado = 0;
            
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese Lado {0}", i+1);
                lado += Double.Parse(Console.ReadLine());
            }
            Console.WriteLine("El Perimetro es = {0}", lado);
            Console.ReadLine();
        }
        static void Ejercicio_4()
        {
            Console.WriteLine(" Calculemos el perimetro ");
            double[] perimetro = new double[2];
            for(int i = 0; i < 2; i++)
            {
                perimetro[i] = Double.Parse(Console.ReadLine());
            }
            Console.WriteLine($" El perimtro es = {perimetro[0] * perimetro[1]}");
            Console.ReadLine();
        }
        static void Ejercicio_5()
        {
            Console.WriteLine(" Dados los datos necesarios de un Rectángulo calcular la superficie.");

            double longitud = Double.Parse(Console.ReadLine()); // Reemplaza con la longitud del rectángulo
            double ancho = Double.Parse(Console.ReadLine());   // Reemplaza con el ancho del rectángulo

            double superficie = longitud * ancho;

            Console.WriteLine(" El resultado es = {0}", superficie);
            Console.ReadLine();
        }
        static void Ejercicio_6()
        {
            Console.WriteLine(" Calculemos el diametro de un circulo");
            Console.WriteLine(" Ingrese la circunferencia");
            double circunferencia = Double.Parse(Console.ReadLine());

            double diametro = circunferencia / Math.PI;

            Console.WriteLine("El diámetro del círculo es: " + diametro);
            Console.ReadLine();
        }
        static void Ejercicio_7()
        {
            Console.WriteLine("Un kilobyte (KB) es igual a 1024 bytes, ya que se basa en el sistema binario.");
            Console.WriteLine("Cada byte tiene 8 bits.");

            Console.WriteLine("Ingrese N bytes");
            int kilobytes = int.Parse(Console.ReadLine());

            Console.WriteLine(" Resultado = {0}", kilobytes * 8*1024);
            Console.ReadLine();
        }
        static void Ejercicio_8()
        {
            Console.WriteLine("Calcular el factorial de 6");

            int numero = 6;
            long factorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"El factorial de {numero} es {factorial}");
            Console.ReadKey();
        }
        static void Ejercicio_9()
        {
            Console.WriteLine(" Ingrese la frase 1");
            string frase1 = Console.ReadLine();
            Console.WriteLine(" Ingrese la frase 2");
            string frase2 = Console.ReadLine();

            string resultado = frase1 + frase2;

            Console.WriteLine(resultado);

            Console.ReadKey();
        }
        static void Ejercicio_10()
        {
            Console.WriteLine("Ingresa una frase: ");
            string frase = Console.ReadLine();

            if (frase.Length % 2 == 0) 
            {
                int mitad = frase.Length / 2;

                string segundaMitad = frase.Substring(mitad);
                string primeraMitad = frase.Substring(0, mitad);

                string nuevaFrase = segundaMitad + primeraMitad;

                Console.WriteLine("Nueva frase: " + nuevaFrase);
            }
            else
            {
                Console.WriteLine("La longitud de la frase no es par, no se puede dividir en mitades iguales.");
            }
            Console.ReadLine();
        }
        static void Ejercicio_11()
        {
            Console.WriteLine(" Dada un frase informar la cantidad de caracteres que tiene");
            string frase = Console.ReadLine();
            int cantidad = frase.Length;
            Console.WriteLine("El numero de elemento ses = {0}",cantidad );
            Console.ReadKey();
        }
        static void Ejercicio_12()
        {
            Console.WriteLine(" Mostrar la fecha actual");
            DateTime fecha = DateTime.Now;
            
            Console.WriteLine("La fecha es = {0}", fecha);
            Console.ReadKey();
        }
        static string ObtenerFecha(DateTime fecha)
        {

            string año = fecha.Year.ToString();
            string mes = fecha.Month.ToString().PadLeft(2, '0'); 
            string día = fecha.Day.ToString().PadLeft(2, '0');   

            string fechaEnFormato = año + mes + día;

            return fechaEnFormato;
        }
        static void Ejercicio_13() /// NO FUNCIONA
        {
            DateTime fecha = DateTime.Now; 

            string fechaEnFormato = ObtenerFecha(fecha);


            Console.WriteLine("Fecha en formato AAAAMMDD: " + fechaEnFormato);
            Console.ReadLine();
        }
        static void Ejercicio_14()
        {
            Console.WriteLine("Ingresa la primera fecha (yyyy-MM-dd): ");
            DateTime fecha1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la segunda fecha (yyyy-MM-dd): ");
            DateTime fecha2 = DateTime.Parse(Console.ReadLine());

            TimeSpan diferencia = fecha2 - fecha1;

            int diferenciaEnDias = (int)diferencia.TotalDays;
            Console.WriteLine("La diferencia en días entre las dos fechas es: " + diferenciaEnDias + " días.");

            Console.Read();
        }
        static void Ejercicio_15()
        {
            DateTime fechaObjetivo = new DateTime(2020, 12, 25);

            DateTime fechaActual = DateTime.Now;

            TimeSpan diferencia = fechaObjetivo - fechaActual;

            int diasFaltantes = (int)diferencia.TotalDays;

            Console.WriteLine("Días faltantes para el 25/12/2020: " + diasFaltantes + " días.");
            Console.ReadLine();
        }
    }
}
