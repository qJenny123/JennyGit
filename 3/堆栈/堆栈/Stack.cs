using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 堆栈
{
    public class Stack:StackExercise
    {
        public Stack<string> stack;

        public Stack()
        {
            stack = new Stack<string>();
        }
        //出栈时要看栈是否为空
        //达到栈顶元素要看栈是否为空

        public string Pop()
        {
            return stack.Pop();
        }
        public void Push(string item)
        {
            stack.Push(item);
        }
        public string Top()
        {
            //得到栈顶对象，并且不移除
            return stack.Peek();
        }
        public bool IsEmpty()
        {
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
