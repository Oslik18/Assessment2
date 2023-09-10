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
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            LoginFile log = new LoginFile();
            DateTime date  = dateBirth.Value;
            string date_birth = date.ToString("dd-MM-yyyy");

            if (textUser.Text == "" || textPass.Text == "" || textType.Text == "" || textFirst.Text == "" || textLast.Text == "")
            {
                MessageBox.Show("Invalid data!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!textPass.Text.Equals(textRePass.Text)) {
                MessageBox.Show("Invalid passwords", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (log.NewLogin(textUser.Text, textPass.Text, textType.Text, textFirst.Text, textLast.Text, date_birth))
                {
                    MessageBox.Show(textUser.Text + " has beed created", "New User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                } else
                {
                    MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
    }
}
