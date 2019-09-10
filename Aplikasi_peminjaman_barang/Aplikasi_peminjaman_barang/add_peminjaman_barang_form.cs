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
    public partial class add_peminjaman_barang_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public static string add_text_nama_barang;
        public static string add_text_id_barang;
        public static string add_text_status;
        public add_peminjaman_barang_form()
        {
            InitializeComponent();
        }

        private void fill_5()
        {
            var databarang = from dg in db.barangs
                             where dg.status == "Ada"
                             where dg.nama_barang.Contains(txt_search.Text)
                             select new { dg.id_barang, dg.nama_barang, dg.status };

            dataGridView1.Rows.Clear();

            foreach (var DataSingle in databarang)
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

        private void add_peminjaman_barang_form_Load(object sender, EventArgs e)
        {
            fill_5();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fill_5();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string databarang = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            barang barang1 = (from b in db.barangs
                              where b.id_barang == databarang
                              select b).First();

            txt_id_barang.Text = barang1.id_barang;
            txt_nama_barang.Text = barang1.nama_barang;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txt_id_barang.Text != "" && txt_nama_barang.Text != "" && txt_status.Text != "")
            {
                add_text_id_barang = txt_id_barang.Text;
                add_text_nama_barang = txt_nama_barang.Text;
                add_text_status = txt_status.Text;

                add_peminjaman_isian_form f16 = new add_peminjaman_isian_form();
                f16.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Anda Tidak Memilih Data Apapun");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_peminjaman_pengguna_form f18 = new add_peminjaman_pengguna_form();
            f18.Show();
            this.Hide();
        }
    }
}
