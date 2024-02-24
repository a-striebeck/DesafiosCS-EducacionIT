namespace Desafios;

class Program
{
    static void Main(string[] args)
    {

        DesafioII desafioII = new DesafioII();

        desafioII.checkIfExamIsApproved();
        desafioII.checkWhoIsBigger();
        desafioII.informIfApproved();

        Console.ReadKey();
    }
}
