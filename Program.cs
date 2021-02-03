using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WhiteBoard_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -10, -3, 0, 5, 9 };
            ConvertSortedArraytoBST(array);
        }

        private static void ConvertSortedArraytoBST(int[] array)
        {
            int median = 0;
            if (array.Length % 2 != 0)
            {
                median = array[array.Length / 2];
            }
            int[] leftArray = array.Take(array.Length / 2).ToArray();
            int[] rightArray = array.Skip(array.Length / 2 + 1).ToArray();

            Node tree = new Node(median);
            Node current = tree;
            for (int i = leftArray.Length - 1; i >= 0; i--)
            {
                current.Left = new Node(leftArray[i]);
                current = current.Left;
            }
            current = tree;
            foreach (int item in rightArray)
            {
                current.Right = new Node(item);
                current = current.Right;
            }
        }
    }
}
