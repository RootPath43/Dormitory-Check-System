namespace yurtVeriTabanı
{
    partial class FrmFakulteOda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFakulteOda));
            this.btn_Oda = new System.Windows.Forms.Button();
            this.btn_Fakulte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Oda
            // 
            this.btn_Oda.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Oda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Oda.Location = new System.Drawing.Point(507, 435);
            this.btn_Oda.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Oda.Name = "btn_Oda";
            this.btn_Oda.Size = new System.Drawing.Size(350, 75);
            this.btn_Oda.TabIndex = 4;
            this.btn_Oda.Text = "Oda-Yatak Ekle";
            this.btn_Oda.UseVisualStyleBackColor = false;
            this.btn_Oda.Click += new System.EventHandler(this.btn_Oda_Click);
            // 
            // btn_Fakulte
            // 
            this.btn_Fakulte.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Fakulte.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Fakulte.Location = new System.Drawing.Point(507, 218);
            this.btn_Fakulte.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fakulte.Name = "btn_Fakulte";
            this.btn_Fakulte.Size = new System.Drawing.Size(350, 75);
            this.btn_Fakulte.TabIndex = 3;
            this.btn_Fakulte.Text = "Fakülte-Bölüm Ekle";
            this.btn_Fakulte.UseVisualStyleBackColor = false;
            this.btn_Fakulte.Click += new System.EventHandler(this.btn_Fakulte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmFakulteOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Oda);
            this.Controls.Add(this.btn_Fakulte);
            this.Name = "FrmFakulteOda";
            this.Text = "FrmFakulteOda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Oda;
        private System.Windows.Forms.Button btn_Fakulte;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}