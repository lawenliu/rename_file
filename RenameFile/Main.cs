using RenameFile.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFile
{
    public partial class Main : Form
    {
        BackgroundWorker backgroundWorker = null;
        private int mSourceFileNumber = -1;

        public Main()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the raw files directory";
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.SelectedPath = Configures.GetFilePath();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnStartAppend_Click(object sender, EventArgs e)
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(AppendFileName_DoWork);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(AppendFileName_ProgressChanged);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(AppendFileName_Completed);
            backgroundWorker.RunWorkerAsync();
        }

        private void AppendFileName_DoWork(object sender, DoWorkEventArgs e)
        {
            mSourceFileNumber = FileManager.CountFileNumber(tbFilePath.Text, cbProcessSubfolder.Checked);
            e.Result = FileManager.AppendFileName(tbFilePath.Text, tbAppendText.Text,
                cbAppendEnd.Checked, cbProcessSubfolder.Checked, backgroundWorker, 0);
        }

        private void AppendFileName_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbStatus.Value = (int)(e.ProgressPercentage * 1.0 / mSourceFileNumber * 100);
            tbStatus.Text = string.Format("{0}%: {1}", e.ProgressPercentage, e.UserState);
        }

        private void AppendFileName_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            tbStatus.Text = "Finish Renaming files, please check them.";
            Process.Start("explorer.exe", tbFilePath.Text);
        }

        private void btnStartReplace_Click(object sender, EventArgs e)
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(ReplaceFileName_DoWork);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(ReplaceFileName_ProgressChanged);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ReplaceFileName_Completed);
            backgroundWorker.RunWorkerAsync();
        }

        private void ReplaceFileName_DoWork(object sender, DoWorkEventArgs e)
        {
            mSourceFileNumber = FileManager.CountFileNumber(tbFilePath.Text, cbProcessSubfolder.Checked);
            e.Result = FileManager.ReplaceFileName(tbFilePath.Text, tbOriginalText.Text, tbReplaceText.Text,
                cbAppendEnd.Checked, cbProcessSubfolder.Checked, backgroundWorker, 0);
        }

        private void ReplaceFileName_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbStatus.Value = (int)(e.ProgressPercentage * 1.0 / mSourceFileNumber * 100);
            tbStatus.Text = string.Format("{0}%: {1}", e.ProgressPercentage, e.UserState);
        }

        private void ReplaceFileName_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            tbStatus.Text = "Finish Renaming files, please check them.";
            Process.Start("explorer.exe", tbFilePath.Text);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    SaveConfigures();
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private void SaveConfigures()
        {
            Configures.SaveFilePath(tbFilePath.Text);
            Configures.SaveIsProcessSubfolder(cbProcessSubfolder.Checked);
            Configures.SaveTextAppend(tbAppendText.Text);
            Configures.SaveIsAppendEnd(cbAppendEnd.Checked);
            Configures.SaveOriginalText(tbOriginalText.Text);
            Configures.SaveReplaceText(tbReplaceText.Text);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tbFilePath.Text = Configures.GetFilePath();
            cbProcessSubfolder.Checked = Configures.IsProcessSubfolder();
            tbAppendText.Text = Configures.GetTextAppend();
            cbAppendEnd.Checked = Configures.IsAppendEnd();
            tbOriginalText.Text = Configures.GetOriginalText();
            tbReplaceText.Text = Configures.GetReplaceText();
        }
    }
}
