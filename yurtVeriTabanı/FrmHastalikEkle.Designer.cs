namespace yurtVeriTabanı
{
    partial class FrmHastalikEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastalikEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonguncelle = new System.Windows.Forms.Button();
            this.txtHastalikId = new System.Windows.Forms.TextBox();
            this.txtHastalikAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaliklarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtVeritabaniDataSet1 = new yurtVeriTabanı.yurtVeritabaniDataSet4();
            this.hastaliklarTableAdapter = new yurtVeriTabanı.yurtVeritabaniDataSet4TableAdapters.HastaliklarTableAdapter();
            this.yeniyurtvertiabaniDataSet1 = new yurtVeriTabanı.yeniyurtvertiabaniDataSet1();
            this.hastaliklarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaliklarTableAdapter1 = new yurtVeriTabanı.yeniyurtvertiabaniDataSet1TableAdapters.HastaliklarTableAdapter();
            this.hastalikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastalikadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaliklarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtVeritabaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniyurtvertiabaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaliklarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eklenecek Hastalığın Adı:";
            // 
            // buttonekle
            // 
            this.buttonekle.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonekle.Location = new System.Drawing.Point(58, 273);
            this.buttonekle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(112, 28);
            this.buttonekle.TabIndex = 3;
            this.buttonekle.Text = "EKLE";
            this.buttonekle.UseVisualStyleBackColor = false;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonsil.Location = new System.Drawing.Point(462, 273);
            this.buttonsil.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(112, 28);
            this.buttonsil.TabIndex = 4;
            this.buttonsil.Text = "SİL";
            this.buttonsil.UseVisualStyleBackColor = false;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonguncelle
            // 
            this.buttonguncelle.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonguncelle.Location = new System.Drawing.Point(267, 273);
            this.buttonguncelle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonguncelle.Name = "buttonguncelle";
            this.buttonguncelle.Size = new System.Drawing.Size(112, 28);
            this.buttonguncelle.TabIndex = 5;
            this.buttonguncelle.Text = "GÜNCELLE";
            this.buttonguncelle.UseVisualStyleBackColor = false;
            this.buttonguncelle.Click += new System.EventHandler(this.buttonguncelle_Click);
            // 
            // txtHastalikId
            // 
            this.txtHastalikId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastalikId.Location = new System.Drawing.Point(310, 57);
            this.txtHastalikId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastalikId.Multiline = true;
            this.txtHastalikId.Name = "txtHastalikId";
            this.txtHastalikId.Size = new System.Drawing.Size(201, 10);
            this.txtHastalikId.TabIndex = 6;
            this.txtHastalikId.Visible = false;
            // 
            // txtHastalikAd
            // 
            this.txtHastalikAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastalikAd.Location = new System.Drawing.Point(310, 22);
            this.txtHastalikAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastalikAd.Name = "txtHastalikAd";
            this.txtHastalikAd.Size = new System.Drawing.Size(201, 28);
            this.txtHastalikAd.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hastalikidDataGridViewTextBoxColumn,
            this.hastalikadiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaliklarBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(629, 185);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // hastaliklarBindingSource
            // 
            this.hastaliklarBindingSource.DataMember = "Hastaliklar";
            this.hastaliklarBindingSource.DataSource = this.yurtVeritabaniDataSet1;
            // 
            // yurtVeritabaniDataSet1
            // 
            this.yurtVeritabaniDataSet1.DataSetName = "yurtVeritabaniDataSet1";
            this.yurtVeritabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaliklarTableAdapter
            // 
            this.hastaliklarTableAdapter.ClearBeforeFill = true;
            // 
            // yeniyurtvertiabaniDataSet1
            // 
            this.yeniyurtvertiabaniDataSet1.DataSetName = "yeniyurtvertiabaniDataSet1";
            this.yeniyurtvertiabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaliklarBindingSource1
            // 
            this.hastaliklarBindingSource1.DataMember = "Hastaliklar";
            this.hastaliklarBindingSource1.DataSource = this.yeniyurtvertiabaniDataSet1;
            // 
            // hastaliklarTableAdapter1
            // 
            this.hastaliklarTableAdapter1.ClearBeforeFill = true;
            // 
            // hastalikidDataGridViewTextBoxColumn
            // 
            this.hastalikidDataGridViewTextBoxColumn.DataPropertyName = "hastalik_id";
            this.hastalikidDataGridViewTextBoxColumn.HeaderText = "hastalik_id";
            this.hastalikidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastalikidDataGridViewTextBoxColumn.Name = "hastalikidDataGridViewTextBoxColumn";
            this.hastalikidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastalikadiDataGridViewTextBoxColumn
            // 
            this.hastalikadiDataGridViewTextBoxColumn.DataPropertyName = "hastalik_adi";
            this.hastalikadiDataGridViewTextBoxColumn.HeaderText = "hastalik_adi";
            this.hastalikadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastalikadiDataGridViewTextBoxColumn.Name = "hastalikadiDataGridViewTextBoxColumn";
            // 
            // FrmHastalikEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(663, 314);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHastalikAd);
            this.Controls.Add(this.txtHastalikId);
            this.Controls.Add(this.buttonguncelle);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHastalikEkle";
            this.Text = "FrmHastalikEkle";
            this.Load += new System.EventHandler(this.FrmHastalikEkle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaliklarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtVeritabaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniyurtvertiabaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaliklarBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonguncelle;
        private System.Windows.Forms.TextBox txtHastalikId;
        private System.Windows.Forms.TextBox txtHastalikAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yurtVeritabaniDataSet4 yurtVeritabaniDataSet1;
        private System.Windows.Forms.BindingSource hastaliklarBindingSource;
        private yurtVeritabaniDataSet4TableAdapters.HastaliklarTableAdapter hastaliklarTableAdapter;
        private yeniyurtvertiabaniDataSet1 yeniyurtvertiabaniDataSet1;
        private System.Windows.Forms.BindingSource hastaliklarBindingSource1;
        private yeniyurtvertiabaniDataSet1TableAdapters.HastaliklarTableAdapter hastaliklarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastalikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastalikadiDataGridViewTextBoxColumn;
    }
}