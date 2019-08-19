using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;

            //while (count < 3)
            //{
            //    count++;
            //    Console.WriteLine("The loop has run " + count + " times.");
            //}
            //Console.ReadKey();

            for (int count = 0; count < 3; count++)
            {
                Console.WriteLine("The loop has run " + count + " times.");
                Console.ReadKey();
                if (count == 2)
                {
                    return;
                }
            }
            Console.WriteLine("The loop is now finished.");
            Console.ReadKey();
        }
    }
}
