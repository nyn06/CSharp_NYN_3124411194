using System;
namespace TH02
{
    public abstract class NhanVien
    {
        protected string maNhanVien;
        protected string hoTen;

        public NhanVien()
        {
            maNhanVien = "";
            hoTen = "";
        }

        public NhanVien(string maNhanVien, string hoTen)
        {
            this.maNhanVien = maNhanVien;
            this.hoTen = hoTen;
        }

        public virtual void Input()
        {
            Console.Write("Nhap ma nhan vien: ");
            maNhanVien = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.WriteLine("Ma nhan vien: " + maNhanVien);
            Console.WriteLine("Ho ten: " + hoTen);
        }

        public abstract double TinhLuong();
    }
}