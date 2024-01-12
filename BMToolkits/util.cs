using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

using Excel = Microsoft.Office.Interop.Excel;

using OfficeOpenXml;
using OfficeOpenXml.Table;

namespace BMToolkits
{
    internal class util
    {
        // Copy and return value from invoice (sheet)
        public static void copyInvoiceToTable(Excel.ListObject table, List<Excel.Worksheet> sheets, string sheetName)
        {
            int rowIndex = table.ListRows.Count + 1;

            foreach (Excel.Worksheet sheet in sheets)
            {
                if (sheet.Name != sheetName)
                {
                    Excel.ListRow newRow = table.ListRows.Add(rowIndex);

                    string invDate = getCellValue(sheet, "កាលបរិច្ឆេទៈ");
                    string invNum = getCellValue(sheet, "លេខវិក្កយបត្រៈ");
                    string subTotal = getCellValue(sheet, "សរុប / Sub Total:");
                    string vat = getCellValue(sheet, "អាករលើតម្លៃបន្ថែម ១០% / VAT 10%:");
                    string grandTotalUsd = getCellValue(sheet, "សរុបរួម ($) / Grand Total ($):");
                    string grandTotalRiel = getCellValue(sheet, "សរុបរួម (Riel) / Grand Total (Riel):");
                    string rate = getCellValue(sheet, "Exchange Rate for E-VAT: ");

                    newRow.Range.Cells[1, 1].Value = sheet.Name;

                    try
                    { 
                        DateTime formattedDate = DateTime.Parse(invDate);
                        newRow.Range.Cells[1, 2].Value = formattedDate.Date;
                    }
                    catch (Exception)
                    {
                        newRow.Range.Cells[1, 2].Value = invDate;
                    }

                    newRow.Range.Cells[1, 3].Value = invNum;

                    newRow.Range.Cells[1, 4].Value = subTotal;
                    newRow.Range.Cells[1, 4].NumberFormat = "$ #,##0.00";

                    newRow.Range.Cells[1, 5].Value = vat;
                    newRow.Range.Cells[1, 5].NumberFormat = "$ #,##0.00";

                    newRow.Range.Cells[1, 6].Value = grandTotalUsd;
                    newRow.Range.Cells[1, 6].NumberFormat = "$ #,##0.00";

                    newRow.Range.Cells[1, 7].Value = grandTotalRiel;
                    newRow.Range.Cells[1, 7].NumberFormat = "\"R\" #,##0";

                    newRow.Range.Cells[1, 8].Value = rate;

                    rowIndex++;
                }              
            }
        }

        // Copy and return value from invoice (sheet) base on customize key
        public static void copyInvoiceToTable(Excel.ListObject table, List<Excel.Worksheet> sheets, string[] customizeKeys, string sheetName)
        {
            // Loop through every sheet. For each sheet loop through all key and get value for each key then add to the same row
            int rowIndex = table.ListRows.Count + 1;
            foreach (Excel.Worksheet sheet in sheets)
            {
                if (sheet.Name != sheetName)
                {
                    Excel.ListRow newRow = table.ListRows.Add(rowIndex);
                    newRow.Range.Cells[1, 1].Value = sheet.Name;
                    for (int i = 0, len = customizeKeys.Length; i < len; i++)
                    {
                        string value = getCellValue(sheet, customizeKeys[i]);
                        if (value != null)
                        {
                            // First col is for sheet name, other col start from second index
                            newRow.Range.Cells[1, i + 2].Value = value;
                        }
                    }
                    rowIndex++;
                }
            }
        }

        public static string getCellValue(Excel.Worksheet ws, string searchValue)
        {
            
            // Find the cell with the specified value
            Excel.Range foundCell = ws.Cells.Find(searchValue, Type.Missing, Excel.XlFindLookIn.xlValues,
                Excel.XlLookAt.xlWhole, Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext,
                false, Type.Missing, Type.Missing);

            if (foundCell != null)
            {
                //ExcelRangeBase foundCell = ws.Cells.Where(cell => cell.Text.Equals(searchValue, StringComparison.OrdinalIgnoreCase));
                int col = 1;

                // Search col in the same row for value
                while (col < 50)
                {
                    // Check if the Offset is not null and if the Value is not null
                    if (foundCell.Offset[0, col] != null && foundCell.Offset[0, col].Value != null)
                    {
                        // Convert the value to string
                        return foundCell.Offset[0, col].Value.ToString();
                    }

                    col++;
                }
            }
            // Value not found or no adjacent cell value
            return null;
        }



        // Search for sheets in workbook
        public static Excel.Worksheet getSheetByEqual(Excel.Workbook wb, string searchTerm)
        {
            foreach (Excel.Worksheet ws in wb.Worksheets)
            {
                if (ws.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
                {   
                    return ws;
                }
            }
            return null;
        }

        // Search for sheet even if they are party the same, control: contain
        public static List<Excel.Worksheet> getSheetsByContain(List<string> selectedWbPath, string searchTerm)
        {
            /*
            List<Excel.Worksheet> sheets = new List<Excel.Worksheet>(); 
            foreach (ws in se.Worksheets)
            {
                if (ws.Name.Contains(searchTerm))
                {
                    sheets.Add(ws);
                }
            }
            return sheets;
            */
            return null;
        }
        
        public static List<Excel.Worksheet> getSheetsByContain(Excel.Workbook selectedWb, string searchTerm)
        {
            List<Excel.Worksheet> sheets = new List<Excel.Worksheet>();

            foreach (Excel.Worksheet sheet in selectedWb.Sheets)
            {
                if (sheet.Name.Contains(searchTerm))
                { 
                   sheets.Add(sheet);
                }    
            }

            return sheets;
        }
        

        // Delete all existing tables in the workbook
        public static void DeleteTables(Excel.Worksheet ws)
        {            
            List<Excel.ListObject> tablesToDelete = new List<Excel.ListObject>();

            foreach (Excel.ListObject table in ws.ListObjects)
            {
                table.Delete();
            }         
        }

        // Create table for summary invoice
        public static Excel.ListObject CreateSummaryInvoiceTable(Excel.Worksheet ws)
        {
            string tableRange = "A1:H1";

            Excel.ListObject summaryTable = ws.ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange,
            ws.Range[tableRange], Type.Missing, Excel.XlYesNoGuess.xlYes, Type.Missing);

            // Set the table name
            summaryTable.Name = "Summary Table";
            summaryTable.HeaderRowRange.Cells[1, 1].Value = "Sheet Name";
            summaryTable.HeaderRowRange.Cells[1, 2].Value = "Invoice Date";
            summaryTable.HeaderRowRange.Cells[1, 3].Value = "Invoice Number";
            summaryTable.HeaderRowRange.Cells[1, 4].Value = "Subtotal";
            summaryTable.HeaderRowRange.Cells[1, 5].Value = "VAT Amount";
            summaryTable.HeaderRowRange.Cells[1, 6].Value = "Grand Total USD";
            summaryTable.HeaderRowRange.Cells[1, 7].Value = "Grand Total Riel";
            summaryTable.HeaderRowRange.Cells[1, 8].Value = "Rate";

            return summaryTable;
        }

        // Create summary table base on summary key
        public static Excel.ListObject CreateSummaryInvoiceTable(Excel.Worksheet ws, string[] customizeKeys)
        {
            // Add col header to table base on key
            ws.Cells[1, 1].Value = "Sheet Name";
            for (int i = 0, len = customizeKeys.Length; i < len; i++)
            {
                ws.Cells[1, i + 2].Value = customizeKeys[i];
            }

            // Get table range to create table on
            Excel.ListObject summaryTable = ws.ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange,
            ws.UsedRange, Type.Missing, Excel.XlYesNoGuess.xlYes, Type.Missing);

            return summaryTable;
        }


    }
}
