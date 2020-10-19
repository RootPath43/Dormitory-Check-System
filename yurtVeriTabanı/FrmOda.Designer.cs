namespace yurtVeriTabanı
{
    partial class FrmOda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOda));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Kapasite = new System.Windows.Forms.TextBox();
            this.cmb_oda = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_OdaID = new System.Windows.Forms.TextBox();
            this.btn_OdaLst = new System.Windows.Forms.Button();
            this.txt_Kapasite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Oda = new System.Windows.Forms.TextBox();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_Oda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PapayaWhip;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(487, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Oda Kapasitesi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PapayaWhip;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(436, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Oda Numarası Seçin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PapayaWhip;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(573, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "OdaID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Kapasite
            // 
            this.Kapasite.Location = new System.Drawing.Point(669, 225);
            this.Kapasite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kapasite.Name = "Kapasite";
            this.Kapasite.ReadOnly = true;
            this.Kapasite.Size = new System.Drawing.Size(121, 22);
            this.Kapasite.TabIndex = 45;
            // 
            // cmb_oda
            // 
            this.cmb_oda.FormattingEnabled = true;
            this.cmb_oda.Location = new System.Drawing.Point(669, 144);
            this.cmb_oda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_oda.Name = "cmb_oda";
            this.cmb_oda.Size = new System.Drawing.Size(121, 24);
            this.cmb_oda.TabIndex = 44;
            this.cmb_oda.SelectedIndexChanged += new System.EventHandler(this.cmb_oda_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PapayaWhip;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(528, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 65);
            this.button1.TabIndex = 43;
            this.button1.Text = "Yatak Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_OdaID
            // 
            this.txt_OdaID.Location = new System.Drawing.Point(669, 185);
            this.txt_OdaID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_OdaID.Name = "txt_OdaID";
            this.txt_OdaID.ReadOnly = true;
            this.txt_OdaID.Size = new System.Drawing.Size(121, 22);
            this.txt_OdaID.TabIndex = 42;
            // 
            // btn_OdaLst
            // 
            this.btn_OdaLst.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_OdaLst.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OdaLst.Location = new System.Drawing.Point(383, 282);
            this.btn_OdaLst.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OdaLst.Name = "btn_OdaLst";
            this.btn_OdaLst.Size = new System.Drawing.Size(240, 65);
            this.btn_OdaLst.TabIndex = 41;
            this.btn_OdaLst.Text = "Odaları Listele";
            this.btn_OdaLst.UseVisualStyleBackColor = false;
            this.btn_OdaLst.Click += new System.EventHandler(this.btn_OdaLst_Click_1);
            // 
            // txt_Kapasite
            // 
            this.txt_Kapasite.Location = new System.Drawing.Point(216, 181);
            this.txt_Kapasite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Kapasite.Name = "txt_Kapasite";
            this.txt_Kapasite.Size = new System.Drawing.Size(159, 22);
            this.txt_Kapasite.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Oda Kapasitesi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(110, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Oda No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Oda
            // 
            this.txt_Oda.Location = new System.Drawing.Point(216, 143);
            this.txt_Oda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Oda.Name = "txt_Oda";
            this.txt_Oda.Size = new System.Drawing.Size(159, 22);
            this.txt_Oda.TabIndex = 37;
            // 
            // btn_Restart
            // 
            this.btn_Restart.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Restart.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Restart.Location = new System.Drawing.Point(383, 366);
            this.btn_Restart.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(240, 65);
            this.btn_Restart.TabIndex = 36;
            this.btn_Restart.Text = "Yenile";
            this.btn_Restart.UseVisualStyleBackColor = false;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click_1);
            // 
            // btn_Oda
            // 
            this.btn_Oda.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Oda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Oda.Location = new System.Drawing.Point(135, 40);
            this.btn_Oda.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Oda.Name = "btn_Oda";
            this.btn_Oda.Size = new System.Drawing.Size(240, 65);
            this.btn_Oda.TabIndex = 34;
            this.btn_Oda.Text = "Oda Ekle";
            this.btn_Oda.UseVisualStyleBackColor = false;
            this.btn_Oda.Click += new System.EventHandler(this.btn_Oda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(472, 457);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(973, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kapasite);
            this.Controls.Add(this.cmb_oda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_OdaID);
            this.Controls.Add(this.btn_OdaLst);
            this.Controls.Add(this.txt_Kapasite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Oda);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.btn_Oda);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmOda";
            this.Text = "FrmOda";
            this.Load += new System.EventHandler(this.FrmOda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Kapasite;
        private System.Windows.Forms.ComboBox cmb_oda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_OdaID;
        private System.Windows.Forms.Button btn_OdaLst;
        private System.Windows.Forms.TextBox txt_Kapasite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Oda;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button btn_Oda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}