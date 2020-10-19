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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace yurtVeriTabanı
{
    public partial class FrmOgrenciListele : Form
    {
        public FrmOgrenciListele()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void btn_ogrMenu_Click(object sender, EventArgs e)
        {
            FrmOgrenci form = new FrmOgrenci();
            form.Show();
            this.Hide();
        }

        private void FrmOgrenciListele_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT ogr_TC,ogr_ad,ogr_soyad,ogr_dogumYeri,ogr_dogumTarihi,fakulte_adi,bolum_adi,ogr_telefon,ogr_mail,kan_grubu, " +
                "hastalik_adi,ogr_veliad,ogr_velisoyad,ogr_velitelefon,ogr_veliadres,oda_no,yatak_numarasi,kayit_tarihi " +
                "FROM ogrGenelBilgiler " +
                "INNER JOIN Fakulteler ON ogrGenelBilgiler.fakulte_id = Fakulteler.fakulte_id " +
                "INNER JOIN Bolumler ON ogrGenelBilgiler.bolum_id = Bolumler.bolum_id " +
                "INNER JOIN kanGrupları ON ogrGenelBilgiler.kan_id = kanGrupları.kan_id " +
                "INNER JOIN Hastaliklar ON ogrGenelBilgiler.hastalik_id = Hastaliklar.hastalik_id  " +
                "INNER JOIN Odalar ON ogrGenelBilgiler.oda_id = Odalar.oda_id " +
                "INNER JOIN Yatak ON ogrGenelBilgiler.yatak_id = Yatak.yatak_id; ", bgl.Open());
            
            DataSet ds = new DataSet();
            da.Fill(ds,"ogrGenelBilgiler,Fakulteler,Bolumler,kanGrupları,Hastaliklar,Odalar,Yatak");
            dataGridView1.DataSource = ds.Tables["ogrGenelBilgiler,Fakulteler,Bolumler,kanGrupları,Hastaliklar,Odalar,Yatak"];

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
                    pdftable.AddCell((cell));
                   
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        
                         pdftable.AddCell((cell.Value.ToString()));
                       
                    }
                }

                //pdf kaydeder
                string folderPath = dialog.SelectedPath.ToString() + "\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + "Ogrenci-Listele.pdf", FileMode.Create))
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
    }
}

