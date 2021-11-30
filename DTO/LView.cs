using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190333_NguyenMinhQuan.DTO
{
    public class LView
    {
        public int STT { get; set; }
        private string MaMANL {get ; set; }
        public string TenNguyenLieu { get; set; }
        public int SoLuong { get; set; }
        public string DonViTinh{ get; set; }
        public bool TinhTrang { get; set; }
        
        public string getMa()
        {
            return this.MaMANL;
        }
        public void setMa(string ma)
        {
            this.MaMANL = ma;
        }
        public static int cTen(LView s1, LView s2)
        {
            return string.Compare(s1.TenNguyenLieu, s2.TenNguyenLieu);
        }
        public static int cDonViTinh(LView s1, LView s2)
        {
            return string.Compare(s1.DonViTinh, s2.DonViTinh);
        }
        public static int cSL(LView s1, LView s2)
        {
            if (s1.SoLuong > s2.SoLuong) return 1;
            if (s1.SoLuong == s2.SoLuong) return 0;
            return -1;
        }
        public static int cTT(LView s1, LView s2)
        {
            if (s1.TinhTrang == s2.TinhTrang) return 0;
            if (s2.TinhTrang == false) return 1;
            return -1;
        }
    }
}
