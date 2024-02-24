namespace Desafios;

class Program
{
    static void Main(string[] args)
    {
    
    // Declarar dos variables n1=5 y n2=10.
    // Utilizando concatenación entre las variables 
    // y los literales, mostrar en pantalla la siguiente 
    // expresión:
    // n1 es igual a 5, n2 es igual a 10 y n1 más n2 es 
    // igual a 15.

        int n1 = 5;
        int n2 = 10;
        Console.WriteLine("n1 es igual "+ n1 ", n2 es igual a "+ n2 "y n1 más n2 es igual a 15.");

    // Dadas las variables n1=true, n2=false y n3=true. 
    // Informar:
    // a. n1 ^ n2
    // b. (n1 & !n2) | n3
    // c. (n1 | n2) & !n3
        bool b1 = true;
        bool b2 = false;
        bool b3 = true;
        bool b4 = false;

        b4 = b1 ^ b2;
        Console.WriteLine("b1 ^ b2 = " + b4);
        b4 = (b1 & !b2) | b3;
        Console.WriteLine("(b1 & !b2) | b3 = " + b4);
        b4 = (n1 | n2) & !b3;
        Console.WriteLine("(n1 | n2) & !b3 = " + b4);

    // Haciendo uso de la constante IVA=21, que 
    // representa el porcentaje de IVA a aplicar a los 
    // siguientes productos, cuyo precio sin IVA se 
    // indica en la siguiente lista: 
    // ● Remera: $59.90.
    // ● Pantalón: $99.90.
    // ● Campera: $149.90.
    // Informar los precios con IVA de cada uno. 
        float remera = 59.9f;
        float pantalon = 99.9f;
        float campera = 149.9f;
        const IVA = 1.21;

        Console.WriteLine("Lista de precios: ");
        Console.WriteLine("Remera: $" + remera*IVA);
        Console.WriteLine("Pantalon: $" + pantalon*IVA);
        Console.WriteLine("Campera: $" campera*IVA);
    }
}
