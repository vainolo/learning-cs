using System;
using System.IO;
using OfficeOpenXml;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "68.xlsx";
            FileInfo file = new FileInfo(filePath);

            using(var p = new ExcelPackage())
            {
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    // get the first worksheet in the workbook
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    int col = 2; //The item description
                    // output the data in column 2
                    for (int row = 2; row < 5; row++)
                        Console.WriteLine("\tCell({0},{1}).Value={2}", row, col, worksheet.Cells[row, col].Value);
                }
            }
        }
    }
}
