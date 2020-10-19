using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurtVeriTabanı
{
    public partial class FrmOdalar : Form
    {
        Baglanti bgl = new Baglanti();
        public FrmOdalar()
        {
            InitializeComponent();
        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_AnaMenu_Click(object sender, EventArgs e)
        {
            FrmOda form = new FrmOda();
            form.Show();
            this.Hide();
        }

        void odaListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT oda_no, oda_kapasite FROM Odalar", bgl.Open());
            DataSet ds = new DataSet();
            da.Fill(ds, "Odalar");
            dataGridView1.DataSource = ds.Tables["Odalar"];
            bgl.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmOdalar_Load_1(object sender, EventArgs e)
        {
            odaListele();
        }
    }
}
