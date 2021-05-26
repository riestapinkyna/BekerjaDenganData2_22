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
    public partial class FormHapusJabatan : Form
    {
        public FormHapusJabatan()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source =.; initial catalog = BekerjaDenganData";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Jabatan WHERE id_jabatan='" + txtIdJabatan.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                txtNamaJabatan.Text = dt.Rows[0]["nama_jabatan"].ToString();
                txtNamaJabatan.Enabled = true;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clear()
        {
            txtIdJabatan.Text = "";
            txtNamaJabatan.Text= "";
        }

        private void btn_Hapus_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin akan menghapus data?", "Validasi Hapus", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.No:
                    clear();
                    break;
                case DialogResult.Yes:
                    {
                        try
                        {
                            string connectionString = "integrated security = true; data source =.; initial catalog = BekerjaDenganData";
                            SqlConnection connection = new SqlConnection(connectionString);
                            SqlCommand com = new SqlCommand();
                            com.Connection = connection;
                            com.CommandText = "sp_HapusJabatan";
                            // mengatur tipe command yang akan digunakan
                            com.CommandType = CommandType.StoredProcedure;

                            //Parameter yang akan dikirimkan ke sp di basis data
                            com.Parameters.AddWithValue("@id", txtIdJabatan.Text);
                            connection.Open();
                            int result = Convert.ToInt32(com.ExecuteNonQuery());
                            connection.Close();
                            //cek apakah ada data yang ditambahkan
                            if (result != 0)
                            {
                                MessageBox.Show("Hapus data berhasil!");
                            }
                            else
                            {
                                MessageBox.Show("Hapus data gagal!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    break;
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
