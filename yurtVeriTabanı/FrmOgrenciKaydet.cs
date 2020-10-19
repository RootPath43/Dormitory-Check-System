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
    public partial class FrmOgrenciKaydet : Form
    {
       private Baglanti bgl = new Baglanti();
        public FrmOgrenciKaydet()
        {
            InitializeComponent();
        }

      

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Boolean kontrol = false;
            try
            { 
                // Ögrenci Kaydetme
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "INSERT INTO ogrGenelBilgiler (ogr_TC ,ogr_ad ,ogr_soyad ,ogr_dogumYeri ,ogr_DogumTarihi ,fakulte_id ,bolum_id," +
                    " ogr_telefon ,ogr_mail ,kan_id ,hastalik_id ,ogr_veliad ,ogr_velisoyad ,ogr_velitelefon, ogr_veliadres ,oda_id ,yatak_id, " +
                    " kayit_tarihi)" +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18)";
                cmd.Parameters.AddWithValue("@p1", mtxt_ogr_TC.Text);
                cmd.Parameters.AddWithValue("@p2", txt_ogr_ad.Text);
                cmd.Parameters.AddWithValue("@p3", txt_ogr_soyad.Text);
                cmd.Parameters.AddWithValue("@p4", txt_dogumYeri.Text);
                cmd.Parameters.AddWithValue("@p5", dateDogumTarihi.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@p6", txt_fakulte_id.Text);
                cmd.Parameters.AddWithValue("@p7", txt_bolum_id.Text);
                cmd.Parameters.AddWithValue("@p8", mtxt_ogr_tel.Text);
                cmd.Parameters.AddWithValue("@p9", txt_mail.Text);
                cmd.Parameters.AddWithValue("@p10", txt_kan_id.Text);
                cmd.Parameters.AddWithValue("@p11", txt_hastalik_id.Text);
                cmd.Parameters.AddWithValue("@p12", txt_veli_ad.Text);
                cmd.Parameters.AddWithValue("@p13", txt_veli_soyad.Text);
                cmd.Parameters.AddWithValue("@p14", mtxt_veli_tel.Text);
                cmd.Parameters.AddWithValue("@p15", rtxt_adres.Text);
                cmd.Parameters.AddWithValue("@p16", txt_oda_id.Text);
                cmd.Parameters.AddWithValue("@p17", txt_yatak_id.Text);
                cmd.Parameters.AddWithValue("@p18", datetimekayit.Value);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                bgl.Close();
                
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = bgl.Open();
                cmd2.CommandText = "UPDATE Odalar SET oda_durum = oda_durum + 1 WHERE oda_id = "+int.Parse(txt_oda_id.Text)+"";
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                bgl.Close();

                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = bgl.Open();
                cmd3.CommandText = "UPDATE Yatak SET yatak_durum = 1 " +  
                    "WHERE Yatak.yatak_id = " + int.Parse(txt_yatak_id.Text) + "";
                cmd3.ExecuteNonQuery();
                cmd3.Dispose();
                bgl.Close();

                lblkayit.Text = lblfiyat.Text;
                SqlCommand cmd4 = new SqlCommand();
                cmd4.Connection = bgl.Open();
                cmd4.CommandText = "INSERT INTO Borclar (ogr_TC,oda_id,borc,kayit_ucreti) values(@p1,@p2,@p3,@p4)";
                cmd4.Parameters.AddWithValue("@p1", mtxt_ogr_TC.Text);
                cmd4.Parameters.AddWithValue("@p2", txt_oda_id.Text);
                cmd4.Parameters.AddWithValue("@p3", float.Parse(lblfiyat.Text));
                cmd4.Parameters.AddWithValue("@p4", Convert.ToInt32(lblkayit.Text));
                cmd4.ExecuteNonQuery();
                cmd4.Dispose();
                bgl.Close();

                SqlCommand cmd5 = new SqlCommand();
                cmd5.Connection = bgl.Open();
                cmd5.CommandText = "INSERT INTO odemeKontrol (ogr_TC,ay_id) values" +
                    " ('" + mtxt_ogr_TC.Text + "',1)," +
                    " ('" + mtxt_ogr_TC.Text + "',2)," +
                    " ('" + mtxt_ogr_TC.Text + "',3)," +
                    " ('" + mtxt_ogr_TC.Text + "',4)," +
                    " ('" + mtxt_ogr_TC.Text + "',5)," +
                    " ('" + mtxt_ogr_TC.Text + "',6)," +
                    " ('" + mtxt_ogr_TC.Text + "',7)," +
                    " ('" + mtxt_ogr_TC.Text + "',8)," +
                    " ('" + mtxt_ogr_TC.Text + "',9)";
                cmd5.ExecuteNonQuery();
                cmd5.Dispose();
                bgl.Close();

                kontrol = true;    

                MessageBox.Show("Kayıt başarıyla yapıldı.");
           }
            catch (Exception )
            {
                MessageBox.Show("Kayıt esnasında bir hata meydana geldi. Lütfen tekrar deneyin.");
            }

            if (kontrol)
            {
                SqlCommand cmd7 = new SqlCommand();
                cmd7.Connection = bgl.Open();
                cmd7.CommandText = "SELECT kayit_tarihi FROM ogrGenelBilgiler WHERE ogr_TC = '" + mtxt_ogr_TC.Text + "'";
                SqlDataReader dr7 = cmd7.ExecuteReader();
                while (dr7.Read())
                    txt_tarih.Text = dr7[0].ToString();
                cmd7.Dispose();
                bgl.Close();

                DateTime tarih;
                tarih = Convert.ToDateTime(txt_tarih.Text);
                textBox1.Text = tarih.Month.ToString();
                int a = Convert.ToInt32(textBox1.Text);

                if (a >= 7)
                {
                    int b = 0;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = bgl.Open();
                    cmd.CommandText = "SELECT ay_id FROM Aylar WHERE ay_sayi = " + a + "";
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                        b = int.Parse(dr[0].ToString());
                    cmd.Dispose();
                    bgl.Close();

                    // Kayıt Edildikten önceki ayların ödemesini almama
                    SqlCommand cmd6 = new SqlCommand();
                    cmd6.Connection = bgl.Open();
                    cmd6.CommandText = "UPDATE odemeKontrol SET odeme_kontrol = 1 FROM odemeKontrol " +
                        "INNER JOIN Aylar ON Aylar.ay_id = odemeKontrol.ay_id " +
                        "WHERE odemeKontrol.ogr_TC =  '" + mtxt_ogr_TC.Text + "' " +
                        "AND Aylar.ay_id BETWEEN 1 AND " + (b - 1) + "";
                    cmd6.ExecuteNonQuery();
                    cmd6.Dispose();
                    bgl.Close();

                    int sayac = 0;

                    SqlCommand cmd8 = new SqlCommand();
                    cmd8.Connection = bgl.Open();
                    cmd8.CommandText = "SELECT ay_id FROM odemeKontrol WHERE odeme_kontrol = 0 AND ogr_TC = '" + mtxt_ogr_TC.Text + "'";
                    SqlDataReader dr8 = cmd8.ExecuteReader();
                    while (dr8.Read())
                    {
                        textBox2.Text = dr8[0].ToString();
                        sayac++;
                    }
                    cmd8.Dispose();
                    bgl.Close();


                    SqlCommand cmd9 = new SqlCommand();
                    cmd9.Connection = bgl.Open();
                    cmd9.CommandText = "UPDATE Borclar SET borc = ((kayit_ucreti / 9 ) * " + sayac + ") WHERE Borclar.ogr_TC = '" + mtxt_ogr_TC.Text + "' ";
                    cmd9.ExecuteNonQuery();
                    cmd9.Dispose();
                    bgl.Close();
                }
                
            }
        }

        private void FrmOgrenciKaydet_Load(object sender, EventArgs e)
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

            // Kan Gruplarının veritabanı üzerinden çekilmesi
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = bgl.Open();
            cmd2.CommandText = "SELECT kan_grubu FROM kanGrupları";
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
                cmb_kan.Items.Add(dr2[0].ToString());
            cmd2.Dispose();
            bgl.Close();

            // Hastalıkların veritabanı üzerinden çekilmesi
            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = bgl.Open();
            cmd3.CommandText = "Select hastalik_adi FROM Hastaliklar";
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
                cmb_hastalik.Items.Add(dr3[0].ToString());
            cmd3.Dispose();
            bgl.Close(); 
        }

        private void cmb_fakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Fakülte secildikten sonra fakültenin sahip oldugu bölümlerin veritabanından çekilmesi ve yüklenmesi
            if (cmb_fakulte.SelectedIndex != -1)
            {
                txt_bolum_id.Text = "";
                txt_fakulte_id.Text = "";
                cmb_bolum.SelectedIndex = -1;
                cmb_bolum.Items.Clear();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT bolum_adi, Fakulteler.fakulte_id FROM Bolumler INNER JOIN Fakulteler ON Bolumler.fakulte_id = Fakulteler.fakulte_id" +
                    " WHERE Fakulteler.fakulte_adi = '"+cmb_fakulte.SelectedItem.ToString()+"'";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_bolum.Items.Add(dr[0].ToString());
                    txt_fakulte_id.Text = dr[1].ToString();
                }             
                bgl.Close();
            }
        }
        private void cmb_bolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_bolum.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT bolum_id FROM Bolumler WHERE bolum_adi ='" + cmb_bolum.SelectedItem.ToString() + "'";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    txt_bolum_id.Text = dr[0].ToString();
                cmd.Dispose();
                bgl.Close();
            }
        }

        private void cmb_kat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Odaları gösterme
            if (cmb_kat.SelectedIndex != -1)
            {
                checkBox1.Visible = false;
                txt_oda_kapasite.Text = "";
                lblfiyat.Text = "";
                checkBox1.Checked = false;
                txt_oda_id.Text = "";
                txt_yatak_id.Text = "";
                cmb_odano.SelectedIndex = -1;
                cmb_odano.Items.Clear();
                cmb_yatakno.SelectedIndex = -1;
                cmb_yatakno.Items.Clear();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT oda_no FROM Odalar WHERE oda_kapasite != oda_durum AND" +
                    " oda_no LIKE '%"+int.Parse(cmb_kat.SelectedItem.ToString())+"__%' ORDER BY oda_no";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    cmb_odano.Items.Add(dr[0].ToString());
                cmd.Dispose();
                bgl.Close();
            }
        }

        private void cmb_odano_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Yatak gosterme ve odanın fiyatını gösterme
            if (cmb_odano.SelectedIndex != -1)
            {
                checkBox1.Visible = true;
                lblfyt.Visible = true;
                lblfiyat.Visible = true;
                txt_yatak_id.Text = "";
                cmb_yatakno.SelectedIndex = -1;
                cmb_yatakno.Items.Clear();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT yatak_numarasi,Odalar.oda_id,Odalar.oda_kapasite FROM Yatak INNER JOIN Odalar ON Yatak.oda_id = Odalar.oda_id" +
                    " WHERE Odalar.oda_no = " + int.Parse(cmb_odano.SelectedItem.ToString()) + " AND  yatak_durum != 1 " +
                    "ORDER BY yatak_numarasi";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_yatakno.Items.Add(dr[0].ToString());
                    txt_oda_id.Text = dr[1].ToString();
                    txt_oda_kapasite.Text = dr[2].ToString();
                }
                cmd.Dispose();
                bgl.Close();

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = bgl.Open();
                cmd2.CommandText = "SELECT kayit_ucreti FROM Borclar,Odalar WHERE Odalar.oda_id = Borclar.oda_id AND " +
                    "Odalar.oda_kapasite = '"+txt_oda_kapasite.Text+"'";
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    lblfiyat.Text = dr2[0].ToString();  
                } 
                cmd2.Dispose();
                bgl.Close();      
            }
        }

        private void cmb_yatakno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_yatakno.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT yatak_id FROM YATAK" +
                    " WHERE yatak_numarasi ="+int.Parse(cmb_yatakno.SelectedItem.ToString())+" AND oda_id = " + txt_oda_id.Text + "";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    txt_yatak_id.Text = dr[0].ToString();
                cmd.Dispose();
                bgl.Close();
            }
        }
        private void cmb_kan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_kan.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT kan_id FROM kanGrupları WHERE kan_grubu = '" + cmb_kan.SelectedItem.ToString() + "'";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    txt_kan_id.Text = dr[0].ToString();
                cmd.Dispose();
                bgl.Close();
            }
        }

        private void cmb_hastalik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_hastalik.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT hastalik_id FROM Hastaliklar WHERE hastalik_adi = '" + cmb_hastalik.SelectedItem.ToString() + "'";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    txt_hastalik_id.Text = dr[0].ToString();
                cmd.Dispose();
                bgl.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    lblfiyat.Text = ((int.Parse(lblfiyat.Text) * 95) / 100).ToString();
                    MessageBox.Show("Erken Kayıt İndirimi Yapıldı");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Erken kayıt indirimi yapılırken hata oluştu.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmOgrenci form = new FrmOgrenci();
            form.Show();
            this.Hide();
        }
    }
    }

