namespace Aplikasi_peminjaman_barang
{
    partial class manage_peminjaman_form
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
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
            this.txt_idpeminjaman = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idbarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nama_barang = new System.Windows.Forms.TextBox();
            this.txt_waktu_peminjaman = new System.Windows.Forms.TextBox();
            this.txt_waktu_pemulangan = new System.Windows.Forms.TextBox();
            this.txt_nama_pengguna = new System.Windows.Forms.TextBox();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_status_pengguna = new System.Windows.Forms.ComboBox();
            this.txt_idpengguna = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(893, 18);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 30);
            this.btn_back.TabIndex = 33;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(869, 341);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 40);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(869, 245);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(117, 40);
            this.btn_edit.TabIndex = 30;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(9, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 150);
            this.dataGridView1.TabIndex = 24;
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
            this.txt_search.Location = new System.Drawing.Point(79, 25);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(160, 20);
            this.txt_search.TabIndex = 23;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Search";
            // 
            // txt_idpeminjaman
            // 
            this.txt_idpeminjaman.Enabled = false;
            this.txt_idpeminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idpeminjaman.Location = new System.Drawing.Point(159, 226);
            this.txt_idpeminjaman.Name = "txt_idpeminjaman";
            this.txt_idpeminjaman.Size = new System.Drawing.Size(181, 20);
            this.txt_idpeminjaman.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID Peminjaman";
            // 
            // txt_idbarang
            // 
            this.txt_idbarang.Enabled = false;
            this.txt_idbarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idbarang.Location = new System.Drawing.Point(158, 265);
            this.txt_idbarang.Name = "txt_idbarang";
            this.txt_idbarang.Size = new System.Drawing.Size(181, 20);
            this.txt_idbarang.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "ID Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "ID Pengguna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nama Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nama Pengguna";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Waktu Peminjaman";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Waktu Pemulangan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 529);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Status";
            // 
            // txt_nama_barang
            // 
            this.txt_nama_barang.Enabled = false;
            this.txt_nama_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama_barang.Location = new System.Drawing.Point(158, 341);
            this.txt_nama_barang.Name = "txt_nama_barang";
            this.txt_nama_barang.Size = new System.Drawing.Size(181, 20);
            this.txt_nama_barang.TabIndex = 46;
            // 
            // txt_waktu_peminjaman
            // 
            this.txt_waktu_peminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_waktu_peminjaman.Location = new System.Drawing.Point(159, 414);
            this.txt_waktu_peminjaman.Name = "txt_waktu_peminjaman";
            this.txt_waktu_peminjaman.Size = new System.Drawing.Size(181, 20);
            this.txt_waktu_peminjaman.TabIndex = 47;
            this.txt_waktu_peminjaman.TextChanged += new System.EventHandler(this.txt_waktu_peminjaman_TextChanged);
            // 
            // txt_waktu_pemulangan
            // 
            this.txt_waktu_pemulangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_waktu_pemulangan.Location = new System.Drawing.Point(159, 451);
            this.txt_waktu_pemulangan.Name = "txt_waktu_pemulangan";
            this.txt_waktu_pemulangan.Size = new System.Drawing.Size(181, 20);
            this.txt_waktu_pemulangan.TabIndex = 48;
            this.txt_waktu_pemulangan.TextChanged += new System.EventHandler(this.txt_waktu_pemulangan_TextChanged);
            // 
            // txt_nama_pengguna
            // 
            this.txt_nama_pengguna.Enabled = false;
            this.txt_nama_pengguna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama_pengguna.Location = new System.Drawing.Point(158, 377);
            this.txt_nama_pengguna.Name = "txt_nama_pengguna";
            this.txt_nama_pengguna.Size = new System.Drawing.Size(181, 20);
            this.txt_nama_pengguna.TabIndex = 50;
            // 
            // cbx_status
            // 
            this.cbx_status.Enabled = false;
            this.cbx_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Location = new System.Drawing.Point(159, 524);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(182, 21);
            this.cbx_status.TabIndex = 51;
            this.cbx_status.SelectedIndexChanged += new System.EventHandler(this.cbx_status_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Status Pengguna";
            // 
            // cbx_status_pengguna
            // 
            this.cbx_status_pengguna.Enabled = false;
            this.cbx_status_pengguna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_status_pengguna.FormattingEnabled = true;
            this.cbx_status_pengguna.Location = new System.Drawing.Point(159, 487);
            this.cbx_status_pengguna.Name = "cbx_status_pengguna";
            this.cbx_status_pengguna.Size = new System.Drawing.Size(182, 21);
            this.cbx_status_pengguna.TabIndex = 53;
            // 
            // txt_idpengguna
            // 
            this.txt_idpengguna.Enabled = false;
            this.txt_idpengguna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idpengguna.Location = new System.Drawing.Point(158, 305);
            this.txt_idpengguna.Name = "txt_idpengguna";
            this.txt_idpengguna.Size = new System.Drawing.Size(181, 20);
            this.txt_idpengguna.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(346, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 55;
            this.label11.Text = "yyyy-mm-dd";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(346, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "yyyy-mm-dd";
            // 
            // manage_peminjaman_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 569);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_idpengguna);
            this.Controls.Add(this.cbx_status_pengguna);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbx_status);
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
            this.Controls.Add(this.txt_idbarang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_idpeminjaman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Name = "manage_peminjaman_form";
            this.Text = "manage_peminjaman_form";
            this.Load += new System.EventHandler(this.manage_peminjaman_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idpeminjaman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idbarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nama_barang;
        private System.Windows.Forms.TextBox txt_waktu_peminjaman;
        private System.Windows.Forms.TextBox txt_waktu_pemulangan;
        private System.Windows.Forms.TextBox txt_nama_pengguna;
        private System.Windows.Forms.ComboBox cbx_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_status_pengguna;
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
        private System.Windows.Forms.TextBox txt_idpengguna;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}