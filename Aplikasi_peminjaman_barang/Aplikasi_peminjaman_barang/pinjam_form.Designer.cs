namespace Aplikasi_peminjaman_barang
{
    partial class pinjam_form
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
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nama_pengguna = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label_2 = new System.Windows.Forms.Label();
            this.txt_nama_barang = new System.Windows.Forms.TextBox();
            this.btn_lanjut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_barang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id_pengguna = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_status_pengguna = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(896, 14);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 30);
            this.btn_back.TabIndex = 18;
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
            this.status,
            this.select});
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 150);
            this.dataGridView1.TabIndex = 16;
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
            // select
            // 
            this.select.HeaderText = "SELECT";
            this.select.Name = "select";
            this.select.Text = "SELECT";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(83, 14);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(160, 20);
            this.txt_search.TabIndex = 15;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search";
            // 
            // txt_nama_pengguna
            // 
            this.txt_nama_pengguna.Enabled = false;
            this.txt_nama_pengguna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama_pengguna.Location = new System.Drawing.Point(140, 298);
            this.txt_nama_pengguna.Name = "txt_nama_pengguna";
            this.txt_nama_pengguna.Size = new System.Drawing.Size(181, 20);
            this.txt_nama_pengguna.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nama Pengguna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Status";
            // 
            // txt_status
            // 
            this.txt_status.Enabled = false;
            this.txt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(138, 368);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(181, 20);
            this.txt_status.TabIndex = 28;
            this.txt_status.Text = "Pinjam";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(9, 338);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(103, 16);
            this.label_2.TabIndex = 29;
            this.label_2.Text = "Nama Barang";
            // 
            // txt_nama_barang
            // 
            this.txt_nama_barang.Enabled = false;
            this.txt_nama_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama_barang.Location = new System.Drawing.Point(140, 334);
            this.txt_nama_barang.Name = "txt_nama_barang";
            this.txt_nama_barang.Size = new System.Drawing.Size(181, 20);
            this.txt_nama_barang.TabIndex = 30;
            // 
            // btn_lanjut
            // 
            this.btn_lanjut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lanjut.Location = new System.Drawing.Point(887, 365);
            this.btn_lanjut.Name = "btn_lanjut";
            this.btn_lanjut.Size = new System.Drawing.Size(116, 34);
            this.btn_lanjut.TabIndex = 31;
            this.btn_lanjut.Text = "Selanjutnya";
            this.btn_lanjut.UseVisualStyleBackColor = true;
            this.btn_lanjut.Click += new System.EventHandler(this.btn_lanjut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID Barang";
            // 
            // txt_id_barang
            // 
            this.txt_id_barang.Enabled = false;
            this.txt_id_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_barang.Location = new System.Drawing.Point(140, 228);
            this.txt_id_barang.Name = "txt_id_barang";
            this.txt_id_barang.Size = new System.Drawing.Size(181, 20);
            this.txt_id_barang.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "ID Pengguna";
            // 
            // txt_id_pengguna
            // 
            this.txt_id_pengguna.Enabled = false;
            this.txt_id_pengguna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_pengguna.Location = new System.Drawing.Point(140, 265);
            this.txt_id_pengguna.Name = "txt_id_pengguna";
            this.txt_id_pengguna.Size = new System.Drawing.Size(181, 20);
            this.txt_id_pengguna.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Status Pengguna";
            // 
            // txt_status_pengguna
            // 
            this.txt_status_pengguna.Enabled = false;
            this.txt_status_pengguna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status_pengguna.Location = new System.Drawing.Point(140, 404);
            this.txt_status_pengguna.Name = "txt_status_pengguna";
            this.txt_status_pengguna.Size = new System.Drawing.Size(181, 20);
            this.txt_status_pengguna.TabIndex = 37;
            this.txt_status_pengguna.Text = "meminjam";
            // 
            // pinjam_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 442);
            this.Controls.Add(this.txt_status_pengguna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_id_pengguna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id_barang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_lanjut);
            this.Controls.Add(this.txt_nama_barang);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nama_pengguna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Name = "pinjam_form";
            this.Text = "Pinjam Form";
            this.Load += new System.EventHandler(this.pinjam_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nama_pengguna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.TextBox txt_nama_barang;
        private System.Windows.Forms.Button btn_lanjut;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_barang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id_pengguna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_status_pengguna;
    }
}