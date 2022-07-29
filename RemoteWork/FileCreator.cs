using System;
using System.IO;


namespace RemoteWork
{
    public class FileCreator
    {
        public static void CreatePdf(string path, string xmlString)
        {
            // Create new pdf file
            try
            {
                /*var fs = new FileStream(path, FileMode.OpenOrCreate);
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
                fs.Close();*/
            }
            catch (Exception ex)
            {
            }
        }


        /*public static string XmlToHtml(string xmlStr)
        {
            // Creating Compiled object    
            XslCompiledTransform objXSLTransform = new XslCompiledTransform();    
           /* objXSLTransform.Load(xmlStr);    #1#
    
            // Creating StringBuilder object to hold html data and creates TextWriter object to hold data from XslCompiled.Transform method    
            StringBuilder htmlOutput = new StringBuilder();    
            TextWriter htmlWriter = new StringWriter(htmlOutput);    
    
            // Creating XmlReader object to read XML content    
            XmlReader reader = XmlReader.Create(xmlStr);    
    
            // Call Transform() method to create html string and write in TextWriter object.    
            objXSLTransform.Transform(reader, null, htmlWriter);    
    
            // Closing xmlreader object    
            reader.Close();    
            return htmlOutput.ToString(); 
        }
*/
        /*public static void CreatePdfFromHtml(string htmlString)
        {
            var pdfDocument = PdfGenerator.GeneratePdf(htmlString, PageSize.A4);
            pdfDocument.Save(@"D:\Pdf\test.pdf");
        }*/
    }
}