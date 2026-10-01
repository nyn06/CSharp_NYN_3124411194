/*Đảo chuỗi*/
using System;
namespace TH01
{
    public class Bai11
    {
        public static string Daochuoi(string s)
        {
            string kq ="";
            for(int i=s.Length - 1; i>=0; i--)
            {
                kq = kq + s[i];
            }
            return kq;
        }
    }
}