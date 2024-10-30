
namespace DaTaGirdView_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaMH = new System.Windows.Forms.TextBox();
            this.txttenMH = new System.Windows.Forms.TextBox();
            this.txtsoTiet = new System.Windows.Forms.TextBox();
            this.bntthem = new System.Windows.Forms.Button();
            this.bntghi = new System.Windows.Forms.Button();
            this.bnthuy = new System.Windows.Forms.Button();
            this.bntkhong = new System.Windows.Forms.Button();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AllowUserToAddRows = false;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMH,
            this.ColTenMH,
            this.ColSoTiet});
            this.dgvMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMonHoc.Location = new System.Drawing.Point(0, 0);
            this.dgvMonHoc.MultiSelect = false;
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(543, 195);
            this.dgvMonHoc.TabIndex = 1;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);
            this.dgvMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã MH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên MH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Tiết";
            // 
            // txtmaMH
            // 
            this.txtmaMH.Location = new System.Drawing.Point(94, 237);
            this.txtmaMH.Name = "txtmaMH";
            this.txtmaMH.Size = new System.Drawing.Size(232, 26);
            this.txtmaMH.TabIndex = 5;
            // 
            // txttenMH
            // 
            this.txttenMH.Location = new System.Drawing.Point(94, 270);
            this.txttenMH.Name = "txttenMH";
            this.txttenMH.Size = new System.Drawing.Size(232, 26);
            this.txttenMH.TabIndex = 6;
            // 
            // txtsoTiet
            // 
            this.txtsoTiet.Location = new System.Drawing.Point(94, 302);
            this.txtsoTiet.Name = "txtsoTiet";
            this.txtsoTiet.Size = new System.Drawing.Size(232, 26);
            this.txtsoTiet.TabIndex = 7;
            // 
            // bntthem
            // 
            this.bntthem.Location = new System.Drawing.Point(345, 234);
            this.bntthem.Name = "bntthem";
            this.bntthem.Size = new System.Drawing.Size(95, 31);
            this.bntthem.TabIndex = 8;
            this.bntthem.Text = "Thêm";
            this.bntthem.UseVisualStyleBackColor = true;
            this.bntthem.Click += new System.EventHandler(this.bntthem_Click);
            // 
            // bntghi
            // 
            this.bntghi.Location = new System.Drawing.Point(345, 299);
            this.bntghi.Name = "bntghi";
            this.bntghi.Size = new System.Drawing.Size(95, 31);
            this.bntghi.TabIndex = 9;
            this.bntghi.Text = "Ghi";
            this.bntghi.UseVisualStyleBackColor = true;
            this.bntghi.Click += new System.EventHandler(this.bntghi_Click);
            // 
            // bnthuy
            // 
            this.bnthuy.Location = new System.Drawing.Point(446, 234);
            this.bnthuy.Name = "bnthuy";
            this.bnthuy.Size = new System.Drawing.Size(95, 31);
            this.bnthuy.TabIndex = 10;
            this.bnthuy.Text = "Huỷ";
            this.bnthuy.UseVisualStyleBackColor = true;
            this.bnthuy.Click += new System.EventHandler(this.bnthuy_Click);
            // 
            // bntkhong
            // 
            this.bntkhong.Location = new System.Drawing.Point(446, 299);
            this.bntkhong.Name = "bntkhong";
            this.bntkhong.Size = new System.Drawing.Size(95, 31);
            this.bntkhong.TabIndex = 11;
            this.bntkhong.Text = "Không";
            this.bntkhong.UseVisualStyleBackColor = true;
            this.bntkhong.Click += new System.EventHandler(this.bntkhong_Click);
            // 
            // colMaMH
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            this.colMaMH.DefaultCellStyle = dataGridViewCellStyle6;
            this.colMaMH.HeaderText = "Mã MH";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.Width = 150;
            // 
            // ColTenMH
            // 
            this.ColTenMH.HeaderText = "Tên Môn";
            this.ColTenMH.Name = "ColTenMH";
            this.ColTenMH.Width = 200;
            // 
            // ColSoTiet
            // 
            this.ColSoTiet.HeaderText = "Số Tiết";
            this.ColSoTiet.Name = "ColSoTiet";
            this.ColSoTiet.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(543, 345);
            this.Controls.Add(this.bntkhong);
            this.Controls.Add(this.bnthuy);
            this.Controls.Add(this.bntghi);
            this.Controls.Add(this.bntthem);
            this.Controls.Add(this.txtsoTiet);
            this.Controls.Add(this.txttenMH);
            this.Controls.Add(this.txtmaMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMonHoc);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaMH;
        private System.Windows.Forms.TextBox txttenMH;
        private System.Windows.Forms.TextBox txtsoTiet;
        private System.Windows.Forms.Button bntthem;
        private System.Windows.Forms.Button bntghi;
        private System.Windows.Forms.Button bnthuy;
        private System.Windows.Forms.Button bntkhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoTiet;
    }
}

