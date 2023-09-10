using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Assessment2
{
    public partial class TextEditorForm : Form
    {
        public Font sel_text;
        string filename = "";
        public TextEditorForm()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info;
            info = "Secure TextPad\nV1.2\n\nAuthor: Olga Darmoroz - 11579846\n\n\n\n\n" +
                "Icon Theme has been developed by The Oxygen Team.\nAddition info in ico\\authors.txt";
            MessageBox.Show(info, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void OpenFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                filename = openFileDialog1.FileName;
                if (filename.EndsWith(".rtf"))
                {
                    richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.LoadFile(filename, RichTextBoxStreamType.PlainText);
                }       
            }
        }

        void SaveFile()
        {
            
            if (filename == "")
            {
                SaveAsFile();
            }
            else
            {
                if (filename.EndsWith(".rtf"))
                {
                    richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
                }
                MessageBox.Show("File has been saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void SaveAsFile()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                if (filename.EndsWith(".rtf"))
                {
                    richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
                }
                MessageBox.Show("File has been saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            filename = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            filename = "";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            sel_text = richTextBox1.SelectionFont;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Font select_text = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(select_text, select_text.Style ^ FontStyle.Bold);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Font select_text = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(select_text, select_text.Style ^ FontStyle.Italic);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Font select_text = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(select_text, select_text.Style ^ FontStyle.Underline);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(sel_text.FontFamily, float.Parse(toolStripComboBox1.Text));
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            string info;
            info = "If you have only View right you can't edit any documents.\n\n" +
                "For some editing you can use Shortcut Keys";
            MessageBox.Show(info, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
