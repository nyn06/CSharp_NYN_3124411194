using System;
using System.Linq;
namespace BaiThucHanhLinQ;
class Bai2_2 
{
    public static void Mangchuoi()
    {
        string[] mangchuoi = {"đầu", "lòng", "hai", "ả", "tố", "nga", "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân"};
        // a. Liệt kê các phần tử có 4 ký tự và sắp xếp tăng dần theo ký tự đầu tiên
        Console.WriteLine("Cac phan tu co 4 ky tu, sap xep tang dan: ");
        var ketquaA = from chuoi in mangchuoi
        where chuoi.Length == 4
        orderby chuoi ascending
        select chuoi;
        foreach (var chuoi in ketquaA)
        {
            Console.Write(chuoi + " ");
        }
        Console.WriteLine();
        // b. Biến đổi mỗi phần tử thành: chữ thường - chữ hoa
        Console.WriteLine("Bien doi thanh dang chu thuong - chu hoa: ");
        var ketquaB = mangchuoi
        .Select(chuoi => chuoi.ToLower() + " - " + chuoi.ToUpper());
        foreach (var chuoi in ketquaB)
        {
            Console.WriteLine(chuoi);
        }
        Console.WriteLine();
        // c. Liệt kê các phần tử có chứa ký tự "u"
        Console.WriteLine("Cac phan tu co chua ky tu 'u':");
        var ketquaC = mangchuoi
        .Where(chuoi => chuoi.Contains("u") || chuoi.Contains("ú") || chuoi.Contains("ù") || chuoi.Contains("ủ") || chuoi.Contains("ụ"));
        foreach (var chuoi in ketquaC)
        {
            Console.Write(chuoi + " ");
        }
        Console.WriteLine();
        // d. Liệt kê các từ bắt đầu bằng chữ in hoa 
        Console.WriteLine("Cac tu bat dau bang chu in hoa:");
        var ketquaD = mangchuoi
        .Where(chuoi => char.IsUpper(chuoi[0])); // lấy ký tự đầu tiên của chuỗi
        foreach (var chuoi in ketquaD)
        {
            Console.Write(chuoi + " ");
        }
        Console.WriteLine();
    }
}