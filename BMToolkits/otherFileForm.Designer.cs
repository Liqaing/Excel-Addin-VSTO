namespace BMToolkits
{
    partial class otherFileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFile = new System.Windows.Forms.Button();
            this.deleteSelected = new System.Windows.Forms.Button();
            this.clearList = new System.Windows.Forms.Button();
            this.selectedFilesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.control = new System.Windows.Forms.ComboBox();
            this.copySheetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customKeys = new System.Windows.Forms.TextBox();
            this.isCustomKey = new System.Windows.Forms.CheckBox();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sheetName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectFile
            // 
            this.selectFile.BackColor = System.Drawing.SystemColors.Control;
            this.selectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectFile.Location = new System.Drawing.Point(12, 12);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(102, 34);
            this.selectFile.TabIndex = 0;
            this.selectFile.Text = "Select File";
            this.selectFile.UseVisualStyleBackColor = false;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // deleteSelected
            // 
            this.deleteSelected.BackColor = System.Drawing.SystemColors.Control;
            this.deleteSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteSelected.Location = new System.Drawing.Point(127, 12);
            this.deleteSelected.Name = "deleteSelected";
            this.deleteSelected.Size = new System.Drawing.Size(137, 34);
            this.deleteSelected.TabIndex = 1;
            this.deleteSelected.Text = "Delete Selected";
            this.deleteSelected.UseVisualStyleBackColor = false;
            this.deleteSelected.Click += new System.EventHandler(this.deleteSelected_Click);
            // 
            // clearList
            // 
            this.clearList.BackColor = System.Drawing.SystemColors.Control;
            this.clearList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearList.Location = new System.Drawing.Point(403, 12);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(113, 34);
            this.clearList.TabIndex = 2;
            this.clearList.Text = "Clear List";
            this.clearList.UseVisualStyleBackColor = false;
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // selectedFilesListBox
            // 
            this.selectedFilesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedFilesListBox.FormattingEnabled = true;
            this.selectedFilesListBox.ItemHeight = 16;
            this.selectedFilesListBox.Location = new System.Drawing.Point(12, 52);
            this.selectedFilesListBox.Name = "selectedFilesListBox";
            this.selectedFilesListBox.Size = new System.Drawing.Size(504, 180);
            this.selectedFilesListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Control";
            // 
            // control
            // 
            this.control.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control.FormattingEnabled = true;
            this.control.Items.AddRange(new object[] {
            "Equal",
            "Contain"});
            this.control.Location = new System.Drawing.Point(12, 261);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(147, 26);
            this.control.TabIndex = 5;
            // 
            // copySheetName
            // 
            this.copySheetName.Location = new System.Drawing.Point(172, 261);
            this.copySheetName.Name = "copySheetName";
            this.copySheetName.Size = new System.Drawing.Size(342, 26);
            this.copySheetName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sheet Name To Copy";
            this.label1.UseWaitCursor = true;
            // 
            // customKeys
            // 
            this.customKeys.Enabled = false;
            this.customKeys.Location = new System.Drawing.Point(172, 363);
            this.customKeys.Multiline = true;
            this.customKeys.Name = "customKeys";
            this.customKeys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customKeys.Size = new System.Drawing.Size(342, 102);
            this.customKeys.TabIndex = 8;
            // 
            // isCustomKey
            // 
            this.isCustomKey.AutoSize = true;
            this.isCustomKey.Location = new System.Drawing.Point(10, 399);
            this.isCustomKey.Name = "isCustomKey";
            this.isCustomKey.Size = new System.Drawing.Size(133, 24);
            this.isCustomKey.TabIndex = 9;
            this.isCustomKey.Text = "Customize Key";
            this.isCustomKey.UseVisualStyleBackColor = true;
            this.isCustomKey.CheckedChanged += new System.EventHandler(this.isCustomKey_CheckedChanged);
            // 
            // summaryBtn
            // 
            this.summaryBtn.BackColor = System.Drawing.Color.LightBlue;
            this.summaryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.summaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.summaryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryBtn.Location = new System.Drawing.Point(171, 471);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(91, 34);
            this.summaryBtn.TabIndex = 10;
            this.summaryBtn.Text = "Summary";
            this.summaryBtn.UseVisualStyleBackColor = false;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Add Sheet Name";
            this.label3.UseWaitCursor = true;
            // 
            // sheetName
            // 
            this.sheetName.Location = new System.Drawing.Point(171, 319);
            this.sheetName.Name = "sheetName";
            this.sheetName.Size = new System.Drawing.Size(342, 26);
            this.sheetName.TabIndex = 11;
            // 
            // otherFileForm
            // 
            this.ClientSize = new System.Drawing.Size(526, 531);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sheetName);
            this.Controls.Add(this.summaryBtn);
            this.Controls.Add(this.isCustomKey);
            this.Controls.Add(this.customKeys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copySheetName);
            this.Controls.Add(this.control);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedFilesListBox);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.deleteSelected);
            this.Controls.Add(this.selectFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "otherFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.Button deleteSelected;
        private System.Windows.Forms.Button clearList;
        private System.Windows.Forms.ListBox selectedFilesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox control;
        private System.Windows.Forms.TextBox copySheetName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customKeys;
        private System.Windows.Forms.CheckBox isCustomKey;
        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sheetName;
    }
}