using System;
namespace TH02
{
    public class NhanVien
    {
        private string hoTen;
        private double mucLuong;
        private int soNgayVang;

        // constructor mac dinh
        public NhanVien()
        {
            hoTen = "";
            mucLuong = 0;
            soNgayVang = 0;
        }
        public NhanVien(string hoTen, double mucLuong, int soNgayVang)
        {
            this.hoTen = hoTen;
            this.mucLuong = mucLuong;
            this.soNgayVang = soNgayVang;
        }
        public void Input()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap muc luong: ");
            mucLuong = double.Parse(Console.ReadLine());

            Console.Write("Nhap so ngay vang: ");
            soNgayVang = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Muc luong: " + mucLuong);
            Console.WriteLine("So ngay vang: " + soNgayVang);
            Console.WriteLine("Luong thuc nhan: " + TinhLuong());
        }
        // tinh luong thuc nhan
        public double TinhLuong()
        {
            return mucLuong - soNgayVang * 100000;
        }
    }
}