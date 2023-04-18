using System;
using System.Collections;
namespace Object_Initializer_and_Collection_Initalizer;

public class Student{
    public int sId { get; set; }
    public string sName { get; set; }
};

class Program{
    public static void Main(string[] args){

        //=========== Initializing objects properties using the object-Initialiers Syntax without the use of the constructor
        var s1 = new Student(){sId = 1, sName = "Utkarsh"};
        var s2 = new Student(){sId = 2, sName = "Utkarsh"};
        var s3 = new Student(){sId = 3, sName = "Utkarsh"};
        var s4 = new Student(){sId = 4, sName = "Utkarsh"};

        // Initializing the  "ArrayList" Collection using the Collection-Initializer Syntax
        List<Student> studentList = new List<Student>(){
            s1,
            s2,
            s3,
            s4
        };

        foreach(var sObj in studentList){
            Console.WriteLine($"Student Id => {sObj.sId} and the Student Name => {sObj.sName}.");
        }
    }
};