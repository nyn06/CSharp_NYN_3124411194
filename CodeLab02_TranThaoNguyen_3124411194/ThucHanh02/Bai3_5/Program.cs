using System;

namespace TH02
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());

            NhanVien[] ds = new NhanVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhan vien thu " + i);
                Console.WriteLine("1. Nhan vien kinh doanh");
                Console.WriteLine("2. Nhan vien san xuat");

                Console.Write("Chon loai nhan vien: ");
                int chon = int.Parse(Console.ReadLine());

                if (chon == 1)
                {
                    ds[i] = new NhanVienKinhDoanh();
                }
                else
                {
                    ds[i] = new NhanVienSanXuat();
                }

                ds[i].Input();
            }

            Console.WriteLine("\nDANH SACH NHAN VIEN");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhan vien thu " + i + ":");
                ds[i].Output();
            }

            Console.WriteLine("\nLUONG CUA CAC NHAN VIEN");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    ds[i].TinhLuong() + " VNĐ"
                );
            }
        }
    }
}