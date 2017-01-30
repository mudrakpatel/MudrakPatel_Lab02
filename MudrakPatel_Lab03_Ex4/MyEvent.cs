using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MudrakPatel_Lab03_Ex4
{
    public delegate void MyEventHandler();
    class MyEvent
    {
        public static void OnMyClick()
        {
            Console.WriteLine("\n\n\n\t\tEvent handeled successfully!\n\n\n");
        }
    }
}
