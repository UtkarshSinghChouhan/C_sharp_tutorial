using System;

namespace searchWords;

class Program{
    static string path = @"C:\C# Projects\C# File Handling\file.txt";

    public static void write_in_file(){
        try{
            Console.WriteLine("Enter the string : ");

            string inp = Console.ReadLine();

            StreamWriter st = new StreamWriter(path);

            st.WriteLine(inp);
            Console.WriteLine("Successfully added in the file");
            st.Close();
        }

        catch(IOException ioe){
            Console.WriteLine(ioe.Message);
        }
    }

    public static void read_from_file(){
        try{
            StreamReader sr = new StreamReader(path);
            
            string text = "";

            while((text = sr.ReadLine()) != null){

               Console.WriteLine(text);
               
                //finding out which words starts with vowel
                string[] arr = text.Split(" ");

                foreach(string val in arr){
                    if(val[0] == 'a' || val[0] == 'e' || val[0] == 'i' || val[0] == 'o' || val[0] == 'u'){
                        Console.WriteLine(val);
                    }
                }               
            }
            

            sr.Close();
        }

        catch(IOException ioe){
            Console.WriteLine(ioe.Message);
        }

    }
    public static void Main(string[] args){
        // STEP - 01 CREATING THE FILE
        if(!File.Exists(path)){
            File.Create(path);
            Console.WriteLine("File created successfully");
        }

        write_in_file();

        Console.WriteLine();

        read_from_file();
    }
}