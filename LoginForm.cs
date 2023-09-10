using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment2
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUserForm userForm = new NewUserForm();
            userForm.Show();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            LoginFile log = new LoginFile();
            TextEditorForm editorForm = new TextEditorForm();

            if (log.CheckLogin(textLog.Text, textPas.Text))
            {
                if (log.UserRight(textLog.Text) == "Edit")
                {
                    editorForm.saveToolStripMenuItem.Enabled = true;
                    editorForm.saveAsToolStripMenuItem.Enabled = true;
                    editorForm.newToolStripMenuItem.Enabled = true;
                    editorForm.toolStripButton1.Enabled = true;
                    editorForm.toolStripButton3.Enabled = true;
                    editorForm.toolStripButton4.Enabled = true;
                    editorForm.toolStripButton5.Enabled = true;
                    editorForm.toolStripButton6.Enabled = true;
                    editorForm.toolStripButton7.Enabled = true;
                    editorForm.toolStripComboBox1.Enabled = true;
                    editorForm.toolStrip2.Enabled = true;
                    editorForm.editToolStripMenuItem.Enabled = true;
                    editorForm.richTextBox1.ReadOnly = false;
                }
                else
                {
                    editorForm.saveToolStripMenuItem.Enabled = false;
                    editorForm.saveAsToolStripMenuItem.Enabled = false;
                    editorForm.newToolStripMenuItem.Enabled = false;
                    editorForm.toolStripButton1.Enabled = false;
                    editorForm.toolStripButton3.Enabled = false;
                    editorForm.toolStripButton4.Enabled = false;
                    editorForm.toolStripButton5.Enabled = false;
                    editorForm.toolStripButton6.Enabled = false;
                    editorForm.toolStripButton7.Enabled = false;
                    editorForm.toolStripComboBox1.Enabled = false;
                    editorForm.toolStrip2.Enabled = false;
                    editorForm.editToolStripMenuItem.Enabled = false;
                    editorForm.richTextBox1.ReadOnly = true;
                }

                this.Hide();
                editorForm.Show();
                editorForm.userLabel.Text = textLog.Text;
            }
            else
            {
                MessageBox.Show("Invalid Login/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
