namespace yurtVeriTabanı
{
    partial class FrmFakulte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFakulte));
            this.btn_Bolum = new System.Windows.Forms.Button();
            this.btn_Fakulte = new System.Windows.Forms.Button();
            this.cmb_fakulte = new System.Windows.Forms.ComboBox();
            this.txt_Bolum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Fakulte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.txt_FakID = new System.Windows.Forms.TextBox();
            this.cmb_bolum = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Bolum
            // 
            this.btn_Bolum.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Bolum.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bolum.Location = new System.Drawing.Point(373, 152);
            this.btn_Bolum.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Bolum.Name = "btn_Bolum";
            this.btn_Bolum.Size = new System.Drawing.Size(200, 75);
            this.btn_Bolum.TabIndex = 10;
            this.btn_Bolum.Text = "Bölüm Ekle";
            this.btn_Bolum.UseVisualStyleBackColor = false;
            this.btn_Bolum.Click += new System.EventHandler(this.btn_Bolum_Click);
            // 
            // btn_Fakulte
            // 
            this.btn_Fakulte.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Fakulte.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Fakulte.Location = new System.Drawing.Point(373, 49);
            this.btn_Fakulte.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fakulte.Name = "btn_Fakulte";
            this.btn_Fakulte.Size = new System.Drawing.Size(200, 75);
            this.btn_Fakulte.TabIndex = 9;
            this.btn_Fakulte.Text = "Fakülte Ekle";
            this.btn_Fakulte.UseVisualStyleBackColor = false;
            this.btn_Fakulte.Click += new System.EventHandler(this.btn_Fakulte_Click);
            // 
            // cmb_fakulte
            // 
            this.cmb_fakulte.FormattingEnabled = true;
            this.cmb_fakulte.Location = new System.Drawing.Point(522, 268);
            this.cmb_fakulte.Name = "cmb_fakulte";
            this.cmb_fakulte.Size = new System.Drawing.Size(319, 24);
            this.cmb_fakulte.TabIndex = 16;
            this.cmb_fakulte.SelectedIndexChanged += new System.EventHandler(this.cmb_fakulte_SelectedIndexChanged);
            // 
            // txt_Bolum
            // 
            this.txt_Bolum.Location = new System.Drawing.Point(215, 356);
            this.txt_Bolum.Name = "txt_Bolum";
            this.txt_Bolum.Size = new System.Drawing.Size(234, 22);
            this.txt_Bolum.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bölüm Adı";
            // 
            // txt_Fakulte
            // 
            this.txt_Fakulte.Location = new System.Drawing.Point(215, 270);
            this.txt_Fakulte.Name = "txt_Fakulte";
            this.txt_Fakulte.Size = new System.Drawing.Size(234, 22);
            this.txt_Fakulte.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fakülte Adı";
            // 
            // btn_Restart
            // 
            this.btn_Restart.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Restart.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Restart.Location = new System.Drawing.Point(373, 433);
            this.btn_Restart.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(200, 75);
            this.btn_Restart.TabIndex = 17;
            this.btn_Restart.Text = "Yenile";
            this.btn_Restart.UseVisualStyleBackColor = false;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // txt_FakID
            // 
            this.txt_FakID.Location = new System.Drawing.Point(464, 270);
            this.txt_FakID.Name = "txt_FakID";
            this.txt_FakID.ReadOnly = true;
            this.txt_FakID.Size = new System.Drawing.Size(52, 22);
            this.txt_FakID.TabIndex = 19;
            // 
            // cmb_bolum
            // 
            this.cmb_bolum.FormattingEnabled = true;
            this.cmb_bolum.Location = new System.Drawing.Point(522, 356);
            this.cmb_bolum.Name = "cmb_bolum";
            this.cmb_bolum.Size = new System.Drawing.Size(319, 24);
            this.cmb_bolum.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(115, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmFakulte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(910, 545);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmb_bolum);
            this.Controls.Add(this.txt_FakID);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.cmb_fakulte);
            this.Controls.Add(this.txt_Bolum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Fakulte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Bolum);
            this.Controls.Add(this.btn_Fakulte);
            this.Name = "FrmFakulte";
            this.Text = "FrmFakulte";
            this.Load += new System.EventHandler(this.FrmFakulte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Bolum;
        private System.Windows.Forms.Button btn_Fakulte;
        private System.Windows.Forms.ComboBox cmb_fakulte;
        private System.Windows.Forms.TextBox txt_Bolum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Fakulte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.TextBox txt_FakID;
        private System.Windows.Forms.ComboBox cmb_bolum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}