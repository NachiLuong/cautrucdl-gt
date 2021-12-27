using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class Flight //: IComparable<Flight>
    {
        public string maChuyenBay { get; set; }
        public DateTime TGKhoiHanh { get; set; }
        public string tenCoTruong { get; set; }
        public string diemDau { get; set; }
        public string diemCuoi { get; set; }
        public double giaVeMacDinh { get; set; }
        public string tenho { get; set; }
        public Flight() { }
        public Flight(Flight cb)
        {
            this.maChuyenBay = cb.maChuyenBay;
            this.TGKhoiHanh = cb.TGKhoiHanh;
            this.tenCoTruong = cb.tenCoTruong;
            this.diemDau = cb.diemDau;
            this.diemCuoi = cb.diemCuoi;
            this.giaVeMacDinh = cb.giaVeMacDinh;
        }
        public Flight(string maChuyenBay, DateTime TGKhoiHanh, string tenCoTruong,
            string diemDau, string diemCuoi, double giaVeMacDinh)
        {
            this.maChuyenBay = maChuyenBay;
            this.TGKhoiHanh = TGKhoiHanh;
            this.tenCoTruong = tenCoTruong;
            this.diemCuoi = diemCuoi;
            this.diemDau = diemDau;
            this.giaVeMacDinh = giaVeMacDinh;
            this.tenho = Reverse(tenCoTruong);
        }
        public override string ToString()
        {
            return maChuyenBay + "_" + tenCoTruong + "_" + diemDau;
        }

        // Đảo ngược họ tên cơ trưởng
        // Nguyễn Nam Liên -> Liên Nam Nguyễn
        public string Reverse(string tenCoTruong)
        {
            this.tenCoTruong = tenCoTruong;
            tenCoTruong = tenCoTruong.Trim();//loai khoang trang thua

            string[] chuoi_tach = tenCoTruong.Split(' ');//tach chuoi
            int len = chuoi_tach.Length;

            string tenho = "";
            for (int i = len - 1; i >= 0; i--)//gộp chuỗi đã tách và đảo ngược vị trí
            {
                tenho += chuoi_tach[i] + " ";
            }
            tenho = tenho.Trim();
            return tenho;
        }

    }
}
