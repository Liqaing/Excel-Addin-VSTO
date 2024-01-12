using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OfficeOpenXml;
using OfficeOpenXml.Table;
using Excel = Microsoft.Office.Interop.Excel;

namespace BMToolkits
{
    public partial class otherFileForm : Form
    {
        Excel.Workbook workbook;
        List<string> selectedWbPath = new List<string>();

        public otherFileForm(Excel.Workbook workbook)
        {
            InitializeComponent();
            this.workbook = workbook;
        }

        
        // Import File
        private void selectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Excel Files";
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx|All Files|*.*";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                foreach (string filename in openFileDialog.FileNames)
                {
                    selectedWbPath.Add(filename);
                    selectedFilesListBox.Items.Add(filename);
                }
            }
        }

        // Delete slected value from list
        private void deleteSelected_Click(object sender, EventArgs e)
        {
            if (selectedFilesListBox.SelectedIndex != -1)
            {
                selectedWbPath.RemoveAt(selectedFilesListBox.SelectedIndex);
                selectedFilesListBox.Items.RemoveAt(selectedFilesListBox.SelectedIndex);
            }
        }

        // Clear listbox
        private void clearList_Click(object sender, EventArgs e)
        {
            selectedWbPath.Clear();
            selectedFilesListBox.Items.Clear();
        }

        // Enable and disable custom keys
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

        // Summary btn click
        private void summaryBtn_Click(object sender, EventArgs e)
        {
            if (selectedWbPath.Count == 0)
            {
                MessageBox.Show("There is no file to copy");
                return;
            }

            if (string.IsNullOrEmpty(copySheetName.Text))
            {
                MessageBox.Show("Please input sheet name to copy");
                return;
            }
            if (string.IsNullOrEmpty(control.Text))
            {
                MessageBox.Show("Please select control");
                return;
            }

            // Create new sheet
            string inputSheetName = sheetName.Text;
            if (string.IsNullOrEmpty(inputSheetName))
            {
                inputSheetName = "Summary";
            }
            Excel.Worksheet newWorksheet = util.getSheetByEqual(workbook, inputSheetName);
            if (newWorksheet == null)
            {
                newWorksheet = workbook.Worksheets.Add(inputSheetName);
            }
            // Delete table
            util.DeleteTables(newWorksheet);

            
            // Search sheet in all those file
            if (control.Text == "Contain")
            {
                // Loop through all workbook to get worksheet
                List<Excel.Worksheet> sheets = util.getSheetsByContain(selectedWbPath, inputSheetName);

                if (isCustomKey.Checked && string.IsNullOrEmpty(customKeys.Text))
                {
                    MessageBox.Show("Please input key to copy");
                    return;
                }

                // User doesn't use custom key
                if (!isCustomKey.Checked)
                {
                    // Create summary table
                    Excel.ListObject summaryTable = util.CreateSummaryInvoiceTable(newWorksheet);

                    // For each sheet copy value into table
                    util.copyInvoiceToTable(summaryTable, sheets, inputSheetName);

                    return;
                }


            }

        }
    }
}
