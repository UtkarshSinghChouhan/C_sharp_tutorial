using System;
using System.Collections;
namespace Object_Initializers;


class Employee{
    // public Employee(){

    // }

    public int ID { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }



}

class Program{
    public static void Main(string[] args){
        Console.WriteLine("============== INSIDE TEH OBJECT INTIALIZER CLASS MAIN BODY ================");

        //=============== Object Initializers ===========
        Employee e = new Employee(){
            ID = 10,
            Name = "Utkarsh",
            Address = "Bhopal"
        };

        Console.WriteLine($"employee ID : {e.ID}");
        Console.WriteLine($"employee ID : {e.Name}");
        Console.WriteLine($"employee ID : {e.Address}");


        // ================== COLLECTION INTIALIZERS =============
        // Here we have a collection "SortedList" which we have initilized using the Collection initializer syntax
        SortedList l = new SortedList(){
            {"India", 200},
            {"China", 200},
            {"Malaysia", 200},
            {"Singapore", 200}
        };

        foreach(DictionaryEntry pair in l){
            Console.WriteLine($"{pair.Key} => {pair.Value}.");
        }

    }
};