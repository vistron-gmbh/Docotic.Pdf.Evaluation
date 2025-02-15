# Extract attachments from PDF documents in C# and VB.NET
This sample shows how to save PDF attachment bytes using [Docotic.Pdf library](https://bitmiracle.com/pdf-library/).

Each attachment is represented by a [PdfFileSpecification object](https://bitmiracle.com/pdf-library/help/pdffilespecification.html).
Use PdfFileSpecification.Contents property to retrieve a reference to a [PdfEmbeddedFile object](https://bitmiracle.com/pdf-library/help/pdfembeddedfile.html). 

If the retrieved reference is null then the file specification refers to an external file. I.e., only reference to a file is attached. 

If the retrieved reference is non-null then the file is actually embedded in the document.
Use [PdfEmbeddedFile.Save methods](https://bitmiracle.com/pdf-library/help/pdfembeddedfile.save.html) to extract contents of the attachment to a stream or a file.

## See also
* [Get free time-limited license key](https://bitmiracle.com/pdf-library/download-pdf-library.aspx)