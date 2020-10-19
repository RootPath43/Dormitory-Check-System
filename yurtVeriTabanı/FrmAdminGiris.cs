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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
            txtSifre.PasswordChar = '*';
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=LAPTOP-RRVHUN4A\SQLEXPRESS;Initial Catalog=yeniyurtvertiabani;Integrated Security=True");



        private void btnGiris_Click_1(object sender, EventArgs e)
        {

            try
            {
                bgl.Open();
                string sql = "Select * From GirisSistemi where kullanici_adi=@girisAdi AND sifre=@girisSifresi";
                SqlParameter parametre1 = new SqlParameter("girisAdi", txtKullaniciAdi.Text.Trim()); //boşluk karakteri önlendi.
                SqlParameter parametre2 = new SqlParameter("girisSifresi", txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, bgl);
                komut.Parameters.Add(parametre1);
                komut.Parameters.Add(parametre2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);


                if (dt.Rows.Count > 0) //e
                {

                    FrmAnaMenu form = new FrmAnaMenu();
                    form.Show();
                    this.Hide();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş yaptınız.");
            }


        }

        private void btnSifreGüncelle_Click(object sender, EventArgs e)
        {
            FrmSifreDegistir frm = new FrmSifreDegistir();
            frm.Show();
            this.Hide();
        }

    }
    }

