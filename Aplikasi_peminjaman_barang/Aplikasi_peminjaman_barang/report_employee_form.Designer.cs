namespace Aplikasi_peminjaman_barang
{
    partial class report_employee_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpeminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengguna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_peminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_pemulangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpeminjaman,
            this.nama_barang,
            this.pengguna,
            this.waktu_peminjaman,
            this.waktu_pemulangan,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(986, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // idpeminjaman
            // 
            this.idpeminjaman.HeaderText = "ID Peminjaman";
            this.idpeminjaman.Name = "idpeminjaman";
            // 
            // nama_barang
            // 
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.Name = "nama_barang";
            // 
            // pengguna
            // 
            this.pengguna.HeaderText = "Pengguna";
            this.pengguna.Name = "pengguna";
            // 
            // waktu_peminjaman
            // 
            this.waktu_peminjaman.HeaderText = "Waktu Peminjaman";
            this.waktu_peminjaman.Name = "waktu_peminjaman";
            // 
            // waktu_pemulangan
            // 
            this.waktu_pemulangan.HeaderText = "Waktu Pemulangan";
            this.waktu_pemulangan.Name = "waktu_pemulangan";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(881, 262);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(117, 38);
            this.btn_next.TabIndex = 45;
            this.btn_next.Text = "Selanjutnya";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // report_employee_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 309);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.dataGridView1);
            this.Name = "report_employee_form";
            this.Text = "Report Employee";
            this.Load += new System.EventHandler(this.report_employee_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengguna;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_peminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_pemulangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btn_next;
    }
}