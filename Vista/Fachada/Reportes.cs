using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Fachada
{
    public class Reportes
    {
        public void generarReporteSocios(DataGridView pDGVListaSocios)
        {
            int numColumn = pDGVListaSocios.ColumnCount - 1;

            PdfPTable pdfTable = new PdfPTable(numColumn);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in pDGVListaSocios.Columns)
            {
                if (column.Name != "Id")
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                    pdfTable.AddCell(cell);
                }
            }

            int row = pDGVListaSocios.Rows.Count;
            int cell2 = pDGVListaSocios.Rows[0].Cells.Count;

            for (int i = 0; i < row ; i++)
            {
                for (int j = 1; j < cell2; j++)
                {
                    if (pDGVListaSocios.Rows[i].Cells[j].Value == null)
                    {
                        pDGVListaSocios.Rows[i].Cells[j].Value = "";
                    }
                    if(pDGVListaSocios.Rows[i].Cells[j].Value.GetType().Name == "DateTime")
                    {
                        if (pDGVListaSocios.Rows[i].Cells[j].Value.ToString() == "1/1/0001 00:00:00")
                        {
                            pdfTable.AddCell("");
                        }
                        else
                        {

                            pdfTable.AddCell(Convert.ToDateTime(pDGVListaSocios.Rows[i].Cells[j].Value).ToShortDateString());
                        }
                    }
                    else
                    {
                        pdfTable.AddCell(pDGVListaSocios.Rows[i].Cells[j].Value.ToString());
                    }
                }
            }

            //Exporting to PDF
            string folderPath = @"C:\Reportes\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            String fileName = "REPORTE DE SOCIOS_" + DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + "-" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            using (FileStream stream = new FileStream(folderPath + fileName + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();

            }

            System.Diagnostics.Process.Start(folderPath+"/"+fileName+".pdf");
        }
    }
}
