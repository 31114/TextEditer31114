﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditer31114
{
    public partial class TextEditer : Form
    {
            
        public string fileName = "新規ファイル";
        public TextEditer()
        {
            InitializeComponent();
            tsmiUndo.Enabled = false;
            tsmiRedo.Enabled = false;
            this.Text = fileName;
        }
        private void OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdFileOpen.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofdFileOpen.FileName, Encoding.GetEncoding("UTF-8"), false))
                {
                    rtbTextEditer.Text = sr.ReadToEnd();
                    this.fileName = ofdFileOpen.FileName;
                }
                this.Text = fileName;
            }
        }

        private void AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdFileSave.ShowDialog() == DialogResult.OK)
            {
                FileSave(sfdFileSave.FileName);
            }
        }

        private void smiOverwrite_Click(object sender, EventArgs e)
        {
            if (this.fileName != "新規ファイル" || this.Text != "新規ファイル")
            {
                FileSave(fileName);
            }
            else
            {
                AToolStripMenuItem_Click(sender, e);
            }
        }

        private void FileSave(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding("UTF-8")))
            {
                sw.WriteLine(rtbTextEditer.Text);
            }
        }

        private void tsmiUndo_Click(object sender, EventArgs e)
        {
            if (rtbTextEditer.CanUndo)
            {
                // Undo the last operation.
                rtbTextEditer.Undo();
            }
        }

        private void tsmiRedo_Click(object sender, EventArgs e)
        {
            // Determines if a Redo operation can be performed.
            if (rtbTextEditer.CanRedo == true)
            {
                // Perform the redo.
                rtbTextEditer.Redo();
            }
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            // Ensure that text is selected in the text box.   
            if (rtbTextEditer.SelectionLength > 0)
                // Copy the selected text to the Clipboard.
                rtbTextEditer.Copy();
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            // Determine if there is any text in the Clipboard to paste into the text box.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                rtbTextEditer.Paste();
            }
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            // Ensure that text is currently selected in the text box.   
            if (rtbTextEditer.SelectionLength > 0)
                // Cut the selected text in the control and paste it into the Clipboard.
                rtbTextEditer.Cut();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (rtbTextEditer.SelectionLength > 0)
            {
                rtbTextEditer.SelectedText = "";
            }
        }
        private void TextEditer_FormClosing(object sender, FormClosingEventArgs e)
        {
            PopupMessage(1);
        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PopupMessage(int Num)
        {
            switch (Num)
            {
                case 1:
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        //MessageBox.Show("Can't Touch This", "Error",
                        //    MessageBoxButtons.OK,
                        //    MessageBoxIcon.Error);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("不完全な文字列", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        break;
                    }
            }
        }

        

        private void 編集EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ensure that text is selected in the text box.   
            if (rtbTextEditer.SelectionLength > 0)
            {
                // Copy the selected text to the Clipboard.
                tsmiCopy.Enabled = true;
                tsmiDelete.Enabled = true;
                tsmiCut.Enabled = true;
                tsmiFont.Enabled = true;
                tsmiColor.Enabled = true;
            }
            else
            {
                tsmiCopy.Enabled = false;
                tsmiDelete.Enabled = false;
                tsmiCut.Enabled = false;
                tsmiFont.Enabled = false;
                tsmiColor.Enabled = false;
            }
            if (Clipboard.ContainsText())
            {
                tsmiPaste.Enabled = true;
            }
            else
            {
                tsmiPaste.Enabled = false;
            }
        }

        private void rtbTextEditer_TextChanged(object sender, EventArgs e)
        {
            if (rtbTextEditer.CanUndo)
            {
                tsmiUndo.Enabled = true;
            }
            else
            {
                tsmiUndo.Enabled = false;
            }

            if (rtbTextEditer.CanRedo)
            {
                tsmiRedo.Enabled = true;
            }
            else
            {
                tsmiRedo.Enabled = false;
            }
        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            if(fdFont.ShowDialog() == DialogResult.OK)
            {
                rtbTextEditer.SelectionFont = fdFont.Font;
            }
        }

        private void tsmiColor_Click(object sender, EventArgs e)
        {
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                rtbTextEditer.SelectionColor = cdColor.Color;
            }
        }

        private void tsmiCreateNew_Click(object sender, EventArgs e)
        {
            this.Text = "新規ファイル"; //アプリケーションのタイトルを変更
            this.fileName = "新規ファイル";
            rtbTextEditer.Clear();      //テキストボックスの内容をクリア
        }

        
    }
}