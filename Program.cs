using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_20192_P1_3_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("menulis lagu anak ayam");
            Console.Write("Masukkan Jumlah N :");
            int N = Convert.ToInt16(Console.ReadLine());

            for(int i=N; i>=1; i--)
            {
                if(i!=1)
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal {1}", i, i - 1);
                }
                else
                {
                    Console.Write("Anak ayam turun {0}, mati satu tinggal induknya", i);
                }
            }
        }
    }
}
