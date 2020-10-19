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
    public partial class FrmFakulteOda : Form
    {
        private Baglanti bgl = new Baglanti();
        public FrmFakulteOda()
        {
            InitializeComponent();
        }

       

        private void btn_Fakulte_Click(object sender, EventArgs e)
        {
            FrmFakulte form = new FrmFakulte();
            form.Show();
            this.Hide();
        }

        private void btn_Oda_Click(object sender, EventArgs e)
        {
            FrmOda form = new FrmOda();
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

