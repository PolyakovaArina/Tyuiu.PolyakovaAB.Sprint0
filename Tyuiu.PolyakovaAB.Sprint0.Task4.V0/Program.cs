using Tyuiu.PolyakovaAB.Sprint0.Task4.V0.Lib;
namespace Tyuiu.PolyakovaAB.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(5,5));
            Console.WriteLine(DataService.Substraction(5, 5));
            Console.WriteLine(DataService.Multiplication(5, 5));
            Console.WriteLine(DataService.Division(5, 5));
            Console.ReadKey();

        }
    }
}
