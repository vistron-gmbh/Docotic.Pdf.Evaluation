using System;
using System.Diagnostics;

namespace BitMiracle.Docotic.Pdf.Samples
{
    public static class SetCustomXmpProperties
    {
        public static void Main()
        {
            // NOTE: 
            // When used in trial mode, the library imposes some restrictions.
            // Please visit http://bitmiracle.com/pdf-library/trial-restrictions.aspx
            // for more information.

            using (PdfDocument pdf = new PdfDocument())
            {
                XmpSchema custom = pdf.Metadata.Custom;

                // add simple string property
                custom.Properties.Add("stringProperty", "string value");

                // add simple array property
                XmpArray array = new XmpArray(XmpArrayType.Ordered);
                for (int i = 0; i < 5; i++)
                    array.Values.Add(new XmpString(i.ToString()));
                custom.Properties.Add("arrayProperty", array);

                // array array with language alternatives
                XmpArray languageArray = new XmpArray(XmpArrayType.Alternative);
                languageArray.Values.Add(new XmpLanguageAlternative("x-default", "I'm Feeling Lucky"));
                languageArray.Values.Add(new XmpLanguageAlternative("fr-fr", "J'ai de la chance"));
                custom.Properties.Add("arrayWithAlternatives", languageArray);

                // add string properties with qualifiers
                XmpString author1 = new XmpString("First Author");
                author1.Qualifiers.Add("role", "main author");
                custom.Properties.Add("anotherStringProperty", author1);

                XmpString author2 = new XmpString("Second Author");
                author2.Qualifiers.Add("role", "co-author");
                custom.Properties.Add("yetAnotherStringProperty", author2);

                // add array with qualified string values
                XmpArray authors = new XmpArray(XmpArrayType.Unordered);
                authors.Values.Add(author1);
                authors.Values.Add(author2);
                custom.Properties.Add("arrayWithQualifiedStrings", authors);

                // add structure
                XmpStructure structure = new XmpStructure("struct", "http://example.com/structure/");
                structure.Properties.Add("string", "string in a structure");
                structure.Properties.Add("array", authors);
                structure.Properties.Add("arrayWithAlternatives", languageArray);
                custom.Properties.Add("structureProperty", structure);

                string pathToFile = "SetCustomXmpProperties.pdf";
                pdf.Save(pathToFile);

                Console.WriteLine($"The output is located in {Environment.CurrentDirectory}");

                Process.Start(new ProcessStartInfo(pathToFile) { UseShellExecute = true });
            }
        }
    }
}
