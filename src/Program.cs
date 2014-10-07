using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            String number1 = Console.ReadLine();
            int numberone =Convert.ToInt32(number1);

            if (numberone == 0)
            {
                Environment.Exit(0);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Enter the second number");
                String number2 = Console.ReadLine();
                int numbertwo = Convert.ToInt32(number2);

                Console.WriteLine("Enter Operator");
                Console.WriteLine("+ - * / % > < ==");
                String Operator = Console.ReadLine();

                if (Operator == "+")
                {
                    int result = numberone + numbertwo;
                    Console.WriteLine("Result = {0}", result);
                }

                if (Operator == "-")
                {
                    int result = numberone - numbertwo;
                    Console.WriteLine("Result = {0}", result);
                }

                if (Operator == "*")
                {
                    int result = numberone * numbertwo;
                    Console.WriteLine("Result ={0}", result);
                }

                if (Operator == "/") 
                {
                    int result = numberone / numbertwo;
                    Console.WriteLine("Result ={0}", result);
                }

                if (Operator == "%")
                {
                    int result = numberone % numbertwo;
                    Console.WriteLine("Result = {0}", result);
                }

                if (Operator == ">" || Operator == "<")

                {
                    if (numberone > numbertwo)
                    {
                        Console.WriteLine("{0} > {1}", numberone, numbertwo);
                    }
                    else
                    {
                        Console.WriteLine("{0} < {1}", numberone, numbertwo);
                    }
                }

                    if (Operator == "==")
                    {
                        if (numberone == numbertwo)
                        {
                            Console.WriteLine("{0} = {1}", numberone, numbertwo);
                        }
                        else
                        {
                            Console.WriteLine("{0} is not equal to {1}", numberone, numbertwo);
                        }
                        
                    }   
            }
            Console.Read();
        }
        
    } 
    
}
