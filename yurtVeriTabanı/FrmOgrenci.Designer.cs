namespace yurtVeriTabanı
{
    partial class FrmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenci));
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_ogrlistele = new System.Windows.Forms.Button();
            this.btn_silme = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Moccasin;
            this.btn_kaydet.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(939, 159);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(300, 65);
            this.btn_kaydet.TabIndex = 0;
            this.btn_kaydet.Text = "Öğrenci Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_ogrlistele
            // 
            this.btn_ogrlistele.BackColor = System.Drawing.Color.Moccasin;
            this.btn_ogrlistele.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrlistele.Location = new System.Drawing.Point(939, 400);
            this.btn_ogrlistele.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ogrlistele.Name = "btn_ogrlistele";
            this.btn_ogrlistele.Size = new System.Drawing.Size(300, 65);
            this.btn_ogrlistele.TabIndex = 2;
            this.btn_ogrlistele.Text = "Öğrenci Listele";
            this.btn_ogrlistele.UseVisualStyleBackColor = false;
            this.btn_ogrlistele.Click += new System.EventHandler(this.btn_ogrlistele_Click);
            // 
            // btn_silme
            // 
            this.btn_silme.BackColor = System.Drawing.Color.Moccasin;
            this.btn_silme.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_silme.Location = new System.Drawing.Point(939, 518);
            this.btn_silme.Margin = new System.Windows.Forms.Padding(4);
            this.btn_silme.Name = "btn_silme";
            this.btn_silme.Size = new System.Drawing.Size(300, 65);
            this.btn_silme.TabIndex = 3;
            this.btn_silme.Text = "Öğrenci Silme";
            this.btn_silme.UseVisualStyleBackColor = false;
            this.btn_silme.Click += new System.EventHandler(this.btn_silme_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Moccasin;
            this.btnGuncelle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(939, 278);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(300, 65);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Öğrenci Bilgisi Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btn_silme);
            this.Controls.Add(this.btn_ogrlistele);
            this.Controls.Add(this.btn_kaydet);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgrenci";
            this.Text = "FrmOgrenci";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_ogrlistele;
        private System.Windows.Forms.Button btn_silme;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}