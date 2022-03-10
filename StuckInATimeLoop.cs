using System;
namespace StuckInATimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " Abracadabra \n");
            }
            Console.ReadKey();
        }
        
    }
}
