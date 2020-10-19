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
    public partial class FrmFiyatDüzenle : Form
    {
        public FrmFiyatDüzenle()
        {
            InitializeComponent();
        }

        private Baglanti bgl = new Baglanti();

        private void btn_fiyatdüzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "UPDATE Borclar SET kayit_ucreti = " + txt_yenifiyat.Text + " FROM Odalar " +
                    "WHERE Odalar.oda_id = Borclar.oda_id AND oda_kapasite = " + int.Parse(cmb_kapasite.SelectedItem.ToString()) + " ";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                bgl.Close();
                MessageBox.Show(cmb_kapasite.SelectedItem.ToString() + " kişilik odanın fiyatı " + txt_yenifiyat.Text + " TL olarak değiştirildi.");
                txt_eskifiyat.Text = "";
                txt_yenifiyat.Text = "";
                cmb_kapasite.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Fiyat güncelleme esnasında bir hata meydana geldi. Lütfen daha sonra tekrar deneyiniz.");
            }
        }

        private void FrmFiyatDüzenle_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = bgl.Open();
            cmd.CommandText = "SELECT oda_kapasite FROM Odalar GROUP BY oda_kapasite HAVING COUNT(oda_kapasite) >= 1";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cmb_kapasite.Items.Add(dr[0].ToString());
            cmd.Dispose();
            bgl.Close();
        }

        private void cmb_kapasite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_kapasite.SelectedIndex != -1)
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT kayit_ucreti FROM Borclar INNER JOIN Odalar ON Odalar.oda_id = Borclar.oda_id" +
                    " WHERE oda_kapasite = "+int.Parse(cmb_kapasite.SelectedItem.ToString())+"";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    txt_eskifiyat.Text = dr[0].ToString();
                cmd.Dispose();
                bgl.Close();
            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnaMenu form = new FrmAnaMenu();
            form.Show();
            this.Hide();
        }
    }
}
