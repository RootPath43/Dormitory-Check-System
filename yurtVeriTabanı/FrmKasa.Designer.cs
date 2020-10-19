namespace yurtVeriTabanı
{
    partial class FrmKasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasa));
            this.btn_kasa = new System.Windows.Forms.Button();
            this.lbl_kasa = new System.Windows.Forms.Label();
            this.cmb_ay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ay_id = new System.Windows.Forms.TextBox();
            this.label_kasa = new System.Windows.Forms.Label();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kasa
            // 
            this.btn_kasa.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_kasa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kasa.Location = new System.Drawing.Point(275, 94);
            this.btn_kasa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kasa.Name = "btn_kasa";
            this.btn_kasa.Size = new System.Drawing.Size(113, 71);
            this.btn_kasa.TabIndex = 5;
            this.btn_kasa.Text = "Göster";
            this.btn_kasa.UseVisualStyleBackColor = false;
            this.btn_kasa.Click += new System.EventHandler(this.btn_kasa_Click);
            // 
            // lbl_kasa
            // 
            this.lbl_kasa.AutoSize = true;
            this.lbl_kasa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kasa.Location = new System.Drawing.Point(92, 278);
            this.lbl_kasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kasa.Name = "lbl_kasa";
            this.lbl_kasa.Size = new System.Drawing.Size(0, 23);
            this.lbl_kasa.TabIndex = 11;
            // 
            // cmb_ay
            // 
            this.cmb_ay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_ay.FormattingEnabled = true;
            this.cmb_ay.Items.AddRange(new object[] {
            "HEPSİ"});
            this.cmb_ay.Location = new System.Drawing.Point(84, 20);
            this.cmb_ay.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ay.Name = "cmb_ay";
            this.cmb_ay.Size = new System.Drawing.Size(180, 31);
            this.cmb_ay.TabIndex = 27;
            this.cmb_ay.SelectedIndexChanged += new System.EventHandler(this.cmb_ay_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ay :";
            // 
            // txt_ay_id
            // 
            this.txt_ay_id.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ay_id.Location = new System.Drawing.Point(84, 76);
            this.txt_ay_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ay_id.Name = "txt_ay_id";
            this.txt_ay_id.Size = new System.Drawing.Size(104, 31);
            this.txt_ay_id.TabIndex = 30;
            this.txt_ay_id.Visible = false;
            // 
            // label_kasa
            // 
            this.label_kasa.AutoSize = true;
            this.label_kasa.BackColor = System.Drawing.Color.Moccasin;
            this.label_kasa.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kasa.Location = new System.Drawing.Point(33, 157);
            this.label_kasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_kasa.Name = "label_kasa";
            this.label_kasa.Size = new System.Drawing.Size(195, 70);
            this.label_kasa.TabIndex = 31;
            this.label_kasa.Text = "Tutar";
            this.label_kasa.Visible = false;
            // 
            // btn_pdf
            // 
            this.btn_pdf.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_pdf.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pdf.Location = new System.Drawing.Point(275, 173);
            this.btn_pdf.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(113, 65);
            this.btn_pdf.TabIndex = 32;
            this.btn_pdf.Text = "PDF Dökümanı";
            this.btn_pdf.UseVisualStyleBackColor = false;
            this.btn_pdf.Visible = false;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 246);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(384, 185);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(397, 245);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.label_kasa);
            this.Controls.Add(this.txt_ay_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ay);
            this.Controls.Add(this.lbl_kasa);
            this.Controls.Add(this.btn_kasa);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKasa";
            this.Text = "FrmKasa";
            this.Load += new System.EventHandler(this.FrmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kasa;
        private System.Windows.Forms.Label lbl_kasa;
        private System.Windows.Forms.ComboBox cmb_ay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ay_id;
        private System.Windows.Forms.Label label_kasa;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}