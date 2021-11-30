using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190333_NguyenMinhQuan.DTO
{
    public class NguyenLieu
    {
        public NguyenLieu()
        {
            MonAnNguyenLieus = new HashSet<MonAnNguyenLieu>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public bool TinhTrang { get; set; }
        public virtual ICollection<MonAnNguyenLieu> MonAnNguyenLieus { get; set; }
    }
}
