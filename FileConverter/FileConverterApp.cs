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

namespace FileConverter
{
    public partial class FileConverterApp : Form
    {
        public FileConverterApp()
        {
            InitializeComponent();
            listView.View = View.Details;
            listView.Columns.Add("Files", -2, HorizontalAlignment.Left);
            LoadImage();
            EvnetBind();
        }

        private void EvnetBind() 
        {
            listView.AllowDrop = true;
            listView.DragEnter += ListView_DragEnter;
            listView.DragDrop += ListView_DragDrop;
        }

        private void ListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // DragDrop 이벤트 핸들러
        private void ListView_DragDrop(object sender, DragEventArgs e)
        {
            listView.Items.Clear();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string filePath in files)
                {
                    FileUtils.FileExp exp = FileUtils.GetFileExp(filePath);

                    if (exp == FileUtils.FileExp.NONE)
                        continue;

                    string fileName = FileUtils.GetOriginalFileName(filePath);
                    FileItem fileItem = new FileItem(fileName, filePath, exp);

                    ListViewItem listViewItem = new ListViewItem(fileItem.FilePath);
                    listViewItem.Tag = fileItem;
                    listView.Items.Add(listViewItem);
                }
            }
        }

        private void LoadImage()
        {
            string relativePath = @"Images\profileImage.png"; 
            string absolutePath = Path.Combine(Application.StartupPath, relativePath);
            if (File.Exists(absolutePath))
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = new Bitmap(absolutePath);
            }
            else
            {
                MessageBox.Show("Image file not found: " + absolutePath);
            }
        }

        private void filePathBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                folderBrowserDialog.ShowNewFolderButton = true;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    filePathText.Text = selectedFolderPath; 
                }
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string outPath = filePathText.Text;
            if (outPath.Length == 0) 
            {
                MessageBox.Show("저장할 파일 경로를 입력하세요.");
                return;
            }

            progressBar.Minimum = 0;
            progressBar.Maximum = listView.Items.Count;
            progressBar.Value = 0;

            if (listView.Items.Count == 0) 
            {
                MessageBox.Show("작업할 파일이 존재하지 않습니다.");
                return;
            }
            List<FileItem> errorList = new List<FileItem>();
            foreach (ListViewItem item in listView.Items)
            {
                FileItem fileItem = (FileItem)item.Tag;
                FileConverter.TaskFile.TaskFile taskFile = TaskFileFactory.GenerateTaskFile(outPath, fileItem);

                if (taskFile == null)
                {
                    progressBar.Value++;
                    continue;
                }
                
                bool result = taskFile.ConverterPng();
                if (!result)
                {
                    errorList.Add(fileItem);
                }
                progressBar.Value++;
            }

            MessageBox.Show("작업이 완료되었습니다");

            if (errorList.Count > 0)
            {
                string errorMsg = "";
                foreach(FileItem f in errorList) 
                {
                    errorMsg += f.FileName+ "\n";
                }
                MessageBox.Show($"파일 변환 실패\n{errorMsg}");
            }
            progressBar.Minimum = 0;
            progressBar.Maximum = 0;
            progressBar.Value = 0;

            listView.Items.Clear();
        }
    }
}
