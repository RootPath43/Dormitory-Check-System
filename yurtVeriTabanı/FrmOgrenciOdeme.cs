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
using System.IO;

namespace yurtVeriTabanı
{
    public partial class FrmOgrenciOdeme : Form
    {
        Baglanti bgl = new Baglanti();
        public FrmOgrenciOdeme()
        {
            InitializeComponent();
        }

        private void btn_odemeıslemlerımenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ode_Click(object sender, EventArgs e)
        {
            Boolean kontrol = false;
            if (cmb_ay.SelectedIndex != -1)
            {
                 try
                 {
                // ödeme yapılan aşama
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = bgl.Open();
                    cmd2.CommandText = "SELECT ogrGenelBilgiler.ogr_ad, ogrGenelBilgiler.ogr_soyad, Borclar.borc" +
                        " Borclar,borc / 9 FROM Borclar" +
                        " INNER JOIN ogrGenelBilgiler ON ogrGenelBilgiler.ogr_TC = Borclar.ogr_tc" +
                        " WHERE Borclar.ogr_tc = '" + mtxt_ogr_TC.Text + "'";
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        txt_kalan.Text = dr2[2].ToString();
                        txt_ogr_ad.Text = dr2[0].ToString();
                        txt_ogr_soyad.Text = dr2[1].ToString();
                    }
                    cmd2.Dispose();
                    bgl.Close();

                    string a = txt_odenen.Text.Replace(",", ".");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = bgl.Open();
                    cmd.CommandText = "UPDATE Borclar SET borc = borc - " + a + " " +
                        "WHERE Borclar.ogr_tc = '" + mtxt_ogr_TC.Text + "'";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    bgl.Close();

                    SqlCommand cmd4 = new SqlCommand();
                    cmd4.Connection = bgl.Open();
                    cmd4.CommandText = "UPDATE Kasa SET para = para + " + float.Parse(txt_odenen.Text) + " " +
                    " from Kasa inner join Aylar ON Aylar.ay_id = kasa.ay_id WHERE kasa.ay_id = " + int.Parse(txt_ay_id.Text) + "";
                    cmd4.ExecuteNonQuery();
                    cmd4.Dispose();
                    bgl.Close();

                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.Connection = bgl.Open();
                    cmd3.CommandText = "UPDATE odemeKontrol SET odeme_kontrol = 1 WHERE ay_id =" + txt_ay_id.Text + " AND " +
                        " odemeKontrol.ogr_TC = '" + mtxt_ogr_TC.Text + "'";
                    cmd3.ExecuteNonQuery();
                    cmd3.Dispose();
                    bgl.Close();

                    MessageBox.Show(txt_odenen.Text + " TL ödeme başarıyla yapıldı. Makbuz veriliyor...");

                    makbuz();
               }
                catch (Exception)
                {
                    MessageBox.Show("Ödeme esnasında bir hata meydana geldi. Lütfen tekrar deneyin.");
                }
           }
             if (cmb_ay.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen ödenen ayı seçiniz.");
                }
            
        }

        private void mtxt_ogr_TC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtxt_ogr_TC.Text != "")
            {
                // kalan borcu ögrenme
               
                txt_odenen.Text = "";
                txt_ogr_ad.Text = "";
                txt_ogr_soyad.Text = "";
                cmb_ay.SelectedIndex = -1;
                cmb_ay.Items.Clear();

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = bgl.Open();
                cmd2.CommandText = "SELECT ogrGenelBilgiler.ogr_ad, ogrGenelBilgiler.ogr_soyad, Borclar.borc" +
                    " FROM Borclar" +
                    " INNER JOIN ogrGenelBilgiler ON ogrGenelBilgiler.ogr_TC = Borclar.ogr_tc" +
                    " WHERE Borclar.ogr_tc = '" + mtxt_ogr_TC.Text + "'";
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    txt_kalan.Text = dr2[2].ToString();
                    txt_ogr_ad.Text = dr2[0].ToString();
                    txt_ogr_soyad.Text = dr2[1].ToString();                       
                }
                cmd2.Dispose();
                bgl.Close();


                // TCsine girilen ögrencisinin ödeme yapmadıgı ayleri çekme
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "select ay_adi from Aylar INNER JOIN odemeKontrol ON odemeKontrol.ay_id = Aylar.ay_id " +
                    "WHERE ogr_TC = '" + mtxt_ogr_TC.Text + "' AND odeme_kontrol = 0";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_ay.Items.Add(dr[0].ToString());
                }
                cmd.Dispose();
                bgl.Close();


            }
        }

        private void btn_makbuz_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();
                MessageBox.Show("Makbuz verildi..");
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem esnasında bir hata oluştu.");
            }

        }
        void makbuz()
        {
            try
            {
                printDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();
              
                MessageBox.Show("Makbuz veriliyor..");
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem esnasında bir hata oluştu.");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Consolas", 12, FontStyle.Regular), Brushes.Black, 600, 60);

            String metin = mtxt_ogr_TC.Text + " kimlik numarasına sahip ögrenci " + txt_odenen.Text + " TL \n yurt" +
               "ücretini yatırmıştır.";
            e.Graphics.DrawString(metin, new Font("Consolas", 12, FontStyle.Regular), Brushes.Black, 100, 140);

            e.Graphics.DrawString("ÖĞRENCİ", new Font("Consolas", 12, FontStyle.Underline), Brushes.Black, 635, 210);

            metin = txt_ogr_ad.Text;   
            e.Graphics.DrawString(" Adı    : "+metin, new Font("Consolas", 12, FontStyle.Regular), Brushes.Black, 600, 240);

            metin = txt_ogr_soyad.Text;
            e.Graphics.DrawString(" Soyadı : "+metin, new Font("Consolas", 12, FontStyle.Regular), Brushes.Black, 600, 260);

            e.Graphics.DrawString("imza", new Font("Consolas", 12, FontStyle.Regular), Brushes.Black, 640, 290);                   
        }

        private void cmb_ay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ay.SelectedIndex != -1)
            {
                txt_odenen.Text = "";
                txt_ay_id.Text = "";

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = bgl.Open();
                cmd2.CommandText = "select odemeKontrol.ay_id from Aylar INNER JOIN odemeKontrol ON odemeKontrol.ay_id = Aylar.ay_id " +
                    "WHERE odeme_kontrol != 1 AND ay_adi = '" + cmb_ay.SelectedItem.ToString() + "' ";
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    txt_ay_id.Text = dr2[0].ToString();

                }
                cmd2.Dispose();
                bgl.Close();


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT kayit_ucreti / 9 FROM Borclar" +
                    " INNER JOIN ogrGenelBilgiler ON Borclar.ogr_tc = ogrGenelBilgiler.ogr_TC" +
                    " WHERE Borclar.ogr_tc = '"+mtxt_ogr_TC.Text+ "' ";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string a;
                    a = dr[0].ToString();
                    a = a.Replace(",", ".");
                    txt_odenen.Text = a;
                }
                cmd.Dispose();
                bgl.Close();          
            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmOdemeİslemler form = new FrmOdemeİslemler();
            form.Show();
            this.Hide();
        }
    }
}
