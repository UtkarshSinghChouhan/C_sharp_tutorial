using System;
using System.Linq;

namespace Operators_Contains;

class Program{
    public static void Main(string[] args){
        var students = new List<string>(){
            "Monica",
            "Rachel",
            "Ross",
            "Kevin",
            "Subhash"            
        };

        var boolVal = students.Contains("Pheobe");
        Console.WriteLine(boolVal);
    }
}
