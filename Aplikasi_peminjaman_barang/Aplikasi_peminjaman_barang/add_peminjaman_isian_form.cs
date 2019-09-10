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
    public partial class add_peminjaman_isian_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public add_peminjaman_isian_form()
        {
            InitializeComponent();
        }

        private void id_peminjaman()
        {
            String id = (from dp in db.detailpeminjamans
                         select dp.id_peminjaman).Max().ToString().Substring(2, 3);

            int IdInt = int.Parse(id);
            IdInt = IdInt + 1;
            String idNew = IdInt.ToString();

            while (idNew.Length < 3)
            {
                idNew = "0" + idNew;
            }

            idNew = "PM" + idNew;
            txt_id_peminjaman.Text = idNew;
        }

        private void updatebarang()
        {
            barang updatebarang = (from ub in db.barangs
                                   where ub.id_barang == txt_id_barang.Text
                                   select ub).First();

            updatebarang.id_barang = txt_id_barang.Text;
            updatebarang.nama_barang = txt_nama_barang.Text;
            updatebarang.status = txt_status.Text;

            db.SubmitChanges();
            
        }

        private void updatepengguna()
        {
            //pengguna updatepengguna = new pengguna();
            pengguna updatepengguna = (from up in db.penggunas
                                       where up.id_pengguna == txt_id_pengguna.Text
                                       select up).First();

            updatepengguna.id_pengguna = add_peminjaman_pengguna_form.add_text_idpengguna;
            updatepengguna.nama = add_peminjaman_pengguna_form.add_text_nama;
            updatepengguna.status_pengguna = txt_statuspengguna.Text;

            db.SubmitChanges();

        }

        private void add_peminjaman_isian_form_Load(object sender, EventArgs e)
        {
            id_peminjaman();
            txt_id_barang.Text = add_peminjaman_barang_form.add_text_id_barang;
            txt_id_pengguna.Text = add_peminjaman_pengguna_form.add_text_idpengguna;
            txt_nama_barang.Text = add_peminjaman_barang_form.add_text_nama_barang;
            txt_namapengguna.Text = add_peminjaman_pengguna_form.add_text_nama;
            txt_status.Text = add_peminjaman_barang_form.add_text_status;
            txt_statuspengguna.Text = add_peminjaman_pengguna_form.add_text_status_pengguna;
        }

        private void btn_next_Click(object sender, EventArgs e)
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

            report_admin_form f8 = new report_admin_form();
            f8.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            add_peminjaman_barang_form f17 = new add_peminjaman_barang_form();
            f17.Show();
            this.Hide();
        }
    }
}
