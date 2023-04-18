using System;
using System.Linq;
using System.Collections.Generic;

namespace Operators_select;


class Employee{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }
}

class Program{
    public static void Main(string[] args){
        var empList = new List<Employee>(){
            new Employee(){Id = 1, Name = "Utkarsh", Email = "email.com"},
            new Employee(){Id = 2, Name = "Raj", Email = "email.com"},
            new Employee(){Id = 3, Name = "Mayank", Email = "email.com"},
            new Employee(){Id = 4, Name = "Sandhya", Email = "email.com"},
            new Employee(){Id = 5, Name = "Sunder", Email = "email.com"}
        };


        // // ===============================================================================

        // var querySyntax = (from emp in empList
        //                  select emp).ToList();

        // foreach(var emp in querySyntax){
        //     Console.WriteLine($"Employee id => {emp.Id} and Employee Name => {emp.Name} and Employee Email => {emp.Email}");
        // } 

        // // ===============================================================================

        // var methodSyntax = empList.Select(emp => emp);

        // foreach(var emp in methodSyntax){
        //     Console.WriteLine($"Employee id => {emp.Id} and Employee Name => {emp.Name} and Employee Email => {emp.Email}");
        // } 

        // // ===============================================================================
        // SELECTING ONLY ONE PROPERTY

        // var methodSyntax1 = empList.Select(emp => emp.Id);          //it will fetch only one property

        // foreach(var emp in methodSyntax1){
        //     Console.WriteLine($"Employee id => {emp}");
        // } 


        // // ===============================================================================
        // SELECTING ONLY TWO PROPERTY

        var twoProperties = empList.Select(emp => (emp.Id, emp.Name));

        foreach(var twoProp in twoProperties){
            Console.WriteLine($"{twoProp.Id} and {twoProp.Name}");
        }

        // Another way of selecting only two property [QUERY SYNTAX]
        var selectQuery = from emp in empList
                          select new Employee(){
                            Id = emp.Id,
                            Email = emp.Email
                          };

        foreach(var twoProp in selectQuery){
            Console.WriteLine($"{twoProp.Id} and {twoProp.Email}");
        }



        // Another way of selecting only two property [QUERY SYNTAX]
        var selectQueryMethodSyantax = empList.Select(emp => new Employee(){
                                            Id = emp.Id,
                                            Email = emp.Email
                                        });

        foreach(var twoProp in selectQueryMethodSyantax){
            Console.WriteLine($"{twoProp.Id} and {twoProp.Email}");
        }
    }
}