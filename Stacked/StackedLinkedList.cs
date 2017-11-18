using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacked
{
    class StackedLinkedList<T> where T : IComparable<T>
    {
        public StackedNode<T> Head = null;
        public StackedLinkedList()
        {
            Head = null;
        }
        #region Peek

        public T Peek()
        {
            StackedNode<T> traversalNode = Head;
            while (traversalNode.NextNode != null)
            {
                traversalNode = traversalNode.NextNode;
            }
            return traversalNode.Data;
        }

        #endregion
        #region Push
        public void Push(T Value)
        {
            StackedNode<T> NewNode = new StackedNode<T>(Value);
            StackedNode<T> traversalNode = Head;
            if (Head == null)
            {
                Head = new StackedNode<T>(Value);
            }
            else
            {
                NewNode.NextNode = Head;
                Head = NewNode;
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
        #region Pop
        public T Pop()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Cannot pop an empty stack");
            }
            StackedNode<T> temp = Head;
            Head = Head.NextNode;
            return temp.Data;
        }
        #endregion
    }
}

