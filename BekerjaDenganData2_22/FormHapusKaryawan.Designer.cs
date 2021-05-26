namespace BekerjaDenganData2_22
{
    partial class FormHapusKaryawan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Cari = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.txtNamaKaryawan = new System.Windows.Forms.TextBox();
            this.txtNik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bekerjaDenganDataDataSet = new BekerjaDenganData2_22.BekerjaDenganDataDataSet();
            this.karyawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.karyawanTableAdapter = new BekerjaDenganData2_22.BekerjaDenganDataDataSetTableAdapters.KaryawanTableAdapter();
            this.karyawanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbJabatan = new System.Windows.Forms.ComboBox();
            this.jabatanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jabatanTableAdapter = new BekerjaDenganData2_22.BekerjaDenganDataDataSetTableAdapters.JabatanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bekerjaDenganDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cari
            // 
            this.btn_Cari.Location = new System.Drawing.Point(257, 77);
            this.btn_Cari.Name = "btn_Cari";
            this.btn_Cari.Size = new System.Drawing.Size(53, 23);
            this.btn_Cari.TabIndex = 36;
            this.btn_Cari.Text = "Cari";
            this.btn_Cari.UseVisualStyleBackColor = true;
            this.btn_Cari.Click += new System.EventHandler(this.btn_Cari_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(197, 191);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(81, 23);
            this.btnBatal.TabIndex = 35;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(102, 191);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(74, 23);
            this.btnHapus.TabIndex = 34;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // txtNamaKaryawan
            // 
            this.txtNamaKaryawan.Location = new System.Drawing.Point(143, 114);
            this.txtNamaKaryawan.Name = "txtNamaKaryawan";
            this.txtNamaKaryawan.Size = new System.Drawing.Size(167, 20);
            this.txtNamaKaryawan.TabIndex = 32;
            // 
            // txtNik
            // 
            this.txtNik.Location = new System.Drawing.Point(143, 77);
            this.txtNik.Name = "txtNik";
            this.txtNik.Size = new System.Drawing.Size(97, 20);
            this.txtNik.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Jabatan                :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nama Karyawan   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "NIK                       :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Karyawan";
            // 
            // bekerjaDenganDataDataSet
            // 
            this.bekerjaDenganDataDataSet.DataSetName = "BekerjaDenganDataDataSet";
            this.bekerjaDenganDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karyawanBindingSource
            // 
            this.karyawanBindingSource.DataMember = "Karyawan";
            this.karyawanBindingSource.DataSource = this.bekerjaDenganDataDataSet;
            // 
            // karyawanTableAdapter
            // 
            this.karyawanTableAdapter.ClearBeforeFill = true;
            // 
            // karyawanBindingSource1
            // 
            this.karyawanBindingSource1.DataMember = "Karyawan";
            this.karyawanBindingSource1.DataSource = this.bekerjaDenganDataDataSet;
            // 
            // cmbJabatan
            // 
            this.cmbJabatan.DataSource = this.jabatanBindingSource;
            this.cmbJabatan.DisplayMember = "nama_jabatan";
            this.cmbJabatan.FormattingEnabled = true;
            this.cmbJabatan.Location = new System.Drawing.Point(143, 152);
            this.cmbJabatan.Name = "cmbJabatan";
            this.cmbJabatan.Size = new System.Drawing.Size(167, 21);
            this.cmbJabatan.TabIndex = 37;
            this.cmbJabatan.ValueMember = "id_jabatan";
            // 
            // jabatanBindingSource
            // 
            this.jabatanBindingSource.DataMember = "Jabatan";
            this.jabatanBindingSource.DataSource = this.bekerjaDenganDataDataSet;
            // 
            // jabatanTableAdapter
            // 
            this.jabatanTableAdapter.ClearBeforeFill = true;
            // 
            // FormHapusKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 243);
            this.Controls.Add(this.cmbJabatan);
            this.Controls.Add(this.btn_Cari);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.txtNamaKaryawan);
            this.Controls.Add(this.txtNik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHapusKaryawan";
            this.Text = "Hapus Karyawan";
            this.Load += new System.EventHandler(this.FormHapusKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bekerjaDenganDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cari;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox txtNamaKaryawan;
        private System.Windows.Forms.TextBox txtNik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BekerjaDenganDataDataSet bekerjaDenganDataDataSet;
        private System.Windows.Forms.BindingSource karyawanBindingSource;
        private BekerjaDenganDataDataSetTableAdapters.KaryawanTableAdapter karyawanTableAdapter;
        private System.Windows.Forms.BindingSource karyawanBindingSource1;
        private System.Windows.Forms.ComboBox cmbJabatan;
        private System.Windows.Forms.BindingSource jabatanBindingSource;
        private BekerjaDenganDataDataSetTableAdapters.JabatanTableAdapter jabatanTableAdapter;
    }
}