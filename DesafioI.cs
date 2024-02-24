using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    internal class DesafioI
    {

        public void showFirstExercise(){

            Console.WriteLine("-------------------------------Ejercicio 1--------------------------------");
            int n1 = 5;
            int n2 = 10;
            Console.WriteLine("La variable \"n1\" es igual "+ n1 + ", \"n2\" es igual a "+ n2 + "y \"n1\" más \"n2\" es igual "+ (n1 + n2));

        }

        public void showSecondExercise() {
            
            Console.WriteLine("-------------------------------Ejercicio 2--------------------------------");
            bool b1 = true;
            bool b2 = false;
            bool b3 = true;
            bool b4 = false;
            Console.WriteLine("Siendo b1: " + b1);
            Console.WriteLine("Siendo b2: " + b2);
            Console.WriteLine("Siendo b3: " + b3);
            b4 = b1 ^ b2;
            Console.WriteLine("b1 ^ b2 = " + b4);
            b4 = (b1 & !b2) | b3;
            Console.WriteLine("(b1 & !b2) | b3 = " + b4);
            b4 = (b1 | b2) & !b3;
            Console.WriteLine("(n1 | n2) & !b3 = " + b4) ;
        }

        public void showThirdExercise()
        {
            Console.WriteLine("-------------------------------Ejercicio 3--------------------------------");

            float remera = 59.9f;
            float pantalon = 99.9f;
            float campera = 149.9f;
            const float IVA = 1.21f;

            Console.WriteLine("Lista de precios sin IVA: ");
            Console.WriteLine("Remera: $" + remera);
            Console.WriteLine("Pantalon: $" + pantalon);
            Console.WriteLine("Campera: $" + campera);
            Console.WriteLine("Lista de precios con IVA: ");
            Console.WriteLine("Remera: $" + remera * IVA);
            Console.WriteLine("Pantalon: $" + pantalon * IVA);
            Console.WriteLine("Campera: $" + campera * IVA);
        }
    }

}
