using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacked
{
    class StackedLinkedList<T> where T : IComparable<T>
    {
        public StackedNode<T> Head;
        public StackedLinkedList()
        {
            Head = null;
        }
        #region Push
        public void Push(T Value)
        {
            if (Head == null)
            {
                Head = new StackedNode<T>(Value);
            }
            else
            {
                StackedNode<T> traversalNode = Head;
                while (traversalNode.NextNode != null)
                {
                    traversalNode = traversalNode.NextNode;
                }
                if (traversalNode.NextNode == null)
                {
                    traversalNode.NextNode = new StackedNode<T>(Value);
                }
            }
        }
        #endregion
        #region Print
        public IEnumerable<StackedNode<T>> Print()
        {
            StackedNode<T> traversalNode = Head;
            while (traversalNode != null)
            {
                yield return traversalNode;
                traversalNode = traversalNode.NextNode;
            }
        }
        #endregion
        #region Remove
        public StackedNode<T> Pop()
        {
            StackedNode<T> traversalNode = Head;
            while (traversalNode.NextNode.NextNode != null)
            {
                //////////////FIX THIS/////////////
                traversalNode = traversalNode.NextNode;
            }
        }
        #endregion
    }
}

