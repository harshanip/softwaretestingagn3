namespace FileSelector
{
    partial class MainWindow
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
            this.firstFile = new System.Windows.Forms.Button();
            this.secondFile = new System.Windows.Forms.Button();
            this.diffButton = new System.Windows.Forms.Button();
            this.lblFirstFolder = new System.Windows.Forms.Label();
            this.lblSecondFolder = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstFile
            // 
            this.firstFile.BackColor = System.Drawing.SystemColors.Info;
            this.firstFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstFile.Location = new System.Drawing.Point(12, 12);
            this.firstFile.Name = "firstFile";
            this.firstFile.Size = new System.Drawing.Size(221, 35);
            this.firstFile.TabIndex = 0;
            this.firstFile.Text = "Select the First Folder";
            this.firstFile.UseVisualStyleBackColor = false;
            this.firstFile.Click += new System.EventHandler(this.FirstFile_Click);
            // 
            // secondFile
            // 
            this.secondFile.BackColor = System.Drawing.SystemColors.Info;
            this.secondFile.FlatAppearance.BorderSize = 2;
            this.secondFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondFile.Location = new System.Drawing.Point(13, 53);
            this.secondFile.Name = "secondFile";
            this.secondFile.Size = new System.Drawing.Size(220, 36);
            this.secondFile.TabIndex = 1;
            this.secondFile.Text = "Select the Second Folder";
            this.secondFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.secondFile.UseVisualStyleBackColor = false;
            this.secondFile.Click += new System.EventHandler(this.SecondFile_Click);
            // 
            // diffButton
            // 
            this.diffButton.BackColor = System.Drawing.SystemColors.Info;
            this.diffButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diffButton.Location = new System.Drawing.Point(13, 109);
            this.diffButton.Name = "diffButton";
            this.diffButton.Size = new System.Drawing.Size(220, 31);
            this.diffButton.TabIndex = 2;
            this.diffButton.Text = "Check the Difference";
            this.diffButton.UseVisualStyleBackColor = false;
            this.diffButton.Click += new System.EventHandler(this.DiffButton_Click);
            // 
            // lblFirstFolder
            // 
            this.lblFirstFolder.AutoSize = true;
            this.lblFirstFolder.BackColor = System.Drawing.SystemColors.Info;
            this.lblFirstFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstFolder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFirstFolder.Location = new System.Drawing.Point(252, 19);
            this.lblFirstFolder.Name = "lblFirstFolder";
            this.lblFirstFolder.Size = new System.Drawing.Size(16, 21);
            this.lblFirstFolder.TabIndex = 3;
            this.lblFirstFolder.Text = "1";
            // 
            // lblSecondFolder
            // 
            this.lblSecondFolder.AutoSize = true;
            this.lblSecondFolder.BackColor = System.Drawing.SystemColors.Info;
            this.lblSecondFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondFolder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSecondFolder.Location = new System.Drawing.Point(249, 61);
            this.lblSecondFolder.Name = "lblSecondFolder";
            this.lblSecondFolder.Size = new System.Drawing.Size(19, 21);
            this.lblSecondFolder.TabIndex = 4;
            this.lblSecondFolder.Text = "2";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.Info;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(25, 174);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(51, 21);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "label1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::FileSelector.Properties.Resources.Image1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(546, 454);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecondFolder);
            this.Controls.Add(this.lblFirstFolder);
            this.Controls.Add(this.diffButton);
            this.Controls.Add(this.secondFile);
            this.Controls.Add(this.firstFile);
            this.Name = "MainWindow";
            this.Text = "Folder Comparison";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button firstFile;
        private System.Windows.Forms.Button secondFile;
        private System.Windows.Forms.Button diffButton;
        private System.Windows.Forms.Label lblFirstFolder;
        private System.Windows.Forms.Label lblSecondFolder;
        private System.Windows.Forms.Label lblResult;
    }
}

