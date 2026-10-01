using System;
using System.Linq;
namespace BaiThucHanhLinQ;
class Bai5_1
{
    public static void Truyvancoban()
    {
        List<MonHoc> dsMon = DuLieu.DS_Mon();
        // a. Liệt kê tên các môn học bắt đầu bằng "Lập trình"
        Console.WriteLine("Cac mon hoc bat dau bang \"Lập trình\":");

        var ketquaA =
            from mon in dsMon
            where mon.Tenmon.StartsWith("Lập trình")
            select mon;

        foreach (var mon in ketquaA)
        {
            Console.WriteLine($"{mon.Mamon} - {mon.Tenmon}");
        }
        Console.WriteLine();
        // b. Môn thuộc hệ CD, sắp số tiết giảm dần, nếu bằng nhau thì mã môn tăng dần
        Console.WriteLine("Cac mon thuoc he \"CD\", sap so tiet giam dan, neu bang nhau thi ma mon tang dan:");

        var ketquaB = dsMon
            .Where(mon => mon.He == "CD")
            .OrderByDescending(mon => mon.Sotiet)
            .ThenBy(mon => mon.Mamon); //nếu các môn có cùng số tiết, thì sắp xếp tiếp theo Mamon từ A → Z / nhỏ → lớn.

        foreach (var mon in ketquaB)
        {
            Console.WriteLine(
                $"{mon.Mamon} - {mon.Tenmon} - {mon.Sotiet} tiet");
        }
        Console.WriteLine();
        // c. Môn có tên chứa từ "web", chỉ lấy Tên môn và Hệ
        Console.WriteLine("Cac mon co ten chua tu \"web\":");
        var ketquaC = dsMon
            .Where(mon => mon.Tenmon.ToLower().Contains("web"))
            .Select(mon => new
            {
                mon.Tenmon,
                mon.He
            });
        foreach (var mon in ketquaC)
        {
            Console.WriteLine(
                $"Tên môn: {mon.Tenmon}, Hệ: {mon.He}");
        }
        Console.WriteLine();
        // d. Môn thuộc hệ KTV, sắp tăng dần theo Mã môn
        Console.WriteLine("Cac mon thuoc he \"KTV\", sap tang dan theo Ma mon:");
        var ketquaD = dsMon
            .Where(mon => mon.He == "KTV")
            .OrderBy(mon => mon.Mamon);

        foreach (var mon in ketquaD)
        {
            Console.WriteLine($"{mon.Mamon} - {mon.Tenmon}");
        }
    }
}