using IronXL;
using System.Reflection;

namespace ReadAndWriteFiles.Utilities
{
    public class Utility
    {
        static string path = @"C:\Users\aanup\OneDrive\Desktop\Learning\LearnTopics\ReadAndWriteFiles\ReadAndWriteFiles\InputDataFiles";

        public static void CreateExcelFile()
        {
            // Create new worksheet
            WorkBook xlxsWorkBook = WorkBook.Create(ExcelFileFormat.XLSX);
            WorkSheet worksheet = xlxsWorkBook.CreateWorkSheet("Sheet_1");

            // Set data inside the worksheet
            worksheet["A1"].Value = "Test Value";
            worksheet["A1"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;

            // Save the workbook
            xlxsWorkBook.SaveAs(Path.Combine(path, "newExceldata.xlsx"));
        }

        public static void ReadExcelFile(string fileName, int workSheetNumber = 0, string workSheetName = "Sheet1")
        {
            WorkBook workBook = WorkBook.Load(Path.Combine(path, fileName));
            WorkSheet workSheet;

            // if any other sheet number is given rather than first sheet
            if (workSheetNumber > 0)
            {
                workSheet = workBook.WorkSheets[workSheetNumber];
            } // if sheet name is provided
            else if (!string.IsNullOrWhiteSpace(workSheetName))
            {
                workSheet = workBook.GetWorkSheet(workSheetName);
            }
            else
            {
                workSheet = workBook.WorkSheets[0];
            }

            Console.WriteLine(workSheet.GetCellAt(0, 0));
        }

        public static void UpdateExcelFile(string fileName, int workSheetNumber = 0, string workSheetName = "Sheet1")
        {
            WorkBook workBook = WorkBook.Load(Path.Combine(path, fileName));
            WorkSheet workSheet;

            // if any other sheet number is given rather than first sheet
            if (workSheetNumber > 0)
            {
                workSheet = workBook.WorkSheets[workSheetNumber];
            } // if sheet name is provided
            else if (!string.IsNullOrWhiteSpace(workSheetName))
            {
                workSheet = workBook.GetWorkSheet(workSheetName);
            }
            else
            {
                workSheet = workBook.WorkSheets[0];
            }

            Cell cell = workSheet.GetCellAt(0, 1);

            if (cell.Text.Split("PCIMFTI-").Length > 1)
            {
                cell.Value = cell.Text.Split("PCIMFTI-")[1].Replace("(github.com)", string.Empty, StringComparison.OrdinalIgnoreCase);
            }
            var temp = "kjdkj-pcimfti-lkkjkd";
            var tempINdex = temp.IndexOf("pcimfti", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(temp.Remove(tempINdex));
            workBook.Save();
        }
    }
}
