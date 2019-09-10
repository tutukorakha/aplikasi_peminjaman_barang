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
    public partial class add_peminjaman_pengguna_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public static string add_text_idpengguna;
        public static string add_text_nama;
        public static string add_text_status_pengguna;
        public add_peminjaman_pengguna_form()
        {
            InitializeComponent();
        }

        private void fill_4()
        {
            var datapengguna = from dp in db.penggunas
                               where dp.role == "Employee"
                               where dp.nama.Contains(txt_search.Text)
                               select new { dp.id_pengguna, dp.username, dp.password, dp.nama, dp.status_pengguna, dp.role };

            dataGridView1.Rows.Clear();

            foreach (var DataSingle in datapengguna)
            {
                dataGridView1.Rows.Add
                (
                    DataSingle.id_pengguna,
                    DataSingle.username,
                    DataSingle.password,
                    DataSingle.nama,
                    DataSingle.status_pengguna,
                    DataSingle.role,
                    "SELECT"
                );
            }
        }

        private void add_peminjaman_pengguna_form_Load(object sender, EventArgs e)
        {
            fill_4();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string datapengguna = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            pengguna pengguna1 = (from p in db.penggunas
                                  where p.id_pengguna == datapengguna
                                  select p).First();

            txt_id_pengguna.Text = pengguna1.id_pengguna;
            txt_username.Text = pengguna1.username;
            txt_password.Text = pengguna1.password;
            txt_nama.Text = pengguna1.nama;
            txt_role.Text = pengguna1.role;

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txt_id_pengguna.Text != "" && txt_username.Text != "" && txt_password.Text != "" && txt_nama.Text != "" && txt_status_pengguna.Text != "" && txt_role.Text != "")
            {
                add_text_idpengguna = txt_id_pengguna.Text;
                add_text_nama = txt_nama.Text;
                add_text_status_pengguna = txt_status_pengguna.Text;

                add_peminjaman_barang_form f15 = new add_peminjaman_barang_form();
                f15.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Maaf Anda Tidak Memilih Data Apapun");
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fill_4();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_form f19 = new Admin_form();
            f19.Show();
            this.Hide();
        }
    }
}
