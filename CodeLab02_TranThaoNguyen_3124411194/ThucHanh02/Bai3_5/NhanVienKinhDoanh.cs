using System;
namespace TH02
{
    public class NhanVienKinhDoanh : NhanVien
    {
        private double luongCoBan;
        private int soHopDong;

        public NhanVienKinhDoanh() : base()
        {
            luongCoBan = 0;
            soHopDong = 0;
        }

        public NhanVienKinhDoanh(
            string maNhanVien,
            string hoTen,
            double luongCoBan,
            int soHopDong) : base(maNhanVien, hoTen)
        {
            this.luongCoBan = luongCoBan;
            this.soHopDong = soHopDong;
        }

        public override void Input()
        {
            base.Input();

            Console.Write("Nhap luong co ban: ");
            luongCoBan = double.Parse(Console.ReadLine());

            Console.Write("Nhap so hop dong: ");
            soHopDong = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();

            Console.WriteLine("Luong co ban: " + luongCoBan);
            Console.WriteLine("So hop dong: " + soHopDong);
            Console.WriteLine("Luong: " + TinhLuong());
        }

        public override double TinhLuong()
        {
            return luongCoBan + soHopDong * 500000;
        }
    }
}