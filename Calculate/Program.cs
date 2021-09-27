using System;

namespace Calculate
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate");
            Operations oprs = new Operations();
            oprs.Add(2, 3);
            oprs.Sub(2, 3);
            oprs.Mult(2, 3);
            oprs.Div(2, 3);
        }
    }
}
