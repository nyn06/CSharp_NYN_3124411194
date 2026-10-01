/* Tính lương nhân viên*/
using System;
namespace TH01 
{
    public class Bai14
    {
        public string HoTen;
        public double MucLuong;
        public int SoNgayVang;

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine()!;

            Console.Write("Nhap muc luong: ");
            MucLuong = double.Parse(Console.ReadLine()!);

            Console.Write("Nhap so ngay vang: ");
            SoNgayVang = int.Parse(Console.ReadLine()!);
        }

        public double TinhLuong()
        {
            double Luong;
            Luong = MucLuong - SoNgayVang * 100000;
            return Luong;
        }

        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Muc luong: " + MucLuong);
            Console.WriteLine("So ngay vang: " + SoNgayVang);
            Console.WriteLine("Luong thuc nhan: " + TinhLuong() + " VNĐ");
        }
    }
}