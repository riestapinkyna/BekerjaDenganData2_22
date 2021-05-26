using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BekerjaDenganData2_22
{
    public partial class FormInsertKaryawan : Form
    {
        public FormInsertKaryawan()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source =.; initial catalog = BekerjaDenganData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                com.CommandText = "sp_InputKaryawan";
                // mengatur tipe command yang akan digunakan
                com.CommandType = CommandType.StoredProcedure;

                //Parameter yang akan dikirimkan ke sp di basis data
                com.Parameters.AddWithValue("@nik", txtNik.Text);
                com.Parameters.AddWithValue ("@nama_karyawan", txtNamaKaryawan.Text);
                com.Parameters.AddWithValue("@jabatan", cmbJabatan.SelectedValue.ToString());

                connection.Open();
                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();
                //cek apakah ada data yang ditambahkan
                if (result != 0)
                {
                    MessageBox.Show("Input data berhasil!");
                }
                else
                {
                    MessageBox.Show("Input data gagal!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clear()
        {
            txtNik.Text = "";
            txtNamaKaryawan.Text = "";
            cmbJabatan.SelectedValue = "";
        }

        private void FormKaryawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bekerjaDenganDataDataSet.Jabatan' table. You can move, or remove it, as needed.
            this.jabatanTableAdapter.Fill(this.bekerjaDenganDataDataSet.Jabatan);
            // TODO: This line of code loads data into the 'bekerjaDenganDataDataSet.Karyawan' table. You can move, or remove it, as needed.
            this.karyawanTableAdapter.Fill(this.bekerjaDenganDataDataSet.Karyawan);

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
