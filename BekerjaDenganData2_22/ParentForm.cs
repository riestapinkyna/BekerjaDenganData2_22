using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BekerjaDenganData2_22
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormInsertKaryawan form = new FormInsertKaryawan();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormUpdateKaryawan form = new FormUpdateKaryawan();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormHapusKaryawan form = new FormHapusKaryawan();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormJabatan form = new FormJabatan();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUpdateJabatan form = new FormUpdateJabatan();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHapusJabatan form = new FormHapusJabatan();
            form.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
