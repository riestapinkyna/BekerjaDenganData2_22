namespace BekerjaDenganData2_22
{
    partial class FormJabatan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdJabatan = new System.Windows.Forms.TextBox();
            this.txtNamaJabatan = new System.Windows.Forms.TextBox();
            this.btn_Simpan = new System.Windows.Forms.Button();
            this.btn_batal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jabatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID                      :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Jabatan   :";
            // 
            // txtIdJabatan
            // 
            this.txtIdJabatan.Location = new System.Drawing.Point(132, 86);
            this.txtIdJabatan.Name = "txtIdJabatan";
            this.txtIdJabatan.Size = new System.Drawing.Size(132, 20);
            this.txtIdJabatan.TabIndex = 3;
            // 
            // txtNamaJabatan
            // 
            this.txtNamaJabatan.Location = new System.Drawing.Point(133, 117);
            this.txtNamaJabatan.Name = "txtNamaJabatan";
            this.txtNamaJabatan.Size = new System.Drawing.Size(132, 20);
            this.txtNamaJabatan.TabIndex = 4;
            // 
            // btn_Simpan
            // 
            this.btn_Simpan.Location = new System.Drawing.Point(71, 178);
            this.btn_Simpan.Name = "btn_Simpan";
            this.btn_Simpan.Size = new System.Drawing.Size(67, 21);
            this.btn_Simpan.TabIndex = 5;
            this.btn_Simpan.Text = "Simpan";
            this.btn_Simpan.UseVisualStyleBackColor = true;
            this.btn_Simpan.Click += new System.EventHandler(this.btn_Simpan_Click);
            // 
            // btn_batal
            // 
            this.btn_batal.Location = new System.Drawing.Point(169, 178);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(67, 21);
            this.btn_batal.TabIndex = 6;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = true;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // FormJabatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 243);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_Simpan);
            this.Controls.Add(this.txtNamaJabatan);
            this.Controls.Add(this.txtIdJabatan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormJabatan";
            this.Text = "Form Input Jabatan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdJabatan;
        private System.Windows.Forms.TextBox txtNamaJabatan;
        private System.Windows.Forms.Button btn_Simpan;
        private System.Windows.Forms.Button btn_batal;
    }
}

