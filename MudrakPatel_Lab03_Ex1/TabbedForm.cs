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
            textBox1.Hide();
            linkLabel1.Hide();
            textBox2.Hide();
            linkLabel2.Hide();
            textBox3.Hide();
            linkLabel3.Hide();
            textBox4.Hide();
            linkLabel4.Hide();
            textBox5.Hide();
            linkLabel5.Hide();
            textBox6.Hide();
            linkLabel6.Hide();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try {
                linkLabel1.Text = textBox1.Text;
                System.Diagnostics.Process.Start(linkLabel1.Text);
            }
            catch (Exception ex) { MessageBox.Show("Please enter a valid link!","Warning!!!"); }
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel2.Text = textBox2.Text;
                System.Diagnostics.Process.Start(linkLabel2.Text);
            }
            catch (Exception ex) { MessageBox.Show("Please enter a valid link!", "Warning!!!"); }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel3.Text = textBox3.Text;
                System.Diagnostics.Process.Start(linkLabel3.Text);
            }
            catch (Exception ex) { MessageBox.Show("Please enter a valid link!", "Warning!!!"); }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel4.Text = textBox4.Text;
                System.Diagnostics.Process.Start(linkLabel4.Text);
            }
            catch (Exception ex) { MessageBox.Show("Please enter a valid link!", "Warning!!!"); }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel5.Text = textBox5.Text;
                System.Diagnostics.Process.Start(linkLabel5.Text);
            }
            catch (Exception ex) { MessageBox.Show("Please enter a valid link!", "Warning!!!"); }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel6.Text = textBox6.Text;
                System.Diagnostics.Process.Start(linkLabel6.Text);
            }
            catch (Exception ex) { MessageBox.Show("Please enter a valid link!", "Warning!!!"); }
        }
    }
}
