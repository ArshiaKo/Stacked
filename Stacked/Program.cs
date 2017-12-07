using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacked
{
    class Program 
    {
        static void Main(string[] args)
        {
            #region Creating The Linked List
            StackedLinkedList<int> StackedLinkedList = new StackedLinkedList<int>();
            #endregion
            #region Pushing
            for (int i = 1; i <= 6; i++)
            {
                StackedLinkedList.Push(i);
                Console.WriteLine(i);
            }
            Console.WriteLine();
            #endregion
            #region Printing
            foreach (StackedNode<int> node in StackedLinkedList.Print())
            {
                Console.WriteLine(node.Data);
            }
            Console.WriteLine();
            #endregion
            #region Popping
            for (int i = 0; i < 5; i++)
            {
                var POP = StackedLinkedList.Pop();
                Console.WriteLine(POP);                
            }
            Console.WriteLine();
            #endregion
            #region Printing
            foreach (StackedNode<int> node in StackedLinkedList.Print())
            {
                Console.WriteLine(node.Data);
            }
            Console.WriteLine();
            #endregion
            Console.ReadKey();
        }
    }
}
