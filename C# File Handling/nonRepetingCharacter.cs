using System;

namespace nonRepetingCharacter;

class Program{
    static string path = @"C:\C# Projects\C# File Handling\file.txt";


    public static void write_in_file(){
        try{
            Console.WriteLine("Enter a line U want ot enter in the file : ");
            string inp1 = Console.ReadLine();


            StreamWriter st= new StreamWriter(path);

            st.WriteLine(inp1);

            Console.WriteLine("Contents Successfully added to the file");

            st.Close();
        }

        catch(IOException ioe){
           Console.WriteLine($"{ioe.Message}"); 
        }
    }




    public static void reading_from_file(){
        try{
            Console.WriteLine("The contents of the file are : ");

            StreamReader sr = new StreamReader(path);

            string text = "";

            while((text = sr.ReadLine()) != null){
                Console.WriteLine(text);

                //FINDING THE FIRST NON-REPEATING CHARACTER
                for(int i = 0; i < text.Length; i++){
                    bool unique = true;

                    for(int j = 0; j < text.Length; j++){

                        if(i != j && text[i] == text[j]){
                            unique = false;
                            break;
                        }
                    }

                    if(unique){
                        Console.WriteLine($"The first non-repeating character is : {text[i]}");
                        break;
                    }
                }

            }


        }

        catch(IOException ioe){
            Console.WriteLine($"{ioe.Message}");
        }
        
    }


    public static void Main(string[] args){
        //STEP - 01 CREATING THE FILE
        if(!File.Exists(path)){
            File.Create(path);

            Console.WriteLine($"File created successfully");
        }

        write_in_file();

        Console.WriteLine();

        reading_from_file();

    }
}