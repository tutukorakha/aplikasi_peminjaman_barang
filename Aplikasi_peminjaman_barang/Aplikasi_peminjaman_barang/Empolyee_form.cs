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
    public partial class Empolyee_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public Empolyee_form()
        {
            InitializeComponent();
        }

        private void Empolyee_form_Load(object sender, EventArgs e)
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
            pinjam_form f5 = new pinjam_form();
            f5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pengembalian_form f14 = new pengembalian_form();
            f14.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit_account_form f15 = new edit_account_form();
            f15.Show();
            this.Hide();
        }
    }
}
