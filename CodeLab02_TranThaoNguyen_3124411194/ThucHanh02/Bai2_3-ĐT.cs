using System;
namespace TH02
{
    public class DaThuc
    {
        private DonThuc[] a;
        public DaThuc()
        {
            a = new DonThuc[0];
        }
        public DaThuc(int n)
        {
            a = new DonThuc[n + 1];

            for (int i = 0; i <= n; i++)
            {
                a[i] = new DonThuc(0, i);
            }
        }
        public DaThuc(DaThuc b)
        {
            a = new DonThuc[b.a.Length];

            for (int i = 0; i < b.a.Length; i++)
            {
                a[i] = b.a[i];
            }
        }
        // indexer truy cap don thuc thu i
        public DonThuc this[int i]
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
                Console.Write("Nhap he so a" + i + ": ");
                double heSo = double.Parse(Console.ReadLine());

                a[i] = new DonThuc(heSo, i);
            }
        }
        public void Output()
        {
            for (int i = 0; i < a.Length; i++)
            {
                double x = 1;

                if (a[i].TinhGiaTri(x) != 0)
                {
                    if (i == 0)
                    {
                        Console.Write(a[i]);
                    }
                    else
                    {
                        Console.Write(" + " + a[i]);
                    }
                }
            }

            Console.WriteLine();
        }
        // tinh gia tri da thuc tai x
        public double TinhGiaTri(double x)
        {
            double tong = 0;

            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i].TinhGiaTri(x);
            }

            return tong;
        }
    }
}