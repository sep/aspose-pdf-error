# PdfToWordExample for Aspose.PDF Failure Demonstration

This command line application is intended to be used to demonstrate an error condition when converting from **PDF to Docx** using Aspose.PDF on **.NET Core**.

## How to execute the test program

I included configuration for `net462`, `netcoreapp3.0` and `netcoreapp3.1`. The program works as intended on .NET Framework (i.e. `net462`) and fails (unexpectedly) on .NET Core (`netcoreapp3.0` and `netcoreapp3.1`).

**Note:** if you place an Aspose license named `Aspose.lic` in the same directory as your executable, it'll pick it up and use it.

Using Visual Studio or VSCode, build the source. Then run the following command from any of the `net462`, `netcoreapp3.0` or `netcoreapp3.1` directories:

```
./PdfToWordExample.exe hello_msword.pdf
```

The program has 4 different supplied sample PDF files:

* `hello_msword.pdf` - The word "hello" typed into a Word document, then printed to PDF.
* `hello_googledocs.pdf` - The word "hello" typed into a Google Doc, then downloaded as PDF.
* `empty_msword.pdf` - An empty Word document, then printed to PDF.
* `empty_googledocs.pdf` - An empty Google Doc, then downloaded as PDF.

## The error

```
$ ./PdfToWordExample.exe hello_msword.pdf
Process terminated. Assertion failed.
Cannot read a name from the name table in a font.
   at #=zSxSO3z15QdTvI7rksayb5HeFV7qkTPi4hQ==.#=zt4xUns85Vujn(Int32 #=zF6312Fk=)
   at #=zSxSO3z15QdTvI7rksayb5HeFV7qkTPi4hQ==.#=z3hqh7z0=()
   at #=zSxSO3z15QdTvI7rksayb5HeFV7qkTPi4hQ==.#=zZUf3c_hhZaaI(#=zxSvHuPbwIiLenohdWF19MC8= #=zbtB7$zs=)
   at #=zm5PqrMJE6FWsDpIkG06GeRRm_fkO.#=zZUf3c_hhZaaI(#=zxSvHuPbwIiLenohdWF19MC8= #=zbtB7$zs=)
   at #=z3yaue1vDPNdLQ8$u5VX6BrNbk$qu.#=z95mPjywolgrb(#=zxSvHuPbwIiLenohdWF19MC8= #=zbtB7$zs=)
   at #=zm5PqrMJE6FWsDpIkG06GeRRm_fkO.#=z96RAgrD6$WkuUgA$Qw==(#=zxSvHuPbwIiLenohdWF19MC8=[] #=zKPK3Dd7Jqmnk)
   at #=z3yaue1vDPNdLQ8$u5VX6BrNbk$qu..ctor(#=zxSvHuPbwIiLenohdWF19MC8=[] #=zKPK3Dd7Jqmnk)
   at #=ze5mHjDNSsWQN1eYjtTp34kNS5flE.#=z_oKJW4UaKypt(#=zxSvHuPbwIiLenohdWF19MC8=[] #=zh54bDjxFSOil)
   at #=ze5mHjDNSsWQN1eYjtTp34kNS5flE.#=z_oKJW4UaKypt()
   at #=ze5mHjDNSsWQN1eYjtTp34kNS5flE.#=zq8lFwRZcO96M()
   at #=ze5mHjDNSsWQN1eYjtTp34kNS5flE.#=zisoFYy0=(String #=zxEui2c0=, FontStyle #=zvVKMXOI=)
   at #=zAgvPyreAEdEKHaSLxi8iFkq4J6sV.#=z0qz$9lbKhsN_(String #=zxEui2c0=, FontStyle #=zvVKMXOI=, String #=zHUJ5kLQqrXGF)
   at #=zAgvPyreAEdEKHaSLxi8iFkq4J6sV.#=ztV3lPeGcFu0G(String #=zxEui2c0=, Single #=zJWh00is_e6JL, FontStyle #=zvVKMXOI=, String #=zHUJ5kLQqrXGF)
   at #=zAgvPyreAEdEKHaSLxi8iFkq4J6sV.#=ztV3lPeGcFu0G(String #=zxEui2c0=, Single #=zJWh00is_e6JL, FontStyle #=zvVKMXOI=)
   at #=zLme2SQ0wNCE8dE$IpchMzOcH0Hst..cctor()
   at #=zLme2SQ0wNCE8dE$IpchMzOcH0Hst.#=z7WKo1Do=()
   at #=z8SnrKyfzlOeGAcNuugGlVD9VbOXo2szcym_gS5g=..ctor(#=zvIi1ia7bgTa3mu1nshbq2G9dSY0kzm09IfdyKsg= #=zuePxi$M=)
   at #=z6RalRduJVQKd5EZuNVMJuKliYjK8PHg7Gw==..ctor(#=zYCtESQ5lSIQrdfrShoiDgJfmWB$DG3PFOzp4KyM=#=zuePxi$M=, Stream #=z6nozkAeK$NlS)
   at #=zF_6hL3aP8NZVRW0KIO57xhg=.#=zvNzwBxfHvo1e(Document #=zcFgz3wE=, DocSaveOptions #=zuePxi$M=, Stream #=zykDMhKF5zYK4)
   at #=zF_6hL3aP8NZVRW0KIO57xhg=.#=zzhUKHADMKKfcAC4tBg==(Document #=zcFgz3wE=, DocSaveOptions #=zuePxi$M=, Queue`1 #=zfWhL2gZKyBnn, Stream #=zykDMhKF5zYK4, Int32 #=z7vqWldne7BE7)
   at #=zF_6hL3aP8NZVRW0KIO57xhg=.#=zRJreogk=(Document #=zcFgz3wE=, Stream #=zykDMhKF5zYK4, DocSaveOptions #=zuePxi$M=)
   at Aspose.Pdf.Document.#=zYI$W0LMGXYgC(Stream #=zykDMhKF5zYK4, SaveOptions #=zuePxi$M=)
   at Aspose.Pdf.Document.#=zYI$W0LMGXYgC(String #=zKB2HGNZAmo5E, SaveOptions #=zuePxi$M=)
   at Aspose.Pdf.Document.Save(String outputFileName, SaveOptions options)
   at Aspose.Pdf.Document.Convert(String srcFileName, LoadOptions loadOptions, String dstFileName, SaveOptions saveOptions)
   at PdfToWordExample.Program.Main(String[] args) in C:\Users\jcfuller\dev\PdfToWordExample\PdfToWordExample\Program.cs:line 30
```