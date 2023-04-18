using System;


namespace reading_from_file;

class Program{
    public static void Main(string[] args){

        
        // STEP - 01 CREATING THE FILE
        string path = @"C:\C# Projects\C# File Handling\file.txt";

        // checking to see if the file alredy exists or not
        if(!File.Exists(path)){


            File.Create(path);

            Console.WriteLine("File Created Successfully");


        }






        // STEP - 02 WRITING INSIDE THE FILE WHICH IS CREATED

        Console.WriteLine("Enter two lines U want ot enter in the file : ");
        string input = Console.ReadLine();

        try{
            TextWriter writer = new StreamWriter(path);
            writer.WriteLine(input);


            Console.WriteLine("Text successfully entered into the file");
            writer.Close();
        }

        catch(IOException ioe){
            Console.WriteLine($"Error occured {ioe.Message}");
        }
        





        // STEP - 03 READING FROM THE FILE WHICH IS CREATED

        Console.WriteLine("The contents of the file are : ");


        try{
            TextReader reader = new StreamReader(path);

            string text = reader.ReadLine();            //the ReadLine function reads only the first line of the file.

            Console.WriteLine(text);

            reader.Close();
        }

        catch(IOException ioe){
            Console.WriteLine(ioe.Message);
        }
    }
}