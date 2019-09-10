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
    public partial class isian_peminjaman_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        detailpeminjaman dpm = new detailpeminjaman();
        public isian_peminjaman_form()
        {
            InitializeComponent();
        }

        private void id_peminjaman()
        {
            String id = (from dp in db.detailpeminjamans
                         select dp.id_peminjaman).Max().ToString().Substring(2, 3);

            int idInt = int.Parse(id);
            idInt = idInt + 1;
            String idNew = idInt.ToString();

            while (idNew.Length < 3)
            {
                idNew = "0" + idNew;
            }

            idNew = "PM" + idNew;
            txt_id_peminjaman.Text = idNew;
         }

        private void updatepeminjaman()
        {
            detailpeminjaman updatepeminjaman = (from up in db.detailpeminjamans
                                                 where up.id_barang == txt_id_peminjaman.Text
                                                 select up).First();

            updatepeminjaman.id_peminjaman = txt_id_peminjaman.Text;
            updatepeminjaman.waktu_peminjaman = txt_waktu_peminjaman.Text;
            updatepeminjaman.waktu_pemulangan = txt_waktu_pemulangan.Text;

            updatebarang();
            updatepengguna();

            db.SubmitChanges();

            txt_id_peminjaman.Clear();
            txt_nama_barang.Clear();
            txt_namapengguna.Clear();
            txt_waktu_peminjaman.Clear();
            txt_waktu_pemulangan.Clear();
            txt_status.Clear();
        }

        private void updatebarang()
        {
            //barang updatebarang = new barang();
            barang updatebarang = (from ub in db.barangs
                                   where ub.id_barang == txt_id_barang.Text
                                   select ub).First();

            updatebarang.id_barang = txt_id_barang.Text;
            updatebarang.nama_barang = txt_nama_barang.Text;
            updatebarang.status = txt_status.Text;

            db.SubmitChanges();

            txt_id_peminjaman.Clear();
            txt_nama_barang.Clear();
            txt_namapengguna.Clear();
            txt_waktu_peminjaman.Clear();
            txt_waktu_pemulangan.Clear();
            txt_status.Clear();
        }

        private void updatepengguna()
        {
            //pengguna updatepengguna = new pengguna();
            pengguna updatepengguna = (from up in db.penggunas
                                       where up.id_pengguna == txt_id_pengguna.Text
                                       select up).First();

            updatepengguna.id_pengguna = pinjam_form.text_id_pengguna;
            updatepengguna.nama = pinjam_form.text_nama_pengguna;
            updatepengguna.status_pengguna = txt_statuspengguna.Text;

            db.SubmitChanges();

            txt_id_peminjaman.Clear();
            txt_nama_barang.Clear();
            txt_namapengguna.Clear();
            txt_waktu_peminjaman.Clear();
            txt_waktu_pemulangan.Clear();
            txt_status.Clear();
        }

        /*private void fill_list()
         {
             listpeminjaman addlist = new listpeminjaman();

             addlist.id_list = txt_id_list.Text;
             addlist.nama_barang = pinjam_form.text_nama_barang;
             addlist.nama_pengguna = Form1.namapengguna;

             db.listpeminjamans.InsertOnSubmit(addlist);
             db.SubmitChanges();

             txt_id_list.Clear();
             txt_id_peminjaman.Clear();
             txt_nama_barang.Clear();
             txt_namapengguna.Clear();
             txt_waktu_peminjaman.Clear();
             txt_waktu_pemulangan.Clear();
             txt_status.Clear();

         }*/

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

        private void isian_peminjaman_form_Load(object sender, EventArgs e)
        {
            txt_id_barang.Text = pinjam_form.text_id_barang;
            txt_id_pengguna.Text = pinjam_form.text_id_pengguna;
            txt_nama_barang.Text = pinjam_form.text_nama_barang;
            txt_namapengguna.Text = pinjam_form.text_nama_pengguna;
            txt_status.Text = pinjam_form.text_status;
            txt_statuspengguna.Text = pinjam_form.text_status_pengguna;
            id_peminjaman();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txt_waktu_peminjaman.ForeColor == System.Drawing.Color.Green && txt_waktu_pemulangan.ForeColor == System.Drawing.Color.Green)
            {
                detailpeminjaman addpeminjaman = new detailpeminjaman();

                addpeminjaman.id_peminjaman = txt_id_peminjaman.Text;
                addpeminjaman.id_barang = txt_id_barang.Text;
                addpeminjaman.id_pengguna = txt_id_pengguna.Text;
                addpeminjaman.waktu_peminjaman = txt_waktu_peminjaman.Text;
                addpeminjaman.waktu_pemulangan = txt_waktu_pemulangan.Text;

                db.detailpeminjamans.InsertOnSubmit(addpeminjaman);
                db.SubmitChanges();

                updatebarang();
                updatepengguna();
                //fill_list();

                txt_id_peminjaman.Clear();
                txt_nama_barang.Clear();
                txt_namapengguna.Clear();
                txt_waktu_peminjaman.Clear();
                txt_waktu_pemulangan.Clear();
                txt_status.Clear();

                id_peminjaman();

                report_employee_form f8 = new report_employee_form();
                f8.Show();
                this.Hide();
            }

            else if (txt_waktu_peminjaman.ForeColor == System.Drawing.Color.Red && txt_waktu_pemulangan.ForeColor == System.Drawing.Color.Red)
            {
                MessageBox.Show("Masukkan format tanggal dengan benar");
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            pinjam_form f7 = new pinjam_form();
            f7.Show();
            this.Hide();
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
