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

            for (int i = 1; i <= 5; i++)
            {
                StackedLinkedList.Push(i);
                Console.WriteLine(i);
            }
            Console.WriteLine();
            
            
            for (int i = 0; i < 5; i++)
            {
                var POP = StackedLinkedList.Pop();
                Console.WriteLine(POP);                
            }
                
                   
            
            Console.ReadKey();
        }
    }
}
