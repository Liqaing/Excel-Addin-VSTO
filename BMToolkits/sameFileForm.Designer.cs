namespace BMToolkits
{
    partial class sameFileForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.copySheetName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.control = new System.Windows.Forms.TextBox();
            this.isCustomKey = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customKeys = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sheetName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Control";
            // 
            // copySheetName
            // 
            this.copySheetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copySheetName.Location = new System.Drawing.Point(182, 41);
            this.copySheetName.Name = "copySheetName";
            this.copySheetName.Size = new System.Drawing.Size(402, 26);
            this.copySheetName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sheet Name To Copy";
            // 
            // summaryBtn
            // 
            this.summaryBtn.BackColor = System.Drawing.Color.LightBlue;
            this.summaryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.summaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.summaryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryBtn.Location = new System.Drawing.Point(590, 41);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(91, 26);
            this.summaryBtn.TabIndex = 4;
            this.summaryBtn.Text = "Summary";
            this.summaryBtn.UseVisualStyleBackColor = false;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            // 
            // control
            // 
            this.control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control.Location = new System.Drawing.Point(16, 41);
            this.control.Name = "control";
            this.control.ReadOnly = true;
            this.control.Size = new System.Drawing.Size(150, 26);
            this.control.TabIndex = 5;
            this.control.Text = "Contain";
            // 
            // isCustomKey
            // 
            this.isCustomKey.AutoSize = true;
            this.isCustomKey.Location = new System.Drawing.Point(16, 207);
            this.isCustomKey.Name = "isCustomKey";
            this.isCustomKey.Size = new System.Drawing.Size(133, 24);
            this.isCustomKey.TabIndex = 6;
            this.isCustomKey.Text = "Customize Key";
            this.isCustomKey.UseVisualStyleBackColor = true;
            this.isCustomKey.CheckedChanged += new System.EventHandler(this.isCustomKey_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Set custom to copy";
            // 
            // customKeys
            // 
            this.customKeys.AllowDrop = true;
            this.customKeys.Enabled = false;
            this.customKeys.Location = new System.Drawing.Point(182, 177);
            this.customKeys.Multiline = true;
            this.customKeys.Name = "customKeys";
            this.customKeys.Size = new System.Drawing.Size(402, 100);
            this.customKeys.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Add Sheet Name";
            // 
            // sheetName
            // 
            this.sheetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheetName.Location = new System.Drawing.Point(182, 103);
            this.sheetName.Name = "sheetName";
            this.sheetName.Size = new System.Drawing.Size(402, 26);
            this.sheetName.TabIndex = 10;
            // 
            // sameFileForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(709, 338);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sheetName);
            this.Controls.Add(this.customKeys);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isCustomKey);
            this.Controls.Add(this.control);
            this.Controls.Add(this.summaryBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.copySheetName);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "sameFileForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Sheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox copySheetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.TextBox control;
        private System.Windows.Forms.CheckBox isCustomKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customKeys;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sheetName;
    }
}