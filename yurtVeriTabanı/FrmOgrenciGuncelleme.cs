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
    public partial class FrmOgrenciGuncelleme : Form
    {
        public FrmOgrenciGuncelleme()
        {
            InitializeComponent();
        }

        private Baglanti bgl = new Baglanti();


        

        private void FrmOgrenciGuncelleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yeniyurtvertiabaniDataSet.ogrGenelBilgiler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrGenelBilgilerTableAdapter1.Fill(this.yeniyurtvertiabaniDataSet.ogrGenelBilgiler);
            

            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = bgl.Open();
            cmd.CommandText = "SELECT fakulte_adi FROM Fakulteler ORDER BY fakulte_adi";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cmb_fakulte.Items.Add(dr[0].ToString());
            cmd.Dispose();
            bgl.Close();

           
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = bgl.Open();
            cmd2.CommandText = "SELECT kan_grubu FROM kanGrupları";
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
                cmb_kanGruplari.Items.Add(dr2[0].ToString());
            cmd2.Dispose();
            bgl.Close();

            
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
            if (cmb_fakulte.SelectedIndex != -1)
            {
                cmb_bolumler.SelectedIndex = -1;
                cmb_bolumler.Items.Clear();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT bolum_adi, Fakulteler.fakulte_id FROM Bolumler INNER JOIN Fakulteler ON Bolumler.fakulte_id = Fakulteler.fakulte_id" +
                    " WHERE Fakulteler.fakulte_adi = '" + cmb_fakulte.SelectedItem.ToString() + "'";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_bolumler.Items.Add(dr[0].ToString());
                    txtFakulteId.Text = dr[1].ToString();

                }
                bgl.Close();
            }
        }

        //dataGridView nesnesindeki bilgilerin textbox'lara aktarılması
        //Data Source=LAPTOP-RRVHUN4A\SQLEXPRESS;Initial Catalog=yeniyurtvertiabani;Integrated Security=True
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-RRVHUN4A\\SQLEXPRESS;Initial Catalog=yeniyurtvertiabani;Integrated Security=True");
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            string tc, ad, soyad, dogumYeri, dogumTarihi, id1, id2, tel, mail, id3, id4, veliAdi, veliSoyadi, veliTelefon, veliAdres, id5, id6, kayitTarihi;

            secilen = dataGridView1.SelectedCells[0].RowIndex;

            tc = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dogumYeri = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dogumTarihi = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            id1 = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            id2 = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            tel = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            mail = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            id3 = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            id4 = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            veliAdi = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            veliSoyadi = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            veliTelefon = dataGridView1.Rows[secilen].Cells[13].Value.ToString();
            veliAdres = dataGridView1.Rows[secilen].Cells[14].Value.ToString();
            id5 = dataGridView1.Rows[secilen].Cells[15].Value.ToString();
            id6 = dataGridView1.Rows[secilen].Cells[16].Value.ToString();
            kayitTarihi = dataGridView1.Rows[secilen].Cells[17].Value.ToString();


            txtTC.Text = tc;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            txtDogumYeri.Text = dogumYeri;
            txtDogumTarhi.Text = dogumTarihi;
            txtFakulteId.Text = id1;
            txtBolumId.Text = id2;
            mskOgrenciTelefon.Text = tel;
            txtMail.Text = mail;
            txtKanId.Text = id3;
            txtHastalıkId.Text = id4;
            txtVeliAdi.Text = veliAdi;
            txtVeliSoyadi.Text = veliSoyadi;
            rchVeliAdres.Text = veliAdres;
            txtKayitTarihi.Text = kayitTarihi;
            txtOdaId.Text = id5;
            txtYatakId.Text = id6;
            mskVeliTelefon.Text = veliTelefon;

            string fakulte = null;
            string bolum = null;
            string kangrubu = null; 
            string hastalik = null;
            String kat = null;
            string oda = null;
            string yatak = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = bgl.Open();
            cmd.CommandText = "SELECT fakulte_adi, bolum_adi, kan_grubu, hastalik_adi, oda_no, yatak_numarasi  FROM ogrGenelBilgiler" +
                " INNER JOIN Fakulteler ON ogrGenelBilgiler.fakulte_id = Fakulteler.fakulte_id" +
                " INNER JOIN Bolumler ON ogrGenelBilgiler.bolum_id = Bolumler.bolum_id" +
                " INNER JOIN kanGrupları ON ogrGenelBilgiler.kan_id = kanGrupları.kan_id" +
                " INNER JOIN Hastaliklar ON ogrGenelBilgiler.hastalik_id = Hastaliklar.hastalik_id" +
                " INNER JOIN Odalar ON ogrGenelBilgiler.oda_id = Odalar.oda_id" +
                " INNER JOIN Yatak ON ogrGenelBilgiler.yatak_id = Yatak.yatak_id " +
                " WHERE ogr_TC = '"+txtTC.Text+"' ";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fakulte = dr[0].ToString();
                bolum = dr[1].ToString();
                kangrubu =  dr[2].ToString();
                hastalik = dr[3].ToString();
                oda = dr[4].ToString();
                yatak = dr[5].ToString();
            }
            cmd.Dispose();
            bgl.Close();
            cmb_fakulte.SelectedIndex = cmb_fakulte.FindString(fakulte);
            cmb_bolumler.SelectedIndex = cmb_bolumler.FindString(bolum);
            cmb_kanGruplari.SelectedIndex = cmb_kanGruplari.FindString(kangrubu);
            cmb_hastalik.SelectedIndex = cmb_hastalik.FindString(hastalik);
            kat = oda.Substring(0, 1);
            cmb_kat.SelectedIndex = cmb_kat.FindString(kat);
            cmb_oda.SelectedIndex = cmb_oda.FindString(oda);
            cmb_yatakNo.SelectedIndex = cmb_yatakNo.FindString(yatak);
            
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           try
            {
               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "update ogrGenelBilgiler set ogr_ad = @p2 , ogr_soyad = @p3 , ogr_dogumYeri=@p4 , ogr_DogumTarihi = @p5, " +
                    "fakulte_id=@p6, bolum_id=@p7 , ogr_telefon=@p8 , ogr_mail =@p9 , kan_id = @p10, hastalik_id = @p11, ogr_veliad = @p12 , ogr_velisoyad= @p13 , ogr_velitelefon = @p14 " +
                    " , ogr_veliadres = @p15, oda_id=@p16, yatak_id=@p17, kayit_tarihi=@p18 where ogr_TC = @p1 ";

                cmd.Parameters.AddWithValue("@p1", txtTC.Text);
                cmd.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                cmd.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
                cmd.Parameters.AddWithValue("p4", txtDogumYeri.Text);
                cmd.Parameters.AddWithValue("@p5", txtDogumTarhi.Text);
                cmd.Parameters.AddWithValue("@p6", txtFakulteId.Text);
                cmd.Parameters.AddWithValue("@p7", txtBolumId.Text);
                cmd.Parameters.AddWithValue("@p8", mskOgrenciTelefon.Text);
                cmd.Parameters.AddWithValue("@p9", txtMail.Text);
                cmd.Parameters.AddWithValue("@p10", txtKanId.Text);
                cmd.Parameters.AddWithValue("@p11", txtHastalıkId.Text);
                cmd.Parameters.AddWithValue("@p12", txtVeliAdi.Text);
                cmd.Parameters.AddWithValue("@p13", txtVeliSoyadi.Text);
                cmd.Parameters.AddWithValue("@p14", mskVeliTelefon.Text);
                cmd.Parameters.AddWithValue("@p16", txtOdaId.Text);
                cmd.Parameters.AddWithValue("@p17", txtYatakId.Text);
                cmd.Parameters.AddWithValue("@p15", Convert.ToString(rchVeliAdres.Text));
                cmd.Parameters.AddWithValue("@p18", txtKayitTarihi.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                bgl.Close();
               MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirildi.");
                this.ogrGenelBilgilerTableAdapter1.Fill(this.yeniyurtvertiabaniDataSet.ogrGenelBilgiler);
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme esnasında hata oluştu, tekrar deneyiniz.");
            }
        }

        private void cmb_kat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_kat.SelectedIndex != -1)
            {
                cmb_oda.Items.Clear();
                cmb_yatakNo.Items.Clear();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT oda_no FROM Odalar WHERE oda_kapasite != oda_durum AND" +
                    " oda_no LIKE '%" + int.Parse(cmb_kat.SelectedItem.ToString()) + "__%' ORDER BY oda_no";
                SqlDataReader dr2 = cmd.ExecuteReader();
                while (dr2.Read())
                    cmb_oda.Items.Add(dr2[0].ToString());
                cmd.Dispose();
                bgl.Close();

                
            }
        }

        private void cmb_oda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_oda.SelectedIndex != -1)
            {
                cmb_yatakNo.Items.Clear();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT yatak_numarasi,Odalar.oda_id,Odalar.oda_kapasite FROM Yatak INNER JOIN Odalar ON Yatak.oda_id = Odalar.oda_id" +
                    " WHERE Odalar.oda_no = " + int.Parse(cmb_oda.SelectedItem.ToString()) + " AND  yatak_durum != 1 " +
                    "ORDER BY yatak_numarasi";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_yatakNo.Items.Add(dr[0].ToString());
                    txtOdaId.Text = dr[1].ToString();

                }
                cmd.Dispose();
                bgl.Close();

                
            }
        }

        private void cmb_bolumler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_bolumler.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT bolum_id FROM Bolumler WHERE bolum_adi ='" + cmb_bolumler.SelectedItem.ToString() + "'";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    txtBolumId.Text = dr[0].ToString();
                cmd.Dispose();
                bgl.Close();
            }
        }

        private void cmb_yatakNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_yatakNo.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT yatak_id FROM YATAK" +
                    " WHERE yatak_numarasi =" + int.Parse(cmb_yatakNo.SelectedItem.ToString()) + " AND oda_id = " + txtOdaId.Text + "";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    txtYatakId.Text = dr[0].ToString();
                cmd.Dispose();
                bgl.Close();
            }
        }

        private void cmb_kanGruplari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_kanGruplari.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bgl.Open();
                cmd.CommandText = "SELECT kan_id FROM kanGrupları WHERE kan_grubu = '" + cmb_kanGruplari.SelectedItem.ToString() + "'";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    txtKanId.Text = dr[0].ToString();
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
                    txtHastalıkId.Text = dr[0].ToString();
                cmd.Dispose();
                bgl.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOgrenci frm = new FrmOgrenci();
            frm.Show();
            this.Hide();
        }
    }
}
