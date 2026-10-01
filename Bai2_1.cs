using System;
using System.Linq;
namespace BaiThucHanhLinQ;
class Bai2_1
{
    public static void ThucHien()
    {
        int[] mangso = {50,42,16,3,9,8,12,7,24,0};
        // a. Liệt kê các phần tử chia hết cho 4 và 3
        Console.WriteLine("Cac phan tu chia het cho 4 va 3: ");
        //Query Syntax
        var ketquaA_query = from so in mangso //Lấy từng phần tử trong mảng mangSo và đặt tên tạm cho phần tử đó là so
        where so % 4 == 0 && so % 3 == 0
        select so;
        Console.Write("Query Syntax: ");
        foreach (var so in ketquaA_query)
        {
            Console.Write(so + " ");
        }
        Console.WriteLine();
        //Method Syntax
        var ketquaA_method = mangso 
        .Where(so => so % 4 == 0 && so % 3 == 0);
        Console.Write("Method Syntax: ");
        foreach (var so in ketquaA_method)
        {
            Console.Write(so + " ");
        }
        Console.WriteLine();
        // b. Liệt kê các phần tử nhỏ hơn hoặc bằng 3
        Console.WriteLine("Cac phan tu nho hon hoac bang 3:");
        //Query Syntax
        var ketquaB_query = from so in mangso 
        where so <= 3
        select so;
        Console.Write("Query Syntax: ");
        foreach (var so in ketquaB_query)
        {
            Console.Write(so + " ");
        }
        Console.WriteLine();
        //Method Syntax
        var ketquaB_method = mangso
        .Where (so => so <= 3);
        Console.Write("Method Syntax: ");
        foreach (var so in ketquaB_method)
        {
            Console.Write(so + " ");
        }
        Console.WriteLine();
        // c. Số chẵn chia đôi, số lẻ giữ nguyên 
        Console.WriteLine("Day moi: ");
        var ketquaC = mangso
        .Select(so => so % 2 == 0 ? so / 2 : so);
        Console.Write("Ket qua: ");
        foreach (var so in ketquaC)
        {
            Console.Write(so+" ");
        }
        Console.WriteLine();
    }
}