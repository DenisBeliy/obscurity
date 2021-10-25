using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;


namespace ConsoleApp1.logo
{
    
    class Greetings
    {
        
        public static void PrintLogotips()
        {
            PrintCompanyLogo(); // отрисовка логотипа компании
            PrintGameLogo(); // отрисовка логотипа игры
        }


        

        private static void PrintCompanyLogo()
        {
            string logoCompany = Properties.Resources.logo_company;
            Console.WriteLine(" " + logoCompany);
            Thread.Sleep(2000);
            Console.Clear();
        }
        private static void PrintGameLogo()
        {
            string logoGame = Properties.Resources.logo_game;
            Console.WriteLine(" " + logoGame);
            Thread.Sleep(2000);
            Console.Clear();
        }

    }
}
