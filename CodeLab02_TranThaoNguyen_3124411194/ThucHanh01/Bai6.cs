/*Tìm giá trị lớn nhất*/
using System;
namespace TH01 
{
    public class Bai6
    {
        public static int timmax(int a,int b,int c)
        {
            int max = a;
            if(max<b)
            {
            max=b;
            }
            if(max<c)
            {
            max=c;
            }
            return max;
        }
    }
}