﻿using System.IO;

namespace BitMiracle.Docotic.Pdf.Samples
{
    public static class LoggingWithLog4Net
    {
        public static void Main()
        {
            // NOTE: 
            // When used in trial mode, the library imposes some restrictions.
            // Please visit http://bitmiracle.com/pdf-library/trial-restrictions.aspx
            // for more information.

            // In order to receive log messages from Docotic.Pdf into a log4net logger, 
            // you would need to configure log4net. Here is a simplest one-line 
            // way to configure it. You might use any other way described in the docs
            // https://logging.apache.org/log4net/release/manual/configuration.html
            log4net.Config.XmlConfigurator.Configure();

            // The above line configures log4net using properties from app.config file.
            // Take a look into the app.config file, it contains more comments.

            // After log4net is configured, there is nothing else to do, the library
            // will put its log messages into the configured loggers. 
            // The following code should produce log messages in console and in 
            // log-file.txt file next to application's exe file.
            using (PdfDocument pdf = new PdfDocument(@"..\Sample Data\Attachments.pdf"))
            {
                using (MemoryStream ms = new MemoryStream())
                    pdf.Pages[0].Save(ms, PdfDrawOptions.Create()); 
            }
        }
    }
}