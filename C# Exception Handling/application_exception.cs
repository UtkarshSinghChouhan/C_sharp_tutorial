using System;

namespace application_exception;


// The following Program demonstrates the Application-exception

class Program{
    public static void Main(string[] args){
            Console.Write("Enter the value of x : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of y : ");
            int y = int.Parse(Console.ReadLine());

            if(y % 2 != 0){
                throw new ApplicationException("Division by odd number is not allowed in this application");
            }

            int z = x / y;

            Console.WriteLine("End of the Program");
    }
}