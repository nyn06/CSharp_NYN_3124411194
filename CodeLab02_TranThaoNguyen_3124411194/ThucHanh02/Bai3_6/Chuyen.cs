using System;
namespace TH02
{
    public class Chuyen : ThiSinh
    {
        private double tiengAnh;

        public Chuyen() : base()
        {
            tiengAnh = 0;
        }

        public Chuyen(
            string sbd,
            string hoTen,
            double bai1,
            double bai2,
            double bai3,
            double tiengAnh)
            : base(sbd, hoTen, bai1, bai2, bai3)
        {
            this.tiengAnh = tiengAnh;
        }

        public override void Input()
        {
            base.Input();

            Console.Write("Nhap diem tieng Anh: ");
            tiengAnh = double.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();

            Console.WriteLine("Diem tieng Anh: " + tiengAnh);
            Console.WriteLine("Tong diem: " + TinhTongDiem());
        }

        public override double TinhTongDiem()
        {
            double tong = bai1 + bai2 + bai3;

            if (tiengAnh >= 7 && tiengAnh <= 8)
            {
                tong = tong + 1;
            }
            else if (tiengAnh >= 9 && tiengAnh <= 10)
            {
                tong = tong + 2;
            }

            return tong;
        }
    }
}