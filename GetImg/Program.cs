using ClosedXML.Excel;
using System;
using System.Net;
using System.Threading.Tasks;

namespace GetImg
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var workbook = new XLWorkbook(@"C:\Users\nxgth\OneDrive\Desktop\ReadIMG\Submit Inlinks.xlsx");
            var worksheet = workbook.Worksheets.Worksheet("Sheet1");
            int row = 2;
            while (worksheet.Cell(row, 1).Value.ToString() != "")
            {
                WebClient client = new WebClient();
                client.DownloadFile(new Uri(worksheet.Cell(row, 1).Value.ToString()), @"C:\Users\nxgth\OneDrive\Desktop\ReadIMG\FolderImgs\" + worksheet.Cell(row, 2).Value.ToString() + ".jpg");
                row++;
            }
        }
    }
}
