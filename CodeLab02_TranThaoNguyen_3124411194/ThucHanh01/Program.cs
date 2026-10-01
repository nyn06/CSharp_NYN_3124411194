using System;
namespace TH01
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // TH01.Bai2.XuatvaNhap();
            // TH01.Bai3.Nhapsonguyen();
            // TH01.Bai5.Menu();
            /*
            -- Bài 6 --
            int a=-5; 
            int b=-2;
            int c=-10;

            int Kq=TH01.Bai6.timmax(a,b,c);

            Console.WriteLine("Gia tri lon nhat la: "+Kq);*/

            /*
            -- Bài 7 --
            int n;
            Console.Write("Nhap n: ");
            n=int.Parse(Console.ReadLine()!);
            bool Kq = TH01.Bai7.Kiemtranguyento(n);
            if(Kq)
            {
                Console.WriteLine(n+" la so nguyen to");
            }
            else
            {
                Console.WriteLine(n+ " khong la so nguyen to");
            }
            */
            /* 
            -- Bài 8 --
            double a,b;
            Console.Write("Nhap a: ");
            a = double.Parse(Console.ReadLine()!);
            Console.Write("Nhap b: ");
            b = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Truoc khi hoan vi: ");
            Console.WriteLine("a= "+a);
            Console.WriteLine("b= "+b);

            TH01.Bai8.Hoanvi(ref a, ref b);
            Console.WriteLine("Sau khi hoan vi: ");
            Console.WriteLine("a= "+a);
            Console.WriteLine("b= "+b);
            */
            /*
            -- Bài 9 --
            double a,b,c;
            double max,min;
            Console.Write("Nhap a: ");
            a = double.Parse(Console.ReadLine()!);

            Console.Write("Nhap b: ");
            b = double.Parse(Console.ReadLine()!);

            Console.Write("Nhap c: ");
            c = double.Parse(Console.ReadLine()!);

            TH01.Bai9.Timmaxmin(a,b,c,out max, out min);

            Console.WriteLine("Gia tri lon nhat la: " + max);
            Console.WriteLine("Gia tri nho nhat la: " + min);*/

            /*
            -- Bài 10 --
            string s;
            Console.Write("Nhap chuoi: ");
            s = Console.ReadLine()!;

            bool kq = TH01.Bai10.Kiemtradoixung(s);

            if(kq)
            {
                Console.WriteLine("Chuoi doi xung.");
            }
            else
            {
                Console.WriteLine("Chuoi khong doi xung.");
            }*/
            /* 
            -- Bài 11 --
            string s;
            Console.Write("Nhap chuoi: ");
            s = Console.ReadLine()!;

            string kq = TH01.Bai11.Daochuoi(s);
            Console.WriteLine("Chuoi sau khi dao: "+kq); */
            /*
            -- Bài 12 --
            string s;

            Console.Write("Nhap chuoi: ");
            s = Console.ReadLine()!;

            TH01.Bai12.Xulychuoi(s);*/
            /*
            -- Bài 13 --
            // Tạo một đối tượng sinh viên 
            TH01.Bai13 sv = new TH01.Bai13();
            sv.Nhap();
            Console.WriteLine("Thong tin sinh vien");
            sv.Xuat(); */
            /*
            -- Bài 14 --
            Bai14 nv = new Bai14();
            nv.Nhap();
            Console.WriteLine("   ");
            Console.WriteLine("Thong tin nhan vien");
            nv.Xuat();     */
            /* 
            -- Bài 15 --
            int n;
            Console.Write("Nhap so phan tu n: ");
            n = int.Parse(Console.ReadLine()!);
            int[] a = new int[n];
            Bai15 bai = new Bai15();
            bai.Nhapmang(a);
            Console.WriteLine("Mang vua nhap:");
            bai.Xuatmang(a);
            int max, min;
            bai.Timmaxmin(a,out max,out min);
            Console.WriteLine("Phan tu lon nhat: "+max);
            Console.WriteLine("Phan tu nho nhat: "+min);
            int[] mangnguyento = bai.Timsonguyento(a);
            Console.Write("Mang cac so nguyen to: ");
            bai.Xuatmang(mangnguyento);*/
            /*
            -- Bài 17 --
            int n;
            Console.Write("Nhap so phan tu n: ");
            n = int.Parse(Console.ReadLine()!);
            string[] a = new string[n];
            Bai16 bai = new Bai16();
            bai.Nhapmang(a);
            Console.WriteLine("Danh sach vua nhap:");
            bai.Xuatmang(a);
            bai.Sapxep(a);
            Console.WriteLine("Danh sach sau khi sap xep:");
            bai.Xuatmang(a);*/

            int n,m;
            Console.Write("Nhap so duong n: ");
            n = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap so duong m: ");
            m = int.Parse(Console.ReadLine()!);

            int[,] a=new int[n,m];
            Bai17 bai = new Bai17();
            bai.Mangngaunhien(a);
            Console.WriteLine("Mang A");
            bai.Xuatmang(a);
            int[] mangchan = bai.Timsochan(a);
            Console.Write("Mang cac so chan: ");
            bai.Xuatmang1chieu(mangchan);
            int[] mangle = bai.Timsole(a);
            Console.Write("Mang cac so le: ");
            bai.Xuatmang1chieu(mangle);
        }
    }
}
