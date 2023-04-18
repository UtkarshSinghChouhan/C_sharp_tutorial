using System;
using System.Linq;

namespace Operators_Any_02;

class Student{
    public string Name { get; set; }
    public int Marks { get; set; }

    public List<Subject> Subjects { get; set; }
}

class Subject{
    public string SubjectName { get; set; }
    public int SubjectMarks { get; set; }
}

class Program{
    public static void Main(string[] args){


        var dataSource = new List<Student>(){

            new Student(){
                Name = "Utkarsh", Marks = 100, Subjects = new List<Subject>(){
                   new Subject() {SubjectName = "Math", SubjectMarks = 70},
                   new Subject() {SubjectName = "Physics", SubjectMarks = 60},
                   new Subject() {SubjectName = "Chemistry", SubjectMarks = 55},
                   new Subject() {SubjectName = "Emglish", SubjectMarks = 89},
                }
            },

            new Student(){
                Name = "Mayank", Marks = 89, Subjects = new List<Subject>(){
                   new Subject() {SubjectName = "Math", SubjectMarks = 99},
                   new Subject() {SubjectName = "Physics", SubjectMarks = 90},
                   new Subject() {SubjectName = "Chemistry", SubjectMarks = 75},
                   new Subject() {SubjectName = "Emglish", SubjectMarks = 81},
                }
            },

            new Student(){
                Name = "Sandhya", Marks = 79, Subjects = new List<Subject>(){
                   new Subject() {SubjectName = "Math", SubjectMarks = 100},
                   new Subject() {SubjectName = "Physics", SubjectMarks = 66},
                   new Subject() {SubjectName = "Chemistry", SubjectMarks = 89},
                   new Subject() {SubjectName = "Emglish", SubjectMarks = 50},
                }
            },

            new Student(){
                Name = "Sunder", Marks = 90, Subjects = new List<Subject>(){
                   new Subject() {SubjectName = "Math", SubjectMarks = 99},
                   new Subject() {SubjectName = "Physics", SubjectMarks = 99},
                   new Subject() {SubjectName = "Chemistry", SubjectMarks = 99},
                   new Subject() {SubjectName = "Emglish", SubjectMarks = 99},
                }
            } 

        };

        // ======================== FIND STUDENTs HAVING MARKS MORE THAN 90% IN ANY OF THE SUBJECT =======================================


        var methodSyntax = dataSource.Where(student => student.Subjects.Any(subject => subject.SubjectMarks > 90));

        foreach(var student in methodSyntax){
            Console.Write($"{student.Name} ");
        }

        Console.WriteLine();


        // We can write the above query in the query syntax asa follows 
        var querySyntax = from student in dataSource
                          where student.Subjects.Any(subject => subject.SubjectMarks > 90)
                          select student;
    }
}