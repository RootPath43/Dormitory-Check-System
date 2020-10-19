namespace yurtVeriTabanı
{
    partial class FrmOgrenciOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciOdeme));
            this.btn_makbuz = new System.Windows.Forms.Button();
            this.btn_ode = new System.Windows.Forms.Button();
            this.mtxt_ogr_TC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_odenen = new System.Windows.Forms.TextBox();
            this.txt_kalan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txt_ogr_ad = new System.Windows.Forms.TextBox();
            this.txt_ogr_soyad = new System.Windows.Forms.TextBox();
            this.cmb_ay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ay_id = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_makbuz
            // 
            this.btn_makbuz.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_makbuz.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_makbuz.Location = new System.Drawing.Point(135, 354);
            this.btn_makbuz.Margin = new System.Windows.Forms.Padding(4);
            this.btn_makbuz.Name = "btn_makbuz";
            this.btn_makbuz.Size = new System.Drawing.Size(240, 65);
            this.btn_makbuz.TabIndex = 3;
            this.btn_makbuz.Text = "Makbuz Çıkar";
            this.btn_makbuz.UseVisualStyleBackColor = false;
            this.btn_makbuz.Click += new System.EventHandler(this.btn_makbuz_Click);
            // 
            // btn_ode
            // 
            this.btn_ode.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_ode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ode.Location = new System.Drawing.Point(135, 281);
            this.btn_ode.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ode.Name = "btn_ode";
            this.btn_ode.Size = new System.Drawing.Size(240, 65);
            this.btn_ode.TabIndex = 4;
            this.btn_ode.Text = "Öde";
            this.btn_ode.UseVisualStyleBackColor = false;
            this.btn_ode.Click += new System.EventHandler(this.btn_ode_Click);
            // 
            // mtxt_ogr_TC
            // 
            this.mtxt_ogr_TC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxt_ogr_TC.Location = new System.Drawing.Point(212, 110);
            this.mtxt_ogr_TC.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_ogr_TC.Mask = "00000000000";
            this.mtxt_ogr_TC.Name = "mtxt_ogr_TC";
            this.mtxt_ogr_TC.Size = new System.Drawing.Size(193, 31);
            this.mtxt_ogr_TC.TabIndex = 5;
            this.mtxt_ogr_TC.ValidatingType = typeof(int);
            this.mtxt_ogr_TC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxt_ogr_TC_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(145, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "TC :";
            // 
            // txt_odenen
            // 
            this.txt_odenen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_odenen.Location = new System.Drawing.Point(212, 190);
            this.txt_odenen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_odenen.Name = "txt_odenen";
            this.txt_odenen.Size = new System.Drawing.Size(193, 31);
            this.txt_odenen.TabIndex = 7;
            // 
            // txt_kalan
            // 
            this.txt_kalan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kalan.Location = new System.Drawing.Point(212, 229);
            this.txt_kalan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kalan.Name = "txt_kalan";
            this.txt_kalan.Size = new System.Drawing.Size(193, 31);
            this.txt_kalan.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ödenen Tutar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PapayaWhip;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kalan Tutar :";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txt_ogr_ad
            // 
            this.txt_ogr_ad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogr_ad.Location = new System.Drawing.Point(212, 15);
            this.txt_ogr_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ogr_ad.Name = "txt_ogr_ad";
            this.txt_ogr_ad.Size = new System.Drawing.Size(193, 31);
            this.txt_ogr_ad.TabIndex = 11;
            this.txt_ogr_ad.Visible = false;
            // 
            // txt_ogr_soyad
            // 
            this.txt_ogr_soyad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogr_soyad.Location = new System.Drawing.Point(212, 54);
            this.txt_ogr_soyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ogr_soyad.Name = "txt_ogr_soyad";
            this.txt_ogr_soyad.Size = new System.Drawing.Size(193, 31);
            this.txt_ogr_soyad.TabIndex = 12;
            this.txt_ogr_soyad.Visible = false;
            // 
            // cmb_ay
            // 
            this.cmb_ay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_ay.FormattingEnabled = true;
            this.cmb_ay.Location = new System.Drawing.Point(212, 149);
            this.cmb_ay.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ay.Name = "cmb_ay";
            this.cmb_ay.Size = new System.Drawing.Size(193, 31);
            this.cmb_ay.TabIndex = 26;
            this.cmb_ay.SelectedIndexChanged += new System.EventHandler(this.cmb_ay_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PapayaWhip;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(145, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ay :";
            // 
            // txt_ay_id
            // 
            this.txt_ay_id.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ay_id.Location = new System.Drawing.Point(72, 149);
            this.txt_ay_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ay_id.Name = "txt_ay_id";
            this.txt_ay_id.Size = new System.Drawing.Size(61, 31);
            this.txt_ay_id.TabIndex = 28;
            this.txt_ay_id.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmOgrenciOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_ay_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_ay);
            this.Controls.Add(this.txt_ogr_soyad);
            this.Controls.Add(this.txt_ogr_ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kalan);
            this.Controls.Add(this.txt_odenen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxt_ogr_TC);
            this.Controls.Add(this.btn_ode);
            this.Controls.Add(this.btn_makbuz);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgrenciOdeme";
            this.Text = "FrmOgrenciOdeme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_makbuz;
        private System.Windows.Forms.Button btn_ode;
        private System.Windows.Forms.MaskedTextBox mtxt_ogr_TC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_odenen;
        private System.Windows.Forms.TextBox txt_kalan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txt_ogr_ad;
        private System.Windows.Forms.TextBox txt_ogr_soyad;
        private System.Windows.Forms.ComboBox cmb_ay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ay_id;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}