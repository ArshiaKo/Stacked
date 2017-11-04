using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacked
{
    class Program 
    {/// <summary>
     /// Make These Fuctions 
     /// https://github.com/GreatMindsRobotics/DataStructuresCurriculum/wiki/Stacks#basic-set-of-functions
     /// </summary>
        static void Main(string[] args)
        {
            StackedLinkedList<int> StackedLinkedList = new StackedLinkedList<int>();
            StackedLinkedList.Push(2);
            foreach (StackedNode<int> node in StackedLinkedList.Print())
            {
                Console.WriteLine(node.Data);
            }
            Console.ReadKey();
        }
    }
}
