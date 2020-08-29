using CDS.MainApplication.Library.ReadFile;
using Question3.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3
{
    public partial class Form1 : Form
    {
        const string fileDirectory = "C:\\demo\\";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {

            CreateFile createFile = new CreateFile();
            createFile.GenerateMainDocument(fileDirectory);
            labelStatus.Text = "File Complete!";
            ShowFileList();
        }

        private void buttonSplitFile_Click(object sender, EventArgs e)
        {
            FileSplitter fileSplitter = new FileSplitter();
            fileSplitter.SplitMainFile(fileDirectory);
            labelStatus.Text = "File Split Complete!";
            ShowFileList();
        }

        private void buttonGenerate_KeyDown(object sender, KeyEventArgs e)
        {
            labelStatus.Text = "Generating file...";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowFileList();
        }

        private void ShowFileList()
        {
            listBox1.Items.Clear();
            string[] filePaths = Directory.GetFiles(fileDirectory);
            for (int i = 0; i < filePaths.Length; ++i)
            {
                string path = filePaths[i];
                listBox1.Items.Add(System.IO.Path.GetFileName(path));
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DeleteFile deleteFile = new DeleteFile();
            foreach(var item in listBox1.Items)
            {
                deleteFile.Delete(fileDirectory, item.ToString());
            }

            ShowFileList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string file = ((System.Windows.Forms.ListBox)sender).Text;
            Process.Start(fileDirectory + file);
        }
    }
}
