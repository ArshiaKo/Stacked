using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacked
{
    class StackedNode <T>
    {
        public T Data;
        public StackedNode<T> NextNode;
        public StackedNode(T data)
        {
            Data = data;
            NextNode = null;
        }

     }
}
