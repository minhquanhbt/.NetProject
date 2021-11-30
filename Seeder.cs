using _102190333_NguyenMinhQuan.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190333_NguyenMinhQuan
{
    class Seeder : CreateDatabaseIfNotExists<CKdb102190333>
    {
        protected override void Seed(CKdb102190333 context)
        {
            context.MonAns.AddRange(new MonAn[]
            {
                new MonAn {MaMonAn=1, TenMonAn = "TrungChien"},
                new MonAn {MaMonAn=2,TenMonAn = "ThitVien"},
                new MonAn {MaMonAn=3,TenMonAn = "Pasta"},
            });

            context.NguyenLieus.AddRange(new NguyenLieu[]
            {
                new NguyenLieu {MaNguyenLieu=1, TenNguyenLieu = "A", TinhTrang = true},
                new NguyenLieu {MaNguyenLieu=2, TenNguyenLieu = "B", TinhTrang = true},
                new NguyenLieu {MaNguyenLieu=3, TenNguyenLieu = "C", TinhTrang = true},
            });
            context.MonAnNguyenLieus.AddRange(new MonAnNguyenLieu[]
{
                new MonAnNguyenLieu {Ma = "10001", SoLuong = 2, DonViTinh = "Gram",MaMonAn = 1, MaNguyenLieu =1},
                new MonAnNguyenLieu {Ma = "10002", SoLuong = 4, DonViTinh = "Cu",MaMonAn = 2, MaNguyenLieu =2},
                new MonAnNguyenLieu {Ma = "10003", SoLuong = 6, DonViTinh = "ml",MaMonAn = 3, MaNguyenLieu =3},
});
        }
    }
}
