using System;
namespace TH02
{
    class program 
    {
        static void Main(string[] args)
        {
            /*
            -- Bài 1_1 -- 
            Bai1_1 bai = new Bai1_1();
            bai.Tinhtuoi();*/
            /*
            -- Bài 1_2 --
            Point A = new Point();
            Point B = new Point();
            Console.WriteLine("Nhap diem A:");
            A.Input();
            Console.WriteLine("Nhap diem B:");
            B.Input();
            Console.WriteLine("Diem A: " + A);
            Console.WriteLine("Diem B: " + B);
            // Khoảng cách - phương thức thành viên
            double kc1 = A.KhoangCach(B);
            Console.WriteLine("Khoang cach AB (thanh vien): " + kc1);
            // Khoảng cách - phương thức tĩnh
            double kc2 = Point.KhoangCach(A, B);
            Console.WriteLine("Khoang cach AB (tinh): " + kc2);
            // Trung điểm - phương thức thành viên
            Point I1 = A.TrungDiem(B);
            Console.WriteLine("Trung diem I (thanh vien): " + I1);
            // Trung điểm - phương thức tĩnh
            Point I2 = Point.TrungDiem(A, B);
            Console.WriteLine("Trung diem I (tinh): " + I2);
            Point C = A + B;
            Console.WriteLine("\nA + B = " + C);
            Point D = A - B;
            Console.WriteLine("A - B = " + D);
            Point E = -A;
            Console.WriteLine("-A = " + E);*/
            /*
            -- Bài 1_3 --
            Person p1 = new Person();
            Console.WriteLine("Nhap thong tin Person");
            p1.Input();
            Console.WriteLine("Thong tin Person");
            p1.Output();
            Console.WriteLine("Kiem tra");
            if (p1.IsLiving())
            {
                Console.WriteLine("Nguoi nay con song.");
            }
            else
            {
                Console.WriteLine("Nguoi nay da mat.");
            }
            Person p2 = new Person(p1);
            Console.WriteLine("Person duoc sao chep");
            p2.Output();*/
            /*
            -- Bài 1_4 --
            PhanSo p1 = new PhanSo();
            PhanSo p2 = new PhanSo(2, 4);
            PhanSo p3 = new PhanSo(5);
            PhanSo p4 = new PhanSo(p2);
            Console.WriteLine("p1 = " + p1);
            Console.WriteLine("p2 = " + p2);
            Console.WriteLine("p3 = " + p3);
            Console.WriteLine("p4 = " + p4);
            Console.WriteLine("Toan tu mot ngoi");
            Console.WriteLine("+p2 = " + (+p2));
            Console.WriteLine("-p2 = " + (-p2));
            PhanSo a = new PhanSo(2, 3);
            PhanSo b = new PhanSo(1, 6);
            Console.WriteLine("Phep toan hai ngoi");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("So sanh");
            Console.WriteLine("a > b  : " + (a > b));
            Console.WriteLine("a < b  : " + (a < b));
            Console.WriteLine("a >= b : " + (a >= b));
            Console.WriteLine("a <= b : " + (a <= b));
            Console.WriteLine("a == b : " + (a == b));
            Console.WriteLine("a != b : " + (a != b)); */
            /*
            -- Bài 1_5 --
            Console.Write("Nhap he so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so mu n: ");
            int n = int.Parse(Console.ReadLine());
            DonThuc p = new DonThuc(a, n);
            Console.WriteLine("Don thuc P(x) = " + p);
            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("P(" + x + ") = " + p.TinhGiaTri(x));
            DonThuc q = p.DaoHam();
            Console.WriteLine("Q(x) = P'(x) = " + q);*/
            /*
            -- Bài 2_1 --
            ArrayPoint arr = new ArrayPoint();

            // tao Point thu 0
            Point p0 = new Point();
            Console.WriteLine("Nhap Point thu 0:");
            p0.Input();
            arr.Add(p0);

            // tao Point thu 1
            Point p1 = new Point();
            Console.WriteLine("Nhap Point thu 1:");
            p1.Input();
            arr.Add(p1);

            // tao Point thu 2
            Point p2 = new Point();
            Console.WriteLine("Nhap Point thu 2:");
            p2.Input();
            arr.Add(p2);

            // truy cap Point bang Indexer
            Console.WriteLine("Point thu 0: " + arr[0]);
            Console.WriteLine("Point thu 1: " + arr[1]);
            Console.WriteLine("Point thu 2: " + arr[2]);

            // thay doi Point tai vi tri 1
            Point p3 = new Point();
            Console.WriteLine("Nhap Point moi de thay cho Point thu 1:");
            p3.Input();

            arr[1] = p3;

            Console.WriteLine("Sau khi thay doi:");
            Console.WriteLine("Point thu 1: " + arr[1]);*/
            /*
            -- Bài 2_2 --
            PersonList list = new PersonList();

            // nhap danh sach
            Console.WriteLine("Nhap danh sach Person:");
            list.Input();

            // xuat danh sach
            Console.WriteLine("\nDanh sach Person:");
            list.Output();

            // lay danh sach nguoi con song
            PersonList living = list.LivingPeople();

            Console.WriteLine("\nDanh sach nguoi con song:");
            living.Output();*/
            /*
            -- Bài 2_3 --
            Console.Write("Nhap so luong phan tu n: ");
            int n = int.Parse(Console.ReadLine());
            DaySo d = new DaySo(n);
            Console.WriteLine("Nhap day so:");
            d.Input();
            Console.WriteLine("Day so vua nhap:");
            d.Output();
            Console.WriteLine("Phan tu thu 0: " + d[0]);
            d.TimSoChan();*/
            /*
            -- Bài 2_4 Mảng 2 chiều --
            Console.Write("Nhap so dong n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine());
            Mang2Chieu a = new Mang2Chieu(n, m);
            Console.WriteLine("Nhap mang:");
            a.Input();
            Console.WriteLine("Mang vua nhap:");
            a.Output();
            // truy cap phan tu bang Indexer
            Console.WriteLine("Phan tu a[0,0]: " + a[0, 0]);
            // tim so nguyen to
            a.TimSoNguyenTo();*/
            /*
            -- Bài 2_3 Đa thức --
            Console.Write("Nhap bac cua da thuc n: ");
            int n = int.Parse(Console.ReadLine());
            DaThuc p = new DaThuc(n);
            Console.WriteLine("Nhap cac he so cua da thuc:");
            p.Input();
            Console.WriteLine("Da thuc vua nhap:");
            p.Output();
            // truy cap don thuc bang Indexer
            Console.WriteLine("Don thuc thu 0: " + p[0]);
            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());   
            Console.WriteLine("P(" + x + ") = " + p.TinhGiaTri(x));*/
            /*
            -- Bài 2_4 Dãy phân số--
            Console.Write("Nhap so luong phan so n: ");
            int n = int.Parse(Console.ReadLine());
            DayPhanSo d = new DayPhanSo(n);
            Console.WriteLine("Nhap day phan so:");
            d.Input();
            Console.WriteLine("Day phan so vua nhap:");
            d.Output();
            PhanSo tong = d.TinhTong();
            Console.WriteLine("Tong cac phan so = " + tong);*/
            /*
            -- Bài 2_5 --
            Console.Write("Nhap so luong nhan vien n: ");
            int n = int.Parse(Console.ReadLine());
            PhongBan pb = new PhongBan(n);
            Console.WriteLine("\nNhap danh sach nhan vien:");
            pb.Input();
            Console.WriteLine("\nDanh sach nhan vien:");
            pb.Output();
            double tongLuong = pb.TinhTongLuong();
            Console.WriteLine("\nTong luong cua phong ban: " + tongLuong + " VNĐ");*/
            /*
            -- Bài 3_1--
            Console.Write("Nhap so luong sinh vien n: ");
            int n = int.Parse(Console.ReadLine());
            SinhVien[] ds = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap sinh vien thu " + i + ":");
                ds[i] = new SinhVien();
                ds[i].Input();
            }
            Console.WriteLine("\nDanh sach truoc khi sap xep:");

            for (int i = 0; i < n; i++)
            {
                ds[i].Output();
                Console.WriteLine();
            }
            Array.Sort(ds);
            Console.WriteLine("Danh sach sau khi sap xep:");
            for (int i = 0; i < n; i++)
            {
                ds[i].Output();
                Console.WriteLine();
            }*/
            /*
            -- Bài 3_2 --
            Console.Write("Nhap so luong sinh vien n: ");
            int n = int.Parse(Console.ReadLine());
            SinhVien1[] ds = new SinhVien1[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap sinh vien thu " + i + ":");

                ds[i] = new SinhVien1();
                ds[i].Input();
            }
            Console.WriteLine("\nDanh sach truoc khi sap xep:");

            for (int i = 0; i < n; i++)
            {
                ds[i].Output();
                Console.WriteLine();
            }
            SoSanhSinhVien soSanh = new SoSanhSinhVien();
            SapXep.Sort(ds, soSanh);
            Console.WriteLine("Danh sach sau khi sap xep:");

            for (int i = 0; i < n; i++)
            {
                ds[i].Output();
                Console.WriteLine();
            }*/
            /*
             -- Bài 3.3 --
            Console.Write("Nhap so luong sinh vien n: ");
            int n = int.Parse(Console.ReadLine());

            SinhVien1[] ds = new SinhVien1[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap sinh vien thu " + i + ":");
                ds[i] = new SinhVien1();
                ds[i].Input();
            }

            Console.WriteLine("\nDanh sach truoc khi sap xep:");

            for (int i = 0; i < n; i++)
            {
                ds[i].Output();
                Console.WriteLine();
            }

            SapXepDelegate.Sort(ds, SoSanhSinhVien1.Compare);

            Console.WriteLine("Danh sach sau khi sap xep:");

            for (int i = 0; i < n; i++)
            {
                ds[i].Output();
                Console.WriteLine();
            }*/
            /*
            // -- Bài 3.4 --
            PTBac2Console app = new PTBac2Console();

            app.Chay();*/
        }
    }
}
