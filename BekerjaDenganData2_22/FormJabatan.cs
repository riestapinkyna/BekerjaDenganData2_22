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
    public partial class FormJabatan : Form
    {
        public FormJabatan()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txtIdJabatan.Text = "";
            txtNamaJabatan.Text = "";
        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source =.; initial catalog = BekerjaDenganData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                com.CommandText = "sp_InputJabatan";
                // mengatur tipe command yang akan digunakan
                com.CommandType = CommandType.StoredProcedure;

                //Parameter yang akan dikirimkan ke sp di basis data
                com.Parameters.AddWithValue("@id_jabatan", txtIdJabatan.Text);
                com.Parameters.AddWithValue("@nama_jabatan", txtNamaJabatan.Text);

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
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
