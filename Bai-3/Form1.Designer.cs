namespace Bai_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxTenSach = new System.Windows.Forms.TextBox();
            this.tboxSoTrang = new System.Windows.Forms.TextBox();
            this.tboxTacgia = new System.Windows.Forms.TextBox();
            this.tboxGiaTien = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbnDelete = new System.Windows.Forms.Button();
            this.btnRender = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gviewSach = new System.Windows.Forms.DataGridView();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gviewSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số trang:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tác giả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá tiền:";
            // 
            // tboxTenSach
            // 
            this.tboxTenSach.Location = new System.Drawing.Point(149, 38);
            this.tboxTenSach.Name = "tboxTenSach";
            this.tboxTenSach.Size = new System.Drawing.Size(193, 20);
            this.tboxTenSach.TabIndex = 4;
            // 
            // tboxSoTrang
            // 
            this.tboxSoTrang.Location = new System.Drawing.Point(149, 65);
            this.tboxSoTrang.Name = "tboxSoTrang";
            this.tboxSoTrang.Size = new System.Drawing.Size(193, 20);
            this.tboxSoTrang.TabIndex = 5;
            // 
            // tboxTacgia
            // 
            this.tboxTacgia.Location = new System.Drawing.Point(149, 90);
            this.tboxTacgia.Name = "tboxTacgia";
            this.tboxTacgia.Size = new System.Drawing.Size(193, 20);
            this.tboxTacgia.TabIndex = 6;
            // 
            // tboxGiaTien
            // 
            this.tboxGiaTien.Location = new System.Drawing.Point(149, 114);
            this.tboxGiaTien.Name = "tboxGiaTien";
            this.tboxGiaTien.Size = new System.Drawing.Size(193, 20);
            this.tboxGiaTien.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(439, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(439, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbnDelete
            // 
            this.tbnDelete.Location = new System.Drawing.Point(439, 89);
            this.tbnDelete.Name = "tbnDelete";
            this.tbnDelete.Size = new System.Drawing.Size(75, 23);
            this.tbnDelete.TabIndex = 10;
            this.tbnDelete.Text = "Xóa";
            this.tbnDelete.UseVisualStyleBackColor = true;
            this.tbnDelete.Click += new System.EventHandler(this.tbnDelete_Click);
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(520, 31);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(75, 23);
            this.btnRender.TabIndex = 11;
            this.btnRender.Text = "Hiển thị";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(520, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(520, 89);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gviewSach
            // 
            this.gviewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gviewSach.Location = new System.Drawing.Point(70, 215);
            this.gviewSach.Name = "gviewSach";
            this.gviewSach.Size = new System.Drawing.Size(664, 176);
            this.gviewSach.TabIndex = 14;
            this.gviewSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gviewSach_CellClick);
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(149, 12);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(193, 20);
            this.tboxID.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gviewSach);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.tbnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tboxGiaTien);
            this.Controls.Add(this.tboxTacgia);
            this.Controls.Add(this.tboxSoTrang);
            this.Controls.Add(this.tboxTenSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gviewSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxTenSach;
        private System.Windows.Forms.TextBox tboxSoTrang;
        private System.Windows.Forms.TextBox tboxTacgia;
        private System.Windows.Forms.TextBox tboxGiaTien;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button tbnDelete;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView gviewSach;
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.Label label5;
    }
}

