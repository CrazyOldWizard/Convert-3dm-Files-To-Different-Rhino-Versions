
namespace Convert_3dm_Files_To_Different_Rhino_Versions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_Browse = new System.Windows.Forms.Button();
            this.BTN_Convert = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_SelecedFileVersion = new System.Windows.Forms.Label();
            this.versionBox = new System.Windows.Forms.ComboBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxFolderMode = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Browse
            // 
            this.BTN_Browse.Location = new System.Drawing.Point(551, 55);
            this.BTN_Browse.Name = "BTN_Browse";
            this.BTN_Browse.Size = new System.Drawing.Size(75, 23);
            this.BTN_Browse.TabIndex = 0;
            this.BTN_Browse.Text = "Browse";
            this.BTN_Browse.UseVisualStyleBackColor = true;
            this.BTN_Browse.Click += new System.EventHandler(this.BTN_Browse_Click);
            // 
            // BTN_Convert
            // 
            this.BTN_Convert.Location = new System.Drawing.Point(551, 105);
            this.BTN_Convert.Name = "BTN_Convert";
            this.BTN_Convert.Size = new System.Drawing.Size(75, 23);
            this.BTN_Convert.TabIndex = 1;
            this.BTN_Convert.Text = "Convert";
            this.toolTip1.SetToolTip(this.BTN_Convert, "Start the conversion process.");
            this.BTN_Convert.UseVisualStyleBackColor = true;
            this.BTN_Convert.Click += new System.EventHandler(this.BTN_Convert_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(12, 55);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(533, 20);
            this.txt_FilePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected Path:";
            this.toolTip1.SetToolTip(this.label1, "The path to the 3dm file that you would like to convert.");
            // 
            // label_SelecedFileVersion
            // 
            this.label_SelecedFileVersion.AutoSize = true;
            this.label_SelecedFileVersion.Location = new System.Drawing.Point(411, 36);
            this.label_SelecedFileVersion.Name = "label_SelecedFileVersion";
            this.label_SelecedFileVersion.Size = new System.Drawing.Size(109, 13);
            this.label_SelecedFileVersion.TabIndex = 5;
            this.label_SelecedFileVersion.Text = "Selected File Version:";
            // 
            // versionBox
            // 
            this.versionBox.FormattingEnabled = true;
            this.versionBox.Items.AddRange(new object[] {
            "Rhino 2",
            "Rhino 3",
            "Rhino 4",
            "Rhino 5",
            "Rhino 6",
            "Rhino 7"});
            this.versionBox.Location = new System.Drawing.Point(414, 105);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(121, 21);
            this.versionBox.TabIndex = 6;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(12, 113);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(40, 13);
            this.label_Status.TabIndex = 7;
            this.label_Status.Text = "Status:";
            this.toolTip1.SetToolTip(this.label_Status, "Current status.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rhino Save Version";
            // 
            // checkBoxFolderMode
            // 
            this.checkBoxFolderMode.AutoSize = true;
            this.checkBoxFolderMode.Location = new System.Drawing.Point(323, 107);
            this.checkBoxFolderMode.Name = "checkBoxFolderMode";
            this.checkBoxFolderMode.Size = new System.Drawing.Size(85, 17);
            this.checkBoxFolderMode.TabIndex = 9;
            this.checkBoxFolderMode.Text = "Folder Mode";
            this.checkBoxFolderMode.UseVisualStyleBackColor = true;
            this.checkBoxFolderMode.CheckedChanged += new System.EventHandler(this.checkBoxFolderMode_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 136);
            this.Controls.Add(this.checkBoxFolderMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.versionBox);
            this.Controls.Add(this.label_SelecedFileVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_FilePath);
            this.Controls.Add(this.BTN_Convert);
            this.Controls.Add(this.BTN_Browse);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 175);
            this.MinimumSize = new System.Drawing.Size(650, 175);
            this.Name = "Form1";
            this.Text = "Convert 3dm Version";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Browse;
        private System.Windows.Forms.Button BTN_Convert;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_SelecedFileVersion;
        private System.Windows.Forms.ComboBox versionBox;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxFolderMode;
    }
}

