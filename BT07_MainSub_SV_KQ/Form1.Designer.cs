namespace BT07_MainSub_SV_KQ
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bdnSinhVien = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.btKhong = new System.Windows.Forms.Button();
            this.btGhi = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSau = new System.Windows.Forms.Button();
            this.btTruot = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.txtTensv = new System.Windows.Forms.TextBox();
            this.txtHocBong = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtHosv = new System.Windows.Forms.TextBox();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.lblSTT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkPhai = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bdnSinhVien)).BeginInit();
            this.bdnSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // bdnSinhVien
            // 
            this.bdnSinhVien.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bdnSinhVien.CountItem = this.bindingNavigatorCountItem;
            this.bdnSinhVien.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bdnSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnSinhVien.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bdnSinhVien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnSinhVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bdnSinhVien.Location = new System.Drawing.Point(0, 605);
            this.bdnSinhVien.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnSinhVien.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnSinhVien.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnSinhVien.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnSinhVien.Name = "bdnSinhVien";
            this.bdnSinhVien.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnSinhVien.Size = new System.Drawing.Size(751, 27);
            this.bdnSinhVien.TabIndex = 58;
            this.bdnSinhVien.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(751, 69);
            this.label7.TabIndex = 57;
            this.label7.Text = "Danh Sách Sinh Viên";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboMaKH
            // 
            this.cboMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(430, 260);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(292, 27);
            this.cboMaKH.TabIndex = 56;
            // 
            // btKhong
            // 
            this.btKhong.BackColor = System.Drawing.Color.LightGray;
            this.btKhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKhong.ForeColor = System.Drawing.Color.Brown;
            this.btKhong.Location = new System.Drawing.Point(634, 379);
            this.btKhong.Name = "btKhong";
            this.btKhong.Size = new System.Drawing.Size(88, 58);
            this.btKhong.TabIndex = 55;
            this.btKhong.Text = "Không";
            this.btKhong.UseVisualStyleBackColor = false;
            this.btKhong.Click += new System.EventHandler(this.btKhong_Click);
            // 
            // btGhi
            // 
            this.btGhi.BackColor = System.Drawing.Color.LightGray;
            this.btGhi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGhi.ForeColor = System.Drawing.Color.Brown;
            this.btGhi.Location = new System.Drawing.Point(540, 379);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(88, 58);
            this.btGhi.TabIndex = 54;
            this.btGhi.Text = "Ghi";
            this.btGhi.UseVisualStyleBackColor = false;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.LightGray;
            this.btHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.Brown;
            this.btHuy.Location = new System.Drawing.Point(446, 379);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(88, 58);
            this.btHuy.TabIndex = 53;
            this.btHuy.Text = "Huỷ";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.LightGray;
            this.btThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Brown;
            this.btThem.Location = new System.Drawing.Point(352, 379);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(88, 58);
            this.btThem.TabIndex = 52;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSau
            // 
            this.btSau.BackColor = System.Drawing.Color.LightGray;
            this.btSau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSau.ForeColor = System.Drawing.Color.Brown;
            this.btSau.Location = new System.Drawing.Point(258, 379);
            this.btSau.Name = "btSau";
            this.btSau.Size = new System.Drawing.Size(88, 58);
            this.btSau.TabIndex = 51;
            this.btSau.Text = "Sau";
            this.btSau.UseVisualStyleBackColor = false;
            this.btSau.Click += new System.EventHandler(this.btSau_Click);
            // 
            // btTruot
            // 
            this.btTruot.BackColor = System.Drawing.Color.LightGray;
            this.btTruot.ForeColor = System.Drawing.Color.Brown;
            this.btTruot.Location = new System.Drawing.Point(35, 379);
            this.btTruot.Name = "btTruot";
            this.btTruot.Size = new System.Drawing.Size(88, 58);
            this.btTruot.TabIndex = 50;
            this.btTruot.Text = "Trước";
            this.btTruot.UseVisualStyleBackColor = false;
            this.btTruot.Click += new System.EventHandler(this.btTruot_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(430, 201);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(292, 27);
            this.dtpNgaySinh.TabIndex = 49;
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDiem.Location = new System.Drawing.Point(430, 320);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(292, 27);
            this.txtTongDiem.TabIndex = 47;
            // 
            // txtTensv
            // 
            this.txtTensv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensv.Location = new System.Drawing.Point(586, 142);
            this.txtTensv.Name = "txtTensv";
            this.txtTensv.Size = new System.Drawing.Size(136, 27);
            this.txtTensv.TabIndex = 48;
            // 
            // txtHocBong
            // 
            this.txtHocBong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocBong.Location = new System.Drawing.Point(133, 319);
            this.txtHocBong.Name = "txtHocBong";
            this.txtHocBong.Size = new System.Drawing.Size(150, 27);
            this.txtHocBong.TabIndex = 46;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiSinh.Location = new System.Drawing.Point(133, 260);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(150, 27);
            this.txtNoiSinh.TabIndex = 45;
            // 
            // txtHosv
            // 
            this.txtHosv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHosv.Location = new System.Drawing.Point(133, 142);
            this.txtHosv.Name = "txtHosv";
            this.txtHosv.Size = new System.Drawing.Size(430, 27);
            this.txtHosv.TabIndex = 43;
            // 
            // txtMasv
            // 
            this.txtMasv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasv.Location = new System.Drawing.Point(133, 83);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(589, 27);
            this.txtMasv.TabIndex = 42;
            // 
            // lblSTT
            // 
            this.lblSTT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSTT.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTT.ImageKey = "(none)";
            this.lblSTT.Location = new System.Drawing.Point(148, 389);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(92, 41);
            this.lblSTT.TabIndex = 40;
            this.lblSTT.Text = "00/00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Học Bổng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nơi Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tổng Điểm";
            // 
            // txtKhoa
            // 
            this.txtKhoa.AutoSize = true;
            this.txtKhoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoa.Location = new System.Drawing.Point(357, 263);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(44, 19);
            this.txtKhoa.TabIndex = 36;
            this.txtKhoa.Text = "Khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Họ Tên SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã SV";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToOrderColumns = true;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMH,
            this.ColTenMH,
            this.ColDiem});
            this.dgvKetQua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKetQua.Location = new System.Drawing.Point(0, 442);
            this.dgvKetQua.MultiSelect = false;
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(751, 163);
            this.dgvKetQua.TabIndex = 59;
            this.dgvKetQua.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvKetQua_RowValidating);
            this.dgvKetQua.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvKetQua_UserDeletedRow);
            // 
            // colMaMH
            // 
            this.colMaMH.DataPropertyName = "MaMH";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            this.colMaMH.DefaultCellStyle = dataGridViewCellStyle9;
            this.colMaMH.HeaderText = "Ma Mon";
            this.colMaMH.MinimumWidth = 6;
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.Width = 150;
            // 
            // ColTenMH
            // 
            this.ColTenMH.DataPropertyName = "TenMH";
            this.ColTenMH.HeaderText = "Tên Môn";
            this.ColTenMH.MinimumWidth = 6;
            this.ColTenMH.Name = "ColTenMH";
            this.ColTenMH.Width = 350;
            // 
            // ColDiem
            // 
            this.ColDiem.DataPropertyName = "Diem";
            this.ColDiem.HeaderText = "Diem";
            this.ColDiem.MinimumWidth = 6;
            this.ColDiem.Name = "ColDiem";
            this.ColDiem.Width = 150;
            // 
            // chkPhai
            // 
            this.chkPhai.AutoSize = true;
            this.chkPhai.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPhai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkPhai.Location = new System.Drawing.Point(32, 205);
            this.chkPhai.Name = "chkPhai";
            this.chkPhai.Size = new System.Drawing.Size(100, 26);
            this.chkPhai.TabIndex = 60;
            this.chkPhai.Text = "Giới tính";
            this.chkPhai.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 632);
            this.Controls.Add(this.chkPhai);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.bdnSinhVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMaKH);
            this.Controls.Add(this.btKhong);
            this.Controls.Add(this.btGhi);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSau);
            this.Controls.Add(this.btTruot);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.txtTensv);
            this.Controls.Add(this.txtHocBong);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.txtHosv);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.lblSTT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdnSinhVien)).EndInit();
            this.bdnSinhVien.ResumeLayout(false);
            this.bdnSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bdnSinhVien;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Button btKhong;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSau;
        private System.Windows.Forms.Button btTruot;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.TextBox txtTensv;
        private System.Windows.Forms.TextBox txtHocBong;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtHosv;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkPhai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiem;
    }
}

