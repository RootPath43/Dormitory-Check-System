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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            FrmOgrenciKaydet form = new FrmOgrenciKaydet();
            form.Show();
            this.Hide();
        }

        private void btn_ogrlistele_Click(object sender, EventArgs e)
        {
            FrmOgrenciListele form = new FrmOgrenciListele();
            form.Show();
            this.Hide();
        }

        private void btn_silme_Click(object sender, EventArgs e)
        {
            FrmOgrenciSilme form = new FrmOgrenciSilme();
            form.Show();
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmOgrenciGuncelleme form = new FrmOgrenciGuncelleme();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnaMenu form = new FrmAnaMenu();
            form.Show();
            this.Hide();
        }
    }
}
