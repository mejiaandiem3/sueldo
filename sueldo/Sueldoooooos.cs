using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sueldo
{
    class Sueldoooooos
    {
        double suma;
        double mult;
           
        public void presentacion1()
        {
            Console.WriteLine(" ");
            Console.WriteLine("      Sueldos.");
            Console.WriteLine(" ");

            Console.WriteLine(" ");
            Console.WriteLine("      Turno.");
            Console.WriteLine(" ");

        }

        public void turno1()
        {

            double[] turno;
            turno = new double[5];
          

            for(int i = 0;i<=4;i++)
            {
                turno[i] = i;
                Console.WriteLine(" Ingresa el sueldo del empleado {0}: ", i + 1);
                Console.WriteLine(" ");
                turno[i] = double.Parse(Console.ReadLine());

                mult = turno[i] * 0.15;
                suma = turno[i] + mult;

                    Console.WriteLine(" ");
                    Console.WriteLine(" Sueldo: " + turno[i]);
                    Console.WriteLine(" ");
                    Console.WriteLine(" Aumento a aplicar (15% del sueldo): " + mult);
                    Console.WriteLine(" ");
                    Console.WriteLine(" Sueldo total (aumento imcluido): " + suma);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ---------------------------------------------------------------------------");

                }

            }

        }

    }

