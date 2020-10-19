namespace yurtVeriTabanı
{
    partial class FrmAnaMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaMenu));
            this.btn_ogreci = new System.Windows.Forms.Button();
            this.btn_fiyatduzenle = new System.Windows.Forms.Button();
            this.btn_odemeislemleri = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Hastaliklar = new System.Windows.Forms.Button();
            this.btn_Kasa = new System.Windows.Forms.Button();
            this.btn_alacaklar = new System.Windows.Forms.Button();
            this.btn_yapılacaklar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ogreci
            // 
            this.btn_ogreci.BackColor = System.Drawing.Color.Moccasin;
            this.btn_ogreci.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogreci.Location = new System.Drawing.Point(964, 164);
            this.btn_ogreci.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ogreci.Name = "btn_ogreci";
            this.btn_ogreci.Size = new System.Drawing.Size(240, 65);
            this.btn_ogreci.TabIndex = 0;
            this.btn_ogreci.Text = "Ögrenci İşlemleri";
            this.btn_ogreci.UseVisualStyleBackColor = false;
            this.btn_ogreci.Click += new System.EventHandler(this.btn_ogreci_Click);
            // 
            // btn_fiyatduzenle
            // 
            this.btn_fiyatduzenle.BackColor = System.Drawing.Color.Moccasin;
            this.btn_fiyatduzenle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fiyatduzenle.Location = new System.Drawing.Point(964, 310);
            this.btn_fiyatduzenle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fiyatduzenle.Name = "btn_fiyatduzenle";
            this.btn_fiyatduzenle.Size = new System.Drawing.Size(240, 65);
            this.btn_fiyatduzenle.TabIndex = 1;
            this.btn_fiyatduzenle.Text = "Fiyat Düzenleme";
            this.btn_fiyatduzenle.UseVisualStyleBackColor = false;
            this.btn_fiyatduzenle.Click += new System.EventHandler(this.btn_fiyatduzenle_Click);
            // 
            // btn_odemeislemleri
            // 
            this.btn_odemeislemleri.BackColor = System.Drawing.Color.Moccasin;
            this.btn_odemeislemleri.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_odemeislemleri.Location = new System.Drawing.Point(964, 237);
            this.btn_odemeislemleri.Margin = new System.Windows.Forms.Padding(4);
            this.btn_odemeislemleri.Name = "btn_odemeislemleri";
            this.btn_odemeislemleri.Size = new System.Drawing.Size(240, 65);
            this.btn_odemeislemleri.TabIndex = 2;
            this.btn_odemeislemleri.Text = "Ödeme İşlemleri";
            this.btn_odemeislemleri.UseVisualStyleBackColor = false;
            this.btn_odemeislemleri.Click += new System.EventHandler(this.btn_odemeislemleri_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Ekle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(964, 383);
            this.btn_Ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(240, 65);
            this.btn_Ekle.TabIndex = 4;
            this.btn_Ekle.Text = "Fakülte-Oda Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Hastaliklar
            // 
            this.btn_Hastaliklar.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Hastaliklar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Hastaliklar.Location = new System.Drawing.Point(964, 456);
            this.btn_Hastaliklar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Hastaliklar.Name = "btn_Hastaliklar";
            this.btn_Hastaliklar.Size = new System.Drawing.Size(240, 65);
            this.btn_Hastaliklar.TabIndex = 5;
            this.btn_Hastaliklar.Text = "Hastalıklar";
            this.btn_Hastaliklar.UseVisualStyleBackColor = false;
            this.btn_Hastaliklar.Click += new System.EventHandler(this.btn_Hastaliklar_Click);
            // 
            // btn_Kasa
            // 
            this.btn_Kasa.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Kasa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kasa.Location = new System.Drawing.Point(964, 602);
            this.btn_Kasa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Kasa.Name = "btn_Kasa";
            this.btn_Kasa.Size = new System.Drawing.Size(240, 65);
            this.btn_Kasa.TabIndex = 6;
            this.btn_Kasa.Text = "Kasa";
            this.btn_Kasa.UseVisualStyleBackColor = false;
            this.btn_Kasa.Click += new System.EventHandler(this.btn_Kasa_Click);
            // 
            // btn_alacaklar
            // 
            this.btn_alacaklar.BackColor = System.Drawing.Color.Moccasin;
            this.btn_alacaklar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_alacaklar.Location = new System.Drawing.Point(964, 529);
            this.btn_alacaklar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_alacaklar.Name = "btn_alacaklar";
            this.btn_alacaklar.Size = new System.Drawing.Size(240, 65);
            this.btn_alacaklar.TabIndex = 7;
            this.btn_alacaklar.Text = "Öğrenci Borçları";
            this.btn_alacaklar.UseVisualStyleBackColor = false;
            this.btn_alacaklar.Click += new System.EventHandler(this.btn_alacaklar_Click);
            // 
            // btn_yapılacaklar
            // 
            this.btn_yapılacaklar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yapılacaklar.Location = new System.Drawing.Point(977, 785);
            this.btn_yapılacaklar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_yapılacaklar.Name = "btn_yapılacaklar";
            this.btn_yapılacaklar.Size = new System.Drawing.Size(244, 29);
            this.btn_yapılacaklar.TabIndex = 3;
            this.btn_yapılacaklar.Text = "Yapılacaklar";
            this.btn_yapılacaklar.UseVisualStyleBackColor = true;
            this.btn_yapılacaklar.Visible = false;
            this.btn_yapılacaklar.Click += new System.EventHandler(this.btn_yapılacaklar_Click);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 827);
            this.Controls.Add(this.btn_alacaklar);
            this.Controls.Add(this.btn_Kasa);
            this.Controls.Add(this.btn_Hastaliklar);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_yapılacaklar);
            this.Controls.Add(this.btn_odemeislemleri);
            this.Controls.Add(this.btn_fiyatduzenle);
            this.Controls.Add(this.btn_ogreci);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmAnaMenu";
            this.Text = "ANA MENÜ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ogreci;
        private System.Windows.Forms.Button btn_fiyatduzenle;
        private System.Windows.Forms.Button btn_odemeislemleri;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Hastaliklar;
        private System.Windows.Forms.Button btn_Kasa;
        private System.Windows.Forms.Button btn_alacaklar;
        private System.Windows.Forms.Button btn_yapılacaklar;
    }
}

