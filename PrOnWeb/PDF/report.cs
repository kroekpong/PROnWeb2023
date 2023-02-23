using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.JSInterop;

namespace PrOnWeb.PDF
{
    public class Report
    {


        public void Generate(IJSRuntime js,  string filename = "report.pdf")
        {
 
            js.InvokeVoidAsync( "jsSaveAsFile",
                                filename,
                                Convert.ToBase64String(ReportPDF())
                                );
        }

        public void OpenToIframe(IJSRuntime js,  string idiFrame)
        {
 
            js.InvokeVoidAsync( "jsOpenToIframe",
                                idiFrame,
                                Convert.ToBase64String(ReportPDF())
                                );
        }
        public void OpenNewTab(IJSRuntime js,  string filename = "report.pdf")
        {
  
            js.InvokeVoidAsync( "jsOpenIntoNewTab",
                                filename,
                                Convert.ToBase64String(ReportPDF())
                                );
        }

        //private byte[] FormFill()
        //{
        //    using (var memoryStream = new MemoryStream())
        //    {
        //        PdfReader reader = new PdfReader(templateFile); //Iput
        //        PdfWriter writer = new PdfWriter(memoryStream); //output
        //        PdfDocument pdfDoc = new PdfDocument(reader, writer);
        //        PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);

        //        var fields = form.GetFormFields();


        //        fields["CompName"].SetValue(branch.Comp.NameTh, font, 10);
        //        fields["CompSSO_ID"].SetValue(String.Format("{0} {1} {2}", sSOBranch.SsoAcc.SubstringMaxLength(0, 2), sSOBranch.SsoAcc.SubstringMaxLength(2, 7), sSOBranch.SsoAcc.SubstringMaxLength(9, 1)), font, 10);
        //        fields["BRN_NAME"].SetValue(branch.NameTh, font, 10);

        //        form.FlattenFields();

        //        pdfDoc.Close();
        //        byte[] b = memoryStream.ToArray();
        //        return b;
        //    }
        //}

        private byte[] ReportPDF()
        {
            var memoryStream = new MemoryStream();

            // Marge in centimeter, then I convert with .ToDpi()
            float margeLeft = 1.5f;
            float margeRight= 1.5f;
            float margeTop = 1.0f;
            float margeBottom = 1.0f;

            Document pdf = new Document(
                                    PageSize.A4,
                                    margeLeft.ToDpi(),
                                    margeRight.ToDpi(),
                                    margeTop.ToDpi(),
                                    margeBottom.ToDpi()
                                   );

            pdf.AddTitle("Blazor-PDF");
            pdf.AddAuthor( "Christophe Peugnet");
            pdf.AddCreationDate();
            pdf.AddKeywords("blazor");
            pdf.AddSubject("Create a pdf file with iText");

            PdfWriter writer = PdfWriter.GetInstance(pdf, memoryStream);

            //HEADER and FOOTER
            var fontStyle = FontFactory.GetFont("Arial", 16, BaseColor.White);
            var labelHeader = new Chunk("Header Blazor PDF", fontStyle);
            HeaderFooter header = new HeaderFooter(new Phrase(labelHeader), false)
            {
                BackgroundColor = new BaseColor(133, 76, 199),
                Alignment = Element.ALIGN_CENTER,
                Border = Rectangle.NO_BORDER
            };
            //header.Border = Rectangle.NO_BORDER;
            pdf.Header = header;


            var labelFooter = new Chunk("Page", fontStyle);
            HeaderFooter footer = new HeaderFooter(new Phrase(labelFooter), true)
            {
                Border = Rectangle.NO_BORDER,
                Alignment = Element.ALIGN_RIGHT
            };
            pdf.Footer = footer;

            pdf.Open();

            Page4.PageTable(pdf, writer);

            pdf.Close();

            return memoryStream.ToArray();
        }



    }
}
