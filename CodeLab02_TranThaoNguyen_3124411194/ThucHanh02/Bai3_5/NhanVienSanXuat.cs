using System;
namespace TH02
{
    public class NhanVienSanXuat : NhanVien
    {
        private int soLuongSanPham;

        public NhanVienSanXuat() : base()
        {
            soLuongSanPham = 0;
        }

        public NhanVienSanXuat(
            string maNhanVien,
            string hoTen,
            int soLuongSanPham) : base(maNhanVien, hoTen)
        {
            this.soLuongSanPham = soLuongSanPham;
        }

        public override void Input()
        {
            base.Input();

            Console.Write("Nhap so luong san pham: ");
            soLuongSanPham = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();

            Console.WriteLine("So luong san pham: " + soLuongSanPham);
            Console.WriteLine("Luong: " + TinhLuong());
        }

        public override double TinhLuong()
        {
            double luong = soLuongSanPham * 1000;

            if (soLuongSanPham > 3000)
            {
                luong = luong + luong * 5 / 100;
            }

            return luong;
        }
    }
}