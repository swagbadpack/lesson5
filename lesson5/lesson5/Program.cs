using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    internal class Program
    {
        /// <summary>
        /// Разделение предложения на массив слов
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] Divider(string text)
        {
            string[] end = text.Split(' ');
            return end;
        }
        /// <summary>
        /// Вывод отдельных слов на экран
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] PrintResult(string text)
        {
            string[] words = Divider(text);
            foreach (var element in words)
            Console.WriteLine(element);
            return words;
        }
        static void Main(string[] args)
        {
            Console.Write("Ведите предложение: ");
            string text = Console.ReadLine();
            Divider(text);
            PrintResult(text);
            Console.ReadKey();
        }
    }
}
