# Embed PDF fonts in C# and VB.NET
This sample shows how to embed fonts in a PDF document using [Docotic.Pdf library](https://bitmiracle.com/pdf-library/).

Use [PdfFont.Embed()](https://bitmiracle.com/pdf-library/help/pdffont.embed.html) method to embed the given font in a PDF document.
By default, this method uses [SystemFontLoader](https://bitmiracle.com/pdf-library/help/systemfontloader.html) to load bytes for TrueType/OpenType fonts.

This sample shows how to embed TrueType font bytes using fonts from a custom directory.

Embedding of PDF fonts is useful when you need to:
* Display or print a PDF document consistently on any devices.
* Fix an existing PDF document with non-embedded fonts.
* Replace an existing PDF font subset with a full font to use in editable form fields.
* Produce PDF/A document.

Note that embedding of PDF fonts can significantly increase an output file size.

## See also
* [Get free time-limited license key](https://bitmiracle.com/pdf-library/download-pdf-library.aspx)
* [Subset PDF fonts in C# and VB.NET](/Samples/Compression/FontSubsetting) sample