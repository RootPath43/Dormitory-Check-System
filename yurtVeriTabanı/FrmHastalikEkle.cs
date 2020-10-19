using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yurtVeriTabanı
{
    public partial class FrmHastalikEkle : Form
    {
        public FrmHastalikEkle()
        {
            InitializeComponent();
        }

        private Baglanti bgl = new Baglanti();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            

            SqlCommand cmd = new SqlCommand("update Hastaliklar set hastalik_adi=@p1 where hastalik_id=@p2");
            cmd.Connection = bgl.Open();
            cmd.Parameters.AddWithValue("@p1", txtHastalikAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtHastalikId.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();
           
                this.hastaliklarTableAdapter1.Fill(this.yeniyurtvertiabaniDataSet1.Hastaliklar);
           
            
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("delete from Hastaliklar where hastalik_id=@p1 ");
            cmd.Connection = bgl.Open();
            cmd.Parameters.AddWithValue("@p1", txtHastalikId.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();

            
                this.hastaliklarTableAdapter1.Fill(this.yeniyurtvertiabaniDataSet1.Hastaliklar);
         

        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("insert into Hastaliklar (hastalik_adi) values (@p1)");
            cmd.Connection = bgl.Open();
            cmd.Parameters.AddWithValue("@p1", txtHastalikAd.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();
           
                this.hastaliklarTableAdapter1.Fill(this.yeniyurtvertiabaniDataSet1.Hastaliklar);
            

        }

        private void FrmHastalikEkle_Load_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yeniyurtvertiabaniDataSet1.Hastaliklar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaliklarTableAdapter1.Fill(this.yeniyurtvertiabaniDataSet1.Hastaliklar);
            
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtHastalikAd.Text = ad;
            txtHastalikId.Text = id;
        }
    }
}