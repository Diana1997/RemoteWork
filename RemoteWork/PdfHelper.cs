using System;
using System.IO;
using iText.Html2pdf;

namespace RemoteWork
{
    public class PdfHelper
    {
        public static void createPdf(String html, String dest)
        {
           HtmlConverter.ConvertToPdf(html, new FileStream(dest, FileMode.OpenOrCreate));
            //   HtmlConverter.convertToPdf(html, new FileStream(dest, FileMode.CreateNew));
        }
    }
}