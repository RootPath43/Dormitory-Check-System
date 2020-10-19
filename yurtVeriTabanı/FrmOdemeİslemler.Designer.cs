namespace yurtVeriTabanı
{
    partial class FrmOdemeİslemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeİslemler));
            this.btn_ode = new System.Windows.Forms.Button();
            this.btn_tumborclar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ode
            // 
            this.btn_ode.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_ode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ode.Location = new System.Drawing.Point(229, 162);
            this.btn_ode.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ode.Name = "btn_ode";
            this.btn_ode.Size = new System.Drawing.Size(240, 65);
            this.btn_ode.TabIndex = 3;
            this.btn_ode.Text = "Öğrenci Borç Ödeme";
            this.btn_ode.UseVisualStyleBackColor = false;
            this.btn_ode.Click += new System.EventHandler(this.btn_ode_Click);
            // 
            // btn_tumborclar
            // 
            this.btn_tumborclar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_tumborclar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tumborclar.Location = new System.Drawing.Point(229, 301);
            this.btn_tumborclar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tumborclar.Name = "btn_tumborclar";
            this.btn_tumborclar.Size = new System.Drawing.Size(240, 65);
            this.btn_tumborclar.TabIndex = 4;
            this.btn_tumborclar.Text = "Tüm Öğrencilerin Borçları";
            this.btn_tumborclar.UseVisualStyleBackColor = false;
            this.btn_tumborclar.Click += new System.EventHandler(this.btn_tumborclar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmOdemeİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(692, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_tumborclar);
            this.Controls.Add(this.btn_ode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOdemeİslemler";
            this.Text = "FrmOdemeİslemler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ode;
        private System.Windows.Forms.Button btn_tumborclar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}