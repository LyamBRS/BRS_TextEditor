using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        clsResize _form_resize;
        /////////////////////////////////////// File saving variables    
        bool unsavedChanges = false;
        bool Timer_FLIP = false;
        int SaveOppacity = 0;
        string OpenedRTFFile = "";
        ///////////////////////////////////////  

        public Form1()
        {
            InitializeComponent();

           _form_resize = new clsResize(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }
        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }
        ////////////////////////////////////////////////////////////////////////////////////// TEXT AREA
        private void TextArea_TextChanged(object sender, EventArgs e)
        {
            unsavedChanges = true;
            // File saved icon
            FileSaved.Enabled = true;
        }
        ////////////////////////////////////////////////////////////////////////////////////// FILE
        private void CloseFile_Click(object sender, EventArgs e)
        {
            // Check if a file is opened
            if(OpenedRTFFile != "")
            {
                if(unsavedChanges)
                {
                    if(!BRS_AreYouSureBox("Unsaved progress will be lost","WARNING"))   {return;}
                }
            }
            // Default back to startup
            OpenedRTFFile = "";
            TextArea.Text = "";
            unsavedChanges = false;
            toolBarState(false);
        }
        private void NewFile_Click(object sender, EventArgs e)
        {
            // File already opened
            if(OpenedRTFFile != "")
            {
                if (!BRS_AreYouSureBox("Unsaved progress will be lost", "WARNING"))
                {
                    return;
                }
            }

            // Create a new file
            BRS_CreateNewRTFfile();
            TextArea.LoadFile(OpenedRTFFile, RichTextBoxStreamType.RichText);

            // Enable the toolbar
            toolBarState(true);

            // Tell no changes were made
            unsavedChanges = false;

            // File saved icon
            FileSaved.Enabled = false;
        }
        private void OpenFile_Click(object sender, EventArgs e)
        {
            // Check if workspace has unsaved opened file
            if (unsavedChanges)
            {
                if (!BRS_AreYouSureBox("Any unsaved progress will be lost.", "Opening existing file"))
                {
                    return;
                }
            }

            BRS_OpenRTFfile();
            unsavedChanges = false;
            //file saved icon
            FileSaved.Enabled = false;
        }
        private void SaveCurrent_Click(object sender, EventArgs e)
        {
            if(OpenedRTFFile != "")
            {
                TextArea.SaveFile(OpenedRTFFile,RichTextBoxStreamType.RichText);
                // Only display this window if the file had changes innit
                if (unsavedChanges)
                {
                    MessageBox.Show("File saved successfully", "Saving...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                unsavedChanges = false;

                //file saved icon
                FileSaved.Enabled = false;
            }
            else
            {
                // Save a new file?
                if(BRS_AreYouSureBox("No files opened, save new file?","Saving file"))
                {
                    BRS_SaveNewRTFfile();
                }
            }
        }
        private void DeleteFile_Click(object sender, EventArgs e)
        {
            if (!BRS_AreYouSureBox("Delete this file ?", "Deleting opened file"))
            {
                return;
            }

            if(OpenedRTFFile != "")
            {
                File.Delete(OpenedRTFFile);
            }
            else
            {
                BRS_ErrorBox("No opened files to delete","Deleting opened file");
                return;
            }

            unsavedChanges = false;
            //toolBarState(false);
            OpenedRTFFile = "";
            TextArea.Text = "";
        }
        //////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////// - FORM QUIT
        //////////////////////////////////////////////////////////////////////////////////////
        private void QuitApp_Click(object sender, EventArgs e)
        {
            // Check for unsaved changes
            if (unsavedChanges)
            {
                if (!BRS_AreYouSureBox("Any unsaved progress will be lost.", "Quitting BRS_Text_Editor"))
                {
                    return;
                }
            }

            this.Close();
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        public void BRS_ErrorBox(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool BRS_AreYouSureBox(string message, string caption)
        {
            return (MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK);
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        public string BRS_HandleSaveFileDialog()
        {
            // Create a new save file dialog
            SaveFileDialog SFD = new SaveFileDialog();

            // Set filter to RTF documents
            SFD.Filter = "Rich Text Files|*.rtf";
            SFD.Title = "Save your new text file";

            //////////////////////////////////////////////////////////////////////////// - [ checks ]
            // Check if we clicked on save
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                // Check if directory path exist
                if (SFD.CheckPathExists)
                {
                    if (!SFD.CheckFileExists)
                    {
                        // If name was empty
                        if (SFD.FileName.Contains("among us"))
                        {
                            BRS_ErrorBox("Your file cannot be an imposter","Saving Error");
                        }
                        else
                        {
                            OpenedRTFFile = SFD.FileName;
                            //////////////////////////////////////////////////////////// - [Create new RTF file]
                            return (SFD.FileName);
                            ////////////////////////////////////////////////////////////
                        }
                    }
                    else
                    {
                        BRS_ErrorBox("This file already exist", "Saving Error");
                    }
                }
                else
                {
                    BRS_ErrorBox("Invalid directory path", "Saving Error");
                }
            }

            return ("ABORT");
        }
        public string BRS_HandleOpenFileDialog()
        {
            string result = "ABORT";

            // Create file opening dialog
            OpenFileDialog OFD = new OpenFileDialog();

            // Set filters for an RTF documents
            OFD.Filter = "Rich Text Files|*.rtf";
            OFD.Title = "Open existing text file";

            //////////////////////////////////////////////////////////////////////////// - [ checks ]
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                // If name was empty
                if (OFD.FileName.Contains("among us"))
                {
                    BRS_ErrorBox("Your file cannot be an imposter", "Opening Error");
                }
                else
                {
                    //Check if file is .rtf
                    if (OFD.FileName.Contains(".rtf"))
                    {
                        OpenedRTFFile = OFD.FileName;
                        //////////////////////////////////////////////////////////// - [Create new RTF file]
                        result = OFD.FileName;
                        ////////////////////////////////////////////////////////////
                    }
                    else
                    {
                        BRS_ErrorBox("File type was not supported", "Opening Error");
                        return ("ABORT");
                    }
                }
            }

            return (result);
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        public void BRS_SaveNewRTFfile()
        {
            if (unsavedChanges)
            {
                if (MessageBox.Show("Any unsaved progress will be lost", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
                {
                    return;
                }
            }

            //Get path and file name
            string result = BRS_HandleSaveFileDialog();

            if (result == "ABORT")
            {
                return;
            }
            else
            {
                OpenedRTFFile = result;
                TextArea.SaveFile(result, RichTextBoxStreamType.RichText);
            }
        }
        public void BRS_CreateNewRTFfile()
        {
            if (unsavedChanges)
            {
                if (MessageBox.Show("Any unsaved progress will be lost", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
                {
                    return;
                }
            }

            //Get path and file name
            string result = BRS_HandleSaveFileDialog();

            if (result == "ABORT")
            {
                return;
            }
            else
            {
                //Erase the text in the textbox
                TextArea.Text = "";

                OpenedRTFFile = result;

                TextArea.SaveFile(result, RichTextBoxStreamType.RichText);
            }
        }

        public void BRS_OpenRTFfile()
        {
            string result = BRS_HandleOpenFileDialog();

            if (result != "ABORT")
            {
                //Store the path of the opened file
                OpenedRTFFile = result;
                unsavedChanges = false;

                //Enable the toolbar
                toolBarState(true);

                //Change text area to the rtf file
                TextArea.LoadFile(OpenedRTFFile, RichTextBoxStreamType.RichText);
            }
        }

        // Toggles to the wanted state certain icons of the toolbar and text area
        public void toolBarState(bool wantedState)
        {
            wantedState = true;

            SaveAs.Enabled          = wantedState;
            SaveCurrent.Enabled     = wantedState;
            CloseFile.Enabled       = wantedState;
            DeleteFile.Enabled      = wantedState;

            Edit_DropDown.Enabled   = wantedState;
            Format_DropDown.Enabled = wantedState;
            Align_DropDown.Enabled  = wantedState;
            TextFormat.Enabled      = wantedState;

            UndoActions.Enabled = wantedState;
            RedoActions.Enabled = wantedState;
            FileSaved.Enabled = wantedState;

            TextArea.Enabled = wantedState;
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////// TIMER
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            //Timer_FLIP = !Timer_FLIP;

            // - Executed each 100ms - //

            // - File Name Update -----//
            // - Empty
            if(OpenedRTFFile == "")
            {
                OpenedDocument.Text = Convert.ToString("Untitled");
            }
            else
            {
                OpenedDocument.Text = Path.GetFileName(OpenedRTFFile);
            }

            // - Icon Animation when unsaved changes -----//
            if(unsavedChanges)
            {
                SaveOppacity = SaveOppacity - 1;
                if(SaveOppacity <= 0)
                {
                    SaveOppacity = 5;
                    FileSaved.Enabled = !FileSaved.Enabled;
                }
                

            }
        }
    }
}
