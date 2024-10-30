using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagirdview_4
{
    public partial class Form1 : Form
    {
        string strcon = @"Server=.; database=QLSV_Tuann_L1; Integrated Security =True";
        DataSet ds = new DataSet();
        //
        SqlDataAdapter adpMonHoc, adpKhoa, adpKetQua;
        //
        SqlCommandBuilder cmdMonHoc;
        BindingSource bs = new BindingSource();
        int stt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoCacDoiTuong();
            DocDuLieu();
            MocNoiQuanHe();
            KhoiTaoBindingSoure();
            dgvMonHoc.DataSource = bs;
            //KhoiTaoCboMaKH();

            dgvMonHoc.Columns[3].Visible = false;
            LienKetDieuKhien();

            bdnMonHoc.BindingSource = bs;
        }

        private void LienKetDieuKhien()
        {
            txtmaMH.DataBindings.Add("Text", bs, "MaMH", true);

            txttenMH.DataBindings.Add("Text", bs, "TenMH", true);

            txtsoTiet.DataBindings.Add("Text", bs, "SoTiet", true);
        }

        private void KhoiTaoBindingSoure()
        {
            bs.DataSource = ds;
            bs.DataMember = "MONHOC";
        }

        private void MocNoiQuanHe()
        {


            ds.Relations.Add("FK_MH_KQ", ds.Tables["MONHOC"].Columns["MaMH"], ds.Tables["KETQUA"].Columns["MaMH"], true);

            ds.Relations["FK_MH_KQ"].ChildKeyConstraint.DeleteRule = Rule.None;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bntthem_Click(object sender, EventArgs e)
        {
            txtmaMH.ReadOnly = false;
            bs.AddNew();
            txtmaMH.Focus();
        }

        private void bntkhong_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
        }

        private void bnthuy_Click(object sender, EventArgs e)
        {
            DataRow rmh = (bs.Current as DataRowView).Row;
            DataRow[] mang_dong_lien_quan = rmh.GetChildRows("FK_MH_KQ");
            if (mang_dong_lien_quan.Length > 0)
                MessageBox.Show("khong xoa mon hoc duoc vi da co sinh vien thi", "Bao Loi", MessageBoxButtons.OK, MessageBoxIcon.Question);


            else
            {
                DialogResult tl;
                tl = MessageBox.Show("Xoa Hoc Vien Nay Khong", "Can Than", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (tl == DialogResult.OK)
                {
                    bs.RemoveCurrent();
                    int n = adpMonHoc.Update(ds, "MONHOC");
                    if (n > 0)
                    {
                        MessageBox.Show("xoa thanh cong", "Thong Bao");
                    }
                }
            }
        } 
      
 
        private void bntghi_Click(object sender, EventArgs e)
        {
            if (txtmaMH.ReadOnly==false)
            {
                DataRow r = ds.Tables["MONHOC"].Rows.Find(txtmaMH.Text);
                if (r!=null)
                {
                    MessageBox.Show("MaMH Da Ton Tai.Nhap Lai !!!", "Trung Khoa Chinh");
                    txtmaMH.Clear();
                    txtmaMH.Focus();
                    return;

                }
                // cap nhat lai
                bs.EndEdit();
                int n = adpMonHoc.Update(ds, "MONHOC");
                if (n>0)
                {
                    MessageBox.Show("Cap Nhat Thanh Cong");
                    txtmaMH.ReadOnly = true;
                }
            }
        }

        private void DocDuLieu()
        {

            adpMonHoc.FillSchema(ds, SchemaType.Source, "MONHOC");
            adpMonHoc.Fill(ds, "MONHOC");

            adpKetQua.FillSchema(ds, SchemaType.Source, "KETQUA");
            adpKetQua.Fill(ds, "KETQUA");

        
    }

        private void KhoiTaoCacDoiTuong()
        {
            adpMonHoc = new SqlDataAdapter("select * from MonHoc ", strcon);
      
            adpKetQua = new SqlDataAdapter("select * from KetQua ", strcon);

            cmdMonHoc = new SqlCommandBuilder(adpMonHoc);
        }
    }
}
