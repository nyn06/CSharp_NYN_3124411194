/*Tìm max min*/
using System;
namespace TH01
{
    public class Bai9 
    {
        public static void Timmaxmin(double a,double b,double c, out double max, out double min)
        {
            max = a;
            min = a;

            if(b>max)
            {
                max=b;
            }
            if(c>max)
            {
                max=c;
            }
            if(b<min)
            {
                min=b;
            }
            if(c<min)
            {
                min=c;
            }
        }
    }
}