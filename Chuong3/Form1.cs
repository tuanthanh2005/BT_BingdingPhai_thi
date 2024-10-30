using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Chuong3
{
    public partial class Form1 : Form
    {

        string strcon = @"Server=THANHTUAN; database=QLSV_Tuann_L1; Integrated Security =True";
        DataSet ds = new DataSet();
        //
        SqlDataAdapter adpSinhVien, adpKhoa, adpKetQua;
        //
        SqlCommandBuilder cmdSinhVien;
        BindingSource bs = new BindingSource();
        int stt = 0;
        public Form1()
        {
            InitializeComponent();
            bs.CurrentChanged += Bs_CurrentChanged;
        }

        private void Bs_CurrentChanged(object sender, EventArgs e)
        {
            lblSTT.Text = bs.Position + 1 + "/" + bs.Count;
            txtTDiem.Text = TongDiem(txtMasv.Text).ToString();
        }
        private Double TongDiem(string MSV)
        {
            double kq = 0;
            Object td = ds.Tables["KETQUA"].Compute("sum(Diem)", "MaSV='" + MSV + "'");

            if (td == DBNull.Value)
                kq = 0;
            else
                kq = Convert.ToDouble(td);
            return kq;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoCacDoiTuong();
            DocDuLieu();
            MocNoiQuanHe();
            KhoiTaoBindingSoure();
            KhoiTaoCboMaKH();
            LienKetDieuKhien();
            bdnSinhVien.BindingSource = bs;
        }

        private void LienKetDieuKhien()
        {
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox && ctl.Name != "txtTDiem" && ctl.Name != "txtPhai")
                    ctl.DataBindings.Add("text", bs, ctl.Name.Substring(3), true);
                else if (ctl is ComboBox)
                    ctl.DataBindings.Add("Selectedvalue", bs, ctl.Name.Substring(3), true);
                else if (ctl is DateTimePicker)
                    ctl.DataBindings.Add("value", bs, ctl.Name.Substring(3), true);
            Binding bdPhai = new Binding("text", bs, "Phai", true);

            bdPhai.Format += BdPhai_Format;
            bdPhai.Parse += BdPhai_Parse;
            txtPhai.DataBindings.Add(bdPhai);
        }

        private void BdPhai_Parse(object sender, ConvertEventArgs e)
        {
            if (e.Value == null) return;
            e.Value = e.Value.ToString().ToUpper() == "NAM" ? true : false;
        }

        private void BdPhai_Format(object sender, ConvertEventArgs e)
        {
            if (e.Value == DBNull.Value || e.Value == null) return;
            e.Value = (Boolean)e.Value ? "Nam" : "Nữ";
        }

        private void KhoiTaoCboMaKH()
        {
            cboMaKH.DisplayMember = "TenKH";
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.DataSource = ds.Tables["KHOA"];
        }

        private void KhoiTaoBindingSoure()
        {
            bs.DataSource = ds;
            bs.DataMember = "SINHVIEN";
        }

        private void MocNoiQuanHe()
        {
            ds.Relations.Add("FK_KH_SV", ds.Tables["KHOA"].Columns["MaKH"], ds.Tables["SINHVIEN"].Columns["MaKH"], true);

            ds.Relations.Add("FK_SV_KQ", ds.Tables["SINHVIEN"].Columns["MaSV"], ds.Tables["KETQUA"].Columns["MaSV"], true);

            ds.Relations["FK_KH_SV"].ChildKeyConstraint.DeleteRule = Rule.None;
            ds.Relations["FK_SV_KQ"].ChildKeyConstraint.DeleteRule = Rule.None;
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            if (txtMasv.ReadOnly==false)
            {
                DataRow r = ds.Tables["SINHVIEN"].Rows.Find(txtMasv.Text);
                if (r!=null)
                {
                    MessageBox.Show("Masv Bị Trùng.Mời nhập lại", "Trùng Khoá chính");
                    txtMasv.Focus();
                    return;
                }
            }
            bs.EndEdit();
            int n = adpSinhVien.Update(ds, "SINHVIEN");
            if (n>0)
            {
                MessageBox.Show("Cập Nhật(thêm/sửa)Thành Công");
                txtMasv.ReadOnly = true;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtMasv.ReadOnly = false;

            bs.AddNew();
            cboMaKH.SelectedIndex = 0;
            dtpNgaySinh.Value = new DateTime(2006, 1, 1);
            txtMasv.Focus();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            DataRow rsv = (bs.Current as DataRowView).Row;
            DataRow[] Mang_Lien_Quan = rsv.GetChildRows("FK_SV_KQ");
            if (Mang_Lien_Quan.Length > 0)
                MessageBox.Show("Không thể xoá sinh viên đã có kết quả");
            else
            {
                DialogResult tl;
                tl = MessageBox.Show("Xoá Sinh Viên Này Không", "Cẩn Thận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl==DialogResult.Yes)
                {
                    bs.RemoveCurrent();
                    int n = adpSinhVien.Update(ds, "SINHVIEN");
                    if (n > 0)
                        MessageBox.Show("Xoá SV Thành Công");

                    
                }
            }

            
        }

        private void btKhong_Click(object sender, EventArgs e)
        {
          
        }

        private void btSau_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btTruot_Click(object sender, EventArgs e)
        {
              bs.MoveNext();
        }

        private void bdnSinhVien_RefreshItems(object sender, EventArgs e)
        {

        }

        private void txtTDiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void DocDuLieu()
        {
            adpKhoa.FillSchema(ds, SchemaType.Source, "KHOA");
            adpKhoa.Fill(ds, "KHOA");

            adpSinhVien.FillSchema(ds, SchemaType.Source, "SINHVIEN");
            adpSinhVien.Fill(ds, "SINHVIEN");

            adpKetQua.FillSchema(ds, SchemaType.Source, "KETQUA");
            adpKetQua.Fill(ds, "KETQUA");
        }

        private void KhoiTaoCacDoiTuong()
        {
            adpKhoa = new SqlDataAdapter("select * from Khoa ", strcon);
            adpSinhVien = new SqlDataAdapter("select * from SinhVien ", strcon);
            adpKetQua = new SqlDataAdapter("select * from KetQua ", strcon);

            cmdSinhVien = new SqlCommandBuilder(adpSinhVien);
        }
    }
}
