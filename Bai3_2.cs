using System;
using System.Linq;
namespace BaiThucHanhLinQ;
class Bai3_2
{
    public static void Thongkemangchuoi()
    {
        string[] monan = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",  "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",  "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" }; 
        // a. Tìm các phần tử có chiều dài ngắn nhất và dài nhất
        Console.WriteLine("Cac mon an co chieu dai ngan nhat va dai nhat:");
        int dodainhonhat = monan.Min(mon => mon.Length); //Length tính cả khoảng trắng trong tên món
        int dodailonnhat = monan.Max(mon => mon.Length);
        var monngannhat = monan.Where(mon => mon.Length == dodainhonhat);
        var mondainhat = monan.Where(mon => mon.Length == dodailonnhat);
        Console.WriteLine($"Chieu dai ngan nhat: {dodainhonhat}");
        Console.Write("Mon ngan nhat: ");
        foreach (var mon in monngannhat)
        {
            Console.Write(mon + ", ");
        }
        Console.WriteLine();
        Console.WriteLine($"Chieu dai dai nhat: {dodailonnhat}");
        Console.Write("Mon dai nhat: ");
        foreach (var mon in mondainhat)
        {
            Console.Write(mon + ", ");
        }
        Console.WriteLine();
        // b. Phân nhóm theo từ đầu tiên của tên món
        Console.WriteLine("Phan nhom theo tu dau tien:");
        var nhommonan = monan.GroupBy(mon => mon.Split(' ')[0]) //tách tên món thành các từ dựa trên khoảng trắng
        .OrderBy(nhom => nhom.Key);
        foreach (var nhom in nhommonan)
        {
            Console.WriteLine("Nhom "+ nhom.Key + ":");
            foreach (var mon in nhom)
            {
                Console.WriteLine(mon);
            }
        }
        Console.WriteLine();
        // c. Đếm số phần tử có từ đầu tiên là "Bánh"
        Console.WriteLine("So mon an co tu dau tien la 'Bánh':");
        int somonbanh = monan.Count(mon => mon.StartsWith("Bánh"));
        Console.WriteLine("Co " + somonbanh + " mon");
    }
}