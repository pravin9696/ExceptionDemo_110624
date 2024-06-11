using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo_110624
{
    class myException : Exception
    {
        public myException(string msg) : base(msg) { }
    }
    class student
    {
        public int roll { set; get; }
        public string  name { get; set; }
        public student(int id1,string name1)
        {
            if (id1<100)
            {
                myException obj1 = new myException("roll no less than 100 not allowed!!!!!");
                throw obj1;
                
            }
            roll = id1;
            name = name1;
        }
    }
    internal class Exception123
    {
        public void method(int a,int b)
        {// chance 1
            int ans = a / b;
            Console.WriteLine("ans="+ans);
        }
        public void div(int x,int y)
        {
            //2
           method(x,y);
        }
    }
}
