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
    public partial class FormUpdateKaryawan : Form
    {
        public FormUpdateKaryawan()
        {
            InitializeComponent();
        }

        private void btn_Cari_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source =.; initial catalog = BekerjaDenganData";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Karyawan WHERE nik='"+txtNik.Text +"'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                txtNamaKaryawan.Text = dt.Rows[0]["nama_karyawan"].ToString();
                cmbJabatan.SelectedValue = dt.Rows[0]["jabatan"].ToString();
                txtNamaKaryawan.Enabled = true;
                cmbJabatan.Enabled = true;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormUpdateKaryawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bekerjaDenganDataDataSet.Jabatan' table. You can move, or remove it, as needed.
            this.jabatanTableAdapter.Fill(this.bekerjaDenganDataDataSet.Jabatan);

        }

        private void clear()
        {
            txtNik.Text = "";
            txtNamaKaryawan.Text = "";
            cmbJabatan.SelectedValue = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionString = "integrated security = true; data source =.; initial catalog = BekerjaDenganData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                com.CommandText = "sp_UpdateKaryawan";
                // mengatur tipe command yang akan digunakan
                com.CommandType = CommandType.StoredProcedure;

                //Parameter yang akan dikirimkan ke sp di basis data
                com.Parameters.AddWithValue("@nik", txtNik.Text);
                com.Parameters.AddWithValue("@nama_karyawan", txtNamaKaryawan.Text);
                com.Parameters.AddWithValue("@jabatan", cmbJabatan.SelectedValue.ToString());

                connection.Open();
                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();
                //cek apakah ada data yang ditambahkan
                if (result != 0)
                {
                    MessageBox.Show("Update data berhasil!");
                }
                else
                {
                    MessageBox.Show("Update data gagal!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
