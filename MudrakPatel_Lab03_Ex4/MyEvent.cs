using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MudrakPatel_Lab03_Ex4
{
    public delegate void MyEventHandler(string username);
    class MyEvent
    {
        public static void showUserName(string username)
        {
            MessageBox.Show("Welcome "+username,"Greetings :D");
        }
    }
}
