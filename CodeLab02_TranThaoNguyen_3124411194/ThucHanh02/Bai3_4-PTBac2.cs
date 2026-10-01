using System;
namespace TH02
{
    public class PTBac2Console : ConsoleMenu
    {
        public PTBac2Console()
        {
            ThucHienChucNang += XuLyChucNang;
        }

        private void XuLyChucNang(int chucNang)
        {
            switch (chucNang)
            {
                case 1:
                    GiaiPhuongTrinh();
                    break;

                case 2:
                    Console.WriteLine("Ban thuc hien chuc nang 2");
                    break;

                default:
                    Console.WriteLine("Chuc nang khong hop le!");
                    break;
            }
        }

        private void GiaiPhuongTrinh()
        {
            Console.WriteLine("GIAI PHUONG TRINH BAC 2");

            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phuong trinh co nghiem x = " + x);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep x = " + x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("Phuong trinh co 2 nghiem:");
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }
        }
    }
}