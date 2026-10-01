using System;
namespace TH02
{
    public class DonThuc
    {
        // khai bao he so va so mu
        private double a;
        private int n;
        public DonThuc()
        {
            a = 0;
            n = 0;
        }
        public DonThuc(double a, int n)
        {
            this.a = a;
            this.n = n;
        }
        // tinh gia tri don thuc
        public double TinhGiaTri(double x)
        {
            return a * Math.Pow(x, n);
        }
        // tinh dao ham
        public DonThuc DaoHam()
        {
            if (n == 0)
            {
                return new DonThuc(0, 0);
            }
            return new DonThuc(a * n, n - 1);
        }
        // xuat don thuc
        public override string ToString()
        {
            if (a == 0)
                return "0";

            if (n == 0)
                return a.ToString();

            if (n == 1)
                return a + "x";
            return a + "x^" + n;
        }
    }
}