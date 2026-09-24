using System;
namespace TH02
{
    public class PhongBan
    {
        private NhanVien[] dsNhanVien;
        public PhongBan()
        {
            dsNhanVien = new NhanVien[0];
        }
        public PhongBan(int n)
        {
            dsNhanVien = new NhanVien[n];

            for (int i = 0; i < n; i++)
            {
                dsNhanVien[i] = new NhanVien();
            }
        }
        public void Input()
        {
            for (int i = 0; i < dsNhanVien.Length; i++)
            {
                Console.WriteLine("\nNhap nhan vien thu " + i + ":");
                dsNhanVien[i].Input();
            }
        }
        public void Output()
        {
            for (int i = 0; i < dsNhanVien.Length; i++)
            {
                Console.WriteLine("\nNhan vien thu " + i + ":");
                dsNhanVien[i].Output();
            }
        }

        // tinh tong luong cua phong ban
        public double TinhTongLuong()
        {
            double tong = 0;

            for (int i = 0; i < dsNhanVien.Length; i++)
            {
                tong += dsNhanVien[i].TinhLuong();
            }

            return tong;
        }
    }
}