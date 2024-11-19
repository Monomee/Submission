using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter width: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Area is: "+ (width*height));
            Console.ReadLine();
        }
    }
}
