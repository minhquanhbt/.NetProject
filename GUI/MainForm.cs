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
    public partial class NguyenMinhQuan_MF : Form
    {
        public NguyenMinhQuan_MF()
        {
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            cbbMonAn.Items.AddRange(BLL_CuoiKy.Instance.GetCBBItem().ToArray());
            cbbMonAn.SelectedIndex = 0;
            cbbProp.Items.Add("Tên Nguyên liệu");
            cbbProp.Items.Add("Số lượng");
            cbbProp.Items.Add("Đơn vị tính");
            cbbProp.Items.Add("Tình trạng");
            cbbProp.SelectedIndex = 0;
            show(((CBBItem)cbbMonAn.SelectedItem).Value, null);
        }
        List<LView> data=new List<LView>();
        public void show(int ID, string name)
        {
            data = BLL_CuoiKy.Instance.GetListMANLByMaMA(ID, name);
            dgvDSSV.DataSource = data;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                NguyenMinhQuan_DF f = new NguyenMinhQuan_DF();
                f.d += new NguyenMinhQuan_DF.MyDel(show);
                f.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error Adding with " + er);
            }
        }
        private void Del_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection table = dgvDSSV.SelectedRows;
                List<string> MSdel = new List<string>();
                foreach (DataGridViewRow i in table)
                {
                    MSdel.Add(data[i.Index].getMa());
                }

                if (!BLL_CuoiKy.Instance.DelMA_BLL(MSdel))
                {
                    MessageBox.Show("Could not find selected row");
                }
                show(((CBBItem)cbbMonAn.SelectedItem).Value, null);
            }
            catch (Exception)
            {
                MessageBox.Show("Can't not deleted!");
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSSV.SelectedRows.Count == 1)
                {
                    string Ma = data[dgvDSSV.SelectedRows[0].Index].getMa();
                    string tnl = data[dgvDSSV.SelectedRows[0].Index].TenNguyenLieu;
                    int sl = data[dgvDSSV.SelectedRows[0].Index].SoLuong;
                    string dvt = data[dgvDSSV.SelectedRows[0].Index].DonViTinh;
                    bool tt = data[dgvDSSV.SelectedRows[0].Index].TinhTrang;
                    NguyenMinhQuan_DF f = new NguyenMinhQuan_DF(Ma, tnl, sl, dvt, tt);
                    f.d += new NguyenMinhQuan_DF.MyDel(show);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("choose one!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Edit");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != null)
            {
                int ID = ((CBBItem)cbbMonAn.SelectedItem).Value;
                show(ID, txtSearch.Text);
            }
        }
        //public delegate bool Compare(o1, o2);
        private void SortBut_Click(object sender, EventArgs e)
        {
            int ID = ((CBBItem)cbbMonAn.SelectedItem).Value;
            try
            {
                if (cbbProp.SelectedItem == null)
                {
                    MessageBox.Show("chon muc tieu sap xep");
                }
                else
                {
                    switch (cbbProp.SelectedItem.ToString())
                    {
                        case "Tên Nguyên liệu":
                            dgvDSSV.DataSource = BLL_CuoiKy.Instance.SortMA(ID, txtSearch.Text, LView.cTen);
                            break;
                        case "Số lượng":
                            dgvDSSV.DataSource = BLL_CuoiKy.Instance.SortMA(ID, txtSearch.Text, LView.cSL);
                            break;
                        case "Đơn vị tính":
                            dgvDSSV.DataSource = BLL_CuoiKy.Instance.SortMA(ID, txtSearch.Text, LView.cDonViTinh);
                            break;
                        case "Tình trạng":
                            dgvDSSV.DataSource = BLL_CuoiKy.Instance.SortMA(ID, txtSearch.Text, LView.cTT);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Sorting");
            }
        }
    }
}
