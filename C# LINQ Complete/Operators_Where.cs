using System;
using System.Linq;

namespace Operators_Where;

public class Employee{
    public int Id { get; set; }
    public string  Name { get; set; }
    public string Email { get; set; }
    public List<Tech> Programming { get; set; }
}


public class Tech{
    public string Technology { get; set; }
}


class Program{
    public static void Main(string[] args){
        var list = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // ================== QUERY SYNTAX ==================
        var querySyntax = from number in list
                          where (number % 2 == 0)
                          select number;

        foreach(var even in querySyntax){
            Console.Write($"{even} ");
        }

        Console.WriteLine();

        // ================== METHOD SYNTAX ==================
        var methodSyntax = list.Where(ele => (ele % 2 == 0));

        foreach(var even in methodSyntax){
            Console.Write($"{even} ");
        }

        Console.WriteLine();

        // ====================== MULTIPLE CONDITIONS ===================
        var methodSyntax1 = list.Where(ele => (ele%2 == 0) && (ele > 4));

        foreach(var num in methodSyntax1){
            Console.Write($"{num} ");
        }

        Console.WriteLine();


        // =================================================================

        var dataSource = new List<string>(){"Utkarsh", "Harry", "Adam", "Ponting", "Sachin"};

        var methodSyntax2 = dataSource.Where(str => (str.Length > 5));

        foreach(var str in methodSyntax2){
            Console.Write($"{str} ");
        }

        Console.WriteLine();


        // ================================ COMPLEX EXAMPLE ===================================

        var dataSource1 = new List<Employee>(){

            new Employee(){Id = 1, Name = "Tom", Email = "abc@email.com", Programming = new List<Tech>(){
                new Tech (){Technology = "C#"},
                new Tech (){Technology = "C++"},
                new Tech (){Technology = "C"},
                new Tech (){Technology = "Java"},
                new Tech (){Technology = "Python"},
                new Tech (){Technology = "Ruby"}
            }},

            
            new Employee(){Id = 2, Name = "Utkarsh", Email = "abc@email.com", Programming = new List<Tech>(){
                new Tech (){Technology = "C#"},
                new Tech (){Technology = "C++"},
                new Tech (){Technology = "C"},
                new Tech (){Technology = "Python"},
                new Tech (){Technology = "Ruby"}
            }},

            new Employee(){Id = 3, Name = "John", Email = "abc@email.com", Programming = new List<Tech>(){
                new Tech (){Technology = "C#"},
                new Tech (){Technology = "C++"},
                new Tech (){Technology = "C"},
                new Tech (){Technology = "Java"}
            }},

            new Employee(){Id = 4, Name = "Harry", Email = "abc@email.com", Programming = new List<Tech>(){               
                new Tech (){Technology = "C"},
                new Tech (){Technology = "Java"},
                new Tech (){Technology = "Python"},
                new Tech (){Technology = "Ruby"}
            }},

            new Employee(){Id = 5, Name = "Shelly", Email = "abc@email.com", Programming = new List<Tech>(){
                new Tech (){Technology = "C#"},
                new Tech (){Technology = "C++"},
                new Tech (){Technology = "Ruby"}
            }},

            new Employee(){Id = 6, Name = "Matt", Email = "abc@email.com", Programming = new List<Tech>(){}},

            new Employee(){Id = 7, Name = "Chandler", Email = "abc@email.com", Programming = new List<Tech>(){}}

        };


        // FILTER OUT THOSE EMPLOYEES WHO HAS TECHNOLOGY

        var methodSyntax3 = dataSource1.Where(ele => ele.Programming.Count == 0);

        foreach(var emp in methodSyntax3){
            Console.Write($"{emp.Name} ");
        }

        Console.WriteLine();

        // =============================================================================
        var methodSyntax4 = dataSource1.Where(ele => (ele.Programming.Count == 0) && ele.Id < 6);       //There are no such employees

        foreach(var emp in methodSyntax4){
            Console.Write($"{emp.Name} ");
        }

        Console.WriteLine();
    }
}