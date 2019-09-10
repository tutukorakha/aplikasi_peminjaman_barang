using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Aplikasi_peminjaman_barang
{
    public partial class manage_peminjaman_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public manage_peminjaman_form()
        {
            InitializeComponent();
        }

        private void penulisan_waktu()
        {
            Regex waktu_peminjaman = new Regex("^[0-9]{4}[-]{1}[0-9]{2}[-]{1}[0-9]{2}$");

            if (waktu_peminjaman.IsMatch(txt_waktu_peminjaman.Text))
            {
                txt_waktu_peminjaman.ForeColor = System.Drawing.Color.Green;
            }

            else
            {
                txt_waktu_peminjaman.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void penulisan_waktu_1()
        {
            Regex waktu_peminjaman = new Regex("^[0-9]{4}[-]{1}[0-9]{2}[-]{1}[0-9]{2}$");

            if (waktu_peminjaman.IsMatch(txt_waktu_pemulangan.Text))
            {
                txt_waktu_pemulangan.ForeColor = System.Drawing.Color.Green;
            }

            else
            {
                txt_waktu_pemulangan.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void fill()
        {
            var datafill = from dp in db.detailpeminjamans
                           join b in db.barangs
                           on dp.id_barang equals b.id_barang
                           join p in db.penggunas
                           on dp.id_pengguna equals p.id_pengguna
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

        private void manage_peminjaman_form_Load(object sender, EventArgs e)
        {
            cbx_status_pengguna.Items.Add("tidak meminjam");
            cbx_status_pengguna.Items.Add("meminjam");
            cbx_status.Items.Add("Ada");
            cbx_status.Items.Add("Pinjam");
            fill();
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

            txt_idpeminjaman.Text = peminjaman.id_peminjaman;
            txt_idbarang.Text = peminjaman.id_barang;
            txt_idpengguna.Text = peminjaman.id_pengguna;
            txt_nama_barang.Text = peminjaman.barang.nama_barang;
            txt_nama_pengguna.Text = peminjaman.pengguna.nama;
            txt_waktu_peminjaman.Text = peminjaman.waktu_peminjaman;
            txt_waktu_pemulangan.Text = peminjaman.waktu_pemulangan;
            cbx_status.Text = peminjaman.barang.status;
            cbx_status_pengguna.Text = peminjaman.pengguna.status_pengguna;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin_form f2 = new Admin_form();
            f2.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_idpeminjaman.Text != "" && txt_idbarang.Text != "" && txt_idpengguna.Text != "" && txt_nama_barang.Text != "" && txt_nama_pengguna.Text != "" && txt_waktu_peminjaman.Text != "" && txt_waktu_pemulangan.Text != "")
            {
                var User = from u in db.detailpeminjamans
                           where u.id_pengguna == txt_idpengguna.Text
                           select u;
                if (User.Count() > 1)
                {
                    if (txt_waktu_peminjaman.ForeColor == System.Drawing.Color.Green && txt_waktu_pemulangan.ForeColor == System.Drawing.Color.Green)
                    {
                        detailpeminjaman deletepeminjaman = (from dp in db.detailpeminjamans
                                                             where dp.id_peminjaman == txt_idpeminjaman.Text
                                                             select dp).First();

                        db.detailpeminjamans.DeleteOnSubmit(deletepeminjaman);
                        db.SubmitChanges();

                        pengguna updatepengguna = (from p in db.penggunas
                                                   where p.id_pengguna == txt_idpengguna.Text
                                                   select p).First();

                        updatepengguna.id_pengguna = txt_idpengguna.Text;
                        updatepengguna.nama = txt_nama_pengguna.Text;

                        db.SubmitChanges();

                        barang updatebarang = (from b in db.barangs
                                               where b.id_barang == txt_idbarang.Text
                                               select b).First();

                        updatebarang.id_barang = txt_idbarang.Text;
                        updatebarang.nama_barang = txt_nama_barang.Text;
                        updatebarang.status = "Ada";

                        db.SubmitChanges();

                        txt_idpeminjaman.Clear();
                        txt_idbarang.Clear();
                        txt_idpengguna.Clear();
                        txt_nama_barang.Clear();
                        txt_nama_pengguna.Clear();
                        txt_waktu_peminjaman.Clear();
                        txt_waktu_pemulangan.Clear();
                        cbx_status.Refresh();
                        cbx_status_pengguna.Refresh();

                        fill();

                        MessageBox.Show("Peminjaman Telah Dihapus");
                    }

                    else if (txt_waktu_peminjaman.ForeColor == System.Drawing.Color.Red && txt_waktu_pemulangan.ForeColor == System.Drawing.Color.Red)
                    {
                        MessageBox.Show("Masukkan format tanggal dengan benar");
                    }
                    
                }

                else if (User.Count() <=1)
                {
                    if (txt_waktu_peminjaman.ForeColor == System.Drawing.Color.Green && txt_waktu_pemulangan.ForeColor == System.Drawing.Color.Green)
                    {
                        detailpeminjaman deletepeminjaman = (from dp in db.detailpeminjamans
                                                             where dp.id_peminjaman == txt_idpeminjaman.Text
                                                             select dp).First();

                        db.detailpeminjamans.DeleteOnSubmit(deletepeminjaman);
                        db.SubmitChanges();

                        pengguna updatepengguna = (from p in db.penggunas
                                                   where p.id_pengguna == txt_idpengguna.Text
                                                   select p).First();

                        updatepengguna.id_pengguna = txt_idpengguna.Text;
                        updatepengguna.nama = txt_nama_pengguna.Text;
                        updatepengguna.status_pengguna = "tidak meminjam";

                        db.SubmitChanges();

                        barang updatebarang = (from b in db.barangs
                                               where b.id_barang == txt_idbarang.Text
                                               select b).First();

                        updatebarang.id_barang = txt_idbarang.Text;
                        updatebarang.nama_barang = txt_nama_barang.Text;
                        updatebarang.status = "Ada";

                        db.SubmitChanges();

                        txt_idpeminjaman.Clear();
                        txt_idbarang.Clear();
                        txt_idpengguna.Clear();
                        txt_nama_barang.Clear();
                        txt_nama_pengguna.Clear();
                        txt_waktu_peminjaman.Clear();
                        txt_waktu_pemulangan.Clear();
                        cbx_status.Refresh();
                        cbx_status_pengguna.Refresh();

                        fill();
                    }

                    else if (txt_waktu_peminjaman.ForeColor == System.Drawing.Color.Red && txt_waktu_pemulangan.ForeColor == System.Drawing.Color.Red)
                    {
                        MessageBox.Show("Masukkan format tanggal dengan benar");
                    }
                    
                }
                
            }

            else
            {
                MessageBox.Show("Anda tidak memilih data apapun");
            }
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fill();
        }

        private void cbx_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_idpeminjaman.Text != "" && txt_idbarang.Text != "" && txt_idpengguna.Text != "" && txt_nama_barang.Text != "" && txt_nama_pengguna.Text != "" && txt_waktu_peminjaman.Text != "" && txt_waktu_pemulangan.Text != "")
            {
                if (txt_waktu_peminjaman.ForeColor == System.Drawing.Color.Green && txt_waktu_pemulangan.ForeColor == System.Drawing.Color.Green)
                {
                    detailpeminjaman updatepeminjaman = (from up in db.detailpeminjamans
                                                         where up.id_peminjaman == txt_idpeminjaman.Text
                                                         select up).First();

                    updatepeminjaman.id_peminjaman = txt_idpeminjaman.Text;
                    updatepeminjaman.id_barang = txt_idbarang.Text;
                    updatepeminjaman.id_pengguna = txt_idpengguna.Text;
                    updatepeminjaman.waktu_peminjaman = txt_waktu_peminjaman.Text;
                    updatepeminjaman.waktu_pemulangan = txt_waktu_pemulangan.Text;

                    db.SubmitChanges();

                    txt_idpeminjaman.Clear();
                    txt_idbarang.Clear();
                    txt_idpengguna.Clear();
                    txt_nama_barang.Clear();
                    txt_nama_pengguna.Clear();
                    txt_waktu_peminjaman.Clear();
                    txt_waktu_pemulangan.Clear();
                    cbx_status.Refresh();
                    cbx_status_pengguna.Refresh();

                    fill();

                    MessageBox.Show("Peminjaman Telah Diubah");
                }

                else if (txt_waktu_peminjaman.ForeColor == System.Drawing.Color.Red && txt_waktu_pemulangan.ForeColor == System.Drawing.Color.Red)
                {
                    MessageBox.Show("Masukkan format tanggal dengan benar");
                }
                
            }

            else
            {
                MessageBox.Show("Anda tidak memilih data apapun");
            }
        }

        private void txt_waktu_peminjaman_TextChanged(object sender, EventArgs e)
        {
            penulisan_waktu();
        }

        private void txt_waktu_pemulangan_TextChanged(object sender, EventArgs e)
        {
            penulisan_waktu_1();
        }
    }
}
