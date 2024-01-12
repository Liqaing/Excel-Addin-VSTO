using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace BMToolkits
{
    public partial class ribbon
    {

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            // Set reference to the workbook associate with add in
            // workbook = Globals.ThisAddIn.Application.ActiveWorkbook;
            // MessageBox.Show(workbook.Title);
        }


        // Sumarry Invoice From Other Files
        private void otherFiles_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Workbook activeWorkbook = Globals.ThisAddIn.Application.ActiveWorkbook;

            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            otherFileForm form = new otherFileForm(activeWorkbook);
            form.Show();

        }

        // Summary Invoice From Same Files
        private void sameFiles_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Workbook activeWorkbook = Globals.ThisAddIn.Application.ActiveWorkbook;
            
            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            sameFileForm form = new sameFileForm(activeWorkbook);
            form.Show();
            
        }
    }
}
