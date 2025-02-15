using System;

namespace BitMiracle.Docotic.Pdf.Samples
{
    public static class EnumerateLayers
    {
        public static void Main()
        {
            // NOTE: 
            // When used in trial mode, the library imposes some restrictions.
            // Please visit http://bitmiracle.com/pdf-library/trial-restrictions.aspx
            // for more information.
            
            using (PdfDocument pdf = new PdfDocument(@"..\Sample Data\BorderPinksOranges.pdf"))
            {
                PdfCollection<PdfLayer> layers = pdf.Layers;
                foreach (PdfLayer layer in layers)
                {
                    string message = string.Format("Name = {0}\nVisible = {1}\nIntents = ",
                        layer.Name, layer.Visible);

                    foreach (PdfLayerIntent intent in layer.GetIntents())
                    {
                        message += intent.ToString();
                        message += " ";
                    }

                    Console.WriteLine("Layer Info:");
                    Console.WriteLine(message);
                    Console.WriteLine();
                }
            }

            using (PdfDocument pdf = new PdfDocument(@"..\Sample Data\VistronCustomerSampleOne.pdf"))
            {
                PdfCollection<PdfLayer> layers = pdf.Layers;
                foreach (PdfLayer layer in layers)
                {
                    string message = string.Format("Name = {0}\nVisible = {1}\nIntents = ",
                        layer.Name, layer.Visible);

                    foreach (PdfLayerIntent intent in layer.GetIntents())
                    {
                        message += intent.ToString();
                        message += " ";
                    }

                    Console.WriteLine("Layer Info:");
                    Console.WriteLine(message);
                    Console.WriteLine();
                }
            }
        }
    }
}
