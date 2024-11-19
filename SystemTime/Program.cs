using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine("Date time now is: " + localDate);
            Console.ReadLine();
        }
    }
}
