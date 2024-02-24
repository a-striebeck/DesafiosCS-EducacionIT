using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    internal class DesafioII
    {
        public void checkIfExamIsApproved()
        {
            int nota = 0;
            Console.WriteLine("Ingrese la nota del alumno");
            try
            {
                nota = int.Parse(Console.ReadLine());

                if (nota >= 7)
                {
                    Console.WriteLine("El alumno ha promocionado la materia");
                }
                else
                {
                    if (nota < 7 & nota > 4)
                    {
                        Console.WriteLine("El alumno ha aprobado la cursada.");
                    }
                    else
                    {
                        Console.WriteLine("Debe rendir el recuperatorio.");
                    }
                }
            } catch {
                Console.WriteLine("Los datos ingresados no son validos.");
            }
        }

        public void checkWhoIsBigger()
        {
            int numA;
            int numB;
     

            Console.WriteLine("Ingrese el valor del primer numero: ");
            numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo numero: ");
            numB = int.Parse(Console.ReadLine());

            if (numA > numB)
            {
                Console.WriteLine(numA + " + " + numB + " = " + (numA + numB));
                Console.WriteLine(numA + " - " + numB + " = " + (numA - numB));
            }
            else
            {
                Console.WriteLine(numA + " * " + numB + " = " + (numA * numB));
                Console.WriteLine(numA + " / " + numB + " = " + ((float)numA / numB));
            }
            {
                
            }
        }

        public void informIfApproved()
        {
            int nota1 = 0;
            int nota2 = 0;
            Console.WriteLine("Ingrese la nota del primer parcial: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del segundo parcial: ");
            nota2 = int.Parse(Console.ReadLine());



            if (nota1 >= 4 && nota2 >= 4)
            {
                Console.WriteLine("El alumno ha aprobado la cursada.");
             
            }else if (nota1 <= 4 && nota2 >= 4)
            {
                Console.WriteLine("El alumno debe recuperar el primer parcial para poder aprobar.");
            }
            else if (nota2 <= 4 && nota1 >= 4)
            {
                Console.WriteLine("El alumno debe recuperar el segundo parcial para poder aprobar.");
            }
            else
            {
                Console.WriteLine("El alumno debe recursar la materia.");
            }
        }
    }
}
