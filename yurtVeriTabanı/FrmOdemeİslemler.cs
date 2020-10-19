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
    public partial class FrmOdemeİslemler : Form
    {
        public FrmOdemeİslemler()
        {
            InitializeComponent();
        }

        private void btn_ode_Click(object sender, EventArgs e)
        {
            FrmOgrenciOdeme form = new FrmOgrenciOdeme();
            form.Show();
            this.Hide();
        }

        

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnaMenu form = new FrmAnaMenu();
            form.Show();
            this.Hide();
        }

        private void btn_tumborclar_Click(object sender, EventArgs e)
        {
            FrmTumBorclar form = new FrmTumBorclar();
            form.Show();
            this.Hide();
        }
    }
}
