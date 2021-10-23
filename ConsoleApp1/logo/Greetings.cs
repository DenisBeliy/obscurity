using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1.logo
{
    class Greetings
    {

        public static void Logo()
        {
            FileStream fileStream = new FileStream("D:\\Новая игра на C#\\Fiels\\logo company.txt", FileMode.Open);
            //File.OpenRead("D:\\Новая игра на C#\\Fiels\\logo company.txt");

            StreamReader streamReader = new StreamReader(fileStream);
            string textOfFile = streamReader.ReadToEnd();

            Console.WriteLine(textOfFile);

            fileStream.Close();
            
        }


    }
}
