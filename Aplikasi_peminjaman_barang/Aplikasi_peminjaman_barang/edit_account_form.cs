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
    public partial class edit_account_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public edit_account_form()
        {
            InitializeComponent();
        }

        private void edit_account_form_Load(object sender, EventArgs e)
        {
            txt_idpengguna.Text = Form1.idpengguna;
            txt_nama.Text = Form1.namapengguna;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text != "" && txt_password.Text != "")
            {
                pengguna updatepengguna = (from up in db.penggunas
                                           where up.id_pengguna == txt_idpengguna.Text
                                           select up).First();

                updatepengguna.id_pengguna = txt_idpengguna.Text;
                updatepengguna.nama = txt_nama.Text;
                updatepengguna.username = txt_username.Text;
                updatepengguna.password = txt_password.Text;

                db.SubmitChanges();

                txt_username.Clear();
                txt_password.Clear();

                MessageBox.Show("Kami sudah menerima perubahan :)");
            }

            else if (txt_username.Text != "" && txt_password.Text == "")
            {
                MessageBox.Show("HARAP ISI DENGAN LENGKAP !!!");
            }

            else if (txt_username.Text == "" && txt_password.Text != "")
            {
                MessageBox.Show("HARAP ISI DENGAN LENGKAP !!!");
            }

            else
            {
                MessageBox.Show("ANDA TIDAK MENGUBAH APAPUN !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.role == "Admin")
            {
                Admin_form f2 = new Admin_form();
                f2.Show();
                this.Hide();
            }

            else if (Form1.role == "Manager")
            {
                Manager_Form f3 = new Manager_Form();
                f3.Show();
                this.Hide();
            }

            else if (Form1.role == "Employee")
            {
                Empolyee_form f4 = new Empolyee_form();
                f4.Show();
                this.Hide();
            }
        }
    }
}
