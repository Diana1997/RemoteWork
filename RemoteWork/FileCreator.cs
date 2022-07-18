using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace RemoteWork
{
    public class FileCreator
    {
        public static void CreatePdf(string path, string xmlString)
        {
            // Create new pdf file
            try
            {
                var fs = new FileStream(path, FileMode.Create);
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                // Create an instance to the PDF file by creating an instance of the PDF 
                // Writer class using the document and the filestrem in the constructor.
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                // Add meta information to the document
                document.AddAuthor("Tios");
                document.AddCreator("XML to PDF using iTextSharp");
                document.AddKeywords("Tios");
                document.AddSubject("Document subject - Describing the steps creating a PDF document");
                document.AddTitle("The document title - PDF creation using iTextSharp");

                document.Open();
                document.Add(new Paragraph(xmlString));
                document.Close();
                writer.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}