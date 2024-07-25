// See https://aka.ms/new-console-template for more information
using ReadAndWriteFiles.Utilities;

Console.WriteLine("Hello, World!");


Utility.ReadExcelFile("newExceldata.xlsx", workSheetName: "Sheet2");
Utility.UpdateExcelFile("newExceldata.xlsx", workSheetName: "Sheet2");
Utility.ReadExcelFile("newExceldata.xlsx", workSheetName: "Sheet2");

//Utility.CreateExcelFile();