/*Nhập số nguyên*/
using System;
namespace TH01
{
    public class Bai3 
    {
        public static void Nhapsonguyen()
        {
            int x,y;
            Console.Write("Nhap so nguyen x: ");
            x = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap so nguyen y: ");
            y = int.Parse(Console.ReadLine()!);

            int Kq = 1;
            for(int i=1;i<=y;i++)
            {
                Kq=Kq*x;
            }

            Console.WriteLine("Ket qua "+x+" mu "+y+" la: "+Kq);
        }
    }
}