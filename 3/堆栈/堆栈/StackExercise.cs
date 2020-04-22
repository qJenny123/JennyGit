using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 堆栈
{
    using System;
    public interface StackExercise
    {
        String Pop();
        //出栈
        void Push(String item);
        //进栈
        String Top();
        //返回栈顶元素
        bool IsEmpty();
        //是否为空
    }
}
