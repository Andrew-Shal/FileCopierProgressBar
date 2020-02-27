namespace FileCopierProgressBar
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.BtnCopyFile = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Location = new System.Drawing.Point(63, 24);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectFile.TabIndex = 0;
            this.BtnSelectFile.Text = "select  file";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(53, 97);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 1;
            // 
            // BtnCopyFile
            // 
            this.BtnCopyFile.Location = new System.Drawing.Point(63, 53);
            this.BtnCopyFile.Name = "BtnCopyFile";
            this.BtnCopyFile.Size = new System.Drawing.Size(75, 23);
            this.BtnCopyFile.TabIndex = 2;
            this.BtnCopyFile.Text = "copy file";
            this.BtnCopyFile.UseVisualStyleBackColor = true;
            this.BtnCopyFile.Click += new System.EventHandler(this.BtnCopyFile_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(156, 29);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(31, 13);
            this.lblFilePath.TabIndex = 3;
            this.lblFilePath.Text = "none";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(53, 127);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(35, 13);
            this.status.TabIndex = 4;
            this.status.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.status);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.BtnCopyFile);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.BtnSelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button BtnCopyFile;
        private System.Windows.Forms.Label lblFilePath;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label status;
    }
}

