using System;
namespace TH02
{
    public class Mang2Chieu
    {
        private int[,] a;
        public Mang2Chieu()
        {
            a = new int[0, 0];
        }
        public Mang2Chieu(int n, int m)
        {
            a = new int[n, m];
        }
        public Mang2Chieu(Mang2Chieu b)
        {
            int n = b.a.GetLength(0);
            int m = b.a.GetLength(1);

            a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = b.a[i, j];
                }
            }
        }
        // indexer truy cap phan tu tai i, j
        public int this[int i, int j]
        {
            get
            {
                return a[i, j];
            }

            set
            {
                a[i, j] = value;
            }
        }
        public void Input()
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("a[" + i + "," + j + "] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Output()
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
        // kiem tra so nguyen to
        private bool LaSoNguyenTo(int x)
        {
            if (x < 2)
            {
                return false;
            }

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        // tim cac so nguyen to
        public void TimSoNguyenTo()
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            Console.Write("Cac so nguyen to: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (LaSoNguyenTo(a[i, j]))
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}