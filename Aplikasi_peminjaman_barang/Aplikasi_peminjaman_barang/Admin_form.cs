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
    public partial class Admin_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Admin_form()
        {
            InitializeComponent();
        }

        private void Admin_form_Load(object sender, EventArgs e)
        {
            lbl_username.Text = Form1.username;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manage_barang_form f5 = new manage_barang_form();
            f5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            manage_peminjaman_form f10 = new manage_peminjaman_form();
            f10.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            manage_pengguna_form f13 = new manage_pengguna_form();
            f13.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit_account_form f15 = new edit_account_form();
            f15.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add_peminjaman_pengguna_form f14 = new add_peminjaman_pengguna_form();
            f14.Show();
            this.Hide();
        }
    }
}
