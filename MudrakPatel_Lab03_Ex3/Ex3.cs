using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MudrakPatel_Lab03_Ex3
{
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void coursesTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (coursesTreeView.SelectedNode.Text == "SETechnician")
            {
                ListViewItem listViewItem = new ListViewItem("SEM1");
                listViewItem.SubItems.Add("COMP100");
                listViewItem.SubItems.Add("COMP120");
                listViewItem.SubItems.Add("COMP122");
                listViewItem.SubItems.Add("COMP219");
                listViewItem.SubItems.Add("MATH175");
                listViewItem.SubItems.Add("COMM170");
                coursesListView.Items.Add(listViewItem);
                //
                ListViewItem listViewItem2 = new ListViewItem("SEM2");
                listViewItem2.SubItems.Add("COMP123");
                listViewItem2.SubItems.Add("COMP213");
                listViewItem2.SubItems.Add("COMP301");
                listViewItem2.SubItems.Add("COMP225");
                listViewItem2.SubItems.Add("GNEDDEL");
                listViewItem2.SubItems.Add("MATH175");
                coursesListView.Items.Add(listViewItem2);
                //
                ListViewItem listViewItem3 = new ListViewItem("SEM3");
                listViewItem3.SubItems.Add("COMP214");
                listViewItem3.SubItems.Add("COMP228");
                listViewItem3.SubItems.Add("COMP229");
                listViewItem3.SubItems.Add("COMP246");
                listViewItem3.SubItems.Add("ENGL253");
                listViewItem3.SubItems.Add("GNED500");
                coursesListView.Items.Add(listViewItem3);
                //
                ListViewItem listViewItem4 = new ListViewItem("SEM4");
                listViewItem4.SubItems.Add("CNET124");
                listViewItem4.SubItems.Add("CNET329");
                listViewItem4.SubItems.Add("COMP212");
                listViewItem4.SubItems.Add("COMP311");
                listViewItem4.SubItems.Add("TechElec");
                listViewItem4.SubItems.Add("MATH210");
                coursesListView.Items.Add(listViewItem4);
            } else if (coursesTreeView.SelectedNode.Text == "SET")
            {
                ListViewItem listViewItem = new ListViewItem("SEM1");
                listViewItem.SubItems.Add("CNET125");
                listViewItem.SubItems.Add("CNET330");
                listViewItem.SubItems.Add("COMP213");
                listViewItem.SubItems.Add("COMP312");
                listViewItem.SubItems.Add("TechElec");
                listViewItem.SubItems.Add("MATH213");
                coursesListView.Items.Add(listViewItem);
                //
                ListViewItem listViewItem2 = new ListViewItem("SEM2");
                listViewItem2.SubItems.Add("CNET125");
                listViewItem2.SubItems.Add("CNET330");
                listViewItem2.SubItems.Add("COMP213");
                listViewItem2.SubItems.Add("COMP312");
                listViewItem2.SubItems.Add("TechElec");
                listViewItem2.SubItems.Add("MATH213");
                coursesListView.Items.Add(listViewItem2);
            }
        }
    }
}
