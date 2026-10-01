/*Bài 1_2*/
using System;
namespace TH02
{
    public class Point
    {
        // Field
        private double x;
        private double y;

        // Property
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        // Constructor mặc định
        public Point()
        {
            x = 0;
            y = 0;
        }

        // Nhập tọa độ
        public void Input()
        {
            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Nhap y: ");
            y = double.Parse(Console.ReadLine());
        }

        // Xuất tọa độ
        public void Output()
        {
            Console.WriteLine("({0}, {1})", x, y);
        }

        // Override ToString()
        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }

        // Phép cộng 2 điểm
        public static Point operator +(Point A, Point B)
        {
            Point C = new Point();

            C.x = A.x + B.x;
            C.y = A.y + B.y;

            return C;
        }

        // Phép trừ 2 điểm
        public static Point operator -(Point A, Point B)
        {
            Point C = new Point();

            C.x = A.x - B.x;
            C.y = A.y - B.y;

            return C;
        }

        // Phép lấy âm
        public static Point operator -(Point A)
        {
            Point C = new Point();

            C.x = -A.x;
            C.y = -A.y;

            return C;
        }

        // Khoảng cách - phương thức thành viên
        public double KhoangCach(Point B)
        {
            double dx = B.x - x;
            double dy = B.y - y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Khoảng cách - phương thức tĩnh
        public static double KhoangCach(Point A, Point B)
        {
            double dx = B.x - A.x;
            double dy = B.y - A.y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Trung điểm - phương thức thành viên
        public Point TrungDiem(Point B)
        {
            Point I = new Point();

            I.x = (x + B.x) / 2;
            I.y = (y + B.y) / 2;

            return I;
        }

        // Trung điểm - phương thức tĩnh
        public static Point TrungDiem(Point A, Point B)
        {
            Point I = new Point();

            I.x = (A.x + B.x) / 2;
            I.y = (A.y + B.y) / 2;

            return I;
        }
    }
}