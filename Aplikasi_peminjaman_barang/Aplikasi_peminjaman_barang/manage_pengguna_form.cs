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
    public partial class manage_pengguna_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public manage_pengguna_form()
        {
            InitializeComponent();
        }

        private void fill()
        {
            var datapengguna = from dp in db.penggunas
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

        private void idpengguna1()
        {
            String id = (from p in db.penggunas
                         select p.id_pengguna).Max().ToString().Substring(2, 3);

            int idInt = int.Parse(id);
            idInt = idInt + 1;
            String idNew = idInt.ToString();

            while (idNew.Length < 3)
            {
                idNew = "0" + idNew;
            }

            idNew = "UR" + idNew;
            txt_id_pengguna.Text = idNew;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_idbarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_idpeminjaman_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idpengguna_TextChanged(object sender, EventArgs e)
        {

        }

        private void manage_pengguna_form_Load(object sender, EventArgs e)
        {
            cbx_role.Items.Add("Admin");
            cbx_role.Items.Add("Employee");
            cbx_role.Items.Add("Manager");
            fill();
            idpengguna1();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fill();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idpengguna = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            pengguna datapengguna = (from pd in db.penggunas
                                     where pd.id_pengguna == idpengguna
                                     select pd).First();

            txt_id_pengguna.Text = datapengguna.id_pengguna;
            txt_username.Text = datapengguna.username;
            txt_password.Text = datapengguna.password;
            txt_nama_pengguna.Text = datapengguna.nama;
            txt_status_pengguna.Text = datapengguna.status_pengguna;
            cbx_role.Text = datapengguna.role;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_id_pengguna.Text != "" && txt_username.Text != "" && txt_password.Text != "" && txt_nama_pengguna.Text != "" && txt_status_pengguna.Text != "" && cbx_role.Text != "")
            {
                pengguna addpengguna = new pengguna();

                addpengguna.id_pengguna = txt_id_pengguna.Text;
                addpengguna.username = txt_username.Text;
                addpengguna.password = txt_password.Text;
                addpengguna.nama = txt_nama_pengguna.Text;
                addpengguna.status_pengguna = txt_status_pengguna.Text;
                addpengguna.role = cbx_role.Text;
                
                db.penggunas.InsertOnSubmit(addpengguna);
                db.SubmitChanges();

                txt_id_pengguna.Clear();
                txt_username.Clear();
                txt_password.Clear();
                txt_nama_pengguna.Clear();
                txt_status_pengguna.Refresh();
                cbx_role.Refresh();

                fill();
                idpengguna1();

                MessageBox.Show("Pengguna Telah Ditambahkan");
            }

            else
            {
                MessageBox.Show("Anda tidak memasukkan data apapun");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_id_pengguna.Text != "" && txt_username.Text != "" && txt_password.Text != "" && txt_nama_pengguna.Text != "" && txt_status_pengguna.Text != "" && cbx_role.Text != "")
            {
                pengguna updatepengguna = (from up in db.penggunas
                                           where up.id_pengguna == txt_id_pengguna.Text
                                           select up).First();

                updatepengguna.id_pengguna = txt_id_pengguna.Text;
                updatepengguna.username = txt_username.Text;
                updatepengguna.password = txt_password.Text;
                updatepengguna.nama = txt_nama_pengguna.Text;
                updatepengguna.status_pengguna = txt_status_pengguna.Text;
                updatepengguna.role = cbx_role.Text;

                db.SubmitChanges();

                txt_id_pengguna.Clear();
                txt_username.Clear();
                txt_password.Clear();
                txt_nama_pengguna.Clear();
                txt_status_pengguna.Refresh();
                cbx_role.Refresh();

                fill();

                MessageBox.Show("Pengguna Telah Diubah");
            }

            else
            {
                MessageBox.Show("Anda tidak memilih data apapun");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_id_pengguna.Text != "" && txt_username.Text != "" && txt_password.Text != "" && txt_nama_pengguna.Text != "" && txt_status_pengguna.Text != "" && cbx_role.Text != "")
            {
                pengguna deletepengguna = (from dp in db.penggunas
                                           where dp.id_pengguna == txt_id_pengguna.Text
                                           select dp).First();

                db.penggunas.DeleteOnSubmit(deletepengguna);
                db.SubmitChanges();

                txt_id_pengguna.Clear();
                txt_username.Clear();
                txt_password.Clear();
                txt_nama_pengguna.Clear();
                txt_status_pengguna.Refresh();
                cbx_role.Refresh();

                fill();

                MessageBox.Show("Pengguna Telah Dihapus");
            }

            else
            {
                MessageBox.Show("Anda tidak memilih data apapun");
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin_form f2 = new Admin_form();
            f2.Show();
            this.Hide();
        }
    }
}
