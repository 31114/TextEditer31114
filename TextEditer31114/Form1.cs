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

namespace TextEditer31114
{
    public partial class TextEditer : Form
    {
        public TextEditer()
        {
            InitializeComponent();
        }
        private void AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdFileSave.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfdFileSave.FileName, false, Encoding.GetEncoding("utf-8")))
                {
                    sw.WriteLine(rtbTextEditer.Text);
                }
            }
        }

        private void OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdFileOpen.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
