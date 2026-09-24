/* Xuất và nhập chuỗi*/
using System; 
namespace TH01
{
    public class Bai2
    {
        public static void XuatvaNhap()
        {
            string Hoten;
            Console.Write("Nhap ho ten cua ban: ");
            Hoten = Console.ReadLine();

            Console.WriteLine("Chao ban "+Hoten+"!");
        }
    }
}