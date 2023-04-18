using System;
using System.Linq;
using System.Collections.Generic;

namespace Operators_select_02;


class Employee{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }
}

class Student{
    public int sId { get; set; }

    public string sName { get; set; }

    public string sEmail { get; set; }
}

class Program{
    public static void Main(string[] args){

        // This is our Data Source
        var empList = new List<Employee>(){
            new Employee(){Id = 1, Name = "Utkarsh", Email = "email.com"},
            new Employee(){Id = 2, Name = "Raj", Email = "email.com"},
            new Employee(){Id = 3, Name = "Mayank", Email = "email.com"},
            new Employee(){Id = 4, Name = "Sandhya", Email = "email.com"},
            new Employee(){Id = 5, Name = "Sunder", Email = "email.com"}
        };



        //========================== SELECTING DATA TO SOME ANOTHER CLASS ==========================
        var methodSyntax = empList.Select(emp => new Student(){
                                sId = emp.Id,
                                sName = emp.Name,
                                sEmail = emp.Email
                            });
                            
        foreach(var stu in methodSyntax){
            Console.WriteLine($"{stu.sId} and {stu.sName} and {stu.sEmail}");
        }



        //========================== SELECTING DATA TO ANONYMOUS CLASS ==========================
        var methodSyntax1 = empList.Select(emp => new{
                                customId = emp.Id,
                                customName = emp.Name,
                                customEmail = emp.Email
                            });

        foreach(var anonymous in methodSyntax1){
            Console.WriteLine($"{anonymous.customId} and {anonymous.customName} and {anonymous.customEmail}");
        }


        //========================== SELECTING DATA BY USING INDEX ==========================
        var methodSyntax2 = empList.Select((emp, index) => new {Index = index, Name = emp.Name});

        foreach(var anonymous in methodSyntax2){
            Console.WriteLine($"{anonymous.Index} and {anonymous.Name}.");
        }
    }
}