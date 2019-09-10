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
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        pengguna UserPosition;

        public static string idpengguna;
        public static string username;
        public static string namapengguna;
        public static string statuspengguna;
        public static string role;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var UserLogin = from usr in db.penggunas
                            where usr.username == txt_username.Text && usr.password == txt_password.Text
                            select usr;

            if (UserLogin.Count() == 1)
            {
                UserPosition = UserLogin.First();
                if (UserPosition.role == "Admin")
                {
                    idpengguna = UserLogin.First().id_pengguna;
                    username = UserLogin.First().username;
                    namapengguna = UserLogin.First().nama;
                    role = UserLogin.First().role;
                    Admin_form f2 = new Admin_form();
                    f2.Show();
                    this.Hide();
                }

                else if (UserPosition.role == "Manager")
                {
                    idpengguna = UserLogin.First().id_pengguna;
                    username = UserLogin.First().username;
                    namapengguna = UserLogin.First().nama;
                    role = UserLogin.First().role;
                    Manager_Form f3 = new Manager_Form();
                    f3.Show();
                    this.Hide();
                }

                else if (UserPosition.role == "Employee")
                {
                    idpengguna = UserLogin.First().id_pengguna;
                    username = UserLogin.First().username;
                    namapengguna = UserLogin.First().nama;
                    statuspengguna = UserLogin.First().status_pengguna;
                    role = UserLogin.First().role;
                    Empolyee_form f4 = new Empolyee_form();
                    f4.Show();
                    this.Hide();
                }
            }

            else if (txt_username.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("HARAP ISI DENGAN LENGKAP !!!");
            }

            else if (txt_username.Text == "" && txt_password.Text != "")
            {
                MessageBox.Show("HARAP ISI DENGAN LENGKAP !!!");
            }

            else if (txt_username.Text != "" && txt_password.Text == "")
            {
                MessageBox.Show("HARAP ISI DENGAN LENGKAP !!!");
            }

            else
            {
                MessageBox.Show("TIDAK ADA AKUN TERSEBUT !!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
