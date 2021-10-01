using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TienLuongNhanVien
{
    class CongNhan : NhanVien
    {
        private int DonGia = 125000;
        public CongNhan()
            : base()
        {
        }
        public CongNhan(string ms, string hoten, int nc)
            : base(ms, hoten, nc)
        {
        }
        public CongNhan(CongNhan a)
            : base(a)
        {
        }
        public override void ganMSNV(string msnv)
        {
            base.ganMSNV(msnv);
        }
        public override void ganHoTen(string ht)
        {
            base.ganHoTen(ht);
        }
        public override void ganNgayCong(int nc)
        {
            base.ganNgayCong(nc);
        }
        public override string layMSNV()
        {
            return base.layMSNV();
        }
        public override string layHoTen()
        {
            return base.layHoTen();
        }
        public override int layNgayCong()
        {
            return base.layNgayCong();
        }
        public override double TienLuong()
        {
            return base.TienLuong() * DonGia;
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin cong nhan !");
            base.Nhap();
        }
        public override void HienThi()
        {
            Console.WriteLine("Thong Tin Cong Nhan !");
            base.HienThi();
            Console.WriteLine("Tien luong: " + TienLuong().ToString("#,##0.00 d"));
        }
    }
}