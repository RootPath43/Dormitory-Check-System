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
    public partial class FrmOgrenciSilme : Form
    {
        public FrmOgrenciSilme()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        private void mtxt_ogr_TC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtxt_ogr_TC.Text != "")
            {
                txt_ogr_ad.Text = "";
                txt_ogr_soyad.Text = "";
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = bgl.Open();
                cmd2.CommandText = "SELECT ogrGenelBilgiler.ogr_ad, ogrGenelBilgiler.ogr_soyad FROM ogrGenelBilgiler" +
                    " WHERE ogrGenelBilgiler.ogr_tc = '" + mtxt_ogr_TC.Text + "'";
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    txt_ogr_ad.Text = dr2[0].ToString();
                    txt_ogr_soyad.Text = dr2[1].ToString();
                }
                cmd2.Dispose();
                bgl.Close();
            }
        }

        private void FrmOgrenciSilme_Load(object sender, EventArgs e)
        {

        }

        private void btn_silme_Click(object sender, EventArgs e)
        {
            
                if (mtxt_ogr_TC.Text != "")
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = bgl.Open();
                    cmd.CommandText = "UPDATE Odalar SET oda_durum = oda_durum - 1 FROM Odalar" +
                    " INNER JOIN ogrGenelBilgiler ON Odalar.oda_id = ogrGenelBilgiler.oda_id" +
                    " WHERE ogr_TC = '"+mtxt_ogr_TC.Text+"'";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    bgl.Close();

                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = bgl.Open();
                    cmd2.CommandText = "UPDATE Yatak SET yatak_durum = 0 FROM Yatak" +
                    " INNER JOIN ogrGenelBilgiler ON Yatak.yatak_id = ogrGenelBilgiler.yatak_id" +
                    " WHERE ogr_TC = '" + mtxt_ogr_TC.Text + "'";
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();
                    bgl.Close();

                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.Connection = bgl.Open();
                    cmd3.CommandText = "DELETE odemeKontrol FROM odemeKontrol " +
                    " WHERE odemeKontrol.ogr_TC = '" + mtxt_ogr_TC.Text + "' ";
                    cmd3.ExecuteNonQuery(); 
                    cmd3.Dispose();
                    bgl.Close();

                    SqlCommand cmd4 = new SqlCommand();
                    cmd4.Connection = bgl.Open();
                    cmd4.CommandText = "DELETE Borclar FROM Borclar  WHERE Borclar.ogr_TC = '" + mtxt_ogr_TC.Text + "'";
                    cmd4.ExecuteNonQuery();
                    cmd4.Dispose();
                    bgl.Close();

                    SqlCommand cmd5 = new SqlCommand();
                    cmd5.Connection = bgl.Open();
                    cmd5.CommandText = "DELETE ogrGenelBilgiler FROM ogrGenelBilgiler  WHERE ogrGenelBilgiler.ogr_TC = '" + mtxt_ogr_TC.Text + "'";
                    cmd5.ExecuteNonQuery();
                    cmd5.Dispose();
                    bgl.Close();

                    MessageBox.Show(mtxt_ogr_TC.Text + " adlı TC  numarasına sahip olan ögrenci silindi.");

                }
                else
                {
                    MessageBox.Show("Silme işleminde bir hata oluştu. Lütfen tekrar deneyiniz.");
                }
            
            
        }
    } 
}
