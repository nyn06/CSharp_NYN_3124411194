namespace TH02
{
    public class SoSanhSinhVien : ISoSanh<SinhVien1>
    {
        // so sanh sinh vien theo diem trung binh
        public int Compare(SinhVien1 a, SinhVien1 b)
        {
            if (a.GetDiemTB() < b.GetDiemTB())
            {
                return -1;
            }

            if (a.GetDiemTB() > b.GetDiemTB())
            {
                return 1;
            }

            return 0;
        }
    }
}