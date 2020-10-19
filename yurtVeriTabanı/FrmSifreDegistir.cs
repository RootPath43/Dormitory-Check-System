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
    public partial class FrmSifreDegistir : Form
    {
        public FrmSifreDegistir()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=LAPTOP-RRVHUN4A\SQLEXPRESS;Initial Catalog=yeniyurtvertiabani;Integrated Security=True");
        

        private void veriler()
        {
            listView1.Items.Clear();
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From GirisSistemi", bgl);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["kullanici_adi"].ToString());
                ekle.SubItems.Add(oku["sifre"].ToString());
                listView1.Items.Add(ekle);
            }
            bgl.Close();
        }

        int id = 0;
        private void btnSifreGüncelle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("update GirisSistemi set kullanici_adi='" + txtKullaniciAdi.Text.ToString() + "', sifre='" + txtSifre.Text.ToString() + "' where id=" + id + "",bgl);
            komut.ExecuteNonQuery();
            bgl.Close();
            veriler();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtKullaniciAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSifre.Text = listView1.SelectedItems[0].SubItems[2].Text;


        }

        private void FrmSifreDegistir_Load(object sender, EventArgs e)
        {
            veriler();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frm = new FrmAdminGiris();
            frm.Show();
            this.Hide();
        }
    }
}
