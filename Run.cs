using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public  class Run
    {
        public void RunFunc(Func func, string data)
        {
            func.Invoke(data);
        }
    }
}
