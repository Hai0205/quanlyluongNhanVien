using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TienLuongNhanVien
{
    class NhanVien
    {
        private string MSNV;
        private string HoTen;
        protected int NgayCong;
        public NhanVien()
        {
            MSNV = "Null";
            HoTen = "Null";
            NgayCong = 0;
        }
        public NhanVien(string ms, string hoten, int nc)
        {
            this.MSNV = ms;
            this.HoTen = hoten;
            this.NgayCong = nc;
        }
        public NhanVien(NhanVien a)
        {
            this.MSNV = a.MSNV;
            this.HoTen = a.HoTen;
            this.NgayCong = a.NgayCong;
        }
        virtual public void ganMSNV(string msnv)
        {
            MSNV = msnv;
        }
        virtual public void ganHoTen(string ht)
        {
            HoTen = ht;
        }
        virtual public void ganNgayCong(int nc)
        {
            NgayCong = nc;
        }
        virtual public string layMSNV()
        {
            return MSNV;
        }
        virtual public string layHoTen()
        {
            return HoTen;
        }
        virtual public int layNgayCong()
        {
            return NgayCong;
        }
        public int TinhNgayCong()
        {
            if (NgayCong < 20)
                return NgayCong - NgayCong * 10 / 100;
            else
                if (NgayCong > 26)
                    return 26 + (NgayCong - 26) * 2;
                else return NgayCong;
        }
        virtual public double TienLuong()
        {
            return TinhNgayCong();
        }
        virtual public void Nhap()
        {
            Console.Write("Nhap MSNV: ");
            MSNV = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap ngay cong: ");
            string strNC = Console.ReadLine();
            while ((!int.TryParse(strNC, out NgayCong)) || NgayCong < 0)
            {
                Console.WriteLine("Loi nhap ngay cong !");
                Console.Write("Nhap ngay cong: ");
                strNC = Console.ReadLine();
            }
        }
        virtual public void HienThi()
        {
            // Console.WriteLine("Thong Tin !");
            Console.WriteLine("MSNV: " + MSNV);
            Console.WriteLine("Ho Ten: " + HoTen);
            Console.WriteLine("Ngay Cong: " + TinhNgayCong());
        }
    }
}