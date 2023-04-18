using System;
using System.Linq;

namespace Operators_All_02;

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


        // ============== Find the Students who have more than 70% marks in all the subjects =============================

        var students = dataSource.Where(student => student.Subjects.All(subject => subject.SubjectMarks > 70));

        foreach(var student in students){
            Console.Write($"{student.Name} ");
        }

        Console.WriteLine();
    }
}