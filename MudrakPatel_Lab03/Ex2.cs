using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MudrakPatel_Lab03
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(userControl1.userNameTextBox.Text) ||
                    String.IsNullOrWhiteSpace(userControl1.passwordTextBox.Text))
                {
                    MessageBox.Show("All textboxes are mandatory to fill.","Validation error!");
                }else
                {
                    userNameDisplayLabel.Text = userControl1.userNameTextBox.Text;
                    passwordDisplayLabel.Text = userControl1.passwordTextBox.Text;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"Exception encountered!");
            }
        }
    }
}
