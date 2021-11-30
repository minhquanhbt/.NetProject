
namespace _102190333_NguyenMinhQuan.GUI
{
    partial class NguyenMinhQuan_MF
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
            this.MonAn = new System.Windows.Forms.Label();
            this.cbbMonAn = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.AddBut = new System.Windows.Forms.Button();
            this.EditBut = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.SortBut = new System.Windows.Forms.Button();
            this.cbbProp = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MonAn
            // 
            this.MonAn.AutoSize = true;
            this.MonAn.Location = new System.Drawing.Point(51, 35);
            this.MonAn.Name = "MonAn";
            this.MonAn.Size = new System.Drawing.Size(55, 17);
            this.MonAn.TabIndex = 0;
            this.MonAn.Text = "Món ăn";
            // 
            // cbbMonAn
            // 
            this.cbbMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonAn.FormattingEnabled = true;
            this.cbbMonAn.Location = new System.Drawing.Point(112, 35);
            this.cbbMonAn.Name = "cbbMonAn";
            this.cbbMonAn.Size = new System.Drawing.Size(174, 24);
            this.cbbMonAn.TabIndex = 1;
            this.cbbMonAn.SelectedIndexChanged += new System.EventHandler(this.Search_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(450, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.Search_Click);
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.AllowUserToAddRows = false;
            this.dgvDSSV.AllowUserToDeleteRows = false;
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDSSV.Location = new System.Drawing.Point(28, 34);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.RowHeadersWidth = 51;
            this.dgvDSSV.RowTemplate.Height = 24;
            this.dgvDSSV.Size = new System.Drawing.Size(717, 221);
            this.dgvDSSV.TabIndex = 4;
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(43, 316);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(75, 23);
            this.AddBut.TabIndex = 7;
            this.AddBut.Text = "Add";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.Add_Click);
            // 
            // EditBut
            // 
            this.EditBut.Location = new System.Drawing.Point(185, 316);
            this.EditBut.Name = "EditBut";
            this.EditBut.Size = new System.Drawing.Size(75, 23);
            this.EditBut.TabIndex = 8;
            this.EditBut.Text = "Edit";
            this.EditBut.UseVisualStyleBackColor = true;
            this.EditBut.Click += new System.EventHandler(this.Edit_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(298, 315);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(75, 23);
            this.DeleteBut.TabIndex = 9;
            this.DeleteBut.Text = "Del";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.Del_Click);
            // 
            // SortBut
            // 
            this.SortBut.Location = new System.Drawing.Point(413, 316);
            this.SortBut.Name = "SortBut";
            this.SortBut.Size = new System.Drawing.Size(75, 23);
            this.SortBut.TabIndex = 10;
            this.SortBut.Text = "Sort";
            this.SortBut.UseVisualStyleBackColor = true;
            this.SortBut.Click += new System.EventHandler(this.SortBut_Click);
            // 
            // cbbProp
            // 
            this.cbbProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProp.FormattingEnabled = true;
            this.cbbProp.Location = new System.Drawing.Point(536, 315);
            this.cbbProp.Name = "cbbProp";
            this.cbbProp.Size = new System.Drawing.Size(209, 24);
            this.cbbProp.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSSV);
            this.groupBox1.Controls.Add(this.cbbProp);
            this.groupBox1.Controls.Add(this.SortBut);
            this.groupBox1.Controls.Add(this.AddBut);
            this.groupBox1.Controls.Add(this.DeleteBut);
            this.groupBox1.Controls.Add(this.EditBut);
            this.groupBox1.Location = new System.Drawing.Point(26, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 364);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search";
            // 
            // NguyenMinhQuan_MF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbbMonAn);
            this.Controls.Add(this.MonAn);
            this.Name = "NguyenMinhQuan_MF";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MonAn;
        private System.Windows.Forms.ComboBox cbbMonAn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button EditBut;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button SortBut;
        private System.Windows.Forms.ComboBox cbbProp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}