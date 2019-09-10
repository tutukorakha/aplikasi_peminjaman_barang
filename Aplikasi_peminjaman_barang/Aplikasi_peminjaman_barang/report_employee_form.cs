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
    public partial class report_employee_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public report_employee_form()
        {
            InitializeComponent();
        }

        private void fill_3()
        {
            var datapinjam_2 = from dp in db.detailpeminjamans
                               join b in db.barangs
                               on dp.id_barang equals b.id_barang
                               join p in db.penggunas
                               on dp.id_pengguna equals p.id_pengguna
                               select new { dp.id_peminjaman, b.nama_barang, p.nama, dp.waktu_peminjaman, dp.waktu_pemulangan, b.status };

            foreach (var datasingle in datapinjam_2)
            {
                dataGridView1.Rows.Add
                (
                    datasingle.id_peminjaman,
                    datasingle.nama_barang,
                    datasingle.nama,
                    datasingle.waktu_peminjaman,
                    datasingle.waktu_pemulangan,
                    datasingle.status    
                );
            }
        }

        private void report_employee_form_Load(object sender, EventArgs e)
        {
            fill_3();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Empolyee_form f3 = new Empolyee_form();
            f3.Show();
            this.Hide();
        }
    }
}
