using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class StackOfInt
    {
        int[] data= new int[10];
        int index = 0;
        public void push(int v)
        {
            data[index++] = v;
        }
        public int pop()
        {
            return data[--index];
        }
    }
}
