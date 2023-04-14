using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practichescaya_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: \n");

            Console.WriteLine("Введите длинное предложение: ");
            string text = Console.ReadLine();

            ShowWords(SplitText(text));

            Console.ReadKey();

            Console.WriteLine("\nВторое задание: \n");

            ReverseWorlds(text);

            Console.ReadKey();
        }

        static string[] SplitText(string text)
        {
            string[] result = text.Split(' ');

            return result;
        }

        static void ShowWords(string[] text)
        {
            foreach (string a in text)
                Console.WriteLine(a);
        }

        static string ReverseWorlds(string text)
        {
            string[] newString = SplitText(text);
            string resultString = "";

            for(int a = newString.Length - 1; a >= 0; a--)
                resultString += newString[a] + " ";

            Console.WriteLine(resultString);

            return text;
        }
    }
}