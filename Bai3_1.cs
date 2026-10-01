using System;
using System.Linq;
namespace BaiThucHanhLinQ;
class Bai3_1
{
    public static void Thongkemangso()
    {
        int[] mangso = {50,42,12,3,9,8,1,50,3,42,85};
        // a. Tổng số phần tử, số phần tử chẵn và số phần tử lẻ
        Console.WriteLine("Thong ke so phan tu:");
        int tongsophantu = mangso.Count();
        int sophantuchan = mangso.Count(so => so % 2 == 0);
        int sophantule = mangso.Count(so => so % 2 != 0);
        Console.WriteLine($"Tong so phan tu: {tongsophantu}");
        Console.WriteLine($"So phan tu chan: {sophantuchan}");
        Console.WriteLine($"So phan tu le: {sophantule}");
        Console.WriteLine();
        // b. Tổng, lớn nhất, nhỏ nhất
        Console.WriteLine("Thong ke gia tri:");
        int tonggiatri = mangso.Sum();
        int giatrilonnhat = mangso.Max();
        int giatrinhonhat = mangso.Min();
        Console.WriteLine($"Tong cac gia tri: {tonggiatri}");
        Console.WriteLine($"Gia tri lon nhat: {giatrilonnhat}");    
        Console.WriteLine($"Gia tri nho nhat: {giatrinhonhat}");
        Console.WriteLine();
        // c. Đếm số giá trị khác nhau
        Console.WriteLine("So gia tri khac nhau:");
        int sogiatrikhacnhau = mangso.Distinct().Count();
        Console.WriteLine($"Co {sogiatrikhacnhau} gia tri khac nhau");
        Console.WriteLine();
        // d. Phân nhóm theo số dư khi chia cho 5
        Console.WriteLine("Phan nhom theo so du khi chia cho 5:");
        var nhomtheosodu = mangso.GroupBy(so => so % 5) // gom những số có cùng số dư vào một nhóm
        .OrderBy(nhom => nhom.Key); // sắp xếp các nhóm theo số dư tăng dần
        foreach (var nhom in nhomtheosodu)
        {
            Console.WriteLine($"So du {nhom.Key}:");
            foreach (var so in nhom)
            {
                Console.Write($" {so}");
            }
            Console.WriteLine();
        }
    }
}