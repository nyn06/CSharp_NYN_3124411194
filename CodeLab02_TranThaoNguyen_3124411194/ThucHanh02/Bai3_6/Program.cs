using System;
namespace TH02
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong thi sinh: ");
            int n = int.Parse(Console.ReadLine());

            ThiSinh[] ds = new ThiSinh[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nThi sinh thu " + i);
                Console.WriteLine("1. Thi sinh Chuyen");
                Console.WriteLine("2. Thi sinh Sieu Cup");

                Console.Write("Chon doi tuong: ");
                int chon = int.Parse(Console.ReadLine());

                if (chon == 1)
                {
                    ds[i] = new Chuyen();
                }
                else
                {
                    ds[i] = new SieuCup();
                }

                ds[i].Input();
            }

            Console.WriteLine("\nKET QUA CUOC THI");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nThi sinh thu " + i + ":");
                ds[i].Output();
            }
        }
    }
}