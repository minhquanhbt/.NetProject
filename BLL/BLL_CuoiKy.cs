using _102190333_NguyenMinhQuan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190333_NguyenMinhQuan.BLL
{
    class BLL_CuoiKy
    {
        private static BLL_CuoiKy _Instance;
        public static BLL_CuoiKy Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_CuoiKy();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        public BLL_CuoiKy()
        {
        }
        public List<CBBItem> GetCBBItem()
        {
            List<CBBItem> data = new List<CBBItem>();
            data.Add(new CBBItem { Value = 0, Text = "All" });
            foreach (MonAn i in GetAllMA())
            {
                data.Add(new CBBItem
                {
                    Value = i.MaMonAn,
                    Text = i.TenMonAn
                });

            }
            return data;
        }
        public List<CBBItem> GetCBBTenNL()
        {
            List<NguyenLieu> data;
            using (CKdb102190333 db = new CKdb102190333())
            {
                data = db.NguyenLieus.ToList();
            }
            List<CBBItem> result = new List<CBBItem>();
            foreach (NguyenLieu i in data)
            {
                result.Add(new CBBItem
                {
                    Value = i.MaNguyenLieu,
                    Text = i.TenNguyenLieu
                });
            }
            return result;
        }
        public List<MonAn> GetAllMA()
        {
            using (CKdb102190333 db = new CKdb102190333())
            {
                return db.MonAns.ToList();
            }
        }
        public List<LView> GetAllMANL()
        {
            using (CKdb102190333 db = new CKdb102190333())
            {
                var query = (from m in db.MonAnNguyenLieus
                             join a in db.MonAns on m.MaMonAn equals a.MaMonAn
                             join n in db.NguyenLieus on m.MaNguyenLieu equals n.MaNguyenLieu
                             select new
                             {
                                MaMANL = m.Ma,
                               TenNguyenLieu = n.TenNguyenLieu,
                               SoLuong = m.SoLuong,
                               DonViTinh = m.DonViTinh,
                               TinhTrang = n.TinhTrang});
                List<LView> data = new List<LView>();
                int i=1;
                foreach (var item in query)
                {
                    LView t = new LView();
                    t.setMa(item.MaMANL);
                    t.TenNguyenLieu = item.TenNguyenLieu;
                    t.SoLuong = item.SoLuong;
                    t.DonViTinh = item.DonViTinh;
                    t.TinhTrang = item.TinhTrang;
                    t.STT = i; i++;
                    data.Add(t);
                }
                return data;
            }
        }
        public MonAnNguyenLieu getMANLLByMaNL(string ma)
        {
            try
            {
                using (CKdb102190333 db = new CKdb102190333())
                {
                    MonAnNguyenLieu res = db.MonAnNguyenLieus.Find(ma);
                    if (res != null)
                    {
                        return res;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<LView> GetListMANLByMaMA(int ID, string name)
        {
            CKdb102190333 db = new CKdb102190333();
            List<LView> data = new List<LView>();
            //Lay du lieu ra
            if (ID == 0)
            {
                data = GetAllMANL();
            }
            else
            {
                var query = (from m in db.MonAnNguyenLieus
                             join a in db.MonAns on m.MaMonAn equals a.MaMonAn
                             join n in db.NguyenLieus on m.MaNguyenLieu equals n.MaNguyenLieu
                             select new
                             {
                                 MaMANL = m.Ma,
                                 MaMonAn = a.MaMonAn,
                                 TenNguyenLieu = n.TenNguyenLieu,
                                 SoLuong = m.SoLuong,
                                 DonViTinh = m.DonViTinh,
                                 TinhTrang = n.TinhTrang
                             }).Where(a => a.MaMonAn == ID);
                int i = 1;
                foreach (var item in query)
                {
                    LView t = new LView();
                    t.setMa(item.MaMANL);
                    t.TenNguyenLieu = item.TenNguyenLieu;
                    t.SoLuong = item.SoLuong;
                    t.DonViTinh = item.DonViTinh;
                    t.TinhTrang = item.TinhTrang;
                    t.STT = i;i++;
                    data.Add(t);
                }
            }
            if(name != null)
            {
                List<LView> res = new List<LView>();
                res.AddRange(data);
                foreach (LView item in res)
                {
                    int t;
                    if (Int32.TryParse(name, out t))
                    {

                        if(t != item.SoLuong)
                        {
                            data.Remove(item);
                            continue;
                        }
                    }
                    else
                    if (!(item.TenNguyenLieu.Contains(name)))
                        if (!(item.DonViTinh.Contains(name)))
                            {
                                data.Remove(item);
                            }
                }
            }
            return data;
        }
        public bool ExecuteDB_BLL(LView t, bool Mode)
        {
            try
            {
                CKdb102190333 db = new CKdb102190333();
                //Add
                if (Mode)
                {
                    NguyenLieu s = new NguyenLieu();
                    s.TenNguyenLieu = t.TenNguyenLieu;
                    s.TinhTrang = t.TinhTrang;
                    db.NguyenLieus.Add(s);
                    db.SaveChanges();
                    MonAnNguyenLieu m = new MonAnNguyenLieu();
                    int MaNL = db.NguyenLieus.Count()+1;
                    m.Ma = t.getMa();
                    m.DonViTinh = t.DonViTinh;
                    m.SoLuong = t.SoLuong;
                    m.MaNguyenLieu = MaNL;
                    m.MaMonAn = 1;
                    db.MonAnNguyenLieus.Add(m);
                    db.SaveChanges();
                    return true;
                }
                //Edit
                else
                {
                    MonAnNguyenLieu m = db.MonAnNguyenLieus.Find(t.getMa());
                    m.DonViTinh = t.DonViTinh;
                    m.SoLuong = t.SoLuong;
                    int MaNL = m.MaNguyenLieu;
                    NguyenLieu s = db.NguyenLieus.Find(MaNL);
                    s.TenNguyenLieu = t.TenNguyenLieu;
                    s.TinhTrang = t.TinhTrang;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DelMA_BLL(List<string> lmssv)
        {
            CKdb102190333 db = new CKdb102190333();
            try
            {
                foreach (string s in lmssv)
                {
                    MonAnNguyenLieu t = db.MonAnNguyenLieus.Find(s);
                    NguyenLieu nl = db.NguyenLieus.Find(t.MaNguyenLieu);
                    db.MonAnNguyenLieus.Remove(t);
                    db.NguyenLieus.Remove(nl);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public delegate int Compare(LView o1, LView o2);
        public List<LView> SortMA(int ID, string name, Compare cmp)
        {
            List<LView> l = GetListMANLByMaMA(ID, name);
            l.Sort((x, y) => cmp(x, y));
            return l;
        }
    }
}
