/* Xử lý chuỗi*/
using System;
namespace TH01
{
    public class Bai12
    {
        public static void Xulychuoi(string s)
        {
            string chuthuong = s.ToLower();
            string chuhoa = s.ToUpper();
            // Tách từ
            string[] cactu = s.Split(' '); // tách chuỗi tại dấu cách
            // Đếm số từ
            int sotu = cactu.Length;

            Console.WriteLine("Chuoi viet thuong: " + chuthuong);
            Console.WriteLine("Chuoi viet hoa: " + chuhoa);
            Console.WriteLine("So tu trong chuoi: " + sotu);
        }
    }
}