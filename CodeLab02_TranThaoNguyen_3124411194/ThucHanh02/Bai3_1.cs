using System;
namespace TH02
{
    public class SinhVien : IComparable
    {
        private string hoTen;
        private double diemTB;
        public SinhVien()
        {
            hoTen = "";
            diemTB = 0;
        }
        public SinhVien(string hoTen, double diemTB)
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
        // so sanh hai sinh vien theo diem trung binh
        public int CompareTo(object obj)
        {
            SinhVien sv = (SinhVien)obj;

            if (diemTB < sv.diemTB)
            {
                return -1;
            }

            if (diemTB > sv.diemTB)
            {
                return 1;
            }

            return 0;
        }
    }
}