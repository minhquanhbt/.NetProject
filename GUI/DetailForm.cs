using _102190333_NguyenMinhQuan.BLL;
using _102190333_NguyenMinhQuan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102190333_NguyenMinhQuan.GUI
{
    public partial class NguyenMinhQuan_DF : Form
    {
        private string MaMANL;
        private string TNL;
        private int SL;
        private string DVT;
        private bool TT;
        private bool mode;
        public delegate void MyDel(int ID, string name);
        public MyDel d { get; set; }
        public NguyenMinhQuan_DF(string st,string tnl, int sl, string dvt, bool tt)
        {
            InitializeComponent();
            MaMANL = st;
            TNL = tnl;
            SL = sl;
            DVT = dvt;
            TT = tt;
            mode = false;
            SetCBB();
            setGUI();
        }
        public NguyenMinhQuan_DF()
        {
            InitializeComponent();
            mode = true;
            SetCBB();
        }
        private void setGUI()
        {
            txtMa.Text = MaMANL;
            txtMa.ReadOnly = true;
            txtSL.Text = SL.ToString();
            txtDVT.Text = DVT;
            int index = 0;
            for (int i = 0; i < cbbTenNL.Items.Count; i++)
                if (((CBBItem)cbbTenNL.Items[i]).Text == TNL)
                {
                    index = i;
                    break;
                }
            cbbTenNL.SelectedIndex = index;
            if(TT)
            {
                cbbTT.SelectedIndex = 0;
            }
            else
            {
                cbbTT.SelectedIndex = 1;
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetCBB()
        {
            cbbTenNL.Items.AddRange(BLL_CuoiKy.Instance.GetCBBTenNL().ToArray());
            List<CBBItem> tmp = new List<CBBItem>();
            tmp.Add(new CBBItem
            {
                Value = 1,
                Text = "Đã nhập hàng"
            });
            tmp.Add(new CBBItem
            {
                Value = 0,
                Text = "Chưa nhập hàng"
            });
            cbbTT.Items.AddRange(tmp.ToArray());
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtMa.Text == null) || (txtDVT.Text == null) || (txtSL.Text == null))
                {
                    throw new ArgumentNullException("Null Exception");
                }
                else
                {
                    LView i = new LView();
                    i.setMa(txtMa.Text);
                    i.TenNguyenLieu = ((CBBItem)cbbTenNL.SelectedItem).Text;
                    i.SoLuong = Convert.ToInt32(txtSL.Text);
                    i.DonViTinh = txtDVT.Text;
                    i.TinhTrang = Convert.ToBoolean(((CBBItem)cbbTT.SelectedItem).Value);
                    if (!BLL_CuoiKy.Instance.ExecuteDB_BLL(i, mode))
                    {
                        throw new Exception("Error");
                    }
                    //BLL_QLSV.Instance.ExecuteDB_BLL(i);
                    d(0, null);
                    this.Dispose();
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Enter Information!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error during updating");
            }
        }
    }
}
