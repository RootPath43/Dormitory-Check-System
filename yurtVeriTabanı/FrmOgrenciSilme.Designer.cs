namespace yurtVeriTabanı
{
    partial class FrmOgrenciSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciSilme));
            this.mtxt_ogr_TC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ogr_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ogr_soyad = new System.Windows.Forms.TextBox();
            this.btn_silme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtxt_ogr_TC
            // 
            this.mtxt_ogr_TC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxt_ogr_TC.Location = new System.Drawing.Point(147, 66);
            this.mtxt_ogr_TC.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_ogr_TC.Mask = "00000000000";
            this.mtxt_ogr_TC.Name = "mtxt_ogr_TC";
            this.mtxt_ogr_TC.Size = new System.Drawing.Size(193, 31);
            this.mtxt_ogr_TC.TabIndex = 3;
            this.mtxt_ogr_TC.ValidatingType = typeof(int);
            this.mtxt_ogr_TC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxt_ogr_TC_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "TC :";
            // 
            // txt_ogr_ad
            // 
            this.txt_ogr_ad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogr_ad.Location = new System.Drawing.Point(147, 105);
            this.txt_ogr_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ogr_ad.Name = "txt_ogr_ad";
            this.txt_ogr_ad.Size = new System.Drawing.Size(193, 31);
            this.txt_ogr_ad.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PapayaWhip;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Soyadı :";
            // 
            // txt_ogr_soyad
            // 
            this.txt_ogr_soyad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogr_soyad.Location = new System.Drawing.Point(147, 145);
            this.txt_ogr_soyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ogr_soyad.Name = "txt_ogr_soyad";
            this.txt_ogr_soyad.Size = new System.Drawing.Size(193, 31);
            this.txt_ogr_soyad.TabIndex = 9;
            // 
            // btn_silme
            // 
            this.btn_silme.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_silme.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_silme.Location = new System.Drawing.Point(71, 216);
            this.btn_silme.Margin = new System.Windows.Forms.Padding(4);
            this.btn_silme.Name = "btn_silme";
            this.btn_silme.Size = new System.Drawing.Size(245, 50);
            this.btn_silme.TabIndex = 11;
            this.btn_silme.Text = "Öğrenci Silme";
            this.btn_silme.UseVisualStyleBackColor = false;
            this.btn_silme.Click += new System.EventHandler(this.btn_silme_Click);
            // 
            // FrmOgrenciSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 325);
            this.Controls.Add(this.btn_silme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ogr_soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ogr_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxt_ogr_TC);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgrenciSilme";
            this.Text = "FrmOgrenciSilme";
            this.Load += new System.EventHandler(this.FrmOgrenciSilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxt_ogr_TC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ogr_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ogr_soyad;
        private System.Windows.Forms.Button btn_silme;
    }
}