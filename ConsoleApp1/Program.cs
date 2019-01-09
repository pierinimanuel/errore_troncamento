using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
         double erroreTroncamento=0.00000095;
         double erroreTempo;
         double spazio;
         int velocità = 1676;
         erroreTempo = erroreTroncamento * 100 * 60 * 60 * 10;
         Console.WriteLine("l'errore per il tempo è di {0}", erroreTempo);

            spazio = erroreTempo * velocità;
            Console.WriteLine("lo spazio è  {0}", spazio);


        }
    }
}
