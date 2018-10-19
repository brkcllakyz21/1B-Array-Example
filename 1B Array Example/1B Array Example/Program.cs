using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1B_Array_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Double[] notlar = new double[50];
            int sayaç = 0;

            for (int i = 0; i < notlar.Length; i++)
            {
                Console.WriteLine((i + 1) + ". öğrenci için notu giriniz");
                notlar[i] = Convert.ToDouble(Console.ReadLine());
                if (notlar[i] > 50)
                {
                    sayaç++;
                }
            }
            Console.WriteLine(sayaç + "kadar öğrenci başarılı oldu.");



        }
    }
}
