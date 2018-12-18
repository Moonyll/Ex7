using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valeur de BC ?");
            int BC = int.Parse(Console.ReadLine());
            Console.WriteLine("Valeur de CA ?");
            int CA = int.Parse(Console.ReadLine());
            int a = (CA * CA) + (BC * BC); // Math.Pow(BC,2) + Math.Pow(CA,2);
            double AC = Math.Sqrt(a);
            Console.WriteLine("AB vaut : " +AC);
        }
    }
}
