using _102190333_NguyenMinhQuan.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace _102190333_NguyenMinhQuan
{
    public class CKdb102190333 : DbContext
    {
        public CKdb102190333()
            : base("name=CKdb102190333")
        {
            Database.SetInitializer<CKdb102190333>(new Seeder());
        }
        public virtual DbSet<MonAn> MonAns { get; set; }
        public virtual DbSet<NguyenLieu> NguyenLieus { get; set; }
        public virtual DbSet<MonAnNguyenLieu> MonAnNguyenLieus { get; set; }
    }
}