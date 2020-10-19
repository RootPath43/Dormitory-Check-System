using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurtVeriTabanı
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void btn_ogreci_Click(object sender, EventArgs e)
        {
            FrmOgrenci form = new FrmOgrenci();
            form.Show();
            this.Hide();
        }

        private void btn_fiyatduzenle_Click(object sender, EventArgs e)
        {
            FrmFiyatDüzenle form = new FrmFiyatDüzenle();
            form.Show();
            this.Hide();
        }

        private void btn_odemeislemleri_Click(object sender, EventArgs e)
        {
            FrmOdemeİslemler form = new FrmOdemeİslemler();
            form.Show();
            this.Hide();
        }

        private void btn_yapılacaklar_Click(object sender, EventArgs e)
        {
            FrmYapilacaklar form = new FrmYapilacaklar();
            form.Show();
            this.Hide();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            FrmFakulteOda form = new FrmFakulteOda();
            form.Show();
            this.Hide();
        }

        private void btn_Hastaliklar_Click(object sender, EventArgs e)
        {
            FrmHastalikEkle form = new FrmHastalikEkle();
            form.Show();
           
        }

        

        private void btn_Kasa_Click(object sender, EventArgs e)
        {
            FrmKasa form = new FrmKasa();
            form.Show();
            this.Hide();
        }

        private void btn_alacaklar_Click(object sender, EventArgs e)
        {
            FrmAlacaklar form = new FrmAlacaklar();
            form.Show();
            this.Hide();
        }
    }
}
