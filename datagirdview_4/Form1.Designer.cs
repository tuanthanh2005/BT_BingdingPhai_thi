
namespace datagirdview_4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bntkhong = new System.Windows.Forms.Button();
            this.bnthuy = new System.Windows.Forms.Button();
            this.bntghi = new System.Windows.Forms.Button();
            this.bntthem = new System.Windows.Forms.Button();
            this.txtsoTiet = new System.Windows.Forms.TextBox();
            this.txttenMH = new System.Windows.Forms.TextBox();
            this.txtmaMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdnMonHoc = new System.Windows.Forms.BindingNavigator(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnMonHoc)).BeginInit();
            this.bdnMonHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntkhong
            // 
            this.bntkhong.Location = new System.Drawing.Point(446, 445);
            this.bntkhong.Name = "bntkhong";
            this.bntkhong.Size = new System.Drawing.Size(95, 31);
            this.bntkhong.TabIndex = 22;
            this.bntkhong.Text = "Không";
            this.bntkhong.UseVisualStyleBackColor = true;
            this.bntkhong.Click += new System.EventHandler(this.bntkhong_Click);
            // 
            // bnthuy
            // 
            this.bnthuy.Location = new System.Drawing.Point(446, 380);
            this.bnthuy.Name = "bnthuy";
            this.bnthuy.Size = new System.Drawing.Size(95, 31);
            this.bnthuy.TabIndex = 21;
            this.bnthuy.Text = "Huỷ";
            this.bnthuy.UseVisualStyleBackColor = true;
            this.bnthuy.Click += new System.EventHandler(this.bnthuy_Click);
            // 
            // bntghi
            // 
            this.bntghi.Location = new System.Drawing.Point(345, 445);
            this.bntghi.Name = "bntghi";
            this.bntghi.Size = new System.Drawing.Size(95, 31);
            this.bntghi.TabIndex = 20;
            this.bntghi.Text = "Ghi";
            this.bntghi.UseVisualStyleBackColor = true;
            this.bntghi.Click += new System.EventHandler(this.bntghi_Click);
            // 
            // bntthem
            // 
            this.bntthem.Location = new System.Drawing.Point(345, 380);
            this.bntthem.Name = "bntthem";
            this.bntthem.Size = new System.Drawing.Size(95, 31);
            this.bntthem.TabIndex = 19;
            this.bntthem.Text = "Thêm";
            this.bntthem.UseVisualStyleBackColor = true;
            this.bntthem.Click += new System.EventHandler(this.bntthem_Click);
            // 
            // txtsoTiet
            // 
            this.txtsoTiet.Location = new System.Drawing.Point(94, 448);
            this.txtsoTiet.Name = "txtsoTiet";
            this.txtsoTiet.Size = new System.Drawing.Size(232, 26);
            this.txtsoTiet.TabIndex = 18;
            // 
            // txttenMH
            // 
            this.txttenMH.Location = new System.Drawing.Point(94, 416);
            this.txttenMH.Name = "txttenMH";
            this.txttenMH.Size = new System.Drawing.Size(232, 26);
            this.txttenMH.TabIndex = 17;
            // 
            // txtmaMH
            // 
            this.txtmaMH.Location = new System.Drawing.Point(94, 383);
            this.txtmaMH.Name = "txtmaMH";
            this.txtmaMH.Size = new System.Drawing.Size(232, 26);
            this.txtmaMH.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số Tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên MH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã MH";
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
            this.dgvMonHoc.Size = new System.Drawing.Size(605, 195);
            this.dgvMonHoc.TabIndex = 12;
            // 
            // colMaMH
            // 
            this.colMaMH.DataPropertyName = "MaMH";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.colMaMH.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMaMH.HeaderText = "Mã MH";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.Width = 150;
            // 
            // ColTenMH
            // 
            this.ColTenMH.DataPropertyName = "TenMH";
            this.ColTenMH.HeaderText = "Tên Môn";
            this.ColTenMH.Name = "ColTenMH";
            this.ColTenMH.Width = 200;
            // 
            // ColSoTiet
            // 
            this.ColSoTiet.DataPropertyName = "SoTiet";
            this.ColSoTiet.HeaderText = "Số Tiết";
            this.ColSoTiet.Name = "ColSoTiet";
            this.ColSoTiet.Width = 150;
            // 
            // bdnMonHoc
            // 
            this.bdnMonHoc.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bdnMonHoc.CountItem = this.bindingNavigatorCountItem;
            this.bdnMonHoc.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bdnMonHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnMonHoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bdnMonHoc.Location = new System.Drawing.Point(0, 485);
            this.bdnMonHoc.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnMonHoc.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnMonHoc.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnMonHoc.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnMonHoc.Name = "bdnMonHoc";
            this.bdnMonHoc.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnMonHoc.Size = new System.Drawing.Size(605, 25);
            this.bdnMonHoc.TabIndex = 23;
            this.bdnMonHoc.Text = "bindingNavigator1";
            this.bdnMonHoc.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 510);
            this.Controls.Add(this.bdnMonHoc);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnMonHoc)).EndInit();
            this.bdnMonHoc.ResumeLayout(false);
            this.bdnMonHoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntkhong;
        private System.Windows.Forms.Button bnthuy;
        private System.Windows.Forms.Button bntghi;
        private System.Windows.Forms.Button bntthem;
        private System.Windows.Forms.TextBox txtsoTiet;
        private System.Windows.Forms.TextBox txttenMH;
        private System.Windows.Forms.TextBox txtmaMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.BindingNavigator bdnMonHoc;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoTiet;
    }
}

