using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using System.IO;
using System.Windows.Forms;

namespace Aplikasi_peminjaman_barang
{
    public partial class manage_barang_form : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        barang newbarang = new barang();
        public manage_barang_form()
        {
            InitializeComponent();
        }

        private void fill()
        {
            var DataBarang = from b in db.barangs
                             where b.nama_barang.Contains(txt_search.Text)
                             select new
                             { b.id_barang, b.nama_barang, b.status };

            dataGridView1.Rows.Clear();

            foreach (var dataSingle in DataBarang)
            {
                dataGridView1.Rows.Add
                    (
                        dataSingle.id_barang,
                        dataSingle.nama_barang,
                        dataSingle.status,
                        "SELECT"
                    );
            }
        }

        private void ID_barang()
        {
            String id = (from b in db.barangs
                         select b.id_barang).Max().ToString().Substring(1, 4);

            int idInt = int.Parse(id);
            idInt = idInt + 1;
            String idNew = idInt.ToString();

            while (idNew.Length < 4)
            {
                idNew = "0" + idNew;
            }

            idNew = "B" + idNew;
            txt_idbarang.Text = idNew;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbx_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void manage_barang_form_Load(object sender, EventArgs e)
        {
            fill();
            ID_barang();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin_form f2 = new Admin_form();
            f2.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_idbarang.Text != "" && txt_nama_barang.Text != "" && txt_status.Text != "")
            {
                barang addbarang = new barang();

                addbarang.id_barang = txt_idbarang.Text;
                addbarang.nama_barang = txt_nama_barang.Text;
                addbarang.status = txt_status.Text;

                db.barangs.InsertOnSubmit(addbarang);
                db.SubmitChanges();

                dataGridView1.Rows.Clear();
                txt_idbarang.Refresh();
                txt_nama_barang.Clear();
                txt_status.Clear();

                fill();
                ID_barang();

                MessageBox.Show("Barang Telah Ditambahkan");
            }

            else
            {
                MessageBox.Show("Anda tidak memasukkan data apapaun");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idbarang = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            barang databarang = (from b in db.barangs
                                 where b.id_barang == idbarang
                                 select b).First();

            txt_idbarang.Text = databarang.id_barang;
            txt_nama_barang.Text = databarang.nama_barang;
            txt_status.Text = databarang.status;
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_idbarang.Text != "" && txt_nama_barang.Text != "" && txt_status.Text != "")
            {
                barang updatebarang = (from b in db.barangs
                                       where b.id_barang == txt_idbarang.Text
                                       select b).First();
                updatebarang.nama_barang = txt_nama_barang.Text;

                db.SubmitChanges();

                dataGridView1.Rows.Clear();
                txt_idbarang.Refresh();
                txt_nama_barang.Clear();
                txt_status.Clear();

                fill();

                MessageBox.Show("Barang Telah Diubah");
            }

            else
            {
                MessageBox.Show("Anda tidak memiliih data apapun");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_idbarang.Text != "" && txt_nama_barang.Text != "" && txt_status.Text != "")
            {
                var baranng = from p in db.detailpeminjamans
                              where p.id_barang == txt_idbarang.Text
                              select p;

                if (baranng.Count() < 1)
                {
                    barang deletebarang = (from da in db.barangs
                                           where da.id_barang == txt_idbarang.Text
                                           select da).First();

                    db.barangs.DeleteOnSubmit(deletebarang);
                    db.SubmitChanges();

                    dataGridView1.Rows.Clear();
                    txt_nama_barang.Clear();

                    fill();

                    MessageBox.Show("Barang Telah Dihapus");
                }

                else
                {
                    MessageBox.Show("Maaf Barang Harus Dikembalikan Dahulu !!!");
                }
                
            }

            else
            {
                MessageBox.Show("Anda tidak memilih data apapun");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            report_employee_form f8 = new report_employee_form();
            f8.Show();
            this.Hide();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fill();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.Filter = "Excel Files|*.xls;*.xlsx";

            if (opendialog.ShowDialog() == DialogResult.Cancel)
                return;

            FileStream stream = new FileStream(opendialog.FileName, FileMode.Open);
            IExcelDataReader excelreader = ExcelReaderFactory.CreateBinaryReader(stream);
            DataSet result = excelreader.AsDataSet();

            DataClasses1DataContext db = new DataClasses1DataContext();
            foreach (DataTable table in result.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    barang adduser = new barang()
                    {
                        id_barang = Convert.ToString(dr[0]),
                        nama_barang = Convert.ToString(dr[1]),
                        status = Convert.ToString(dr[2])
                    };

                    db.barangs.InsertOnSubmit(adduser);
                }
            }

            db.SubmitChanges();

            excelreader.Close();
            stream.Close();

            dataGridView1.Rows.Clear();
            fill();
        }
    }
}
