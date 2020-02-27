using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopierProgressBar
{
    public partial class Form1 : Form
    {
        CustomFileCopier fileCopy;

        public Form1()
        {
            InitializeComponent();

            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;   //Tell the user how the process went
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;    //Allow for the process to be cancelled
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                status.Text = "Process was cancelled";
            }
            else if (e.Error != null)
            {
                status.Text = "There was an error running the process. The thread aborted: "+e.Error.Message.ToString();
            }
            else {
                status.Text = "Process was completed";
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string src = lblFilePath.Text;
            string fileName = Path.GetFileName(src);
            string dest = @"C:\RED\" + fileName;
            fileCopy = new CustomFileCopier(src,dest);

            fileCopy.OnProgressChanged += copyProcessChanged;
            fileCopy.OnComplete += copyProcessCompleted;

            fileCopy.Copy();
        }

        private void copyProcessCompleted()
        {
            backgroundWorker1.ReportProgress(100);
        }

        private void copyProcessChanged(double Percentage, ref bool Cancel)
        {
            backgroundWorker1.ReportProgress((int)Percentage);
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void BtnCopyFile_Click(object sender, EventArgs e)
        {
            // Start Process
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
