using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5._2
{
    internal class Program
    {
        /// <summary>
        /// Разделение входной строки на слова
        /// </summary>
        /// <param name="inputPhrase"></param>
        /// <returns></returns>
        static string[] Divider(string inputPhrase)
        {
            string[] end = inputPhrase.Split(' ');
            return end;
            
        }
        /// <summary>
        /// Вывод строки со словами в обратном порядке
        /// </summary>
        /// <param name="inputPhrase"></param>
        /// <returns></returns>
        static string[] ReversWords(string inputPhrase)        //ResultString += NewString + “ ”  тема для рассуждений
        {
            string[] start = Divider(inputPhrase);
            string[] reverse = new string[start.Length];
            for (int i = reverse.Length - 1; i + 1 > 0; i--)
            {
                int j = 0;
                reverse[j] = start[i];
                Console.WriteLine(reverse[j]);
                j++;
            }
            return reverse;


        }
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string inputPhrase = Console.ReadLine();
            ReversWords(inputPhrase);
            Console.ReadKey();
        }
    }
}
