using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaTaGirdView_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
          
        }

        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void Them_Cot_Vao_Dong()
        {
            dgvMonHoc.Rows.Add("01", "Cơ sở dữ liệu", 90);
            dgvMonHoc.Rows.Add("02", "Tin Học", 75);
            dgvMonHoc.Rows.Add("03", "Lập trình windows", 105);
            dgvMonHoc.Rows.Add("04", "Lập trình CSDL cơ bản", 75);
            dgvMonHoc.Rows.Add("05", "Java cơ bản", 75);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  Them_Cot_Vao_Dong();
            DataGridViewRow r = dgvMonHoc.Rows[2];
            r.Selected = true;
            Gan_Du_Lieu(r);
        }

        private void Gan_Du_Lieu(DataGridViewRow r)
        {
            txtmaMH.Text = r.Cells["colMaMH"].Value.ToString();
            txttenMH.Text = r.Cells["colTenMh"].Value.ToString();
            txtsoTiet.Text = r.Cells[2].Value.ToString();

        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvMonHoc.Rows[e.RowIndex];
            Gan_Du_Lieu(r);
        }

        private void bntthem_Click(object sender, EventArgs e)
        {
            txtmaMH.ReadOnly = false;
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                    (ctl as TextBox).Clear();
            txtmaMH.Focus();

                 





          

           
        }

        private void bntkhong_Click(object sender, EventArgs e)
        {
            Gan_Du_Lieu(dgvMonHoc.SelectedRows[0]);
            txtmaMH.ReadOnly = true;
        }

        private void bnthuy_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Ban co muon xoa sv nay khong?", "Can than", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl==DialogResult.Yes)
            {
                DataGridViewRow rhuy = dgvMonHoc.SelectedRows[0];
                //bnthuy trong luoi 
                dgvMonHoc.Rows.Remove(rhuy);
                dgvMonHoc.Rows[0].Selected = true;
                Gan_Du_Lieu(dgvMonHoc.Rows[0]);
            }
        }

        private void bntghi_Click(object sender, EventArgs e)
        {
            if (txtmaMH.ReadOnly==true)
            {
                DataGridViewRow rsua = dgvMonHoc.SelectedRows[0];
                rsua.Cells[1].Value = txtmaMH.Text;
                rsua.Cells[2].Value = txtsoTiet.Text;
            }
            else
            {
                int stt = dgvMonHoc.Rows.Add(txtmaMH.Text,  txttenMH.Text,txtsoTiet.Text);
                dgvMonHoc.Rows[stt].Selected = true;
                txtmaMH.ReadOnly = true;
            }
        }
    }
}
