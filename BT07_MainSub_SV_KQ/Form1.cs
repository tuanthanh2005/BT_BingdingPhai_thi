using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT07_MainSub_SV_KQ
{
    public partial class Form1 : Form
    {
  
        DSSV1 ds = new DSSV1();
        DSSV1TableAdapters.KHOATableAdapter adpKhoa = new DSSV1TableAdapters.KHOATableAdapter();
        DSSV1TableAdapters.SINHVIENTableAdapter adpSinhVien = new DSSV1TableAdapters.SINHVIENTableAdapter();
        DSSV1TableAdapters.KETQUATableAdapter adpKetQua = new DSSV1TableAdapters.KETQUATableAdapter();
        DSSV1TableAdapters.MONHOCTableAdapter adpMonHoc = new DSSV1TableAdapters.MONHOCTableAdapter();
        BindingSource bsSV = new BindingSource();
        BindingSource bsKQ = new BindingSource();
        int stt = 1;

        public Form1()
        {
            InitializeComponent();
            bsSV.CurrentChanged += bsSV_currentchange;
        }

        private void bsSV_currentchange(object sender, EventArgs e)
        {
            bdnSinhVien.BindingSource = bsSV;
            lblSTT.Text = (bsSV.Position + 1) + "/" + bsSV.Count;
            txtTongDiem.Text = TongDiem(txtMasv.Text).ToString();
            btTruot.Enabled = bsSV.Position > 0;
            //btTruot.Enabled = btSau.Enabled;
            btSau.Enabled = bsSV.Position < bsSV.Count - 1;
            //btSau.Enabled = btSau.Enabled;
        }

        private object TongDiem(string MSV)
        {
            double kq = 0;
            Object td = ds.Tables["KETQUA"].Compute("sum(Diem)", "Masv='" + MSV + "'");
        
                if (td == DBNull.Value)
                kq = 0;
            else
                kq = Convert.ToDouble(td);
            return kq;

            
        }

        private void btSau_Click(object sender, EventArgs e)
        {
            bsSV.MoveNext();
        }

        private void btTruot_Click(object sender, EventArgs e)
        {

            bsSV.MovePrevious();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Doc_Du_Lieu();
            Lien_Ket_Dieu_Khien();
            txtTongDiem.Text = TongDiem(txtMasv.Text).ToString();


        }

        private void Lien_Ket_Dieu_Khien()
        {
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox && ctl.Name != "txtTongDiem")
                    ctl.DataBindings.Add("text", bsSV, ctl.Name.Substring(3), true);
                else if (ctl is ComboBox)
                    ctl.DataBindings.Add("Selectedvalue", bsSV, ctl.Name.Substring(3), true);
                else if (ctl is DateTimePicker)
                    ctl.DataBindings.Add("value", bsSV, ctl.Name.Substring(3), true);
                else if (ctl is CheckBox)
                    ctl.DataBindings.Add("checked", bsSV, ctl.Name.Substring(3), true);





        }

        private void Doc_Du_Lieu()
        {
            adpKhoa.Fill(ds.KHOA);
            adpSinhVien.Fill(ds.SINHVIEN);
            adpMonHoc.Fill(ds.MONHOC);
            adpKetQua.Fill(ds.KETQUA);
            // 2 nạp nguồn
            cboMaKH.DisplayMember = "TenKH";
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.DataSource = ds.KHOA;
            //2.1
            bsSV.DataSource = ds.SINHVIEN;
            // 3 nạp nguồn bindingsoure
            bsKQ.DataSource = bsSV;
            bsKQ.DataMember = "SINHVIENKETQUA";

            dgvKetQua.DataSource = bsKQ;

            // 6 
            dgvKetQua.Columns["MaSV"].Visible = false;


        }

        private void btKhong_Click(object sender, EventArgs e)
        {
            bsSV.CancelEdit();
            bsSV.Position = stt;
            txtMasv.ReadOnly = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtMasv.ReadOnly = false;
            stt= bsSV.Position;
            bsSV.AddNew();
            cboMaKH.SelectedIndex = 0;
            txtMasv.Focus();

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            DSSV1.SINHVIENRow rSV = (bsSV.Current as DataRowView).Row as DSSV1.SINHVIENRow;
            if (rSV.GetKETQUARows().Length > 0)
            {
                MessageBox.Show("Mon hoc nay co sv du thi , khong the xoa ");
                return;
            }
            DialogResult tl;
            tl = MessageBox.Show(" Cap Nhat Thanh Cong Sua / Xoa" + "\r\n" +
                    "+ MaSV: " + txtMasv.Text + "\r\n" +
                    "+ Ho Va Ten: " + txtHosv.Text + ' ' + txtTensv.Text + "\r\n" +
                    "khong y/n", "Can Than", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (tl == DialogResult.Yes)
            {
                bsSV.RemoveCurrent();
                int n = adpSinhVien.Update(ds.SINHVIEN);
                if (n > 0)
                {
                    MessageBox.Show("xoa thanh cong", "Thong Bao");
                }
            }
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            if (txtMasv.ReadOnly == false)
            {
                DSSV1.SINHVIENRow rSV = ds.SINHVIEN.FindByMaSV(txtMasv.Text);
                if (rSV != null)
                {
                    MessageBox.Show("Ma Sinh Vien Bi Trung :" +txtMasv.Text + "Vua NHap Bi Trung , Vui Long Nhap Lai", "Thong Bao Loi Trung MaSV",MessageBoxButtons.OK,MessageBoxIcon.Question);

                    txtMasv.Clear();
                    txtMasv.Focus();
                    return;

                }
            }
            txtMasv.ReadOnly = true;
            bsSV.EndEdit();
            int n = adpSinhVien.Update(ds.SINHVIEN);
            if (n > 0)
            {
                MessageBox.Show(" Cap Nhat Thanh Cong Sua / Xoa"+ "\r\n"+
                    "+ MaSV: " +txtMasv.Text + "\r\n"+
                    "+ Ho Va Ten: " + txtHosv.Text +' ' + txtTensv.Text +"\r\n"+
                    "thanh cong","cap nhat sinh vien thanh cong !!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        // B1 NHAN VAOF DANH SACH SINH VIEN - ROWSVALIDATING (SAM SET)
        private void dgvKetQua_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvKetQua.CurrentRow.IsNewRow == true) return;
            
                if (dgvKetQua.IsCurrentRowDirty == true)
                {
                    if ((dgvKetQua.CurrentRow.DataBoundItem as DataRowView).IsNew == true)
                {
                    if (ds.KETQUA.FindByMaSVMaMH(dgvKetQua.CurrentRow.Cells["MaSV"].Value.ToString(), dgvKetQua.CurrentRow.Cells["colMaMH"].Value.ToString()) != null)
                    {
                        MessageBox.Show("Mon Hoc Nay , Sinh vien da thi , vui long chon mon hoc khac !", " thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        dgvKetQua.CurrentCell = dgvKetQua.CurrentRow.Cells["colMaMH"];
                        return;
                    }                  
                }
                    (dgvKetQua.CurrentRow.DataBoundItem as DataRowView).EndEdit();
                int n = adpKetQua.Update(ds.KETQUA);
                if (n > 0)
                    MessageBox.Show(" cap nhat diem thi cho sinh vien thanh cong ", " cap nhat ket qua thanh cong ", MessageBoxButtons.OK, MessageBoxIcon.Question);

                
                  
                }

            }

        private void dgvKetQua_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //USDERdeleteaddrow
            int n = adpKetQua.Update(ds.KETQUA);
            if (n > 0)
                MessageBox.Show("huy ket qua diem thanh cong", "huy ke qua thi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    
        }
    }
    }

