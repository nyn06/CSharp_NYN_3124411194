using System;
namespace TH02
{
    public abstract class ThiSinh
    {
        protected string sbd;
        protected string hoTen;
        protected double bai1;
        protected double bai2;
        protected double bai3;

        public ThiSinh()
        {
            sbd = "";
            hoTen = "";
            bai1 = 0;
            bai2 = 0;
            bai3 = 0;
        }

        public ThiSinh(
            string sbd,
            string hoTen,
            double bai1,
            double bai2,
            double bai3)
        {
            this.sbd = sbd;
            this.hoTen = hoTen;
            this.bai1 = bai1;
            this.bai2 = bai2;
            this.bai3 = bai3;
        }

        public virtual void Input()
        {
            Console.Write("Nhap so bao danh: ");
            sbd = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap diem bai 1: ");
            bai1 = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem bai 2: ");
            bai2 = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem bai 3: ");
            bai3 = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine("So bao danh: " + sbd);
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Diem bai 1: " + bai1);
            Console.WriteLine("Diem bai 2: " + bai2);
            Console.WriteLine("Diem bai 3: " + bai3);
        }

        public abstract double TinhTongDiem();
    }
}