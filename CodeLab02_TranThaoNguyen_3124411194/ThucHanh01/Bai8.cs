/*Hoán vị hai số*/
using System;
namespace TH01
{
    public class Bai8 
    {
        public static void Hoanvi(ref double a, ref double b)
        {
            double tam;
            tam = a;
            a = b;
            b = tam;
        }
    }
}