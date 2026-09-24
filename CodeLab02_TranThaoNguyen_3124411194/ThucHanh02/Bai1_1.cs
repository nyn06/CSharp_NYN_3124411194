/*Tính tuổi 1 sinh viên*/
using System;
namespace TH02
{
    public class Bai1_1
    {
        public void Tinhtuoi()
        {
            Console.Write("Nhap ho ten sinh vien: ");
            string Hoten = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            int Namsinh=int.Parse(Console.ReadLine());
            int namhientai = DateTime.Now.Year;
            int tuoi = namhientai - Namsinh;
            Console.WriteLine("Sinh vien {0} co tuoi la: {1}",Hoten,tuoi);
        }
    }
}