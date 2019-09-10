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
    public partial class Manager_Form : Form
    {
        public Manager_Form()
        {
            InitializeComponent();
        }

        private void Manager_Form_Load(object sender, EventArgs e)
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
            report_barang_manager_form f11 = new report_barang_manager_form();
            f11.Show();
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
