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
                coursesListView.Items.Clear();
                //
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
                coursesListView.Items.Clear();
                //
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
                listViewItem2.SubItems.Add("CNET126");
                listViewItem2.SubItems.Add("CNET331");
                listViewItem2.SubItems.Add("COMP214");
                listViewItem2.SubItems.Add("COMP313");
                listViewItem2.SubItems.Add("TechElec");
                listViewItem2.SubItems.Add("MATH214");
                coursesListView.Items.Add(listViewItem2);
                //
                ListViewItem listViewItem3 = new ListViewItem("SEM3");
                listViewItem3.SubItems.Add("CNET126");
                listViewItem3.SubItems.Add("CNET331");
                listViewItem3.SubItems.Add("COMP214");
                listViewItem3.SubItems.Add("COMP313");
                listViewItem3.SubItems.Add("TechElec");
                listViewItem3.SubItems.Add("MATH214");
                coursesListView.Items.Add(listViewItem3);
                //
                ListViewItem listViewItem4 = new ListViewItem("SEM4");
                listViewItem4.SubItems.Add("CNET126");
                listViewItem4.SubItems.Add("CNET331");
                listViewItem4.SubItems.Add("COMP214");
                listViewItem4.SubItems.Add("COMP313");
                listViewItem4.SubItems.Add("TechElec");
                listViewItem4.SubItems.Add("MATH214");
                coursesListView.Items.Add(listViewItem4);
            } else if (coursesTreeView.SelectedNode.Text == "SET-IG"){

                coursesListView.Items.Clear();
                //
                ListViewItem listViewItem = new ListViewItem("SEM1");
                listViewItem.SubItems.Add("CNET127");
                listViewItem.SubItems.Add("CNET332");
                listViewItem.SubItems.Add("COMP215");
                listViewItem.SubItems.Add("COMP314");
                listViewItem.SubItems.Add("TechElec");
                listViewItem.SubItems.Add("MATH215");
                coursesListView.Items.Add(listViewItem);
                //
                ListViewItem listViewItem2 = new ListViewItem("SEM2");
                listViewItem2.SubItems.Add("CNET127");
                listViewItem2.SubItems.Add("CNET332");
                listViewItem2.SubItems.Add("COMP215");
                listViewItem2.SubItems.Add("COMP314");
                listViewItem2.SubItems.Add("TechElec");
                listViewItem2.SubItems.Add("MATH215");
                coursesListView.Items.Add(listViewItem2);
                //
                ListViewItem listViewItem3 = new ListViewItem("SEM3");
                listViewItem3.SubItems.Add("CNET127");
                listViewItem3.SubItems.Add("CNET332");
                listViewItem3.SubItems.Add("COMP215");
                listViewItem3.SubItems.Add("COMP314");
                listViewItem3.SubItems.Add("TechElec");
                listViewItem3.SubItems.Add("MATH215");
                coursesListView.Items.Add(listViewItem3);
                //
                ListViewItem listViewItem4 = new ListViewItem("SEM4");
                listViewItem4.SubItems.Add("CNET129");
                listViewItem4.SubItems.Add("CNET334");
                listViewItem4.SubItems.Add("COMP217");
                listViewItem4.SubItems.Add("COMP316");
                listViewItem4.SubItems.Add("TechElec");
                listViewItem4.SubItems.Add("MATH216");
                coursesListView.Items.Add(listViewItem4);
            } else if (coursesTreeView.SelectedNode.Text == "HIT"){

                coursesListView.Items.Clear();
                //
                ListViewItem listViewItem = new ListViewItem("SEM1");
                listViewItem.SubItems.Add("HIT129");
                listViewItem.SubItems.Add("HIT334");
                listViewItem.SubItems.Add("HIT217");
                listViewItem.SubItems.Add("HIT316");
                listViewItem.SubItems.Add("TechElec");
                listViewItem.SubItems.Add("HIT216");
                coursesListView.Items.Add(listViewItem);
                //
                ListViewItem listViewItem2 = new ListViewItem("SEM2");
                listViewItem2.SubItems.Add("HIT130");
                listViewItem2.SubItems.Add("HIT335");
                listViewItem2.SubItems.Add("HIT218");
                listViewItem2.SubItems.Add("HIT317");
                listViewItem2.SubItems.Add("TechElec");
                listViewItem2.SubItems.Add("HIT217");
                coursesListView.Items.Add(listViewItem2);
                //
                ListViewItem listViewItem3 = new ListViewItem("SEM3");
                listViewItem3.SubItems.Add("HIT131");
                listViewItem3.SubItems.Add("HIT336");
                listViewItem3.SubItems.Add("HIT219");
                listViewItem3.SubItems.Add("HIT318");
                listViewItem3.SubItems.Add("TechElec");
                listViewItem3.SubItems.Add("HIT218");
                coursesListView.Items.Add(listViewItem3);
                //
                ListViewItem listViewItem4 = new ListViewItem("SEM4");
                listViewItem4.SubItems.Add("HIT132");
                listViewItem4.SubItems.Add("HIT337");
                listViewItem4.SubItems.Add("HIT220");
                listViewItem4.SubItems.Add("HIT319");
                listViewItem4.SubItems.Add("TechElec");
                listViewItem4.SubItems.Add("HIT219");
                coursesListView.Items.Add(listViewItem4);
            }
        }
    }
}
