using System;
using System.Linq;
namespace BaiThucHanhLinQ;
class Bai5_2 
{
    public static void Thongkemonhoc()
    {
        List<MonHoc> dsMon = DuLieu.DS_Mon();
        // a. Tổng số môn hiện có
        Console.WriteLine("Tong so mon hien co:");
        int tongsomon = dsMon.Count();
        Console.WriteLine("Tong so mon: " + tongsomon);
        Console.WriteLine();
        // b. Đếm số môn có tên bắt đầu bằng "Lập trình"
        Console.WriteLine("So mon co ten bat dau bang \"Lập trình\":");
        int somonlaptrinh = dsMon.Count(mon => mon.Tenmon.StartsWith("Lập trình"));
        Console.WriteLine("So mon: " + somonlaptrinh);
        // c. Tổng số tiết của hệ KTV
        Console.WriteLine("Tong so tiet cua he KTV:");
        int tongtietktv = dsMon.Where(mon => mon.He == "KTV").Sum(mon => mon.Sotiet);
        Console.WriteLine("Tong so tiet cua KTV: " + tongtietktv);
        Console.WriteLine();
        // d. Tổng số môn của mỗi hệ
        Console.WriteLine("Tong so mon cua moi he:");
        var thongketheohe = dsMon.GroupBy(mon => mon.He);
        foreach (var nhom in thongketheohe)
        {
            Console.WriteLine("He: " + nhom.Key + ", Tong so mon: " + nhom.Count());
        }
        Console.WriteLine();
        // e. Nhóm theo Số tiết
        Console.WriteLine("Nhom theo so tiet, sap xem giam dan:");
        var nhomtheosotiet = dsMon.GroupBy(mon => mon.Sotiet).OrderByDescending(nhom => nhom.Key);
        foreach (var nhom in nhomtheosotiet)
        {
            Console.WriteLine($"So tiet: {nhom.Key} - Tong so mon: {nhom.Count()}");
        }
        Console.WriteLine();
        // f. Môn học có số tiết cao nhất
        Console.WriteLine("Mon hoc co so tiet cao nhat:");
        int sotietcaonhat = dsMon.Max(mon => mon.Sotiet);
        var moncaonhat = dsMon.Where(mon => mon.Sotiet == sotietcaonhat);
        foreach (var mon in moncaonhat)
        {
            Console.WriteLine($"{mon.Mamon} - {mon.Tenmon} - {mon.He} - {mon.Sotiet} tiet");
        }
        Console.WriteLine();
        // g. Thống kê theo Hệ
        Console.WriteLine("Thong ke theo He:");
        var thongkehe = dsMon.GroupBy(mon => mon.He).OrderBy(nhom => nhom.Key);
        foreach (var nhom in thongkehe)
        {
            Console.WriteLine($"He: {nhom.Key}");
            Console.WriteLine($"\tTong so mon: {nhom.Count()}");
            Console.WriteLine($"\tTong so tiet: {nhom.Sum(mon => mon.Sotiet)}");
            Console.WriteLine($"\tSo tiet cao nhat: {nhom.Max(mon => mon.Sotiet)}");
        }   
        Console.WriteLine();
        // h. Liệt kê môn học được phân nhóm theo Hệ
        Console.WriteLine("Mon hoc phan nhom theo He:");
        var montheohe = dsMon.GroupBy(mon => mon.He).OrderBy(nhom => nhom.Key);
        foreach (var nhom in montheohe)
        {
            Console.WriteLine($"He: {nhom.Key}");
            foreach (var mon in nhom)
            {
                Console.WriteLine($"\t{mon.Mamon} - {mon.Tenmon} - {mon.Sotiet} tiet");
            }
        }
        Console.WriteLine();
        // i. Phân nhóm theo Số tiết và tăng dần
        Console.WriteLine("Cac mon hoc phan nhom theo so tiet:");
        var monTheoSoTiet = dsMon
            .GroupBy(mon => mon.Sotiet)
            .OrderBy(nhom => nhom.Key);

        foreach (var nhom in monTheoSoTiet)
        {
            Console.WriteLine($"{nhom.Key} tiet");

            foreach (var mon in nhom)
            {
                Console.WriteLine(
                    $"{mon.Mamon} - {mon.Tenmon} - {mon.He}"
                );
            }
        }
        Console.WriteLine();
        // j. Hệ KTV, phân nhóm theo HP2, HP3, HP4, HP5
        Console.WriteLine("He KTV, phan nhom theo HP2, HP3, HP4, HP5:");
        var monKTV = dsMon
            .Where(mon => mon.He == "KTV")
            .Where(mon =>
                mon.Mamon.StartsWith("HP2") ||
                mon.Mamon.StartsWith("HP3") ||
                mon.Mamon.StartsWith("HP4") ||
                mon.Mamon.StartsWith("HP5"));
        var nhomHocPhan = monKTV
            .GroupBy(mon => mon.Mamon.Substring(0, 3))
            .OrderBy(nhom => nhom.Key);

        foreach (var nhom in nhomHocPhan)
        {
            Console.WriteLine($"--- {nhom.Key} ---");

            foreach (var mon in nhom.OrderBy(mon => mon.Mamon))
            {
                Console.WriteLine(
                    $"{mon.Mamon} - {mon.Tenmon} - {mon.Sotiet} tiet"
                );
            }
        }
        Console.WriteLine();
        // k. Phân nhóm theo Hệ, chỉ lấy môn có Số tiết > 40
            Console.WriteLine("Phan nhom theo He, chi lay mon co So tiet > 40:");
            var nhomHeTren40 = dsMon
            .Where(mon => mon.Sotiet > 40)
            .GroupBy(mon => mon.He)
            .OrderBy(nhom => nhom.Key);

        foreach (var nhom in nhomHeTren40)
        {
            Console.WriteLine($"He {nhom.Key}");

            foreach (var mon in nhom.OrderBy(mon => mon.Mamon))
            {
                Console.WriteLine(
                    $"{mon.Mamon} - {mon.Tenmon} - {mon.Sotiet} tiet"
                );
            }
        }
    }
}