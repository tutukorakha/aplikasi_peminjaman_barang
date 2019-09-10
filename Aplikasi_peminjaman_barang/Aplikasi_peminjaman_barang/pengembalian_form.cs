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
    public partial class pengembalian_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public pengembalian_form()
        {
            InitializeComponent();
        }

        private void fill_3()
        {
            var datafill = from dp in db.detailpeminjamans
                           join b in db.barangs
                           on dp.id_barang equals b.id_barang
                           join p in db.penggunas
                           on dp.id_pengguna equals p.id_pengguna
                           where p.nama == Form1.namapengguna
                           where b.nama_barang.Contains(txt_search.Text)
                           select new { dp.id_peminjaman, dp.id_barang, dp.id_pengguna, b.nama_barang, p.nama, dp.waktu_peminjaman, dp.waktu_pemulangan, b.status, p.status_pengguna };

            dataGridView1.Rows.Clear();

            foreach (var DataSingle in datafill)
            {
                dataGridView1.Rows.Add
                (
                    DataSingle.id_peminjaman,
                    DataSingle.id_barang,
                    DataSingle.id_pengguna,
                    DataSingle.nama_barang,
                    DataSingle.nama,
                    DataSingle.waktu_peminjaman,
                    DataSingle.waktu_pemulangan,
                    DataSingle.status,
                    DataSingle.status_pengguna,
                    "SELECT"
                );
            }
        }

        private void pengembalian_form_Load(object sender, EventArgs e)
        {
            fill_3();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string data = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            detailpeminjaman peminjaman = (from dp in db.detailpeminjamans
                                           join b in db.barangs
                                           on dp.id_barang equals b.id_barang
                                           join p in db.penggunas
                                           on dp.id_pengguna equals p.id_pengguna
                                           where dp.id_peminjaman == data
                                           select dp).First();

            txt_id_peminjaman.Text = peminjaman.id_peminjaman;
            txt_id_barang.Text = peminjaman.id_barang;
            txt_id_pengguna.Text = peminjaman.id_pengguna;
            txt_nama_barang.Text = peminjaman.barang.nama_barang;
            txt_nama_pengguna.Text = peminjaman.pengguna.nama;
            txt_waktu_peminjaman.Text = peminjaman.waktu_peminjaman;
            txt_waktu_pemulangan.Text = peminjaman.waktu_pemulangan;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_id_peminjaman.Text != "" && txt_id_barang.Text != "" && txt_id_pengguna.Text != "" && txt_nama_barang.Text != "" && txt_nama_pengguna.Text != "" && txt_status.Text != "" && txt_status_pengguna.Text != "" && txt_waktu_peminjaman.Text != "" && txt_waktu_pemulangan.Text != "")
            {
                var User = from u in db.detailpeminjamans
                           where u.id_pengguna == txt_id_pengguna.Text
                           select u;
                if (User.Count() > 1)
                {
                    detailpeminjaman deletepeminjaman = (from dp in db.detailpeminjamans
                                                         where dp.id_peminjaman == txt_id_peminjaman.Text
                                                         select dp).First();

                    db.detailpeminjamans.DeleteOnSubmit(deletepeminjaman);
                    db.SubmitChanges();

                    pengguna updatepengguna = (from p in db.penggunas
                                               where p.id_pengguna == txt_id_pengguna.Text
                                               select p).First();

                    updatepengguna.id_pengguna = txt_id_pengguna.Text;
                    updatepengguna.nama = txt_nama_pengguna.Text;

                    db.SubmitChanges();

                    barang updatebarang = (from b in db.barangs
                                           where b.id_barang == txt_id_barang.Text
                                           select b).First();

                    updatebarang.id_barang = txt_id_barang.Text;
                    updatebarang.nama_barang = txt_nama_barang.Text;
                    updatebarang.status = txt_status.Text;

                    db.SubmitChanges();

                    txt_id_peminjaman.Clear();
                    txt_id_barang.Clear();
                    txt_id_pengguna.Clear();
                    txt_nama_barang.Clear();
                    txt_nama_pengguna.Clear();
                    txt_waktu_peminjaman.Clear();
                    txt_waktu_pemulangan.Clear();
                    txt_status.Refresh();
                    txt_status_pengguna.Refresh();

                    fill_3();
                }

                else if (User.Count() <= 1)
                {
                    detailpeminjaman deletepeminjaman = (from dp in db.detailpeminjamans
                                                         where dp.id_peminjaman == txt_id_peminjaman.Text
                                                         select dp).First();

                    db.detailpeminjamans.DeleteOnSubmit(deletepeminjaman);
                    db.SubmitChanges();

                    pengguna updatepengguna = (from p in db.penggunas
                                               where p.id_pengguna == txt_id_pengguna.Text
                                               select p).First();

                    updatepengguna.id_pengguna = txt_id_pengguna.Text;
                    updatepengguna.nama = txt_nama_pengguna.Text;
                    updatepengguna.status_pengguna = txt_status_pengguna.Text;

                    db.SubmitChanges();

                    barang updatebarang = (from b in db.barangs
                                           where b.id_barang == txt_id_barang.Text
                                           select b).First();

                    updatebarang.id_barang = txt_id_barang.Text;
                    updatebarang.nama_barang = txt_nama_barang.Text;
                    updatebarang.status = txt_status.Text;

                    db.SubmitChanges();

                    txt_id_peminjaman.Clear();
                    txt_id_barang.Clear();
                    txt_id_pengguna.Clear();
                    txt_nama_barang.Clear();
                    txt_nama_pengguna.Clear();
                    txt_waktu_peminjaman.Clear();
                    txt_waktu_pemulangan.Clear();
                    txt_status.Refresh();
                    txt_status_pengguna.Refresh();

                    fill_3();
                }
                
            }

            else
            {
                MessageBox.Show("Anda tidak memilih data apapun");
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Empolyee_form f4 = new Empolyee_form();
            f4.Show();
            this.Hide();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fill_3();
        }
    }
}
