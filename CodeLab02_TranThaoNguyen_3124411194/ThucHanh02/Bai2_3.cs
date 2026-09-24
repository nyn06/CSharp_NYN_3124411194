using System;
namespace TH02
{
    public class DaySo
    {
        private int[] a;
        public DaySo()
        {
            a = new int[0];
        }
        public DaySo(int n)
        {
            a = new int[n];
        }
        public DaySo(DaySo d)
        {
            a = new int[d.a.Length];

            for (int i = 0; i < d.a.Length; i++)
            {
                a[i] = d.a[i];
            }
        }
        // indexer truy cap phan tu thu i
        public int this[int i]
        {
            get
            {
                return a[i];
            }

            set
            {
                a[i] = value;
            }
        }
        public void Input()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Output()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
        }
        // tim cac so chan
        public void TimSoChan()
        {
            Console.Write("Cac so chan: ");

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}