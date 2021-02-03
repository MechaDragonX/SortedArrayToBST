using System;
using System.Collections.Generic;
using System.Text;

namespace WhiteBoard_2._2
{
    class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
