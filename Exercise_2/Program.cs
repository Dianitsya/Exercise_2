using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, dm, temp;
            int[] tasya = new int[31];
            {
                while (true)
                {
                    //tentukan banyaknya data (n)
                    Console.Write("Masukkan banyaknya elemen pada Array : ");
                    string s = Console.ReadLine();
                    n = Int32.Parse(s);
                    if (n <= 31)
                        break;
                    else
                        Console.WriteLine("\nArray dapat mempunyai maksimal 31 elemen.\n");
                }
                Console.WriteLine("");
                Console.WriteLine("------------------------");
                Console.WriteLine(" Masukkan elemen array");
                Console.WriteLine("------------------------");

                //input data ke array sebanyak n data
                for (i = 0; i <= n - 1; i++)
                {
                    Console.Write("<" + (i + 1) + "> ");
                    tasya[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("\n");
                Console.WriteLine("MEMILIH METODE PENGURUTAN DATA");
                Console.WriteLine("1. Insertion Sort");
                Console.WriteLine("2. Merge SORT");
                Console.WriteLine("3. Exit");
                Console.WriteLine("--------------------------");
                Console.Write("Pilihan : ");
                int pilihan = Convert.ToInt32(Console.ReadLine());

                {
          
        }
    }
}
