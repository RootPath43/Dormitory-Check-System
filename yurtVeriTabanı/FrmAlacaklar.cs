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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace yurtVeriTabanı
{
    public partial class FrmAlacaklar : Form
    {
        private Baglanti bgl = new Baglanti();
        public FrmAlacaklar()
        {
            InitializeComponent();
        }

        private void cmb_ay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAlacaklar_Load(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            int tarih = int.Parse(bugun.Month.ToString());
            int ay = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = bgl.Open();
            cmd.CommandText = "SELECT ay_id FROM Aylar WHERE ay_sayi = " + tarih + "";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                ay = int.Parse(dr[0].ToString());
            cmd.Dispose();
            bgl.Close();

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT odemeKontrol.ogr_TC, Aylar.ay_adi, Borclar.kayit_ucreti / 10 as 'ücret' FROM odemeKontrol" +
                " INNER JOIN Aylar ON Aylar.ay_id = odemeKontrol.ay_id " +
                " INNER JOIN Borclar ON Borclar.ogr_tc = odemeKontrol.ogr_TC" +
                " WHERE odeme_kontrol = 0 AND Aylar.ay_id BETWEEN 1 AND " + ay + ""
                , bgl.Open());
            DataSet ds = new DataSet();
            da.Fill(ds, "odemeKontrol,Aylar,Borclar");
            dataGridView1.DataSource = ds.Tables["odemeKontrol,Aylar,Borclar"];
            bgl.Close();


        }

   

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Pdf'in kaydedileceği yeri seçiniz.";
            dialog.RootFolder = Environment.SpecialFolder.Desktop;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdftable = new PdfPTable(dataGridView1.Columns.Count);
                pdftable.DefaultCell.Padding = 3;
                pdftable.WidthPercentage = 100;
                pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdftable.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdftable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdftable.AddCell(cell.Value.ToString());
                    }
                }

                //pdf kaydeder
                string folderPath = dialog.SelectedPath.ToString() + "\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + "Ogrenci-Alacaklar.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdftable);
                    pdfDoc.Close();
                    stream.Close();
                }
                MessageBox.Show("Pdf Kaydedildi");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnaMenu form = new FrmAnaMenu();
            form.Show();
            this.Hide();
        }
    }
}
