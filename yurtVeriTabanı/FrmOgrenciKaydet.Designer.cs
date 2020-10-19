namespace yurtVeriTabanı
{
    partial class FrmOgrenciKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciKaydet));
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.mtxt_ogr_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_ogr_ad = new System.Windows.Forms.TextBox();
            this.txt_ogr_soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dogumYeri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_fakulte = new System.Windows.Forms.ComboBox();
            this.cmb_bolum = new System.Windows.Forms.ComboBox();
            this.mtxt_ogr_tel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.cmb_kan = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_hastalik = new System.Windows.Forms.ComboBox();
            this.cmb_kat = new System.Windows.Forms.ComboBox();
            this.cmb_yatakno = new System.Windows.Forms.ComboBox();
            this.cmb_odano = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_veli_ad = new System.Windows.Forms.TextBox();
            this.txt_veli_soyad = new System.Windows.Forms.TextBox();
            this.mtxt_veli_tel = new System.Windows.Forms.MaskedTextBox();
            this.rtxt_adres = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_fakulte_id = new System.Windows.Forms.TextBox();
            this.txt_bolum_id = new System.Windows.Forms.TextBox();
            this.txt_kan_id = new System.Windows.Forms.TextBox();
            this.txt_hastalik_id = new System.Windows.Forms.TextBox();
            this.txt_oda_id = new System.Windows.Forms.TextBox();
            this.txt_yatak_id = new System.Windows.Forms.TextBox();
            this.lblfyt = new System.Windows.Forms.Label();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.txt_oda_kapasite = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.datetimekayit = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_tarih = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblkayit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Peru;
            this.btn_kaydet.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(1099, 546);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(201, 53);
            this.btn_kaydet.TabIndex = 0;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // mtxt_ogr_TC
            // 
            this.mtxt_ogr_TC.BackColor = System.Drawing.Color.Bisque;
            this.mtxt_ogr_TC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxt_ogr_TC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mtxt_ogr_TC.Location = new System.Drawing.Point(196, 64);
            this.mtxt_ogr_TC.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_ogr_TC.Mask = "00000000000";
            this.mtxt_ogr_TC.Name = "mtxt_ogr_TC";
            this.mtxt_ogr_TC.Size = new System.Drawing.Size(193, 31);
            this.mtxt_ogr_TC.TabIndex = 2;
            this.mtxt_ogr_TC.ValidatingType = typeof(int);
            // 
            // txt_ogr_ad
            // 
            this.txt_ogr_ad.BackColor = System.Drawing.Color.Bisque;
            this.txt_ogr_ad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogr_ad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ogr_ad.Location = new System.Drawing.Point(196, 119);
            this.txt_ogr_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ogr_ad.Name = "txt_ogr_ad";
            this.txt_ogr_ad.Size = new System.Drawing.Size(193, 31);
            this.txt_ogr_ad.TabIndex = 3;
            // 
            // txt_ogr_soyad
            // 
            this.txt_ogr_soyad.BackColor = System.Drawing.Color.Bisque;
            this.txt_ogr_soyad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogr_soyad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ogr_soyad.Location = new System.Drawing.Point(196, 172);
            this.txt_ogr_soyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ogr_soyad.Name = "txt_ogr_soyad";
            this.txt_ogr_soyad.Size = new System.Drawing.Size(193, 31);
            this.txt_ogr_soyad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(128, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(116, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyadı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(213, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ögrenci";
            // 
            // txt_dogumYeri
            // 
            this.txt_dogumYeri.BackColor = System.Drawing.Color.Bisque;
            this.txt_dogumYeri.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_dogumYeri.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_dogumYeri.Location = new System.Drawing.Point(196, 225);
            this.txt_dogumYeri.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dogumYeri.Name = "txt_dogumYeri";
            this.txt_dogumYeri.Size = new System.Drawing.Size(193, 31);
            this.txt_dogumYeri.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doğum Yeri :";
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateDogumTarihi.Location = new System.Drawing.Point(196, 278);
            this.dateDogumTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(352, 31);
            this.dateDogumTarihi.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 286);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(68, 334);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fakülte :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(92, 384);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bölüm :";
            // 
            // cmb_fakulte
            // 
            this.cmb_fakulte.BackColor = System.Drawing.Color.Bisque;
            this.cmb_fakulte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fakulte.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_fakulte.FormattingEnabled = true;
            this.cmb_fakulte.Location = new System.Drawing.Point(196, 330);
            this.cmb_fakulte.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_fakulte.Name = "cmb_fakulte";
            this.cmb_fakulte.Size = new System.Drawing.Size(477, 31);
            this.cmb_fakulte.TabIndex = 15;
            this.cmb_fakulte.SelectedIndexChanged += new System.EventHandler(this.cmb_fakulte_SelectedIndexChanged);
            // 
            // cmb_bolum
            // 
            this.cmb_bolum.BackColor = System.Drawing.Color.Bisque;
            this.cmb_bolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bolum.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_bolum.FormattingEnabled = true;
            this.cmb_bolum.Location = new System.Drawing.Point(196, 380);
            this.cmb_bolum.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_bolum.Name = "cmb_bolum";
            this.cmb_bolum.Size = new System.Drawing.Size(477, 31);
            this.cmb_bolum.TabIndex = 16;
            this.cmb_bolum.SelectedIndexChanged += new System.EventHandler(this.cmb_bolum_SelectedIndexChanged);
            // 
            // mtxt_ogr_tel
            // 
            this.mtxt_ogr_tel.BackColor = System.Drawing.Color.Bisque;
            this.mtxt_ogr_tel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxt_ogr_tel.Location = new System.Drawing.Point(196, 431);
            this.mtxt_ogr_tel.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_ogr_tel.Mask = "(999) 000-0000";
            this.mtxt_ogr_tel.Name = "mtxt_ogr_tel";
            this.mtxt_ogr_tel.Size = new System.Drawing.Size(193, 31);
            this.mtxt_ogr_tel.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(68, 434);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefon :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(104, 482);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Mail :";
            // 
            // txt_mail
            // 
            this.txt_mail.BackColor = System.Drawing.Color.Bisque;
            this.txt_mail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mail.Location = new System.Drawing.Point(196, 479);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(352, 31);
            this.txt_mail.TabIndex = 20;
            // 
            // cmb_kan
            // 
            this.cmb_kan.BackColor = System.Drawing.Color.Bisque;
            this.cmb_kan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kan.FormattingEnabled = true;
            this.cmb_kan.Location = new System.Drawing.Point(196, 532);
            this.cmb_kan.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_kan.Name = "cmb_kan";
            this.cmb_kan.Size = new System.Drawing.Size(193, 31);
            this.cmb_kan.TabIndex = 21;
            this.cmb_kan.SelectedIndexChanged += new System.EventHandler(this.cmb_kan_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(44, 535);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Kan Grubu :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(8, 583);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "Hastalık Adı :";
            // 
            // cmb_hastalik
            // 
            this.cmb_hastalik.BackColor = System.Drawing.Color.Bisque;
            this.cmb_hastalik.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_hastalik.FormattingEnabled = true;
            this.cmb_hastalik.Location = new System.Drawing.Point(196, 580);
            this.cmb_hastalik.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_hastalik.Name = "cmb_hastalik";
            this.cmb_hastalik.Size = new System.Drawing.Size(352, 31);
            this.cmb_hastalik.TabIndex = 24;
            this.cmb_hastalik.SelectedIndexChanged += new System.EventHandler(this.cmb_hastalik_SelectedIndexChanged);
            // 
            // cmb_kat
            // 
            this.cmb_kat.BackColor = System.Drawing.Color.Bisque;
            this.cmb_kat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kat.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kat.FormattingEnabled = true;
            this.cmb_kat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmb_kat.Location = new System.Drawing.Point(196, 631);
            this.cmb_kat.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_kat.Name = "cmb_kat";
            this.cmb_kat.Size = new System.Drawing.Size(193, 31);
            this.cmb_kat.TabIndex = 25;
            this.cmb_kat.SelectedIndexChanged += new System.EventHandler(this.cmb_kat_SelectedIndexChanged);
            // 
            // cmb_yatakno
            // 
            this.cmb_yatakno.BackColor = System.Drawing.Color.Bisque;
            this.cmb_yatakno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_yatakno.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_yatakno.FormattingEnabled = true;
            this.cmb_yatakno.Location = new System.Drawing.Point(196, 746);
            this.cmb_yatakno.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_yatakno.Name = "cmb_yatakno";
            this.cmb_yatakno.Size = new System.Drawing.Size(193, 31);
            this.cmb_yatakno.TabIndex = 26;
            this.cmb_yatakno.SelectedIndexChanged += new System.EventHandler(this.cmb_yatakno_SelectedIndexChanged);
            // 
            // cmb_odano
            // 
            this.cmb_odano.BackColor = System.Drawing.Color.Bisque;
            this.cmb_odano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_odano.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_odano.FormattingEnabled = true;
            this.cmb_odano.Location = new System.Drawing.Point(196, 686);
            this.cmb_odano.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_odano.Name = "cmb_odano";
            this.cmb_odano.Size = new System.Drawing.Size(193, 31);
            this.cmb_odano.TabIndex = 27;
            this.cmb_odano.SelectedIndexChanged += new System.EventHandler(this.cmb_odano_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(116, 635);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "Kat :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(80, 689);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 23);
            this.label14.TabIndex = 29;
            this.label14.Text = "Oda No :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(56, 750);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 23);
            this.label15.TabIndex = 30;
            this.label15.Text = "Yatak No :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(1124, 25);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 23);
            this.label16.TabIndex = 31;
            this.label16.Text = "Veli";
            // 
            // txt_veli_ad
            // 
            this.txt_veli_ad.BackColor = System.Drawing.Color.Bisque;
            this.txt_veli_ad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_veli_ad.Location = new System.Drawing.Point(1068, 82);
            this.txt_veli_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_veli_ad.Name = "txt_veli_ad";
            this.txt_veli_ad.Size = new System.Drawing.Size(193, 31);
            this.txt_veli_ad.TabIndex = 32;
            // 
            // txt_veli_soyad
            // 
            this.txt_veli_soyad.BackColor = System.Drawing.Color.Bisque;
            this.txt_veli_soyad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_veli_soyad.Location = new System.Drawing.Point(1068, 139);
            this.txt_veli_soyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_veli_soyad.Name = "txt_veli_soyad";
            this.txt_veli_soyad.Size = new System.Drawing.Size(193, 31);
            this.txt_veli_soyad.TabIndex = 33;
            // 
            // mtxt_veli_tel
            // 
            this.mtxt_veli_tel.BackColor = System.Drawing.Color.Bisque;
            this.mtxt_veli_tel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxt_veli_tel.Location = new System.Drawing.Point(1068, 191);
            this.mtxt_veli_tel.Margin = new System.Windows.Forms.Padding(4);
            this.mtxt_veli_tel.Mask = "(999) 000-0000";
            this.mtxt_veli_tel.Name = "mtxt_veli_tel";
            this.mtxt_veli_tel.Size = new System.Drawing.Size(193, 31);
            this.mtxt_veli_tel.TabIndex = 34;
            // 
            // rtxt_adres
            // 
            this.rtxt_adres.BackColor = System.Drawing.Color.Bisque;
            this.rtxt_adres.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxt_adres.Location = new System.Drawing.Point(1068, 244);
            this.rtxt_adres.Margin = new System.Windows.Forms.Padding(4);
            this.rtxt_adres.Name = "rtxt_adres";
            this.rtxt_adres.Size = new System.Drawing.Size(365, 117);
            this.rtxt_adres.TabIndex = 35;
            this.rtxt_adres.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(988, 89);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 23);
            this.label17.TabIndex = 36;
            this.label17.Text = "Adı :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(952, 142);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 23);
            this.label18.TabIndex = 37;
            this.label18.Text = "Soyadı :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(940, 194);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 23);
            this.label19.TabIndex = 38;
            this.label19.Text = "Telefon :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(964, 249);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 23);
            this.label20.TabIndex = 40;
            this.label20.Text = "Adres :";
            // 
            // txt_fakulte_id
            // 
            this.txt_fakulte_id.BackColor = System.Drawing.Color.Bisque;
            this.txt_fakulte_id.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_fakulte_id.Location = new System.Drawing.Point(681, 330);
            this.txt_fakulte_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fakulte_id.Name = "txt_fakulte_id";
            this.txt_fakulte_id.Size = new System.Drawing.Size(71, 31);
            this.txt_fakulte_id.TabIndex = 41;
            this.txt_fakulte_id.Visible = false;
            // 
            // txt_bolum_id
            // 
            this.txt_bolum_id.BackColor = System.Drawing.Color.Bisque;
            this.txt_bolum_id.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bolum_id.Location = new System.Drawing.Point(681, 380);
            this.txt_bolum_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bolum_id.Name = "txt_bolum_id";
            this.txt_bolum_id.Size = new System.Drawing.Size(71, 31);
            this.txt_bolum_id.TabIndex = 42;
            this.txt_bolum_id.Visible = false;
            // 
            // txt_kan_id
            // 
            this.txt_kan_id.BackColor = System.Drawing.Color.Bisque;
            this.txt_kan_id.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kan_id.Location = new System.Drawing.Point(412, 533);
            this.txt_kan_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kan_id.Name = "txt_kan_id";
            this.txt_kan_id.Size = new System.Drawing.Size(120, 31);
            this.txt_kan_id.TabIndex = 43;
            this.txt_kan_id.Visible = false;
            // 
            // txt_hastalik_id
            // 
            this.txt_hastalik_id.BackColor = System.Drawing.Color.Bisque;
            this.txt_hastalik_id.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hastalik_id.Location = new System.Drawing.Point(587, 580);
            this.txt_hastalik_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hastalik_id.Name = "txt_hastalik_id";
            this.txt_hastalik_id.Size = new System.Drawing.Size(120, 31);
            this.txt_hastalik_id.TabIndex = 44;
            this.txt_hastalik_id.Visible = false;
            // 
            // txt_oda_id
            // 
            this.txt_oda_id.BackColor = System.Drawing.Color.Bisque;
            this.txt_oda_id.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_oda_id.Location = new System.Drawing.Point(399, 687);
            this.txt_oda_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_oda_id.Name = "txt_oda_id";
            this.txt_oda_id.Size = new System.Drawing.Size(120, 31);
            this.txt_oda_id.TabIndex = 45;
            this.txt_oda_id.Visible = false;
            // 
            // txt_yatak_id
            // 
            this.txt_yatak_id.BackColor = System.Drawing.Color.Bisque;
            this.txt_yatak_id.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yatak_id.Location = new System.Drawing.Point(399, 746);
            this.txt_yatak_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yatak_id.Name = "txt_yatak_id";
            this.txt_yatak_id.Size = new System.Drawing.Size(120, 31);
            this.txt_yatak_id.TabIndex = 46;
            this.txt_yatak_id.Visible = false;
            // 
            // lblfyt
            // 
            this.lblfyt.AutoSize = true;
            this.lblfyt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfyt.Location = new System.Drawing.Point(583, 694);
            this.lblfyt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfyt.Name = "lblfyt";
            this.lblfyt.Size = new System.Drawing.Size(98, 23);
            this.lblfyt.TabIndex = 47;
            this.lblfyt.Text = "Fiyat : ";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfiyat.Location = new System.Drawing.Point(739, 695);
            this.lblfiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(98, 23);
            this.lblfiyat.TabIndex = 48;
            this.lblfiyat.Text = "Fiyat : ";
            this.lblfiyat.Visible = false;
            // 
            // txt_oda_kapasite
            // 
            this.txt_oda_kapasite.BackColor = System.Drawing.Color.Bisque;
            this.txt_oda_kapasite.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_oda_kapasite.Location = new System.Drawing.Point(587, 633);
            this.txt_oda_kapasite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_oda_kapasite.Name = "txt_oda_kapasite";
            this.txt_oda_kapasite.Size = new System.Drawing.Size(120, 31);
            this.txt_oda_kapasite.TabIndex = 49;
            this.txt_oda_kapasite.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(399, 635);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(164, 23);
            this.label21.TabIndex = 50;
            this.label21.Text = "Oda Kapasite :";
            this.label21.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(587, 746);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(296, 27);
            this.checkBox1.TabIndex = 51;
            this.checkBox1.Text = "Erken Kayıt (%5 İndirim)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // datetimekayit
            // 
            this.datetimekayit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datetimekayit.Location = new System.Drawing.Point(1081, 473);
            this.datetimekayit.Margin = new System.Windows.Forms.Padding(4);
            this.datetimekayit.Name = "datetimekayit";
            this.datetimekayit.Size = new System.Drawing.Size(352, 31);
            this.datetimekayit.TabIndex = 52;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(885, 479);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(164, 23);
            this.label22.TabIndex = 53;
            this.label22.Text = "Kayit Tarihi :";
            // 
            // txt_tarih
            // 
            this.txt_tarih.BackColor = System.Drawing.Color.Bisque;
            this.txt_tarih.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tarih.Location = new System.Drawing.Point(1107, 626);
            this.txt_tarih.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(193, 31);
            this.txt_tarih.TabIndex = 54;
            this.txt_tarih.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Bisque;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(1107, 671);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 31);
            this.textBox1.TabIndex = 55;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Bisque;
            this.textBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(1107, 711);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 31);
            this.textBox2.TabIndex = 56;
            this.textBox2.Visible = false;
            // 
            // lblkayit
            // 
            this.lblkayit.AutoSize = true;
            this.lblkayit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayit.Location = new System.Drawing.Point(739, 641);
            this.lblkayit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkayit.Name = "lblkayit";
            this.lblkayit.Size = new System.Drawing.Size(87, 23);
            this.lblkayit.TabIndex = 57;
            this.lblkayit.Text = "Kayit :";
            this.lblkayit.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1166, 749);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmOgrenciKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1655, 891);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblkayit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_tarih);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.datetimekayit);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txt_oda_kapasite);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.lblfyt);
            this.Controls.Add(this.txt_yatak_id);
            this.Controls.Add(this.txt_oda_id);
            this.Controls.Add(this.txt_hastalik_id);
            this.Controls.Add(this.txt_kan_id);
            this.Controls.Add(this.txt_bolum_id);
            this.Controls.Add(this.txt_fakulte_id);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.rtxt_adres);
            this.Controls.Add(this.mtxt_veli_tel);
            this.Controls.Add(this.txt_veli_soyad);
            this.Controls.Add(this.txt_veli_ad);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmb_odano);
            this.Controls.Add(this.cmb_yatakno);
            this.Controls.Add(this.cmb_kat);
            this.Controls.Add(this.cmb_hastalik);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_kan);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mtxt_ogr_tel);
            this.Controls.Add(this.cmb_bolum);
            this.Controls.Add(this.cmb_fakulte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateDogumTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_dogumYeri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ogr_soyad);
            this.Controls.Add(this.txt_ogr_ad);
            this.Controls.Add(this.mtxt_ogr_TC);
            this.Controls.Add(this.btn_kaydet);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgrenciKaydet";
            this.Text = "Adres :";
            this.Load += new System.EventHandler(this.FrmOgrenciKaydet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.MaskedTextBox mtxt_ogr_TC;
        private System.Windows.Forms.TextBox txt_ogr_ad;
        private System.Windows.Forms.TextBox txt_ogr_soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dogumYeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_fakulte;
        private System.Windows.Forms.ComboBox cmb_bolum;
        private System.Windows.Forms.MaskedTextBox mtxt_ogr_tel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.ComboBox cmb_kan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_hastalik;
        private System.Windows.Forms.ComboBox cmb_kat;
        private System.Windows.Forms.ComboBox cmb_yatakno;
        private System.Windows.Forms.ComboBox cmb_odano;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_veli_ad;
        private System.Windows.Forms.TextBox txt_veli_soyad;
        private System.Windows.Forms.MaskedTextBox mtxt_veli_tel;
        private System.Windows.Forms.RichTextBox rtxt_adres;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_fakulte_id;
        private System.Windows.Forms.TextBox txt_bolum_id;
        private System.Windows.Forms.TextBox txt_kan_id;
        private System.Windows.Forms.TextBox txt_hastalik_id;
        private System.Windows.Forms.TextBox txt_oda_id;
        private System.Windows.Forms.TextBox txt_yatak_id;
        private System.Windows.Forms.Label lblfyt;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.TextBox txt_oda_kapasite;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker datetimekayit;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_tarih;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblkayit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}