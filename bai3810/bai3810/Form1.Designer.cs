namespace bai3810
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupLeft;
        private System.Windows.Forms.GroupBox groupRight;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colUnit;
        private System.Windows.Forms.ColumnHeader colPrice;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.groupLeft = new System.Windows.Forms.GroupBox();
            this.groupRight = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.colCode = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colUnit = new System.Windows.Forms.ColumnHeader();
            this.colPrice = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.groupLeft.SuspendLayout();
            this.groupRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLeft
            // 
            this.groupLeft.Controls.Add(this.lblCode);
            this.groupLeft.Controls.Add(this.txtCode);
            this.groupLeft.Controls.Add(this.lblName);
            this.groupLeft.Controls.Add(this.txtName);
            this.groupLeft.Controls.Add(this.lblUnit);
            this.groupLeft.Controls.Add(this.cmbUnit);
            this.groupLeft.Controls.Add(this.lblPrice);
            this.groupLeft.Controls.Add(this.nudPrice);
            this.groupLeft.Controls.Add(this.btnAdd);
            this.groupLeft.Controls.Add(this.btnUpdate);
            this.groupLeft.Controls.Add(this.btnDelete);
            this.groupLeft.Controls.Add(this.btnClearAll);
            this.groupLeft.Location = new System.Drawing.Point(12, 12);
            this.groupLeft.Name = "groupLeft";
            this.groupLeft.Size = new System.Drawing.Size(330, 426);
            this.groupLeft.TabIndex = 0;
            this.groupLeft.TabStop = false;
            this.groupLeft.Text = "Khung nhập liệu";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(16, 30);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(62, 15);
            this.lblCode.Text = "Mã vật tư";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(16, 48);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(296, 23);
            this.txtCode.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 15);
            this.lblName.Text = "Tên vật tư";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(16, 138);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(66, 15);
            this.lblUnit.Text = "Đơn vị tính";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            this.cmbUnit.Location = new System.Drawing.Point(16, 156);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(296, 23);
            this.cmbUnit.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 192);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 15);
            this.lblPrice.Text = "Đơn giá";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] { 100, 0, 0, 131072 });
            this.nudPrice.Location = new System.Drawing.Point(16, 210);
            this.nudPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(296, 23);
            this.nudPrice.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(172, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa dòng";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(172, 290);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(140, 30);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Xóa toàn bộ";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // groupRight
            // 
            this.groupRight.Controls.Add(this.listViewItems);
            this.groupRight.Location = new System.Drawing.Point(348, 12);
            this.groupRight.Name = "groupRight";
            this.groupRight.Size = new System.Drawing.Size(440, 426);
            this.groupRight.TabIndex = 1;
            this.groupRight.TabStop = false;
            this.groupRight.Text = "Danh sách";
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCode,
            this.colName,
            this.colUnit,
            this.colPrice});
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.GridLines = true;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(12, 22);
            this.listViewItems.MultiSelect = false;
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(420, 398);
            this.listViewItems.TabIndex = 0;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.SelectedIndexChanged += new System.EventHandler(this.listViewItems_SelectedIndexChanged);
            // 
            // colCode
            // 
            this.colCode.Text = "Mã VT";
            this.colCode.Width = 90;
            // 
            // colName
            // 
            this.colName.Text = "Tên VT";
            this.colName.Width = 160;
            // 
            // colUnit
            // 
            this.colUnit.Text = "Đơn vị tính";
            this.colUnit.Width = 80;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Đơn giá";
            this.colPrice.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupLeft);
            this.Controls.Add(this.groupRight);
            this.Name = "Form1";
            this.Text = "Quản lý danh mục Vật tư / Linh kiện";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.groupLeft.ResumeLayout(false);
            this.groupLeft.PerformLayout();
            this.groupRight.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
