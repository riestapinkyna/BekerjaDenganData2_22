namespace BekerjaDenganData2_22
{
    partial class FormInsertKaryawan
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
            this.btnSimpan = new System.Windows.Forms.Button();
            this.cmbJabatan = new System.Windows.Forms.ComboBox();
            this.jabatanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bekerjaDenganDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bekerjaDenganDataDataSet = new BekerjaDenganData2_22.BekerjaDenganDataDataSet();
            this.txtNamaKaryawan = new System.Windows.Forms.TextBox();
            this.txtNik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.karyawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.karyawanTableAdapter = new BekerjaDenganData2_22.BekerjaDenganDataDataSetTableAdapters.KaryawanTableAdapter();
            this.jabatanTableAdapter = new BekerjaDenganData2_22.BekerjaDenganDataDataSetTableAdapters.JabatanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bekerjaDenganDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bekerjaDenganDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(101, 189);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(74, 23);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // cmbJabatan
            // 
            this.cmbJabatan.DataSource = this.jabatanBindingSource;
            this.cmbJabatan.DisplayMember = "nama_jabatan";
            this.cmbJabatan.FormattingEnabled = true;
            this.cmbJabatan.Location = new System.Drawing.Point(142, 145);
            this.cmbJabatan.Name = "cmbJabatan";
            this.cmbJabatan.Size = new System.Drawing.Size(167, 21);
            this.cmbJabatan.TabIndex = 14;
            this.cmbJabatan.ValueMember = "id_jabatan";
            // 
            // jabatanBindingSource
            // 
            this.jabatanBindingSource.DataMember = "Jabatan";
            this.jabatanBindingSource.DataSource = this.bekerjaDenganDataDataSetBindingSource;
            // 
            // bekerjaDenganDataDataSetBindingSource
            // 
            this.bekerjaDenganDataDataSetBindingSource.DataSource = this.bekerjaDenganDataDataSet;
            this.bekerjaDenganDataDataSetBindingSource.Position = 0;
            // 
            // bekerjaDenganDataDataSet
            // 
            this.bekerjaDenganDataDataSet.DataSetName = "BekerjaDenganDataDataSet";
            this.bekerjaDenganDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNamaKaryawan
            // 
            this.txtNamaKaryawan.Location = new System.Drawing.Point(142, 112);
            this.txtNamaKaryawan.Name = "txtNamaKaryawan";
            this.txtNamaKaryawan.Size = new System.Drawing.Size(167, 20);
            this.txtNamaKaryawan.TabIndex = 13;
            // 
            // txtNik
            // 
            this.txtNik.Location = new System.Drawing.Point(142, 75);
            this.txtNik.Name = "txtNik";
            this.txtNik.Size = new System.Drawing.Size(167, 20);
            this.txtNik.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jabatan                :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nama Karyawan   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "NIK                       :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Karyawan";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(196, 189);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(81, 23);
            this.btnBatal.TabIndex = 16;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // karyawanBindingSource
            // 
            this.karyawanBindingSource.DataMember = "Karyawan";
            this.karyawanBindingSource.DataSource = this.bekerjaDenganDataDataSetBindingSource;
            // 
            // karyawanTableAdapter
            // 
            this.karyawanTableAdapter.ClearBeforeFill = true;
            // 
            // jabatanTableAdapter
            // 
            this.jabatanTableAdapter.ClearBeforeFill = true;
            // 
            // FormInsertKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 243);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cmbJabatan);
            this.Controls.Add(this.txtNamaKaryawan);
            this.Controls.Add(this.txtNik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInsertKaryawan";
            this.Text = "Input Data Karyawan";
            this.Load += new System.EventHandler(this.FormKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bekerjaDenganDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bekerjaDenganDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ComboBox cmbJabatan;
        private System.Windows.Forms.TextBox txtNamaKaryawan;
        private System.Windows.Forms.TextBox txtNik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.BindingSource bekerjaDenganDataDataSetBindingSource;
        private BekerjaDenganDataDataSet bekerjaDenganDataDataSet;
        private System.Windows.Forms.BindingSource karyawanBindingSource;
        private BekerjaDenganDataDataSetTableAdapters.KaryawanTableAdapter karyawanTableAdapter;
        private System.Windows.Forms.BindingSource jabatanBindingSource;
        private BekerjaDenganDataDataSetTableAdapters.JabatanTableAdapter jabatanTableAdapter;
    }
}