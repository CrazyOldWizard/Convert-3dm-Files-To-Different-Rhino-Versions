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
            using (var window = new OpenFileDialog())
            {
                window.InitialDirectory = filePath;
                window.Filter = "3dm Files (*.3dm) | *.3dm";
                window.RestoreDirectory = true;

                if (window.ShowDialog() == DialogResult.OK)
                {
                    filePath = window.FileName;
                    txt_FilePath.Text = filePath;
                    try
                    {
                        var version = File3dm.ReadArchiveVersion(filePath);
                        if (version == 0)
                        {
                            MessageBox.Show("Couldn't get Rhino version for selected file! File could be invalid or corrupt!",
                                "File warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            label_SelecedFileVersion.Text = $"Selected File Version: Unknown";
                        }
                        else
                        {
                            label_SelecedFileVersion.Text = $"Selected File Version: Rhino {version.ToString().Replace("0", "")}";
                            BTN_Convert.Enabled = true;
                        }

                    }
                    catch (Exception errorMessage)
                    {
                        MessageBox.Show($"Error while trying to access file! Message: {Environment.NewLine}{errorMessage.Message}");
                    }
                }
            }
        }

        private void BTN_Convert_Click(object sender, EventArgs e)
        {
            if (File.Exists(txt_FilePath.Text))
            {
                var _3dm = File3dm.Read(filePath);
                var finfo = new FileInfo(filePath);
                var dir = finfo.Directory.FullName;
                var versionNumber = RhinoVersions[versionBox.SelectedIndex];
                var newFileName = Path.Combine(dir, Path.GetFileNameWithoutExtension(filePath) + $"_VERSION{versionNumber}.3dm");
                label_Status.Text = $"Status: Saving file as version {versionNumber} file.";
                try
                {
                    _3dm.Write(newFileName, versionNumber);
                    label_Status.Text = "Status: Saved file. Success.";
                    BTN_Convert.Enabled = false;
                }
                catch (Exception fileSaveError)
                {
                    MessageBox.Show($"Error while trying to save new file! Message: {Environment.NewLine}{fileSaveError.Message}");
                    label_Status.Text = "Status: Failed to save file.";
                }

            }
            else
            {
                label_Status.Text = "Status: Could't find file path.";
            }
        }
    }
}
