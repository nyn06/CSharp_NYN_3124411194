using System;
using System.Linq;
namespace BaiThucHanhLinQ;
class Bai6_2
{
    public static void Bailam62()
    {
        List<MonHoc> dsMon = DuLieu.DS_Mon();
        List<He> dsHe = DuLieu.DS_He();
        // a. Dùng Join để liệt kê: Tên hệ, Mã môn, Tên môn
        Console.WriteLine("Ten he, Ma mon, Ten mon:");
        var ketquaA = from he in dsHe 
        join mon in dsMon on he.MaHe equals mon.He
        select new {he.TenHe, mon.Mamon, mon.Tenmon};
        foreach (var item in ketquaA)
        {
            Console.WriteLine($"{item.TenHe}, {item.Mamon}, {item.Tenmon}");
        }
        Console.WriteLine();
        // b. Left Outer Join, Liệt kê cả những hệ chưa có môn học
        Console.WriteLine("Liet ke ca nhung he chua co mon hoc:");
        var ketquaB = from he in dsHe
        join mon in dsMon on he.MaHe equals mon.He into nhommon
        from mon in nhommon.DefaultIfEmpty()
        select new {he.TenHe, Mamon = mon == null ? "(chua co)" : mon.Mamon, Tenmon = mon == null ? "(chua co mon hoc)" : mon.Tenmon};
        foreach (var item in ketquaB)
        {
            Console.WriteLine($"{item.TenHe} - {item.Mamon} - {item.Tenmon}");
        }
        Console.WriteLine();
        // c. Full Outer Join, Cả hệ chưa có môn và môn chưa khai báo hệ
        Console.WriteLine("Liet ke he chua co mon va mon chua khai bao he:");
        // Phan 1: cac he va mon tuong ung
        var phanhe = from he in dsHe
        join mon in dsMon on he.MaHe equals mon.He into nhommon
        from mon in nhommon.DefaultIfEmpty()
        select new {he.TenHe, Mamon = mon == null ? "(chua co)" : mon.Mamon, Tenmon = mon == null ? "(chua co mon hoc)" : mon.Tenmon};
        // Phan 2: cac mon chua khai bao he
        var monchuacohe = from mon in dsMon 
        where !dsHe.Any(he => he.MaHe == mon.He)
        select new {TenHe = "(chua co he)", Mamon = mon.Mamon, Tenmon = mon.Tenmon};
        var ketquaC = phanhe.Concat(monchuacohe);
        foreach (var item in ketquaC)
        {
            Console.WriteLine($"{item.TenHe} - {item.Mamon} - {item.Tenmon}");
        }
        Console.WriteLine();
        // d. Chỉ liệt kê hệ chưa có môn và môn chưa khai báo hệ
        Console.WriteLine("Chi liet ke he chua co mon va mon chua khai bao he:");
        // He chua co mon
        var hechuacomon = from he in dsHe 
        join mon in dsMon on he.MaHe equals mon.He into nhommon
        where !nhommon.Any()
        select new {TenHe = he.TenHe, Mamon = "(chua co)", Tenmon = "(chua co mon hoc)"};
        // Mon chua khai bao he
        var monchuakhaibaohe = from mon in dsMon
        where !dsHe.Any(he => he.MaHe == mon.He)
        select new {TenHe = "(chua co he)", Mamon = mon.Mamon, Tenmon = mon.Tenmon};
        var ketquaD = hechuacomon.Concat(monchuakhaibaohe);
        foreach (var item in ketquaD)
        {
            Console.WriteLine($"{item.TenHe} - {item.Mamon} - {item.Tenmon}");
        }
        Console.WriteLine();
        // e. Lấy 5 môn đầu tiên có số tiết giảm dần
        Console.WriteLine("5 mon dau tien co so tiet giam dan:");
        var ketquaE = (from mon in dsMon
        join he in dsHe on mon.He equals he.MaHe
        orderby mon.Sotiet descending
        select new {mon.Mamon, mon.Tenmon, he.TenHe, mon.Sotiet}).Take(5);
        foreach (var item in ketquaE)
        {
            Console.WriteLine($"{item.Mamon} - {item.Tenmon} - {item.TenHe} - {item.Sotiet} tiet");
            Console.WriteLine();
        }
        // f. Tổng số môn học của mỗi hệ
        Console.WriteLine("Tong so mon hoc cua moi he:");
        var ketquaF = from he in dsHe
        join mon in dsMon on he.MaHe equals mon.He into nhommon
        select new {he.MaHe, he.TenHe, Tongsomon = nhommon.Count()};
        foreach (var item in ketquaF)
        {
            Console.WriteLine($"{item.MaHe} - {item.TenHe} - Tong so mon: {item.Tongsomon}");
        }
        Console.WriteLine();
        // g. Có bao nhiêu loại Số tiết khác nhau
        Console.WriteLine("Co bao nhieu loai So tiet khac nhau:");
        int soloaisotiet = dsMon.Select(mon => mon.Sotiet).Distinct().Count();
        Console.WriteLine($"So loai So tiet khac nhau: {soloaisotiet}");
        Console.WriteLine();
        // h. Môn học đầu tiên có tên bắt đầu bằng "Lập trình"
        Console.WriteLine("Mon hoc dau tien co ten bat dau bang 'Lap trinh':");
        var monhocdautien = dsMon.FirstOrDefault(mon => mon.Tenmon.StartsWith("Lập trình"));
        if (monhocdautien != null)
        {
            Console.WriteLine($"Mon hoc dau tien: {monhocdautien.Mamon} - {monhocdautien.Tenmon}" + $"- {monhocdautien.He} - {monhocdautien.Sotiet} tiet");
        }
        else
        {
            Console.WriteLine("Khong co mon hoc nao bat dau bang 'Lap trinh'");
        }
        Console.WriteLine();
        // i. Liệt kê môn theo từng hệ, đánh số thứ tự trong nhóm
        Console.WriteLine("Liet ke mon theo tung he, danh so thu tu trong nhom:");
        var ketqauI = from he in dsHe 
        join mon in dsMon on he.MaHe equals mon.He into nhommon
        select new {he.TenHe, MonHoc = nhommon.OrderBy(mon => mon.Mamon).Select((mon,index) => new 
        {
            STT = index + 1, mon.Mamon, mon.Tenmon, mon.Sotiet
        })
        };
        foreach (var nhom in ketqauI)
        {
            Console.WriteLine($"He {nhom.TenHe}:");
            foreach (var mon in nhom.MonHoc)
            {
                Console.WriteLine($"{mon.STT}. {mon.Mamon} - {mon.Tenmon} - {mon.Sotiet} tiet");
            }
        }
    }
}