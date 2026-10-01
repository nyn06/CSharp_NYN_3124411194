/*Chuỗi đối xứng*/
using System;
namespace TH01
{
    public class Bai10 
    {
        public static bool Kiemtradoixung(string s)
        {
            for(int i=0; i<s.Length/2; i++)
            {
                if(s[i] != s[s.Length -1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
