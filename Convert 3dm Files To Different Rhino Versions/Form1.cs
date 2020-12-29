using Rhino.FileIO;
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

namespace Convert_3dm_Files_To_Different_Rhino_Versions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            versionBox.SelectedIndex = 3;
            versionBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BTN_Convert.Enabled = false;
        }

        private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static readonly int[] RhinoVersions = new int[] { 2, 3, 4, 5, 6, 7 };
        private static bool inFolderMode = false;
        private static List<string> Models = new List<string>();

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_Browse_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }

        private void BTN_Browse_Click(object sender, EventArgs e)
        {
            label_Status.Text = "Status:";
            Models.Clear();
            if(inFolderMode)
            {
                using (var window = new FolderBrowserDialog())
                {
                    window.RootFolder = Environment.SpecialFolder.Desktop;
                    window.ShowNewFolderButton = true;
                    window.Description = "Select a folder containing .3dm files to convert.";

                    if(window.ShowDialog() == DialogResult.OK)
                    {
                        var files = Directory.GetFiles(window.SelectedPath, "*.3dm", SearchOption.TopDirectoryOnly);
                        var task = Task.Run(() =>
                        {
                            foreach (var model in files)
                            {
                                Read3dmFile(model);
                            }
                        });
                    }
                }
            }
            else
            {
                using (var window = new OpenFileDialog())
                {
                    window.InitialDirectory = filePath;
                    window.Filter = "3dm Files (*.3dm) | *.3dm";
                    window.RestoreDirectory = true;
                    window.Multiselect = false;

                    if (window.ShowDialog() == DialogResult.OK)
                    {
                        Read3dmFile(window.FileName);
                    }
                }
            }
            
        }

        private void Read3dmFile(string filePath)
        {
            UpdateFilePathBoxText(filePath);
            try
            {
                UpdateStatusText($"Reading {Path.GetFileName(filePath)}");
                var version = File3dm.ReadArchiveVersion(filePath);
                if (version == 0)
                {
                    MessageBox.Show($"Couldn't get Rhino version for selected file! File could be invalid or corrupt! {Environment.NewLine}" +
                        $"File:  {filePath}",
                        "File warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    label_SelecedFileVersion.Invoke((MethodInvoker)delegate
                    {
                        label_SelecedFileVersion.Text = "Selected File Version: Unknown";
                    });
                }
                else
                {
                    if(!inFolderMode)
                    {
                        label_SelecedFileVersion.Invoke((MethodInvoker)delegate
                        {
                            label_SelecedFileVersion.Text = $"Selected File Version: Rhino {version.ToString().Replace("0", "")}";
                        });
                    }
                    Models.Add(filePath);
                    EnableConvertButton(true);
                    UpdateStatusText("Status:");
                }

            }
            catch (Exception errorMessage)
            {
                MessageBox.Show($"Error while trying to access file! Message: {Environment.NewLine}{errorMessage.Message}");
            }
        }

        private void BTN_Convert_Click(object sender, EventArgs e)
        {
            var versionNumber = RhinoVersions[versionBox.SelectedIndex];
            var task = Task.Run(() =>
            {
                foreach (var model in Models)
                {
                    if (File.Exists(model))
                    {
                        var _3dm = File3dm.Read(model);
                        var finfo = new FileInfo(model);
                        var dir = finfo.Directory.FullName;
                        var newFileName = Path.Combine(dir, Path.GetFileNameWithoutExtension(model) + $"_VERSION{versionNumber}.3dm");
                        UpdateFilePathBoxText(model);
                        UpdateStatusText($"Status: Saving file as version {versionNumber} file.");
                        try
                        {
                            _3dm.Write(newFileName, versionNumber);
                            UpdateStatusText("Status: Saved file. Success.");
                            EnableConvertButton(false);
                        }
                        catch (Exception fileSaveError)
                        {
                            MessageBox.Show($"Error while trying to save new file! Message: {Environment.NewLine}{fileSaveError.Message}");
                            UpdateStatusText("Status: Failed to save file.");
                        }
                    }
                    else
                    {
                        UpdateStatusText("Status: Could't find file path.");
                    }
                }
            });
        }

        private void checkBoxFolderMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFolderMode.Checked)
                inFolderMode = true;
            else
                inFolderMode = false;
        }

        private void UpdateStatusText(string text)
        {
            label_Status.Invoke((MethodInvoker)delegate
            {
                label_Status.Text = text;
            });
        }
        private void UpdateFilePathBoxText(string text)
        {
            txt_FilePath.Invoke((MethodInvoker)delegate
            {
                txt_FilePath.Text = text;
            });
        }
        private void EnableConvertButton(bool value)
        {
            BTN_Convert.Invoke((MethodInvoker)delegate
            {
                BTN_Convert.Enabled = value;
            });
        }

    }
}
