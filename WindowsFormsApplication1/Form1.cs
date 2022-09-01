using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        clsResize _form_resize;

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
////////////////////////////////////////////////////////////////////////////////////// FILE
        private void CloseFile_Click(object sender, EventArgs e)
        {
            
        }
        private void NewFile_Click(object sender, EventArgs e)
        {
            BRS_CreateNewRTFfile();
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
        public void BRS_AreYouSureBox(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        public void BRS_CreateNewRTFfile()
        {

            if (MessageBox.Show("Any unsaved progress will be lost","WARNING",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                // Get path and file name
                string result = BRS_HandleSaveFileDialog();

                if (result == "ABORT")
                {
                    return;
                }
                else
                {
                    // Erase the text in the textbox
                    TextArea.Text = "";
                    TextArea.SaveFile(result, RichTextBoxStreamType.RichText);
                }
            }
        }
    }
}
