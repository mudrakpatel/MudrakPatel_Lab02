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
    public partial class tabbedForm : Form
    {
        public tabbedForm()
        {
            InitializeComponent();
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (checkedListBox.GetItemCheckState(0) == CheckState.Checked){
            //    this.Refresh();
            //    textBox1.Show();
            //    linkLabel1.Show();
            //}
            //else if (checkedListBox.GetItemCheckState(1) == CheckState.Checked){
            //    this.Refresh();
            //    textBox2.Show();
            //    linkLabel2.Show();
            //}
            //else if (checkedListBox.GetItemCheckState(2) == CheckState.Checked){
            //    this.Refresh();
            //    textBox3.Show();
            //    linkLabel3.Show();
            //}
            //else if (checkedListBox.GetItemCheckState(3) == CheckState.Checked){
            //    this.Refresh();
            //    textBox4.Show();
            //    linkLabel4.Show();
            //}
            //else if (checkedListBox.GetItemCheckState(4) == CheckState.Checked){
            //    this.Refresh();
            //    textBox5.Show();
            //    linkLabel5.Show();
            //}
            //else if (checkedListBox.GetItemCheckState(5) == CheckState.Checked){
            //    this.Refresh();
            //    textBox6.Show();
            //    linkLabel6.Show();
            //}
            //else{
            //    textBox1.Hide();
            //    linkLabel1.Hide();
            //    textBox2.Hide();
            //    linkLabel2.Hide();
            //    textBox3.Hide();
            //    linkLabel3.Hide();
            //    textBox4.Hide();
            //    linkLabel4.Hide();
            //    textBox5.Hide();
            //    linkLabel5.Hide();
            //    textBox6.Hide();
            //    linkLabel6.Hide();
            //}

            switch (checkedListBox.SelectedItem.ToString())
            {
                case "Link1": textBox1.Show();
                              linkLabel1.Show();
                    break;
                case "Link2": textBox2.Show();
                              linkLabel2.Show();
                    break;
                case "Link3": textBox3.Show();
                              linkLabel3.Show();
                    break;
                case "Link4": textBox4.Show();
                    linkLabel4.Show();
                    break;
            }
        }
    }
}
