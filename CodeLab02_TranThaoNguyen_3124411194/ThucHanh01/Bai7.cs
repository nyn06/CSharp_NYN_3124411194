/*Kiểm tra số nguyên tố*/
using System;
namespace TH01
{
    public class Bai7 
    {
        public static bool Kiemtranguyento(int n)
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
    }
}