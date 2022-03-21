using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Interface_2:Interface_1
    {
        string item_name { set; get; }
        int price();
        int inum();
    }
}
