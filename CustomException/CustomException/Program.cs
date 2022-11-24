using System;
namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            //NameExceptio exp  = new NameExceptio();
            string name;
            Console.WriteLine("enter your  name");
            try
            {
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    //throw exp;
                    throw new NameException(" input your Name");
                }
                else
                {
                    Console.WriteLine("Name: " + name);
                }
                
            }
            catch(NameException exp)
            {
                Console.WriteLine($"Message: {exp.Message}");
                Console.WriteLine($"HelpLink: {exp.HelpLink}");
            }

            Console.WriteLine("End of the Program");
            Console.ReadKey();

        }
    }
    
}

