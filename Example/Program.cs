using IronPdf;

IronPdf.Logging.Logger.EnableDebugging = true;
IronPdf.Logging.Logger.LogFilePath = "Default.log"; //May be set to a directory name or full file
IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;

var Renderer = new ChromePdfRenderer();
Renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
{
    MaxHeight = 15, //millimeters
    HtmlFragment = "<center><i>footer<i></center>",
    DrawDividerLine = true
};

using var PDF = Renderer.RenderHtmlAsPdf("<h1>Html with CSS and Images</h1>")
    .WatermarkAllPages("<h1>test</h1>");

PDF.SaveAs("pixel-perfect.pdf");

Thread.Sleep(TimeSpan.FromMinutes(3));
