using System;


namespace ExceptionDemo
{
    class Exception
    {
        public void CalculateSum()
        {
            int i=0;
            int[] num = new int[5] {12,13,14,15,15};
            int sum = 0;
            try
            {
                for (i = 0; i < 5; i++)
                {
                    sum += num[i];
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please check the iteration of the list");
            }
            finally
            {
                Console.WriteLine("Total {0}", sum);
            
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Handling Systems Exception:");
            Exception index = new Exception();
            index.CalculateSum();
        }
    }
}
