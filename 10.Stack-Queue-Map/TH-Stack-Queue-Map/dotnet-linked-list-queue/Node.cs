using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_linked_list_queue
{
    class Node
    {
        public int key { get; set; }
        public Node next;
        public Node(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
}
