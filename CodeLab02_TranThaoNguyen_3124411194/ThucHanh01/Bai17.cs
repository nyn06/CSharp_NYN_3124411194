/*Bài 17*/
using System;
namespace TH01
{
    public class Bai17
    {
        public void Mangngaunhien(int[,] a)
        {
            Random rd = new Random();
            for(int i=0;i<a.GetLength(0);i++) //dòng
            {
                for(int j=0; j<a.GetLength(1);j++) //cột
                {
                    a[i,j] = rd.Next(10,101);
                }
            }
        }

        public void Xuatmang(int[,] a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }

        public int[] Timsochan(int[,] a)
        {
            int dem=0;
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                   if(a[i,j]%2==0)
                   {
                     dem++;
                   } 
                }
            }
            int[] mangchan = new int[dem];
            int k=0;
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(a[i,j]%2==0)
                    {
                        mangchan[k]=a[i,j];
                        k++;
                    }
                }
            }
            return mangchan;
        }
        public int[] Timsole(int[,] a)
        {
            int dem=0;
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(a[i,j]%2 !=0)
                    {
                        dem++;
                    }
                }
            }
            int[] mangle=new int[dem];
            int k=0;
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(a[i,j]%2!=0)
                    {
                        mangle[k]=a[i,j];
                        k++;
                    }
                }
            }
            return mangle;
        }
        public void Xuatmang1chieu(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
        }
    }
}