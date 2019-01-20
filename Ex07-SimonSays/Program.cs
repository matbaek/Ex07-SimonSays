using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_SimonSays
{
    class Program
    {
        static void Main(string[] args)
        {
            Simon simon = new Simon();

            //Console.Write("Indtast besked: ");
            //string message = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("Echo: " + simon.Echo(message));
            //Console.WriteLine("Shout: " + simon.Shout(message));

            Console.WriteLine(
            simon.Titleize("the bridge over the river kwai"));
        }
    }
}
