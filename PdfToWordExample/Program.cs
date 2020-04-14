using System;
using System.IO;
using System.Linq;
using Aspose.Pdf;

namespace PdfToWordExample
{
    class Program
    {
        private const int ExitCode_Nominal = 0;
        private const int ExitCode_GeneralError = 1;
        private const int ExitCode_InvalidArguments = 64;

        static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Error.WriteLine("This program takes 1 argument: the full path to a PDF file to convert to a docx file");
                return ExitCode_InvalidArguments;
            }
            var srcFileName = args.First();
            var dstFileName = Path.ChangeExtension(srcFileName, "docx");

            const string licenseFile = "Aspose.lic";
            if (File.Exists(licenseFile))
            {
                new License().SetLicense(licenseFile);
            }

            try
            {

                Document.Convert(srcFileName, null, dstFileName, new DocSaveOptions
                {
                    Format = DocSaveOptions.DocFormat.DocX,
                });

                Console.Out.WriteLine($"converted '{srcFileName}' to '{dstFileName}'");
                return ExitCode_Nominal;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return ExitCode_GeneralError;
            }
        }
    }
}
