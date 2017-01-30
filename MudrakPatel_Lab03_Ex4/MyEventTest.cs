using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudrakPatel_Lab03_Ex4
{
    class MyEventTest
    {
        static void Main(string[] args)
        {
            MyEventHandler handler1 = new MyEventHandler(MyEvent.showUserName);
            handler1.Invoke();
        }
    }
}
