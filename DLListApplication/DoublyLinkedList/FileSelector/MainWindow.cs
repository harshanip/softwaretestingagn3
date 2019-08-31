using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLLibrary;
namespace FileSelector
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
 

        private void FirstFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {               
                lblFirstFolder.Text = dlg.SelectedPath;
            }
        }

        private void SecondFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
             
                lblSecondFolder.Text = dlg.SelectedPath;
            }
        }

        private void DiffButton_Click(object sender, EventArgs e)
        {

            FileUtility util = new FileUtility();
            util.AddFolderContentToList(lblFirstFolder.Text);
            util.RemoveFolderContentFromList(lblSecondFolder.Text);
            lblResult.Text = util.GetList().display(5);
            if(lblResult.Text == null || lblResult.Text.Trim().Length == 0)
            {
                lblResult.Text = "Both folders have same content";
               
            }
            //lblResult.Text = "Done"+ util.GetList().ToString(); 
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lblFirstFolder.Text = "";
            lblSecondFolder.Text = "";
            lblResult.Text = "";
            lblFirstFolder.AutoSize = true;
            lblSecondFolder.AutoSize = true;
            lblResult.AutoSize = true;

        }
    }
}
