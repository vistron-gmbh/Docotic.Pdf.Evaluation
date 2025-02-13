# Copy text, paths and images between PDF pages in C# and VB.NET
This sample shows how to copy page objects (text, paths and images) to a new PDF page using [Docotic.Pdf library](https://bitmiracle.com/pdf-library/).

Use PdfDocument.CopyPage method to copy full page content and associated resources (fonts, images) to a new document. Then use PdfPage.GetObjects() method to get all text, paths and images drawn on the page. Copy required objects to a new page. At the end, remove original page from the result document.

Copying of page objects is useful when you want to remove or replace some content (e.g., text) from the page.

## See also
* [Get free time-limited license key](https://bitmiracle.com/pdf-library/download-pdf-library.aspx)
* [Remove paths](/Samples/Graphics/RemovePaths) sample
* [Remove painted images](/Samples/Images/RemovePaintedImages) sample