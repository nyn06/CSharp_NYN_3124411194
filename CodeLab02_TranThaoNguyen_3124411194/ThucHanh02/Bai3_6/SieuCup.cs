using System;
namespace TH02
{
    public class SieuCup : ThiSinh
    {
        private double csdl;

        public SieuCup() : base()
        {
            csdl = 0;
        }

        public SieuCup(
            string sbd,
            string hoTen,
            double bai1,
            double bai2,
            double bai3,
            double csdl)
            : base(sbd, hoTen, bai1, bai2, bai3)
        {
            this.csdl = csdl;
        }

        public override void Input()
        {
            base.Input();

            Console.Write("Nhap diem CSDL: ");
            csdl = double.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();

            Console.WriteLine("Diem CSDL: " + csdl);
            Console.WriteLine("Tong diem: " + TinhTongDiem());
        }

        public override double TinhTongDiem()
        {
            return bai1 + bai2 + bai3 + csdl;
        }
    }
}