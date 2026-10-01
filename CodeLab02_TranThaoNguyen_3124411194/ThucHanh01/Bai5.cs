using System;
namespace TH01
{
    public class Bai5 
    {
        public static void Menu()
        {
            double x = 0,y = 0;
            int chon = 0;
            while(chon != 4)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");
                chon = int.Parse(Console.ReadLine());
                    
                switch(chon)
                {
                    case 1:
                    {
                        Console.Write("Nhap gia tri x: ");
                        x = double.Parse(Console.ReadLine()!);
                        Console.Write("Nhap gia tri y: ");
                        y = double.Parse(Console.ReadLine()!);
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Ket qua x^y = "+ Math.Pow(x,y));
                        break;
                    }
                    case 3:
                    {
                        if (x>=0 && y>=0)
                        {
                            Console.WriteLine("Can bac 2 cua x = "+Math.Sqrt(x));
                            Console.WriteLine("Can bac 2 cua y = "+Math.Sqrt(y));
                        }
                        else
                        {
                            Console.WriteLine("Khong the tinh can bac 2 cua so am!");
                        }
                        break;
                    }
                    case 4: 
                    {
                        Console.WriteLine("Thoat chuong trinh!");
                        break;
                    }
                    default:
                    Console.WriteLine("Chuc nang khong hop le!");
                    break;
                }
            }
        }
    }
}
