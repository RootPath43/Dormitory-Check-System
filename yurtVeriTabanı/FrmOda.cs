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
    public partial class FrmOda : Form
    {
        private Baglanti bgl = new Baglanti();
        private Baglanti bgl2 = new Baglanti();
        public FrmOda()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void FrmOda_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = bgl.Open();
            cmd.CommandText = "SELECT oda_no FROM odalar";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cmb_oda.Items.Add(dr[0].ToString());
            cmd.Dispose();
            bgl.Close();
        }
        private void btn_OdaLst_Click_1(object sender, EventArgs e)
        {
            FrmOdalar form = new FrmOdalar();
            form.Show();
            this.Hide();
        }

        

        private void btn_Restart_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                int kapasite = Convert.ToInt32(Kapasite.Text);
                for (int i = 1; i < kapasite + 1; i++)
                {
                    cmd.CommandText = "INSERT INTO Yatak (oda_id,yatak_numarasi) values ('" + txt_OdaID.Text + "','" + i + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                bgl.Close();
                MessageBox.Show("Yatak ekleme başarılı.");

            }
            catch (Exception)
            {
                MessageBox.Show("Yatak ekleme başarısız.");
            }
        }

        private void cmb_oda_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_oda.SelectedIndex != -1)
            {
                txt_OdaID.Text = "";
                Kapasite.Text = "";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT oda_kapasite, Odalar.oda_id  FROM Yatak INNER JOIN Odalar ON Yatak.oda_id = Odalar.oda_id WHERE Odalar.oda_no = '" + cmb_oda.SelectedItem.ToString() + "'";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Kapasite.Text = dr[0].ToString();
                    txt_OdaID.Text = dr[1].ToString();
                }
                bgl.Close();
            }
        }

        private void btn_Oda_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = bgl.Open();
            cmd.CommandText = "insert into Odalar(oda_no,oda_kapasite,oda_durum) values (@p1 , @p2 , @p3)";
            cmd.Parameters.AddWithValue("@p1", txt_Oda.Text);
            cmd.Parameters.AddWithValue("@p2", txt_Kapasite.Text);
            cmd.Parameters.AddWithValue("@p3", 0);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            bgl.Close();
            MessageBox.Show("Oda eklendi.");

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = bgl2.Open();
            cmd2.CommandText = "INSERT INTO Yatak(oda_id) SELECT oda_id FROM Odalar WHERE oda_no='" + txt_Oda.Text + "'";
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            bgl2.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnaMenu form = new FrmAnaMenu();
            form.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
