/*Bài 16*/
using System;
namespace TH01
{
    public class Bai16
    {
        public void Nhapmang(string[] a)
        {
            for(int i=0;i<a.Length; i++)
            {
                Console.Write("Nhap ho ten nguoi thu "+(i+1)+": ");
                a[i]=Console.ReadLine()!;
            }
        }
        public void Xuatmang(string[] a)
        {
            for(int i=0;i<a.Length;i++)
            Console.WriteLine(a[i]);
        }
        // Sắp xếp mảng theo thứ tự tăng dần 
        public void Sapxep(string[] a)
        {
            for(int i=0;i<a.Length-1;i++)
            {
                for(int j =i+1;j<a.Length;j++)
                {
                    if(string.Compare(a[i],a[j])>0) // Nếu tên ở vị trí i đứng sau tên ở vị trí j trong bảng chữ cái thì đổi chỗ
                    {
                        string tam = a[i];
                        a[i]=a[j];
                        a[j]=tam;
                    }
                }
            }
        }
    }
}