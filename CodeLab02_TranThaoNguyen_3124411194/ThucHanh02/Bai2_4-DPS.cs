using System;
namespace TH02
{
    public class DayPhanSo
    {
        private PhanSo[] a;
        public DayPhanSo()
        {
            a = new PhanSo[0];
        }
        public DayPhanSo(int n)
        {
            a = new PhanSo[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = new PhanSo();
            }
        }
        public void Input()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Nhap phan so thu " + i + ":");

                Console.Write("Tu so: ");
                int tu = int.Parse(Console.ReadLine());

                Console.Write("Mau so: ");
                int mau = int.Parse(Console.ReadLine());

                a[i] = new PhanSo(tu, mau);
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

        // tinh tong cac phan so
        public PhanSo TinhTong()
        {
            PhanSo tong = new PhanSo();

            for (int i = 0; i < a.Length; i++)
            {
                tong = tong + a[i];
            }

            return tong;
        }
    }
}