using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MudrakPatel_Lab03_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (checkedListBox1.SelectedItem.ToString())
            {
                case "Link1": textBox1.Show();
                    linkLabel1.Show();
                    break;
                case "Link2": textBox2.Show();
                    linkLabel2.Show();
                    break;
                case "Link3":
                    textBox3.Show();
                    linkLabel3.Show();
                    break;
                case "Link4":
                    textBox4.Show();
                    linkLabel4.Show();
                    break;
                case "Link5":
                    textBox5.Show();
                    linkLabel5.Show();
                    break;
                case "Link6":
                    textBox6.Show();
                    linkLabel6.Show();
                    break;
                default:
                    textBox1.Hide();
                    linkLabel1.Hide();
                    textBox2.Hide();
                    linkLabel2.Hide();
                    textBox3.Hide();
                    linkLabel3.Hide();
                    textBox4.Show();
                    linkLabel4.Hide();
                    textBox5.Hide();
                    linkLabel5.Hide();
                    textBox6.Hide();
                    linkLabel6.Hide();
                    break;
            }
        }
    }
}
