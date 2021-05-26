namespace BekerjaDenganData2_22
{
    partial class FormHapusJabatan
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
            this.btnCari = new System.Windows.Forms.Button();
            this.btn_batal = new System.Windows.Forms.Button();
            this.btn_Hapus = new System.Windows.Forms.Button();
            this.txtNamaJabatan = new System.Windows.Forms.TextBox();
            this.txtIdJabatan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(247, 98);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(56, 21);
            this.btnCari.TabIndex = 22;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btn_batal
            // 
            this.btn_batal.Location = new System.Drawing.Point(163, 191);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(67, 21);
            this.btn_batal.TabIndex = 21;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = true;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // btn_Hapus
            // 
            this.btn_Hapus.Location = new System.Drawing.Point(65, 191);
            this.btn_Hapus.Name = "btn_Hapus";
            this.btn_Hapus.Size = new System.Drawing.Size(67, 21);
            this.btn_Hapus.TabIndex = 20;
            this.btn_Hapus.Text = "Hapus";
            this.btn_Hapus.UseVisualStyleBackColor = true;
            this.btn_Hapus.Click += new System.EventHandler(this.btn_Hapus_Click);
            // 
            // txtNamaJabatan
            // 
            this.txtNamaJabatan.Location = new System.Drawing.Point(127, 130);
            this.txtNamaJabatan.Name = "txtNamaJabatan";
            this.txtNamaJabatan.Size = new System.Drawing.Size(132, 20);
            this.txtNamaJabatan.TabIndex = 19;
            // 
            // txtIdJabatan
            // 
            this.txtIdJabatan.Location = new System.Drawing.Point(126, 99);
            this.txtIdJabatan.Name = "txtIdJabatan";
            this.txtIdJabatan.Size = new System.Drawing.Size(104, 20);
            this.txtIdJabatan.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nama Jabatan   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID                      :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Jabatan";
            // 
            // FormHapusJabatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 243);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_Hapus);
            this.Controls.Add(this.txtNamaJabatan);
            this.Controls.Add(this.txtIdJabatan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHapusJabatan";
            this.Text = "Hapus Jabatan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Button btn_Hapus;
        private System.Windows.Forms.TextBox txtNamaJabatan;
        private System.Windows.Forms.TextBox txtIdJabatan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}