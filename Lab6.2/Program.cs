using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Определение полиндрома
            Console.WriteLine("Введите предложение без знаков препинания");
            string predlogenie = Console.ReadLine();
            string predlogenieBezProbelov = predlogenie.Replace(" ", "").ToLower();
            int n = predlogenieBezProbelov.Length;
            string nachalo = "";
            string konec = "";
            string obratno = "";
            if (n % 2 == 0)
            {
                nachalo = predlogenieBezProbelov.Substring(0, n / 2);
                konec = predlogenieBezProbelov.Substring(n / 2);
                char[] konecArray = konec.ToCharArray();
                Array.Reverse(konecArray);
                obratno = new string(konecArray);
            }
            else
            {
                nachalo = predlogenieBezProbelov.Substring(0, (n / 2));
                konec = predlogenieBezProbelov.Substring(n / 2 + 1);
                char[] konecArray = konec.ToCharArray();
                Array.Reverse(konecArray);
                obratno = new string(konecArray);
            }
            int result = String.Compare(nachalo, obratno);
            if (result == 0)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
