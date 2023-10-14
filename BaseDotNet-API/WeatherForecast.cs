using OfficeOpenXml;
using System.Data;
using System.Net.Mail;

namespace BaseDotNet_API;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
    public static Attachment GetAttachment(DataTable dataTable)
    {
        MemoryStream outputStream = new MemoryStream();
        using (ExcelPackage package = new ExcelPackage(outputStream))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("sheetName");
            worksheet.Cells.LoadFromDataTable(dataTable, true);
            package.Save();
        }
        outputStream.Position = 0;
        Attachment attachment = new Attachment(outputStream, "sample.xlsx", "application/vnd.ms-excel");
        return attachment;
    }
}

