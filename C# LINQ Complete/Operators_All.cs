using System;
using System.Linq;

namespace Operators_All;

class Student{
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program{
    public static void Main(string[] args){

        var dataSource = new List<Student>(){
            new Student(){Name = "Utkarsh", Marks = 89},
            new Student(){Name = "Mayank", Marks = 90},
            new Student(){Name = "Sandhya", Marks = 100}
        };


        // ========================== Check Weather all student have more than 70% marks or not ================


        var methodSyntax = dataSource.All(student => student.Marks > 70);     //this will return "true"
        Console.WriteLine(methodSyntax);  
                         
        // We donot have All() emthod operator in Query Syntax we can we it in Method-syntax or mixed-syntax as follow
        var mixedSyntax = (from student in dataSource
                          select student).All(student => student.Marks > 70);
                
        Console.WriteLine(mixedSyntax);  

    }
}