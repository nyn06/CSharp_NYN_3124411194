using System.Collections.Generic;

namespace BaiThucHanhLinQ;

public class DuLieu
{
    public static List<MonHoc> DS_Mon()
    {
        return new List<MonHoc>
        {
            new MonHoc
            {
                Mamon = "HP2_1",
                Tenmon = "Nền tảng C#",
                He = "KTV",
                Sotiet = 64
            },

            new MonHoc
            {
                Mamon = "HP2_2",
                Tenmon = "Công nghệ ADO.NET",
                He = "KTV",
                Sotiet = 64
            },

            new MonHoc
            {
                Mamon = "HP3_1",
                Tenmon = "Lập trình Windows Forms",
                He = "KTV",
                Sotiet = 64
            },

            new MonHoc
            {
                Mamon = "HP3_2",
                Tenmon = "Xây dựng ứng dụng Windows Forms",
                He = "KTV",
                Sotiet = 64
            },

            new MonHoc
            {
                Mamon = "HP4_1",
                Tenmon = "Lập trình Web với HTML, CSS và JavaScript",
                He = "KTV",
                Sotiet = 64
            },

            new MonHoc
            {
                Mamon = "HP4_2",
                Tenmon = "Xây dựng ứng dụng Web với ASP.NET",
                He = "KTV",
                Sotiet = 64
            },

            new MonHoc
            {
                Mamon = "HP5_1",
                Tenmon = "Lập trình CSDL SQL Server căn bản",
                He = "KTV",
                Sotiet = 64
            },

            new MonHoc
            {
                Mamon = "HP5_2",
                Tenmon = "Lập trình CSDL SQL Server nâng cao",
                He = "KTV",
                Sotiet = 64
            },

            new MonHoc
            {
                Mamon = "JLCB",
                Tenmon = "Joomla cơ bản",
                He = "CD",
                Sotiet = 72
            },

            new MonHoc
            {
                Mamon = "LINQ",
                Tenmon = "Language-Integrated Query",
                He = "CD",
                Sotiet = 64
            },

            new MonHoc
            {
                Mamon = "DAWEB",
                Tenmon = "Đồ án thực tế Web với ASP.NET",
                He = "CD",
                Sotiet = 40
            },

            new MonHoc
            {
                Mamon = "DAWIN",
                Tenmon = "Đồ án thực tế Windows Forms",
                He = "CD",
                Sotiet = 40
            },

            new MonHoc
            {
                Mamon = "CC++",
                Tenmon = "Lập trình hướng đối tượng với C/C++",
                He = "CD",
                Sotiet = 128
            },

            new MonHoc
            {
                Mamon = "JQUE",
                Tenmon = "JQuery",
                He = "CD",
                Sotiet = 22
            },

            new MonHoc
            {
                Mamon = "XML",
                Tenmon = "Công nghệ XML",
                He = "CD",
                Sotiet = 32
            },

            new MonHoc
            {
                Mamon = "CRYS",
                Tenmon = "Crystal Report trong Visual Studio",
                He = "CD",
                Sotiet = 32
            },

            new MonHoc
            {
                Mamon = "BWEB",
                Tenmon = "HTML, CSS và JavaScript",
                He = "CD",
                Sotiet = 32
            },

            new MonHoc
            {
                Mamon = "XYZ",
                Tenmon = "Chưa đặt tên môn",
                He = "",
                Sotiet = 0
            }
        };
    } 

    public static List<He> DS_He()
    {
        return new List<He>
        {
            new He
            {
                MaHe = "KTV",
                TenHe = "Kỹ thuật viên"
            },

            new He
            {
                MaHe = "CD",
                TenHe = "Chuyên đề"
            },

            new He
            {
                MaHe = "QT",
                TenHe = "Chứng chỉ quốc tế"
            }
        };
    }
}