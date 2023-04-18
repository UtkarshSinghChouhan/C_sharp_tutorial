using System;

namespace try_catch;





// THERE ARE TWO TYPES OF EXCEPTIONS
// 1 => SYSTEM EXCEPTIONS
// 2 => APPLICATION EXCEPTIONS


// The following program demonstrate the System exception

class Program{
    public static void Main(string[] args){
        try{
            Console.Write("Enter the value of x : ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("\nEnter the value of y : ");
            int y = int.Parse(Console.ReadLine());

            int z = x / y;

            Console.WriteLine($"\nThe value of z = {z}");
        }
        
        // Handle the Division by zero exception
        catch(DivideByZeroException ex){
            Console.WriteLine(ex.Message);
        }


        // Handle the format exeption
        catch(FormatException ex){
            Console.WriteLine(ex.Message);
        }

        //Whatever exception is not caught by the upper two catch  block will be handled by this catch block
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("End of the Program");
    }
}