using System;
namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your  name");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                throw new CustomException(" input your Name");
            }
            else
            {
                Console.WriteLine("Name: " + name);
            }
            Console.ReadLine();
             
        }
    }
    
}
