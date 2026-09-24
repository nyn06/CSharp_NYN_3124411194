namespace TH02
{
    public delegate int SoSanh<T>(T a, T b);

    public class SapXepDelegate
    {
        // sap xep mang tang dan
        public static void Sort<T>(T[] a, SoSanh<T> soSanh)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (soSanh(a[i], a[j]) > 0)
                    {
                        T temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }
}