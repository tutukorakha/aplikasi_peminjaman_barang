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
    public partial class report_barang_manager_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public report_barang_manager_form()
        {
            InitializeComponent();
        }

        private void fill_barang()
        {
            var databarang = from da in db.barangs
                             where da.nama_barang.Contains(txt_search1.Text)
                             select new { da.id_barang, da.nama_barang, da.status };

            dataGridView1.Rows.Clear();

            foreach (var DataSingle in databarang)
            {
                dataGridView1.Rows.Add
                (
                    DataSingle.id_barang,
                    DataSingle.nama_barang,
                    DataSingle.status     
                );
            }
        }

        private void fill_peminjaman()
        {
            var datapeminjaman = from dp in db.detailpeminjamans
                           join b in db.barangs
                           on dp.id_barang equals b.id_barang
                           join p in db.penggunas
                           on dp.id_pengguna equals p.id_pengguna
                           where b.nama_barang.Contains(txt_search2.Text)
                           select new { dp.id_peminjaman, dp.id_barang, dp.id_pengguna, b.nama_barang, p.nama, dp.waktu_peminjaman, dp.waktu_pemulangan, b.status };

            dataGridView2.Rows.Clear();

            foreach (var DataSingle in datapeminjaman)
            {
                dataGridView2.Rows.Add
                (
                    DataSingle.id_peminjaman,
                    DataSingle.id_barang,
                    DataSingle.id_pengguna,
                    DataSingle.nama_barang,
                    DataSingle.nama,
                    DataSingle.waktu_peminjaman,
                    DataSingle.waktu_pemulangan,
                    DataSingle.status,
                    "SELECT"
                );
            }
        }

        private void report_barang_manager_form_Load(object sender, EventArgs e)
        {
            fill_barang();
            fill_peminjaman();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Manager_Form f3 = new Manager_Form();
            f3.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fill_barang();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            fill_peminjaman();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
