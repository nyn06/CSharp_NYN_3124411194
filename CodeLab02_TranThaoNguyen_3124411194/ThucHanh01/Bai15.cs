/*BÀI 15*/
using System;
namespace TH01
{
    public class Bai15
    {
        public void Nhapmang(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.Write("Nhap a["+i+"]: ");
                a[i] = int.Parse(Console.ReadLine()!);
            }
        }
        public void Xuatmang(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
        }
        // Tìm min, max
        public void Timmaxmin(int[] a, out int max, out int min)
        {
            max = a[0];
            min = a[0];

            for(int i=0; i<a.Length;i++)
            {
                if(a[i]>max)
                {
                    max=a[i];
                }
                if(a[i]<min)
                {
                    min=a[i];
                }
            }
        }
        //Kiểm tra số nguyên tố 
        public bool Lasonguyento(int n)
        {
            if(n<2)
            {
                return false;
            }

            for(int i=2;i<=Math.Sqrt(n);i++)
            {
                if(n%i==0)
                {
                    return false;
                }
            }
            return true;
        }

        //Trả về mảng các số nguyên tố 
        public int[] Timsonguyento(int[] a)
        {
            int dem=0;

            for(int i=0;i<a.Length;i++)
            {
                if(Lasonguyento(a[i]))
                {
                    dem++;
                }
            }
            //Tạo mảng có đúng số phần tử nguyên tố 
            int[] mangnguyento = new int[dem];
            int j = 0;

            for(int i=0;i<a.Length;i++)
            {
                if(Lasonguyento(a[i]))
                {
                    mangnguyento[j] = a[i];
                    j++;
                }
            }
            return mangnguyento;
        }
        
    }
}