using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    public class Node
    {
        public int val { get; set; }
        public Node next { get; set; }

        public Node(int val)
        {
            this.val = val;
            this.next = null;
        }
    }
}
