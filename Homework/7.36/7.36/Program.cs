using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._36
{
    class Program
    {
        static void Main(string[] args)
        {
            hanoi(4);
        }
        static void hanoi(int disks)
        {
            //Initialize our stacks and pass it on to our main function.

            //And yes, I'm using stacks, they are the datatype that makes sense for this application.
            Stack<int> p1 = new Stack<int>();
            Stack<int> p2 = new Stack<int>();
            Stack<int> p3 = new Stack<int>();
            for(int i=disks; i>0; i--)
            {
                p1.Push(i);
            }
            hanoi(disks, p1, p2, p3);
        }
        static void hanoi(int disks, Stack<int>p1, Stack<int>p2, Stack<int> p3)
        {
            if (p1.Count == 0 && p3.Count == 0)//Check if we are done
            {
                return;
            }
            if (p2.Count > 0)
            {
                if (p3.Count == 0 || p2.Peek() < p3.Peek())
                {
                    p3.Push(p2.Pop());
                    Console.WriteLine("p2->p3");
                }
                else if (p1.Count == 0 || p2.Peek() < p1.Peek())
                {
                    p1.Push(p2.Pop());
                    Console.WriteLine("p2->p1");
                }
            }
            if (p1.Count > 0)//Unfortunatly this will only work if p1's count is bigger than zero ..
            {
                if (p3.Count == 0 || p1.Peek() < p3.Peek())
                {
                    //Move top elemenet of p1 to p3
                    p3.Push(p1.Pop());
                    Console.WriteLine("p1->p3");
                }
                else if (p2.Count == 0 || p1.Peek() < p2.Peek())//If p2 is empty or has a smaller disk
                {
                    //Move top element of p1 to p2
                    p2.Push(p1.Pop());
                    Console.WriteLine("p1->p2");
                }
            }
            if (p3.Count > 0)//Things that will only work if p3 still has pegs
            {

                
                if (p1.Count == 0 || p3.Peek() < p1.Peek())//if p1 is empty or if p3 contains a smaller element than p1
                {
                    p1.Push(p3.Pop());
                    Console.WriteLine("p3->p1");
                }
                else if (p2.Count == 0 || p3.Peek() < p2.Peek())//If p2 is empty, or if p3 contains a smaller element than p2
                {
                    p2.Push(p3.Pop());
                    Console.WriteLine("p3->p2");
                }
            }
            hanoi(disks, p1, p2, p3);
        }
    }
}
