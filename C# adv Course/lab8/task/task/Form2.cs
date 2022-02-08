using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    public partial class Note_editor : Form
    {
        string path;
        public Note_editor()
        {
            InitializeComponent();
            path = null;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileD.ShowDialog() == DialogResult.OK)
            {
                rtb_text.SaveFile(saveFileD.FileName);
                rtb_text.Clear();
            } 
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileD.ShowDialog() == DialogResult.OK)
            {
                rtb_text.LoadFile(openFileD.FileName);
                path = openFileD.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(path == null)
            {
                saveAsToolStripMenuItem_Click(null,null);
            }
            else
            {
                rtb_text.SaveFile(path);
                rtb_text.Clear();
                path = null;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                saveAsToolStripMenuItem_Click(null, null);
            }
            else
            {
                if (rtb_text.Text != "")
                {
                    saveAsToolStripMenuItem_Click(null, null);
                }
            }
            path = null;
            rtb_text.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontD.ShowDialog() == DialogResult.OK)
            {
                if (rtb_text.SelectedText != "")
                    rtb_text.SelectionFont = fontD.Font;
                else
                    rtb_text.Font = fontD.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorD.ShowDialog()== DialogResult.OK)
            {
                if (rtb_text.SelectedText != "")
                    rtb_text.SelectionColor = colorD.Color;
                else
                    rtb_text.ForeColor = colorD.Color;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                if (rtb_text.SelectedText != "")
                    rtb_text.SelectionBackColor = colorD.Color;
                else
                    rtb_text.BackColor = colorD.Color;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
