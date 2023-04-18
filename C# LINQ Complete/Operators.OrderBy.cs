using System;
using System.Linq;

namespace Operators_OrderBy;


class Employee{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

class Program{
    public static void Main(string[] args){
        var dataSource = new List<int>(){10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

        // ======================= QUERY SYNTAX ======================
        var querySyntax = from num in dataSource
                          orderby num
                          select num;
        
        foreach(var num in querySyntax){
            Console.Write($"{num} ");
        }

        Console.WriteLine();


        // ======================= METHOD SYNTAX ======================
        var methodSyntax = dataSource.OrderBy(num => num);
        
        foreach(var num in methodSyntax){
            Console.Write($"{num} ");
        }

        Console.WriteLine();

        // ======================= OrderBY with where ======================

        var querySyntax1 = from num in dataSource
                           where num % 2 == 0
                           orderby num
                           select num;
        
        foreach(var num in querySyntax1){
            Console.Write($"{num} ");
        }

        Console.WriteLine();


        // ============================================

        var methodSyntax1 = dataSource.Where(num => num % 2 == 0).OrderBy(num => num);
        
        foreach(var num in methodSyntax1){
            Console.Write($"{num} ");
        }

        Console.WriteLine();












        //======================================= EXAMPLE WITH DIFFERENT DATASOURCE of strings =========================================
        
        var dataSource1 = new List<string>(){
            "Monica",
            "Chandler",
            "Pheobe",
            "Rachel",
            "Ross",
            "Joey",
            "Mona",
            "Janice",
            "Gunther"
        };

        var querySyntax2 = from name in dataSource1
                           orderby name
                           select name;
        
        foreach(var name in querySyntax2){
            Console.Write($"{name} ");
        }

        Console.WriteLine();

        // ===============================================================

        var methodSyntax2 = dataSource1.OrderBy(name => name);

        
        foreach(var name in methodSyntax2){
            Console.Write($"{name} ");
        }

        Console.WriteLine();


        // ===============================================================

        var methodSyntax3 = dataSource1.Where(name => name.Length > 6).OrderBy(name => name);

        
        foreach(var name in methodSyntax3){
            Console.Write($"{name} ");
        }

        Console.WriteLine();











        //======================================= EXAMPLE WITH DIFFERENT DATASOURCE of objects =========================================
        var dataSource2 = new List<Employee>(){

            new Employee(){
                Id = 2,
                Name = "Utkarsh",
                Email = "abc@email.com"
            },

            
            new Employee(){
                Id = 1,
                Name = "Mayank",
                Email = "abc@email.com"
            },

            new Employee(){
                Id = 5,
                Name = "Sunder",
                Email = "abc@email.com"
            },

            new Employee(){
                Id = 4,
                Name = "Sandhya",
                Email = "abc@email.com"
            },

            new Employee(){
                Id = 3,
                Name = "Preeti",
                Email = "abc@email.com"
            }

        };


        var querySyntax3 = from emp in dataSource2
                           orderby emp.Id
                           select emp;
        
        foreach(var emp in querySyntax3){
            Console.Write($"{emp.Id} ");
        }

        Console.WriteLine();

        // ===============================================

        var methodSyntax4 = dataSource2.OrderBy(emp => emp.Id);
        
        foreach(var emp in methodSyntax4){
            Console.Write($"{emp.Id} ");
        }

        Console.WriteLine();


        // ================== orderBy with the Where() ============

        var querySyntax4 = from emp in dataSource2
                           where emp.Name.Length > 6
                           orderby emp.Id
                           select emp;
        
        foreach(var emp in querySyntax4){
            Console.Write($"{emp.Name} ");
        }

        Console.WriteLine();

        // ===============================================

        var methodSyntax5 = dataSource2.Where(emp => emp.Name.Length > 6).OrderBy(emp => emp.Id);
        
        foreach(var emp in methodSyntax5){
            Console.Write($"{emp.Name} ");
        }

        Console.WriteLine();
    }

}
