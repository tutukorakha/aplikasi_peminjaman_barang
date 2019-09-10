using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_peminjaman_barang
{
    public partial class pinjam_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public static string text_id_barang;
        public static string text_id_pengguna;
        public static string text_nama_barang;
        public static string text_nama_pengguna;
        public static string text_status;
        public static string text_status_pengguna;
        public pinjam_form()
        {
            InitializeComponent();
        }

        private void Fill_2 ()
        {
            var DataPinjam_1 = from dp in db.barangs
                               where dp.status == "Ada"
                               where dp.nama_barang.Contains(txt_search.Text)
                               select new { dp.id_barang, dp.nama_barang, dp.status };

            dataGridView1.Rows.Clear();

            foreach (var DataSingle in DataPinjam_1)
            {
                dataGridView1.Rows.Add
                (
                    DataSingle.id_barang,
                    DataSingle.nama_barang,
                    DataSingle.status,
                    "SELECT"
                );
            }
        }
        
        private void pinjam_form_Load(object sender, EventArgs e)
        {
            txt_id_pengguna.Text = Form1.idpengguna;
            txt_nama_pengguna.Text = Form1.namapengguna;
            Fill_2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pinjam = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            barang datapinjam = (from dp in db.barangs
                                 where dp.id_barang == pinjam
                                 select dp).First();

            txt_id_barang.Text = datapinjam.id_barang;
            txt_nama_barang.Text = datapinjam.nama_barang;

        }

        private void btn_lanjut_Click(object sender, EventArgs e)
        {
            if (txt_id_barang.Text != "" && txt_id_pengguna.Text != "" && txt_nama_barang.Text != "" && txt_nama_pengguna.Text != "" && txt_status.Text != "" && txt_status_pengguna.Text != "")
            {
                text_id_barang = txt_id_barang.Text;
                text_id_pengguna = txt_id_pengguna.Text;
                text_nama_barang = txt_nama_barang.Text;
                text_nama_pengguna = txt_nama_pengguna.Text;
                text_status = txt_status.Text;
                text_status_pengguna = txt_status_pengguna.Text;

                isian_peminjaman_form f7 = new isian_peminjaman_form();
                f7.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Anda tidak meminjam apapun");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Empolyee_form f3 = new Empolyee_form();
            f3.Show();
            this.Hide();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            Fill_2();
        }
    }
}
