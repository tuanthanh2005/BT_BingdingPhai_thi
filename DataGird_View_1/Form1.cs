using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGird_View_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Them_Cot_Vao_Luoi();
            Them_Dong_Vao_Luoi();
            Dinh_Dang_Luoi();
        }

        private void Dinh_Dang_Luoi()
        {
            dgvMonHoc.Columns[0].Width = 100;
            dgvMonHoc.Columns[1].Width = 300;
            dgvMonHoc.Columns[2].Width = 100;
            dgvMonHoc.Columns[3].Width = 100;
        }

        private void Them_Dong_Vao_Luoi()
        {
            dgvMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonHoc.MultiSelect = false;
            dgvMonHoc.AllowUserToAddRows = false;




            dgvMonHoc.Rows.Add("01", "Cơ sở dữ liệu", 90, "BB");
            dgvMonHoc.Rows.Add("02", "Tin Học", 75, "TC");
            dgvMonHoc.Rows.Add("03", "Lập trình windows", 105, "BB");
            dgvMonHoc.Rows.Add("04", "Lập trình CSDL cơ bản", 75, "BB");
            dgvMonHoc.Rows.Add("05", "Java cơ bản", 75, "TC");
         
        
    }

        private void Them_Cot_Vao_Luoi()
        {
            dgvMonHoc.Columns.Add("colMaMH", "Mã Môn");
            dgvMonHoc.Columns.Add("colTenMH", "Tên Môn Học");
            dgvMonHoc.Columns.Add("colSoTiet", "Số Tiết");
            dgvMonHoc.Columns.Add("colLoaiMH", "Loại MH");
        }
    }
}
