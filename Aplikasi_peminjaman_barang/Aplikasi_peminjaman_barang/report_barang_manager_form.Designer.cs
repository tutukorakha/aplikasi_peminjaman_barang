namespace Aplikasi_peminjaman_barang
{
    partial class report_barang_manager_form
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
            this.btn_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idpeminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbarang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpengguna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapengguna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktupeminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktupemulangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(896, 14);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 30);
            this.btn_back.TabIndex = 38;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarang,
            this.namabarang,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 150);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idbarang
            // 
            this.idbarang.HeaderText = "ID Barang";
            this.idbarang.Name = "idbarang";
            // 
            // namabarang
            // 
            this.namabarang.HeaderText = "Nama Barang";
            this.namabarang.Name = "namabarang";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // txt_search1
            // 
            this.txt_search1.Location = new System.Drawing.Point(82, 21);
            this.txt_search1.Name = "txt_search1";
            this.txt_search1.Size = new System.Drawing.Size(160, 20);
            this.txt_search1.TabIndex = 35;
            this.txt_search1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Search";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpeminjaman,
            this.idbarang1,
            this.idpengguna,
            this.namabarang1,
            this.namapengguna,
            this.waktupeminjaman,
            this.waktupemulangan,
            this.status1});
            this.dataGridView2.Location = new System.Drawing.Point(12, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(984, 150);
            this.dataGridView2.TabIndex = 41;
            // 
            // idpeminjaman
            // 
            this.idpeminjaman.HeaderText = "ID Peminjaman";
            this.idpeminjaman.Name = "idpeminjaman";
            // 
            // idbarang1
            // 
            this.idbarang1.HeaderText = "ID Barang";
            this.idbarang1.Name = "idbarang1";
            // 
            // idpengguna
            // 
            this.idpengguna.HeaderText = "ID Pengguna";
            this.idpengguna.Name = "idpengguna";
            // 
            // namabarang1
            // 
            this.namabarang1.HeaderText = "Nama Barang";
            this.namabarang1.Name = "namabarang1";
            // 
            // namapengguna
            // 
            this.namapengguna.HeaderText = "Nama Pengguna";
            this.namapengguna.Name = "namapengguna";
            // 
            // waktupeminjaman
            // 
            this.waktupeminjaman.HeaderText = "Waktu Peminjaman";
            this.waktupeminjaman.Name = "waktupeminjaman";
            // 
            // waktupemulangan
            // 
            this.waktupemulangan.HeaderText = "Waktu Pemulangan";
            this.waktupemulangan.Name = "waktupemulangan";
            // 
            // status1
            // 
            this.status1.HeaderText = "Status";
            this.status1.Name = "status1";
            // 
            // txt_search2
            // 
            this.txt_search2.Location = new System.Drawing.Point(85, 242);
            this.txt_search2.Name = "txt_search2";
            this.txt_search2.Size = new System.Drawing.Size(160, 20);
            this.txt_search2.TabIndex = 40;
            this.txt_search2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Search";
            // 
            // report_barang_manager_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 485);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txt_search2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_search1);
            this.Controls.Add(this.label1);
            this.Name = "report_barang_manager_form";
            this.Text = "Report Barang";
            this.Load += new System.EventHandler(this.report_barang_manager_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_search1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarang1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpengguna;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarang1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapengguna;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktupeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktupemulangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn status1;
        private System.Windows.Forms.TextBox txt_search2;
        private System.Windows.Forms.Label label2;
    }
}