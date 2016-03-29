namespace RenameFile
{
    partial class Main
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbProcessSubfolder = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAppendText = new System.Windows.Forms.TextBox();
            this.btnStartAppend = new System.Windows.Forms.Button();
            this.btnStartReplace = new System.Windows.Forms.Button();
            this.tbReplaceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOriginalText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAppendEnd = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 120);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(733, 201);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbAppendEnd);
            this.tabPage1.Controls.Add(this.btnStartAppend);
            this.tabPage1.Controls.Add(this.tbAppendText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(725, 175);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Append Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnStartReplace);
            this.tabPage2.Controls.Add(this.tbReplaceText);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbOriginalText);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(725, 175);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Replace Text";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbProcessSubfolder);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.tbFilePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select folder which contains files";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(64, 31);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(476, 20);
            this.tbFilePath.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(592, 31);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbProcessSubfolder
            // 
            this.cbProcessSubfolder.AutoSize = true;
            this.cbProcessSubfolder.Location = new System.Drawing.Point(150, 70);
            this.cbProcessSubfolder.Name = "cbProcessSubfolder";
            this.cbProcessSubfolder.Size = new System.Drawing.Size(147, 17);
            this.cbProcessSubfolder.TabIndex = 3;
            this.cbProcessSubfolder.Text = "Process Files in Subfolder";
            this.cbProcessSubfolder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text will Append";
            // 
            // tbAppendText
            // 
            this.tbAppendText.Location = new System.Drawing.Point(185, 31);
            this.tbAppendText.Name = "tbAppendText";
            this.tbAppendText.Size = new System.Drawing.Size(260, 20);
            this.tbAppendText.TabIndex = 1;
            // 
            // btnStartAppend
            // 
            this.btnStartAppend.Location = new System.Drawing.Point(586, 58);
            this.btnStartAppend.Name = "btnStartAppend";
            this.btnStartAppend.Size = new System.Drawing.Size(75, 23);
            this.btnStartAppend.TabIndex = 2;
            this.btnStartAppend.Text = "Start";
            this.btnStartAppend.UseVisualStyleBackColor = true;
            this.btnStartAppend.Click += new System.EventHandler(this.btnStartAppend_Click);
            // 
            // btnStartReplace
            // 
            this.btnStartReplace.Location = new System.Drawing.Point(586, 58);
            this.btnStartReplace.Name = "btnStartReplace";
            this.btnStartReplace.Size = new System.Drawing.Size(75, 23);
            this.btnStartReplace.TabIndex = 7;
            this.btnStartReplace.Text = "Start";
            this.btnStartReplace.UseVisualStyleBackColor = true;
            this.btnStartReplace.Click += new System.EventHandler(this.btnStartReplace_Click);
            // 
            // tbReplaceText
            // 
            this.tbReplaceText.Location = new System.Drawing.Point(228, 85);
            this.tbReplaceText.Name = "tbReplaceText";
            this.tbReplaceText.Size = new System.Drawing.Size(253, 20);
            this.tbReplaceText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Replace Text in File Name";
            // 
            // tbOriginalText
            // 
            this.tbOriginalText.Location = new System.Drawing.Point(228, 31);
            this.tbOriginalText.Name = "tbOriginalText";
            this.tbOriginalText.Size = new System.Drawing.Size(253, 20);
            this.tbOriginalText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Orignal Text in File Name";
            // 
            // cbAppendEnd
            // 
            this.cbAppendEnd.AutoSize = true;
            this.cbAppendEnd.Location = new System.Drawing.Point(73, 95);
            this.cbAppendEnd.Name = "cbAppendEnd";
            this.cbAppendEnd.Size = new System.Drawing.Size(222, 17);
            this.cbAppendEnd.TabIndex = 4;
            this.cbAppendEnd.Text = "Append to End of Name (Default is Head)";
            this.cbAppendEnd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbStatus);
            this.groupBox2.Controls.Add(this.pbStatus);
            this.groupBox2.Location = new System.Drawing.Point(12, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 156);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(79, 37);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(555, 23);
            this.pbStatus.TabIndex = 1;
            // 
            // tbStatus
            // 
            this.tbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStatus.Location = new System.Drawing.Point(79, 91);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(555, 13);
            this.tbStatus.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.Text = "Rename Files";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbAppendEnd;
        private System.Windows.Forms.Button btnStartAppend;
        private System.Windows.Forms.TextBox tbAppendText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnStartReplace;
        private System.Windows.Forms.TextBox tbReplaceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOriginalText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbProcessSubfolder;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.ProgressBar pbStatus;
    }
}

