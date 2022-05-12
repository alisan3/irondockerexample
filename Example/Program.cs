using IronPdf;

IronPdf.Logging.Logger.EnableDebugging = true;
IronPdf.Logging.Logger.LogFilePath = "Default.log"; //May be set to a directory name or full file
IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;

var Renderer = new ChromePdfRenderer();
using var PDF = Renderer.RenderHtmlAsPdf("<h1>Html with CSS and Images</h1>");

PDF.SaveAs("pixel-perfect.pdf");
