using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Нахождение самого длинного слова
            Console.WriteLine("Введите предложение без знаков препинания");
            string predlogenie = Console.ReadLine();
            int number = 0;
            int numberMax = 0;
            string wordMax = "";
            string[] stringArray = predlogenie.Split();
            foreach (string s in stringArray)
            {
                number = s.Length;
                while (number > numberMax)
                {
                    numberMax = number;
                    wordMax = s;
                }
            }
            Console.WriteLine("Самое длинное слово - {0}", wordMax);
            Console.ReadKey();
        }
    }
}
