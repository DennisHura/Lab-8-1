using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prog_4s_l8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> numbers = new Stack<string>();
            StreamReader sr = new StreamReader("in.txt");
            string row = sr.ReadLine();
            string[] rowSP = row.Split(' ');
            for (int i = 0; i < rowSP.Length; i++)
            {
                Console.Write(rowSP[i]);
            }
            Console.WriteLine("\n\n");

            List<string> skobochki = new List<string>();

            int left = 0, right = 0;

            for (int i = 0; i < rowSP.Length; i++)
            {
                if (rowSP[i] == '('.ToString())
                {
                    skobochki.Add(rowSP[i]);
                    left++;
                }
                else
                {
                    if (rowSP[i] == ')'.ToString())
                    {
                        skobochki.Add(rowSP[i]);
                        right++;
                    }
                }
            }
            //foreach(string skobochka in skobochki)
            //{
            //    Console.WriteLine(skobochka);
            //}
            if (left == right)
            {
                Console.WriteLine("Скобочек в выражении поровну");
            }
            else
            {
                if (left > right)
                {
                    Console.WriteLine("'(' скобочек больше");
                }
                else
                {
                    Console.WriteLine("')' скобочек больше");
                }
            }
        }
    }
}
