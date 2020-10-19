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
    
    public partial class FrmFakulte : Form
    {
        private Baglanti bgl = new Baglanti();
        private Baglanti bgl2 = new Baglanti();
        public FrmFakulte()
        {
            InitializeComponent();
        }

        private void btn_Fakulte_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd2.Connection = bgl2.Open();
                cmd.CommandText = "insert into Fakulteler(fakulte_adi) values ('" + txt_Fakulte.Text + "')";
                cmd2.CommandText = "INSERT INTO Bolumler (fakulte_id) SELECT fakulte_id FROM Fakulteler WHERE fakulte_adi='"+ txt_Fakulte.Text+"'";
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd.Dispose();
                cmd2.Dispose();
                bgl.Close();
                bgl2.Close();
                MessageBox.Show("Fakülte ekleme başarılı.");

            }
            catch (Exception)
            {
                MessageBox.Show("Fakülte ekleme başarısız");
            }
        }

        private void btn_Bolum_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "insert into Bolumler(fakulte_id,bolum_adi) values ('"+ txt_FakID.Text+"','"+txt_Bolum.Text+"')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                bgl.Close();
                MessageBox.Show("Bölüm ekleme başarılı.");

            }
            catch (Exception)
            {
                MessageBox.Show("Bölüm ekleme başarısız");
            }
        }

        private void btn_AnaMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmFakulte_Load(object sender, EventArgs e)
        {
            // Form Yüklendiğinde fakültelerin veritabanı üzerinden çekilmesi
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = bgl.Open();
            cmd.CommandText = "SELECT fakulte_adi FROM Fakulteler ORDER BY fakulte_adi";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cmb_fakulte.Items.Add(dr[0].ToString());
            cmd.Dispose();
            bgl.Close();
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmb_fakulte_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Fakülte secildikten sonra fakültenin sahip oldugu bölümlerin veritabanından çekilmesi ve yüklenmesi
            if (cmb_fakulte.SelectedIndex != -1)
            {
                //txt_bolum_id.Text = "";
                txt_FakID.Text = "";
                cmb_bolum.SelectedIndex = -1;
                cmb_bolum.Items.Clear();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT bolum_adi, Fakulteler.fakulte_id FROM Bolumler INNER JOIN Fakulteler ON Bolumler.fakulte_id = Fakulteler.fakulte_id" +
                    " WHERE Fakulteler.fakulte_adi = '" + cmb_fakulte.SelectedItem.ToString() + "'";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_bolum.Items.Add(dr[0].ToString());
                    txt_FakID.Text = dr[1].ToString();
                }
                bgl.Close();
            }
        }

       

      

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FrmFakulteOda fr = new FrmFakulteOda();
            fr.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
