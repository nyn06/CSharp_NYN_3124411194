using System;
namespace TH02
{
    public class ConsoleMenu
    {
        public delegate void XuLyChucNang(int chucNang);

        public event XuLyChucNang ThucHienChucNang;

        public void Chay()
        {
            int chon;

            do
            {
                Console.Clear();

                Console.WriteLine("Menu");
                Console.WriteLine("1. Chuc nang 1");
                Console.WriteLine("2. Chuc nang 2");
                Console.WriteLine("0. Thoat chuong trinh");

                Console.Write("Thuc hien: ");
                chon = int.Parse(Console.ReadLine());

                if (chon != 0)
                {
                    if (ThucHienChucNang != null)
                    {
                        ThucHienChucNang(chon);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                }

            } while (chon != 0);
        }
    }
}