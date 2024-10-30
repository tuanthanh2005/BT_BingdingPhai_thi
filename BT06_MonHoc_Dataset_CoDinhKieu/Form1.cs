using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT06_MonHoc_Dataset_CoDinhKieu
{
    public partial class Form1 : Form
    {
        DataSet2 ds = new DataSet2();
        DataSet2TableAdapters.MONHOCTableAdapter adpMONHOC = new DataSet2TableAdapters.MONHOCTableAdapter();
        DataSet2TableAdapters.KETQUATableAdapter adpKetQua = new DataSet2TableAdapters.KETQUATableAdapter();
        BindingSource bs = new BindingSource();
        int stt = 1;
        
        public Form1()
        {
            InitializeComponent();
            bs.CurrentChanged += Bs_CurrentChanged;
        }

        private void Bs_CurrentChanged(object sender, EventArgs e)
        {
            lblstt.Text = bs.Position + 1 + "/" + bs.Count;
            string mmh = txtMamh.Text;
            DemTSSV(txtMamh.Text);
            txtDiemlonnhat.Text = LayDiemLonNhat(mmh).ToString();           
            btDau.Enabled = bs.Position > 0;
            btTruot.Enabled = btDau.Enabled;
            btSau.Enabled = bs.Position < bs.Count - 1;
            btCuoi.Enabled = btSau.Enabled;
        }

        private void DemTSSV(string mmh)
        {
            if (string.IsNullOrEmpty(mmh))
            {
                txtTSSV.Text = "0";
                return;
            }

            int tssv = (int)ds.Tables["KETQUA"].Compute("COUNT(MaSV)", "MaMH='" + mmh + "'");

            txtTSSV.Text = tssv.ToString();

            var sinhViens = ds.Tables["KETQUA"].AsEnumerable()
                .Where(row => row.Field<string>("MaMH") == mmh)
                .Select(row => row.Field<string>("MaSV"))
                .Distinct();

            string danhSachSinhVien = string.Join(", ", sinhViens);
            txtTSSV.Text += "";
        }

        private object LayDiemLonNhat(string mmh)
        {
            if (string.IsNullOrEmpty(mmh))
            {
                return 0;
            }
            object diemLonNhat = ds.Tables["KETQUA"].Compute("MAX(Diem)", "MaMH='" + mmh + "'");

            return diemLonNhat != DBNull.Value ? Convert.ToInt32(diemLonNhat) : 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Do_Du_Lieu();
            Khoi_Tao_BidingSoure();
            Lien_ket_dieu_khien();
            bdnmonhoc.BindingSource = bs;
            

        }

        private void Khoi_Tao_BidingSoure()
        {
            bs.DataSource = ds;
            bs.DataMember = ds.MONHOC.TableName;
        }

        private void Lien_ket_dieu_khien()
        {

            foreach (Control ctl in this.Controls)
                if (ctl is TextBox && ctl.Name != "txtDiemlonnhat" && ctl.Name != "txtTSSV" && ctl.Name != "txtLoaimon")
                    ctl.DataBindings.Add("text", bs, ctl.Name.Substring(3), true);

            Binding bdLoaimh = new Binding("text", bs, "Loaimh", true);

            bdLoaimh.Format += BdLoaimh_format;
            bdLoaimh.Parse += BdLoaimh_Parse;
            txtLoaimon.DataBindings.Add(bdLoaimh);
        }

        private void BdLoaimh_Parse(object sender, ConvertEventArgs e)
        {
            if (e.Value == null) return;
            e.Value = e.Value.ToString().ToUpper() == "BAT BUOT" ? true : false;
        }

        private void BdLoaimh_format(object sender, ConvertEventArgs e)
        {
            if (e.Value == DBNull.Value || e.Value == null) return;
            e.Value = (Boolean)e.Value ? "Bat buoc" : "Tuy Chon";
        }

        private void Do_Du_Lieu()
        {
            adpMONHOC.Fill(ds.MONHOC);
            adpKetQua.Fill(ds.KETQUA);
        }

        private void btSau_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btDau_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                bs.MoveFirst();
            }
        }

        private void btCuoi_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                bs.MoveLast();
            }
        }

        private void btTruot_Click(object sender, EventArgs e)
        {
            
            bs.MovePrevious();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtMamh.ReadOnly = false;
            stt = bs.Position;
            bs.AddNew();
            txtMamh.Focus();
        }

        private void btKhong_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            bs.Position=stt;
            txtMamh.ReadOnly = true;

        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            if (txtMamh.ReadOnly==false)
            {
                DataSet2.MONHOCRow rmh = ds.MONHOC.FindByMaMH(txtMamh.Text);
                if (rmh!=null)
                {
                    MessageBox.Show("mamh bij trung , khong the xoa ", " thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    txtMamh.Clear();
                    txtMamh.Focus();
                    return;

                }
            }
            txtMamh.ReadOnly = true;
            bs.EndEdit();
            int n = adpMONHOC.Update(ds.MONHOC);
            if (n>0)
            {
                MessageBox.Show(" Cap Nhat Thanh Cong Sua / Xoa");
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            DataSet2.MONHOCRow rmh = (bs.Current as DataRowView).Row as DataSet2.MONHOCRow;
            if (rmh.GetKETQUARows().Length>0)
            {
                MessageBox.Show("Mon hoc nay co sv du thi , khong the xoa ");
                return;
            }
            DialogResult tl;
            tl = MessageBox.Show("Xoa Hoc Vien Nay Khong", "Can Than", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                bs.RemoveCurrent();
                int n = adpMONHOC.Update(ds.MONHOC);
                if (n > 0)
                {
                    MessageBox.Show("xoa thanh cong", "Thong Bao");
                }
            }
        }

        private void txtTSSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
