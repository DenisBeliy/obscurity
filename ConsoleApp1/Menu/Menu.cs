using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Menu
{
    class Menu
    {

        public static void MenuVisual()
        {
            PrintMenu(); //отрисовка изначального меню
        }

        private static void PrintMenu()
        {
            string prMenu1 = Properties.Resources.Menu1;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" " + prMenu1);

            

           
        }

        private static void MenuLogic()
        {
            
        }


    }
}
