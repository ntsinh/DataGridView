namespace DataGridView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            btnThem = new Button();
            dgvNv = new System.Windows.Forms.DataGridView();
            txtTen = new TextBox();
            label1 = new Label();
            txtDate = new TextBox();
            label2 = new Label();
            txtDiachi = new TextBox();
            label3 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            txtId = new TextBox();
            label4 = new Label();
            Id = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvNv).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(13, 292);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(69, 35);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // dgvNv
            // 
            dgvNv.BackgroundColor = SystemColors.ButtonHighlight;
            dgvNv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNv.Columns.AddRange(new DataGridViewColumn[] { Id, Ten, NgaySinh, DiaChi });
            dgvNv.Location = new Point(256, 31);
            dgvNv.Name = "dgvNv";
            dgvNv.ReadOnly = true;
            dgvNv.RowTemplate.Height = 25;
            dgvNv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNv.Size = new Size(406, 296);
            dgvNv.TabIndex = 1;
            dgvNv.CellClick += dataGridView1_CellClick;
            dgvNv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTen.Location = new Point(13, 126);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(224, 29);
            txtTen.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 99);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 3;
            label1.Text = "Tên ";
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDate.Location = new Point(13, 188);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(224, 29);
            txtDate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 161);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 3;
            label2.Text = "Ngày Sinh ";
            // 
            // txtDiachi
            // 
            txtDiachi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiachi.Location = new Point(13, 248);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(224, 29);
            txtDiachi.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 221);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 3;
            label3.Text = "Địa chỉ";
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(90, 292);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(69, 35);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button1_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(168, 292);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(69, 35);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button1_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(13, 55);
            txtId.Name = "txtId";
            txtId.Size = new Size(224, 29);
            txtId.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 28);
            label4.Name = "label4";
            label4.Size = new Size(25, 21);
            label4.TabIndex = 3;
            label4.Text = "Id";
            // 
            // Id
            // 
            Id.DataPropertyName = "IdNv";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 30;
            // 
            // Ten
            // 
            Ten.DataPropertyName = "tenNv";
            Ten.HeaderText = "Ten";
            Ten.Name = "Ten";
            Ten.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "ngaySinh";
            NgaySinh.HeaderText = "Ngay Sinh";
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "diaChi";
            DiaChi.HeaderText = "Dia Chi";
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            DiaChi.Width = 140;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 339);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtDiachi);
            Controls.Add(txtDate);
            Controls.Add(txtId);
            Controls.Add(txtTen);
            Controls.Add(dgvNv);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private System.Windows.Forms.DataGridView dgvNv;
        private TextBox txtTen;
        private Label label1;
        private TextBox txtDate;
        private Label label2;
        private TextBox txtDiachi;
        private Label label3;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtId;
        private Label label4;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn DiaChi;
    }
}