using System;

namespace finally;


// Here we will understand the concept of the finally{} block by using the following example

// step - 01 Open the File
// step - 02 Write into the File
// step - 03 Close the File

// try{
//     -Open the file
// }

// try_catch(exception ex){
    
// }

// finally{
//     -close the file
//     -closing database connection
// }

class Program{
    public static void Main(string[] args){

        try{
            Console.Write("Enter the value of x : ");
            int x = int.Parse(Console.ReadLine());

            if(x == 1){
                // return; statement meaning move outside the
                //  main-method but still due the presence of 
                // the finally-block the statements inside it will get executed.
                return;
            }

            Console.Write("Enter the value of y : ");
            int y = int.Parse(Console.ReadLine());

            int z = x / y;
        }

        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }


        //All the statements whose execution is mandatory even after the abnormal termination of the program are placed inside the finally-block
        finally{
            Console.WriteLine("Finally Block Executed");
        }

        Console.WriteLine("End of the Program");

    }
}