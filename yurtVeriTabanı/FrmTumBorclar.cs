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
    public partial class FrmTumBorclar : Form
    {
        Baglanti bgl = new Baglanti();
        public FrmTumBorclar()
        {
            InitializeComponent();
        }

        

        private void FrmTumBorclar_Load(object sender, EventArgs e)
        {
            gridDoldur();
        }

        void gridDoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Borclar.ogr_TC,ogrGenelBilgiler.ogr_ad,ogrGenelBilgiler.ogr_soyad,Odalar.oda_no,Borclar.borc" +
                " FROM Borclar" +
                " INNER JOIN ogrGenelBilgiler ON Borclar.ogr_tc = ogrGenelBilgiler.ogr_TC" +
                " INNER JOIN Odalar ON Odalar.oda_id = Borclar.oda_id WHERE Borclar.ogr_TC NOT LIKE '%F%'", bgl.Open());
            DataSet ds = new DataSet();
            da.Fill(ds, "Borclar,ogrGenelBilgiler,Odalar");
            dataGridView1.DataSource = ds.Tables["Borclar,ogrGenelBilgiler,Odalar"];
            bgl.Close();
        }

        private void btn_pdfaktar_Click(object sender, EventArgs e)
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
                using (FileStream stream = new FileStream(folderPath + "Ogrenci-Borçlar.pdf", FileMode.Create))
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
            FrmOdemeİslemler form = new FrmOdemeİslemler();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FrmOdemeİslemler frm = new FrmOdemeİslemler();
            frm.Show();
            this.Hide();
        }
    }
}
