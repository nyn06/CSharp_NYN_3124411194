/*Nhập xuất thông tin sinh viên*/
using System;
namespace TH01 
{
    public class Bai13 
    {
        public string MaSV;
        public string HoTen;
        public string DiaChi;
        public int NamThu;

        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine()!;

            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine()!;

            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine()!;

            Console.Write("Nhap sinh vien nam thu: ");
            NamThu = int.Parse(Console.ReadLine()!);
        }

        public void Xuat()
        {
            Console.WriteLine("Ma sinh vien"+MaSV);
            Console.WriteLine("Ho ten: "+HoTen);
            Console.WriteLine("Dia chi: "+DiaChi);
            Console.WriteLine("Sinh vien nam thu: "+NamThu);
        }
    }
}