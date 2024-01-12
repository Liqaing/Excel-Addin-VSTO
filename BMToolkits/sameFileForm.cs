using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace BMToolkits
{
    public partial class sameFileForm : Form
    {
        Excel.Workbook workbook;
        public sameFileForm(Excel.Workbook workbook)
        {
            InitializeComponent();
            this.workbook = workbook;
            
        }

        // When summary button is clicked
        private void summaryBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(control.Text) || string.IsNullOrEmpty(copySheetName.Text))
            {
                MessageBox.Show("Input cannot be empty");
                return;
            }

            // Search for invoice sheets
            List<Excel.Worksheet> sheets = util.getSheetsByContain(workbook, copySheetName.Text);
            if (sheets.Count <= 1)
            {
                MessageBox.Show("Counld not find invoice sheets with the given name");
                return;
            }

            // Create new sheet
            string inputSheetName = sheetName.Text;
            if (string.IsNullOrEmpty(inputSheetName)) {
                inputSheetName = "Summary";
            }
            Excel.Worksheet newWorksheet = util.getSheetByEqual(workbook, inputSheetName);
            if (newWorksheet == null)
            {
                newWorksheet = workbook.Worksheets.Add();
                newWorksheet.Name = inputSheetName;
            }

            util.DeleteTables(newWorksheet);

            // User doesn't use custom key
            if (!isCustomKey.Checked)
            {
                // Create summary table
                Excel.ListObject summaryTable = util.CreateSummaryInvoiceTable(newWorksheet);

                // For each sheet copy value into table
                util.copyInvoiceToTable(summaryTable, sheets, inputSheetName);
                
                return;
            }

            if (isCustomKey.Checked && string.IsNullOrEmpty(customKeys.Text))
            {
                MessageBox.Show("Please input key to copy");
                return;
            }

            // User set custom key to copy
            if (isCustomKey.Checked && !string.IsNullOrEmpty(customKeys.Text))
            {
                // Get input key from user and store in array in array 
                string[] userCustomKeys = customKeys.Text.Split(',').Select(key => key.Trim()).ToArray();
                //MessageBox.Show(userCustomKeys[0]);

                // Create summary table base on key value
                Excel.ListObject summaryTable = util.CreateSummaryInvoiceTable(newWorksheet, userCustomKeys);

                // Copy value into table base on key
                util.copyInvoiceToTable(summaryTable, sheets, userCustomKeys, inputSheetName);

                return;
            }
        }

        private void isCustomKey_CheckedChanged(object sender, EventArgs e)
        {
            if (isCustomKey.Checked)
            {
                customKeys.Enabled = true;
            }
            else
            {
                customKeys.Enabled = false; 
            }
        }
    }
}
