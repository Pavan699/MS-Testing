using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    public class Operations
    {
        public int Add(int a, int b)
        {
            int res = a + b;
            Console.WriteLine("Addition is : " + res);
            return res;
        }
        public int Sub(int a, int b)
        {
            int res ;
            if(a > b)
            {
                res = a - b;
            }
            else
            {
                res = b - a;
            }           
            Console.WriteLine("Subtraction is : " + res);
            return res;
        }
        public int Mult(int a, int b)
        {
            int res = a * b;
            Console.WriteLine("Multiplication is : " + res);
            return res;
        }
        public int Div(int a, int b)
        {
            int res;            
            if (a < b)
            {
                res = b / a;
            }
            else
            {
                res = a / b;
            }
            Console.WriteLine("Division is : " + res);
            return res;
        }
    }
}
