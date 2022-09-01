namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextArea = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.File_DropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_DropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.CopySelection = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.CutSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.Format_DropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.Bold = new System.Windows.Forms.ToolStripMenuItem();
            this.Italic = new System.Windows.Forms.ToolStripMenuItem();
            this.Underline = new System.Windows.Forms.ToolStripMenuItem();
            this.StrikeThrough = new System.Windows.Forms.ToolStripMenuItem();
            this.Upper = new System.Windows.Forms.ToolStripMenuItem();
            this.Lower = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.AlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.AlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.AlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.AlignJustify = new System.Windows.Forms.ToolStripMenuItem();
            this.TextFormat = new System.Windows.Forms.ToolStripDropDownButton();
            this.SelectFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.FontSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.IncreaseFont = new System.Windows.Forms.ToolStripMenuItem();
            this.DecreaseFont = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoActions = new System.Windows.Forms.ToolStripButton();
            this.RedoActions = new System.Windows.Forms.ToolStripButton();
            this.HelpButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.89335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.10665F));
            this.tableLayoutPanel1.Controls.Add(this.TextArea, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 347);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TextArea
            // 
            this.TextArea.AcceptsTab = true;
            this.TextArea.AutoWordSelection = true;
            this.TextArea.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TextArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextArea.EnableAutoDragDrop = true;
            this.TextArea.ForeColor = System.Drawing.SystemColors.Menu;
            this.TextArea.Location = new System.Drawing.Point(42, 3);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(755, 341);
            this.TextArea.TabIndex = 6;
            this.TextArea.Text = "";
            this.TextArea.WordWrap = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_DropDown,
            this.Edit_DropDown,
            this.Format_DropDown,
            this.toolStripDropDownButton1,
            this.TextFormat,
            this.UndoActions,
            this.RedoActions,
            this.HelpButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(39, 347);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // File_DropDown
            // 
            this.File_DropDown.BackColor = System.Drawing.SystemColors.WindowText;
            this.File_DropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.File_DropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFile,
            this.OpenFile,
            this.SaveCurrent,
            this.SaveAs,
            this.CloseFile,
            this.toolStripMenuItem1,
            this.QuitApp});
            this.File_DropDown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.File_DropDown.Image = ((System.Drawing.Image)(resources.GetObject("File_DropDown.Image")));
            this.File_DropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.File_DropDown.Name = "File_DropDown";
            this.File_DropDown.ShowDropDownArrow = false;
            this.File_DropDown.Size = new System.Drawing.Size(38, 20);
            this.File_DropDown.Text = "File";
            this.File_DropDown.ToolTipText = "File";
            // 
            // NewFile
            // 
            this.NewFile.AutoToolTip = true;
            this.NewFile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NewFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewFile.Image = ((System.Drawing.Image)(resources.GetObject("NewFile.Image")));
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(180, 22);
            this.NewFile.Text = "New...";
            this.NewFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NewFile.ToolTipText = "Creates a new text file";
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.AutoToolTip = true;
            this.OpenFile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OpenFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OpenFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("OpenFile.Image")));
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(180, 22);
            this.OpenFile.Text = "Open...";
            this.OpenFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OpenFile.ToolTipText = "Opens a rich text file";
            // 
            // SaveCurrent
            // 
            this.SaveCurrent.AutoToolTip = true;
            this.SaveCurrent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaveCurrent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveCurrent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveCurrent.Image = ((System.Drawing.Image)(resources.GetObject("SaveCurrent.Image")));
            this.SaveCurrent.Name = "SaveCurrent";
            this.SaveCurrent.Size = new System.Drawing.Size(180, 22);
            this.SaveCurrent.Text = "Save...";
            this.SaveCurrent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SaveCurrent.ToolTipText = "Overwrites the currently openned file";
            // 
            // SaveAs
            // 
            this.SaveAs.AutoToolTip = true;
            this.SaveAs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaveAs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveAs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveAs.Image = ((System.Drawing.Image)(resources.GetObject("SaveAs.Image")));
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(180, 22);
            this.SaveAs.Text = "Save as...";
            this.SaveAs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SaveAs.ToolTipText = "Saves the current file under a new name";
            // 
            // CloseFile
            // 
            this.CloseFile.AutoToolTip = true;
            this.CloseFile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseFile.Image = ((System.Drawing.Image)(resources.GetObject("CloseFile.Image")));
            this.CloseFile.Name = "CloseFile";
            this.CloseFile.Size = new System.Drawing.Size(180, 22);
            this.CloseFile.Text = "Close file";
            this.CloseFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CloseFile.ToolTipText = "Close the opened file";
            this.CloseFile.Click += new System.EventHandler(this.CloseFile_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoToolTip = true;
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Delete file";
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripMenuItem1.ToolTipText = "Delete the currently opened file (PROGRESS WILL BE LOST)";
            // 
            // QuitApp
            // 
            this.QuitApp.AutoToolTip = true;
            this.QuitApp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.QuitApp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QuitApp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.QuitApp.Image = ((System.Drawing.Image)(resources.GetObject("QuitApp.Image")));
            this.QuitApp.Name = "QuitApp";
            this.QuitApp.Size = new System.Drawing.Size(180, 22);
            this.QuitApp.Text = "Quit";
            this.QuitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.QuitApp.ToolTipText = "Quit the application";
            // 
            // Edit_DropDown
            // 
            this.Edit_DropDown.BackColor = System.Drawing.SystemColors.WindowText;
            this.Edit_DropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Edit_DropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopySelection,
            this.PasteClipboard,
            this.CutSelection});
            this.Edit_DropDown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Edit_DropDown.Image = ((System.Drawing.Image)(resources.GetObject("Edit_DropDown.Image")));
            this.Edit_DropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_DropDown.Name = "Edit_DropDown";
            this.Edit_DropDown.ShowDropDownArrow = false;
            this.Edit_DropDown.Size = new System.Drawing.Size(38, 20);
            this.Edit_DropDown.Text = "Edit";
            // 
            // CopySelection
            // 
            this.CopySelection.AutoToolTip = true;
            this.CopySelection.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CopySelection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CopySelection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CopySelection.Image = ((System.Drawing.Image)(resources.GetObject("CopySelection.Image")));
            this.CopySelection.Name = "CopySelection";
            this.CopySelection.ShortcutKeyDisplayString = "Ctrl+C";
            this.CopySelection.Size = new System.Drawing.Size(144, 22);
            this.CopySelection.Text = "Copy";
            this.CopySelection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CopySelection.ToolTipText = "Copy the text selection";
            // 
            // PasteClipboard
            // 
            this.PasteClipboard.AutoToolTip = true;
            this.PasteClipboard.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PasteClipboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasteClipboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PasteClipboard.Image = ((System.Drawing.Image)(resources.GetObject("PasteClipboard.Image")));
            this.PasteClipboard.Name = "PasteClipboard";
            this.PasteClipboard.ShortcutKeyDisplayString = "Ctrl+V";
            this.PasteClipboard.Size = new System.Drawing.Size(144, 22);
            this.PasteClipboard.Text = "Paste";
            this.PasteClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.PasteClipboard.ToolTipText = "Paste the clipboard where the cursor is located";
            // 
            // CutSelection
            // 
            this.CutSelection.AutoToolTip = true;
            this.CutSelection.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CutSelection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CutSelection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CutSelection.Image = ((System.Drawing.Image)(resources.GetObject("CutSelection.Image")));
            this.CutSelection.Name = "CutSelection";
            this.CutSelection.ShortcutKeyDisplayString = "Ctrl+X";
            this.CutSelection.Size = new System.Drawing.Size(144, 22);
            this.CutSelection.Text = "Cut";
            this.CutSelection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CutSelection.ToolTipText = "Cut the highlated selection";
            // 
            // Format_DropDown
            // 
            this.Format_DropDown.BackColor = System.Drawing.SystemColors.WindowText;
            this.Format_DropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Format_DropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bold,
            this.Italic,
            this.Underline,
            this.StrikeThrough,
            this.Upper,
            this.Lower});
            this.Format_DropDown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Format_DropDown.Image = ((System.Drawing.Image)(resources.GetObject("Format_DropDown.Image")));
            this.Format_DropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Format_DropDown.Name = "Format_DropDown";
            this.Format_DropDown.ShowDropDownArrow = false;
            this.Format_DropDown.Size = new System.Drawing.Size(38, 20);
            this.Format_DropDown.Text = "Format";
            // 
            // Bold
            // 
            this.Bold.AutoToolTip = true;
            this.Bold.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bold.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Bold.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Bold.Image = ((System.Drawing.Image)(resources.GetObject("Bold.Image")));
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(203, 22);
            this.Bold.Text = "Bold";
            this.Bold.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Bold.ToolTipText = "Bolds the selected text";
            // 
            // Italic
            // 
            this.Italic.AutoToolTip = true;
            this.Italic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Italic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Italic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Italic.Image = ((System.Drawing.Image)(resources.GetObject("Italic.Image")));
            this.Italic.Name = "Italic";
            this.Italic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.Italic.Size = new System.Drawing.Size(203, 22);
            this.Italic.Text = "Italic";
            this.Italic.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Italic.ToolTipText = "Italics the selected text";
            // 
            // Underline
            // 
            this.Underline.AutoToolTip = true;
            this.Underline.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Underline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Underline.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Underline.Image = ((System.Drawing.Image)(resources.GetObject("Underline.Image")));
            this.Underline.Name = "Underline";
            this.Underline.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.Underline.Size = new System.Drawing.Size(203, 22);
            this.Underline.Text = "Underline";
            this.Underline.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Underline.ToolTipText = "Underlines the selection";
            // 
            // StrikeThrough
            // 
            this.StrikeThrough.AutoToolTip = true;
            this.StrikeThrough.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StrikeThrough.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StrikeThrough.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StrikeThrough.Image = ((System.Drawing.Image)(resources.GetObject("StrikeThrough.Image")));
            this.StrikeThrough.Name = "StrikeThrough";
            this.StrikeThrough.Size = new System.Drawing.Size(203, 22);
            this.StrikeThrough.Text = "StrikeThrough";
            this.StrikeThrough.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.StrikeThrough.ToolTipText = "Strikes the text in the middle";
            // 
            // Upper
            // 
            this.Upper.AutoToolTip = true;
            this.Upper.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Upper.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Upper.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Upper.Image = ((System.Drawing.Image)(resources.GetObject("Upper.Image")));
            this.Upper.Name = "Upper";
            this.Upper.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Up)));
            this.Upper.Size = new System.Drawing.Size(203, 22);
            this.Upper.Text = "Upper...";
            this.Upper.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Upper.ToolTipText = "Makes the selection upper case";
            // 
            // Lower
            // 
            this.Lower.AutoToolTip = true;
            this.Lower.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lower.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lower.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lower.Image = ((System.Drawing.Image)(resources.GetObject("Lower.Image")));
            this.Lower.Name = "Lower";
            this.Lower.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Down)));
            this.Lower.Size = new System.Drawing.Size(203, 22);
            this.Lower.Text = "Lower...";
            this.Lower.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Lower.ToolTipText = "Lower cases the selection";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlignLeft,
            this.AlignRight,
            this.AlignCenter,
            this.AlignJustify});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 20);
            this.toolStripDropDownButton1.Text = "Alignement";
            this.toolStripDropDownButton1.ToolTipText = "Text alignements";
            // 
            // AlignLeft
            // 
            this.AlignLeft.AutoToolTip = true;
            this.AlignLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AlignLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AlignLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AlignLeft.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("AlignLeft.Image")));
            this.AlignLeft.Name = "AlignLeft";
            this.AlignLeft.Size = new System.Drawing.Size(109, 22);
            this.AlignLeft.Text = "Left";
            this.AlignLeft.ToolTipText = "Align text on the left";
            // 
            // AlignRight
            // 
            this.AlignRight.AutoToolTip = true;
            this.AlignRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AlignRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AlignRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AlignRight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AlignRight.Image = ((System.Drawing.Image)(resources.GetObject("AlignRight.Image")));
            this.AlignRight.Name = "AlignRight";
            this.AlignRight.Size = new System.Drawing.Size(109, 22);
            this.AlignRight.Text = "Right";
            this.AlignRight.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.AlignRight.ToolTipText = "Align text on the right";
            // 
            // AlignCenter
            // 
            this.AlignCenter.AutoToolTip = true;
            this.AlignCenter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AlignCenter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AlignCenter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("AlignCenter.Image")));
            this.AlignCenter.Name = "AlignCenter";
            this.AlignCenter.Size = new System.Drawing.Size(109, 22);
            this.AlignCenter.Text = "Center";
            this.AlignCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AlignCenter.ToolTipText = "Align the text in center";
            // 
            // AlignJustify
            // 
            this.AlignJustify.AutoSize = false;
            this.AlignJustify.AutoToolTip = true;
            this.AlignJustify.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AlignJustify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AlignJustify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AlignJustify.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AlignJustify.Image = ((System.Drawing.Image)(resources.GetObject("AlignJustify.Image")));
            this.AlignJustify.Name = "AlignJustify";
            this.AlignJustify.Size = new System.Drawing.Size(180, 22);
            this.AlignJustify.Text = "Justify";
            // 
            // TextFormat
            // 
            this.TextFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TextFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectFont,
            this.toolStripSeparator4,
            this.FontSize,
            this.toolStripSeparator2,
            this.IncreaseFont,
            this.DecreaseFont});
            this.TextFormat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TextFormat.Image = ((System.Drawing.Image)(resources.GetObject("TextFormat.Image")));
            this.TextFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TextFormat.Name = "TextFormat";
            this.TextFormat.ShowDropDownArrow = false;
            this.TextFormat.Size = new System.Drawing.Size(38, 20);
            this.TextFormat.Text = "Alignement";
            this.TextFormat.ToolTipText = "Text alignements";
            // 
            // SelectFont
            // 
            this.SelectFont.AutoToolTip = true;
            this.SelectFont.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectFont.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectFont.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SelectFont.Image = ((System.Drawing.Image)(resources.GetObject("SelectFont.Image")));
            this.SelectFont.Name = "SelectFont";
            this.SelectFont.Size = new System.Drawing.Size(130, 22);
            this.SelectFont.Text = "Fonts";
            this.SelectFont.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SelectFont.ToolTipText = "Pops up font selection window";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.toolStripSeparator4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(127, 6);
            // 
            // FontSize
            // 
            this.FontSize.AutoToolTip = true;
            this.FontSize.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FontSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FontSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FontSize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FontSize.Image = ((System.Drawing.Image)(resources.GetObject("FontSize.Image")));
            this.FontSize.Name = "FontSize";
            this.FontSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FontSize.Size = new System.Drawing.Size(130, 22);
            this.FontSize.Text = "0";
            this.FontSize.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.FontSize.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.FontSize.ToolTipText = "The selection\'s font size.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(127, 6);
            // 
            // IncreaseFont
            // 
            this.IncreaseFont.AutoToolTip = true;
            this.IncreaseFont.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IncreaseFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IncreaseFont.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IncreaseFont.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IncreaseFont.Image = ((System.Drawing.Image)(resources.GetObject("IncreaseFont.Image")));
            this.IncreaseFont.Name = "IncreaseFont";
            this.IncreaseFont.Size = new System.Drawing.Size(130, 22);
            this.IncreaseFont.Text = "Increase...";
            this.IncreaseFont.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.IncreaseFont.ToolTipText = "Increase font size by 1";
            // 
            // DecreaseFont
            // 
            this.DecreaseFont.AutoToolTip = true;
            this.DecreaseFont.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DecreaseFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DecreaseFont.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DecreaseFont.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DecreaseFont.Image = ((System.Drawing.Image)(resources.GetObject("DecreaseFont.Image")));
            this.DecreaseFont.Name = "DecreaseFont";
            this.DecreaseFont.Size = new System.Drawing.Size(130, 22);
            this.DecreaseFont.Text = "Decrease...";
            this.DecreaseFont.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.DecreaseFont.ToolTipText = "Decreases font size by 1";
            // 
            // UndoActions
            // 
            this.UndoActions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoActions.Image = ((System.Drawing.Image)(resources.GetObject("UndoActions.Image")));
            this.UndoActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoActions.Name = "UndoActions";
            this.UndoActions.Size = new System.Drawing.Size(38, 20);
            this.UndoActions.Text = "Undo";
            this.UndoActions.ToolTipText = "Undo your last actions";
            // 
            // RedoActions
            // 
            this.RedoActions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedoActions.Image = ((System.Drawing.Image)(resources.GetObject("RedoActions.Image")));
            this.RedoActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedoActions.Name = "RedoActions";
            this.RedoActions.Size = new System.Drawing.Size(38, 20);
            this.RedoActions.Text = "Redo";
            this.RedoActions.ToolTipText = "Redo your last changes";
            // 
            // HelpButton
            // 
            this.HelpButton.AccessibleName = "Help";
            this.HelpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpButton.Image")));
            this.HelpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(38, 20);
            this.HelpButton.Text = "Help";
            this.HelpButton.ToolTipText = "Displays informations and help about this application";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(798, 345);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "BRS Text Editor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox TextArea;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton File_DropDown;
        private System.Windows.Forms.ToolStripMenuItem NewFile;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem SaveCurrent;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripMenuItem CloseFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem QuitApp;
        private System.Windows.Forms.ToolStripDropDownButton Edit_DropDown;
        private System.Windows.Forms.ToolStripMenuItem CopySelection;
        private System.Windows.Forms.ToolStripMenuItem PasteClipboard;
        private System.Windows.Forms.ToolStripMenuItem CutSelection;
        private System.Windows.Forms.ToolStripDropDownButton Format_DropDown;
        private System.Windows.Forms.ToolStripMenuItem Bold;
        private System.Windows.Forms.ToolStripMenuItem Italic;
        private System.Windows.Forms.ToolStripMenuItem Underline;
        private System.Windows.Forms.ToolStripMenuItem StrikeThrough;
        private System.Windows.Forms.ToolStripMenuItem Upper;
        private System.Windows.Forms.ToolStripMenuItem Lower;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem AlignLeft;
        private System.Windows.Forms.ToolStripMenuItem AlignRight;
        private System.Windows.Forms.ToolStripMenuItem AlignCenter;
        private System.Windows.Forms.ToolStripMenuItem AlignJustify;
        private System.Windows.Forms.ToolStripDropDownButton TextFormat;
        private System.Windows.Forms.ToolStripMenuItem SelectFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem FontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem IncreaseFont;
        private System.Windows.Forms.ToolStripMenuItem DecreaseFont;
        private System.Windows.Forms.ToolStripButton UndoActions;
        private System.Windows.Forms.ToolStripButton RedoActions;
        private System.Windows.Forms.ToolStripButton HelpButton;
    }
}

