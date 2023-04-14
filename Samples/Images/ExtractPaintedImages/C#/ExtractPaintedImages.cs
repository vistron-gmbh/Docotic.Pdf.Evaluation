using System;
using System.Diagnostics;

namespace BitMiracle.Docotic.Pdf.Samples
{
    public static class ExtractPaintedImages
    {
        public static void Main()
        {
            //VistronExample();
            DocticExample();
        }

        private static void VistronExample()
        {
            // NOTE: 
            // When used in trial mode, the library imposes some restrictions.
            // Please visit http://bitmiracle.com/pdf-library/trial-restrictions.aspx
            // for more information.

            var asIsOutputName = "";
            var asPaintedOutputName = "VistronCustomerSampleOne.SaveAsPainted.tiff";

            using (PdfDocument pdf = new PdfDocument(@"..\Sample Data\VistronCustomerSampleOne.pdf"))
            {
                var images = pdf.Pages[0].GetImages();
                PdfCollection<PdfPaintedImage> paintedImages = pdf.Pages[0].GetPaintedImages();

                PdfPaintedImage image = paintedImages[0];

                // save image as is
                asIsOutputName = image.Image.Save("PdfImage2.Save");

                // save image as painted
                var options = new PdfPaintedImageSavingOptions
                {
                    
                    Format = PdfExtractedImageFormat.Tiff,
                    HorizontalResolution = 300,
                    VerticalResolution = 300
                };
                image.SaveAsPainted(asPaintedOutputName, options);
            }

            Console.WriteLine($"The output is located in {Environment.CurrentDirectory}");

            Process.Start(new ProcessStartInfo(asIsOutputName) { UseShellExecute = true });
            Process.Start(new ProcessStartInfo(asPaintedOutputName) { UseShellExecute = true });
        }

        private static void DocticExample()
        {
            // NOTE: 
            // When used in trial mode, the library imposes some restrictions.
            // Please visit http://bitmiracle.com/pdf-library/trial-restrictions.aspx
            // for more information.

            var asIsOutputName = "";
            var asPaintedOutputName = "PdfPaintedImage.SaveAsPainted.tiff";

            using (PdfDocument pdf = new PdfDocument(@"..\Sample Data\ImageScaleAndRotate.pdf"))
            {
                var images = pdf.Pages[0].GetImages();
                PdfCollection<PdfPaintedImage> paintedImages = pdf.Pages[0].GetPaintedImages();

                PdfPaintedImage image = paintedImages[0];

                // save image as is
                asIsOutputName = image.Image.Save("PdfImage.Save");

                // save image as painted
                var options = new PdfPaintedImageSavingOptions
                {
                    Format = PdfExtractedImageFormat.Tiff,
                    HorizontalResolution = 300,
                    VerticalResolution = 300
                };
                image.SaveAsPainted(asPaintedOutputName, options);
            }

            Console.WriteLine($"The output is located in {Environment.CurrentDirectory}");

            Process.Start(new ProcessStartInfo(asIsOutputName) { UseShellExecute = true });
            Process.Start(new ProcessStartInfo(asPaintedOutputName) { UseShellExecute = true });
        }
    }
}
