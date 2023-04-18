using System;
using System.Linq;

namespace Operators_Any;

class Student{
    public string Name { get; set; }
    public int Marks { get; set; }
};

class Program{
    public static void Main(string[] args){


        // Similar to All() operator Any() operator does not exists in the Query Syntax we can use either method-syntax or mixed-syntax

        var nums = new List<int>() {};      //datasource

        var isAvailable = nums.Any();
        Console.WriteLine(isAvailable);


        // ==========================================================================================================================================
        
        var nums1 = new List<int>() {11, 22, 33, 44, 55, 66};      //datasource
        var res = nums1.Any(num => (num % 11 == 0) && (num > 30));      //weather it contains the data which satisfies the condition.
        Console.WriteLine(res);

        // ==========================================================================================================================================


        //DATASOURCE
        var students = new List<Student>(){
            new Student(){Name = "Monica", Marks = 99},
            new Student(){Name = "Chandler", Marks = 89},
            new Student(){Name = "Rachel", Marks = 91},
            new Student(){Name = "Ross", Marks = 80}
        };


        var boolValue = students.Any(student => student.Marks > 95);
        Console.WriteLine(boolValue);


    }
}