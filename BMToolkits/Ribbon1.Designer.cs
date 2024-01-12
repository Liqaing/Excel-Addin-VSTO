namespace BMToolkits
{
    partial class ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ribbon));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.summaryTables = this.Factory.CreateRibbonSplitButton();
            this.otherFiles = this.Factory.CreateRibbonButton();
            this.sameFile = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "BMToolkits";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.summaryTables);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // summaryTables
            // 
            this.summaryTables.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.summaryTables.Image = ((System.Drawing.Image)(resources.GetObject("summaryTables.Image")));
            this.summaryTables.Items.Add(this.otherFiles);
            this.summaryTables.Items.Add(this.sameFile);
            this.summaryTables.Label = "Summary Invoices";
            this.summaryTables.Name = "summaryTables";
            // 
            // otherFiles
            // 
            this.otherFiles.Label = "From Other Files";
            this.otherFiles.Name = "otherFiles";
            this.otherFiles.ShowImage = true;
            this.otherFiles.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.otherFiles_Click);
            // 
            // sameFile
            // 
            this.sameFile.Label = "From Same File";
            this.sameFile.Name = "sameFile";
            this.sameFile.ShowImage = true;
            this.sameFile.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sameFiles_Click);
            // 
            // ribbon
            // 
            this.Name = "ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton summaryTables;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton otherFiles;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sameFile;
    }

    partial class ThisRibbonCollection
    {
        internal ribbon Ribbon1
        {
            get { return this.GetRibbon<ribbon>(); }
        }
    }
}
