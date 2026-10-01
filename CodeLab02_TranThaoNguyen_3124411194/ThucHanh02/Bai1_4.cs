/* Bài 1_4 */
using System;
namespace TH02
{
    public class PhanSo
    {
        private int tuSo;
        private int mauSo;
        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }
        public PhanSo(int tuSo, int mauSo)
        {
            if (mauSo == 0)
            {
                Console.WriteLine("Mau so phai khac 0.");
                this.tuSo = 0;
                this.mauSo = 1;
            }
            else
            {
                this.tuSo = tuSo;
                this.mauSo = mauSo;
                RutGon();
            }
        }
        public PhanSo(int tuSo)
        {
            this.tuSo = tuSo;
            this.mauSo = 1;
        }
        public PhanSo(PhanSo p)
        {
            tuSo = p.tuSo;
            mauSo = p.mauSo;
        }
        private static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }

            return a;
        }
        private void RutGon()
        {
            int ucln = UCLN(tuSo, mauSo);

            tuSo /= ucln;
            mauSo /= ucln;

            // dua dau am len tu so
            if (mauSo < 0)
            {
                tuSo = -tuSo;
                mauSo = -mauSo;
            }
        }
        public override string ToString()
        {
            if (mauSo == 1)
            {
                return tuSo.ToString();
            }

            return tuSo + "/" + mauSo;
        }

        // toan tu mot ngoi +
        public static PhanSo operator +(PhanSo p)
        {
            return new PhanSo(p);
        }

        // toan tu mot ngoi -
        public static PhanSo operator -(PhanSo p)
        {
            return new PhanSo(-p.tuSo, p.mauSo);
        }

        // toan tu hai ngoi +
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            int tu = a.tuSo * b.mauSo + b.tuSo * a.mauSo;

            int mau = a.mauSo * b.mauSo;

            return new PhanSo(tu, mau);
        }

        // toan tu hai ngoi -
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            int tu = a.tuSo * b.mauSo - b.tuSo * a.mauSo;

            int mau = a.mauSo * b.mauSo;

            return new PhanSo(tu, mau);
        }

        // toan tu hai ngoi *
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            int tu = a.tuSo * b.tuSo;
            int mau = a.mauSo * b.mauSo;

            return new PhanSo(tu, mau);
        }

        // toan tu hai ngoi /
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.tuSo == 0)
            {
                Console.WriteLine("Khong the chia cho phan so 0.");
                return new PhanSo();
            }

            int tu = a.tuSo * b.mauSo;
            int mau = a.mauSo * b.tuSo;

            return new PhanSo(tu, mau);
        }

        // toan tu so sanh >
        public static bool operator >(PhanSo a, PhanSo b)
        {
            return a.tuSo * b.mauSo > b.tuSo * a.mauSo;
        }

        // toan tu so sanh <
        public static bool operator <(PhanSo a, PhanSo b)
        {
            return a.tuSo * b.mauSo < b.tuSo * a.mauSo;
        }

        // toan tu so sanh >=
        public static bool operator >=(PhanSo a, PhanSo b)
        {
            return a.tuSo * b.mauSo >= b.tuSo * a.mauSo;
        }

        // toan tu so sanh <=
        public static bool operator <=(PhanSo a, PhanSo b)
        {
            return a.tuSo * b.mauSo <= b.tuSo * a.mauSo;
        }

        // toan tu so sanh ==
        public static bool operator ==(PhanSo a, PhanSo b)
        {
            return a.tuSo * b.mauSo == b.tuSo * a.mauSo;
        }

        // toan tu so sanh !=
        public static bool operator !=(PhanSo a, PhanSo b)
        {
            return !(a == b);
        }
    }
}