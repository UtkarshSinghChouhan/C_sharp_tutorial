using System;


namespace reading_the_whole_file;

class Program{
    static string path = @"C:\C# Projects\C# File Handling\file.txt";



    public static void write_in_file(){
        // STEP - 02 WRITING INSIDE THE FILE WHICH IS CREATED

        Console.WriteLine("Enter three lines U want to enter in the file : ");
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string input3 = Console.ReadLine();

        try{
            TextWriter writer = new StreamWriter(path);
            writer.WriteLine(input1);
            writer.WriteLine(input2);
            writer.WriteLine(input3);


            Console.WriteLine("Text successfully entered into the file");
            writer.Close();
        }

        catch(IOException ioe){
            Console.WriteLine($"Error occured {ioe.Message}");
        }
    }




    static public void reading_from_the_file(){
        // STEP - 03 READING FROM THE FILE WHICH IS CREATED

        Console.WriteLine("The contents of the file are : ");


        try{
            TextReader reader = new StreamReader(path);



            string text = "";

            while((text = reader.ReadLine()) != null){
                Console.WriteLine(text);
            }


            reader.Close();
        }

        catch(IOException ioe){
            Console.WriteLine(ioe.Message);
        }
    }






    public static void Main(string[] args){

        
        // STEP - 01 CREATING THE FILE

        // checking to see if the file alredy exists or not
        if(!File.Exists(path)){


            File.Create(path);

            Console.WriteLine("File Created Successfully");


        }







        
        write_in_file();


        Console.WriteLine();
        reading_from_the_file();


    }
}