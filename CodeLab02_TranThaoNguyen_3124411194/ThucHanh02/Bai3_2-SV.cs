using System;
namespace TH02
{
    public class SinhVien1
    {
        private string hoTen;
        private double diemTB;
        public SinhVien1()
        {
            hoTen = "";
            diemTB = 0;
        }
        public SinhVien1(string hoTen, double diemTB)
        {
            this.hoTen = hoTen;
            this.diemTB = diemTB;
        }
        public void Input()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap diem trung binh: ");
            diemTB = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Diem trung binh: " + diemTB);
        }

        // lay diem trung binh
        public double GetDiemTB()
        {
            return diemTB;
        }
    }
}