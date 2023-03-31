using System;


namespace Test
{
    public class Stack_<T>
    {
        private readonly T[] item;

        private int curr_index = -1;
        public Stack_() => item = new T[20];
        public int count => curr_index + 1;
        public void Push(T item1) => item[++curr_index] = item1;
        public T Pop() => item[curr_index--];
        public void KK<T1, T2>(T1 t1, T2 t2)//double generics
        {
        Console.WriteLine(t1.GetType());
            Console.WriteLine(t2.GetType());
        }
            

    }
   
    class test
    {
        public static char ch = 'y';
        public static double val;

        public static void Main(string[] args)
        {
            var stack = new Stack_<double>();
            Console.WriteLine("enter values to add");

            while (ch.Equals('y') || ch.Equals('Y'))
            { 
                val = Convert.ToDouble(Console.ReadLine());
                 stack.Push(val);
                Console.WriteLine("wanna add more? \n enter y or n");
                ch = Convert.ToChar(Console.ReadLine());

            } 
           
            double sum = 0.0;

            while (stack.count > 0)
            {
                double item = (double)stack.Pop();
                Console.WriteLine($"Item:{item}");
                sum += item;

            }
            Console.WriteLine($"sum of all={sum}");
            stack.KK(22, "okay");  //double generic
             
        }

    }

}
