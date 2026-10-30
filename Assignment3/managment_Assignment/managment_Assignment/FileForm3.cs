using System;
using System.IO;
using System.Windows.Forms;

namespace managment_Assignment
{
    public partial class FileForm3 : Form
    {
        public FileForm3()
        {
            InitializeComponent();
        }

        // 1. CREATE - New File
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = tbFileName.Text.Trim();

                if (filePath == "")
                {
                    MessageBox.Show("File name is empty!");
                    return;
                }

                using (StreamWriter fileWriter = File.CreateText(filePath))
                {
                    // the file is created here
                }

                MessageBox.Show("New file created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 2. WRITE - Write
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = tbFileName.Text.Trim();

                if (filePath == "")
                {
                    MessageBox.Show("File name is empty!");
                    return;
                }

                using (StreamWriter fileWriter = File.CreateText(filePath))
                {
                    fileWriter.WriteLine(tbInput.Text);
                }

                MessageBox.Show("Text saved to file!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 3. READ - Read
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = tbFileName.Text.Trim();

                if (File.Exists(filePath))
                {
                    using (StreamReader fileReader = File.OpenText(filePath))
                    {
                        tbOutput.Clear();
                        while (!fileReader.EndOfStream)
                        {
                            tbOutput.AppendText(fileReader.ReadLine() + Environment.NewLine);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 4. APPEND - Add Text
        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = tbFileName.Text.Trim();

                if (filePath == "")
                {
                    MessageBox.Show("File name is empty!");
                    return;
                }

                using (StreamWriter fileWriter = File.AppendText(filePath))
                {
                    fileWriter.WriteLine(tbInput.Text);
                }

                MessageBox.Show("Text added to the end of the file!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 5. DELETE - Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = tbFileName.Text.Trim();

                if (File.Exists(filePath))
                {
                    DialogResult answer = MessageBox.Show(
                        "Delete this file?",
                        "Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (answer == DialogResult.Yes)
                    {
                        File.Delete(filePath);
                        tbOutput.Clear();
                        MessageBox.Show("File deleted!");
                    }
                }
                else
                {
                    MessageBox.Show("File not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 6. CLEAR - Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFileName.Clear();
            tbInput.Clear();
            tbOutput.Clear();
        }
    }
}
