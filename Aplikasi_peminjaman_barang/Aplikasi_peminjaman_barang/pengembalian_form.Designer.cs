namespace Aplikasi_peminjaman_barang
{
    partial class pengembalian_form
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
            this.idpeminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpengguna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapengguna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktupeminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktupemulangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuspengguna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_pengguna = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nama_pengguna = new System.Windows.Forms.TextBox();
            this.txt_waktu_pemulangan = new System.Windows.Forms.TextBox();
            this.txt_waktu_peminjaman = new System.Windows.Forms.TextBox();
            this.txt_nama_barang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id_barang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_peminjaman = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_status_pengguna = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(896, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 30);
            this.btn_back.TabIndex = 37;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpeminjaman,
            this.idbarang,
            this.idpengguna,
            this.namabarang,
            this.namapengguna,
            this.waktupeminjaman,
            this.waktupemulangan,
            this.status,
            this.statuspengguna,
            this.select});
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 150);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idpeminjaman
            // 
            this.idpeminjaman.HeaderText = "ID Peminjaman";
            this.idpeminjaman.Name = "idpeminjaman";
            // 
            // idbarang
            // 
            this.idbarang.HeaderText = "ID Barang";
            this.idbarang.Name = "idbarang";
            // 
            // idpengguna
            // 
            this.idpengguna.HeaderText = "IDPengguna";
            this.idpengguna.Name = "idpengguna";
            // 
            // namabarang
            // 
            this.namabarang.HeaderText = "Nama Barang";
            this.namabarang.Name = "namabarang";
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
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // statuspengguna
            // 
            this.statuspengguna.HeaderText = "Status Pengguna";
            this.statuspengguna.Name = "statuspengguna";
            // 
            // select
            // 
            this.select.HeaderText = "SELECT";
            this.select.Name = "select";
            this.select.Text = "SELECT";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(82, 19);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(160, 20);
            this.txt_search.TabIndex = 35;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Search";
            // 
            // txt_id_pengguna
            // 
            this.txt_id_pengguna.Enabled = false;
            this.txt_id_pengguna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_pengguna.Location = new System.Drawing.Point(158, 302);
            this.txt_id_pengguna.Name = "txt_id_pengguna";
            this.txt_id_pengguna.Size = new System.Drawing.Size(181, 20);
            this.txt_id_pengguna.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 70;
            this.label8.Text = "Status Pengguna";
            // 
            // txt_nama_pengguna
            // 
            this.txt_nama_pengguna.Enabled = false;
            this.txt_nama_pengguna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama_pengguna.Location = new System.Drawing.Point(158, 374);
            this.txt_nama_pengguna.Name = "txt_nama_pengguna";
            this.txt_nama_pengguna.Size = new System.Drawing.Size(181, 20);
            this.txt_nama_pengguna.TabIndex = 68;
            // 
            // txt_waktu_pemulangan
            // 
            this.txt_waktu_pemulangan.Enabled = false;
            this.txt_waktu_pemulangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_waktu_pemulangan.Location = new System.Drawing.Point(159, 448);
            this.txt_waktu_pemulangan.Name = "txt_waktu_pemulangan";
            this.txt_waktu_pemulangan.Size = new System.Drawing.Size(181, 20);
            this.txt_waktu_pemulangan.TabIndex = 67;
            // 
            // txt_waktu_peminjaman
            // 
            this.txt_waktu_peminjaman.Enabled = false;
            this.txt_waktu_peminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_waktu_peminjaman.Location = new System.Drawing.Point(159, 411);
            this.txt_waktu_peminjaman.Name = "txt_waktu_peminjaman";
            this.txt_waktu_peminjaman.Size = new System.Drawing.Size(181, 20);
            this.txt_waktu_peminjaman.TabIndex = 66;
            // 
            // txt_nama_barang
            // 
            this.txt_nama_barang.Enabled = false;
            this.txt_nama_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama_barang.Location = new System.Drawing.Point(158, 338);
            this.txt_nama_barang.Name = "txt_nama_barang";
            this.txt_nama_barang.Size = new System.Drawing.Size(181, 20);
            this.txt_nama_barang.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 526);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 64;
            this.label10.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 16);
            this.label9.TabIndex = 63;
            this.label9.Text = "Waktu Pemulangan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "Waktu Peminjaman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "Nama Pengguna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "ID Pengguna";
            // 
            // txt_id_barang
            // 
            this.txt_id_barang.Enabled = false;
            this.txt_id_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_barang.Location = new System.Drawing.Point(158, 262);
            this.txt_id_barang.Name = "txt_id_barang";
            this.txt_id_barang.Size = new System.Drawing.Size(181, 20);
            this.txt_id_barang.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "ID Barang";
            // 
            // txt_id_peminjaman
            // 
            this.txt_id_peminjaman.Enabled = false;
            this.txt_id_peminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_peminjaman.Location = new System.Drawing.Point(159, 223);
            this.txt_id_peminjaman.Name = "txt_id_peminjaman";
            this.txt_id_peminjaman.Size = new System.Drawing.Size(181, 20);
            this.txt_id_peminjaman.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "ID Peminjaman";
            // 
            // txt_status
            // 
            this.txt_status.Enabled = false;
            this.txt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(158, 522);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(181, 20);
            this.txt_status.TabIndex = 73;
            this.txt_status.Text = "Ada";
            // 
            // txt_status_pengguna
            // 
            this.txt_status_pengguna.Enabled = false;
            this.txt_status_pengguna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status_pengguna.Location = new System.Drawing.Point(158, 485);
            this.txt_status_pengguna.Name = "txt_status_pengguna";
            this.txt_status_pengguna.Size = new System.Drawing.Size(181, 20);
            this.txt_status_pengguna.TabIndex = 74;
            this.txt_status_pengguna.Text = "tidak meminjam";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(842, 235);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(154, 47);
            this.btn_add.TabIndex = 75;
            this.btn_add.Text = "Kembalikan Barang";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pengembalian_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 552);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_status_pengguna);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_id_pengguna);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_nama_pengguna);
            this.Controls.Add(this.txt_waktu_pemulangan);
            this.Controls.Add(this.txt_waktu_peminjaman);
            this.Controls.Add(this.txt_nama_barang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id_barang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id_peminjaman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Name = "pengembalian_form";
            this.Text = "pengembalian_form";
            this.Load += new System.EventHandler(this.pengembalian_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpengguna;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapengguna;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktupeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktupemulangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuspengguna;
        private System.Windows.Forms.DataGridViewButtonColumn select;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_pengguna;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nama_pengguna;
        private System.Windows.Forms.TextBox txt_waktu_pemulangan;
        private System.Windows.Forms.TextBox txt_waktu_peminjaman;
        private System.Windows.Forms.TextBox txt_nama_barang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id_barang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_peminjaman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_status_pengguna;
        private System.Windows.Forms.Button btn_add;
    }
}