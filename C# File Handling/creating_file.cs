using System;
using System.IO;

namespace creating_file;

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
        string input2 = Console.ReadLine();

        try{
            TextWriter writer = new StreamWriter(path);
            writer.WriteLine(input);
            writer.WriteLine(input2);


            Console.WriteLine("Text successfully entered into the file");
            writer.Close();
        }

        catch(IOException ioe){
            Console.WriteLine($"Error occured {ioe.Message}");
        }
    }
}