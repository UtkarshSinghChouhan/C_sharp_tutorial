using System;
using System.Linq;
using System.Collections.Generic;

namespace DifferentWaysToWriteQuery;

public class QuerySyntaxes{
    public static void Main(string[] args){
        List<int> list = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // ========== QUERY SYNTAX (Similar to Sql) ===============
        var querySyntax = from obj in list
                          where obj > 2
                          select obj;
        
        foreach(int val in querySyntax){
            Console.Write($"{val} ");
        }
        Console.WriteLine();

        // ========== METHOD SYNTAX (Most Popularly Used) ===============

        var methodSyntax = list.Where(obj => obj > 2);

        foreach(int val in methodSyntax){
            Console.Write($"{val} ");
        }
        Console.WriteLine();


        var maxValue = list.Max();      //Max() is a LINQ method which returns the maximum item in the list
        Console.WriteLine($"Maxium value in the list = {maxValue}");



        // ========== MIXED SYNTAX ===============
        var mixedSyntax = (from obj in list
                            select obj).Where(obj => obj > 2);

        foreach(int val in mixedSyntax){
            Console.Write($"{val} ");
        }
        Console.WriteLine();


        var maximumValue = (from obj in list
                            select obj).Max();
        Console.WriteLine($"Maxium value in the list = {maximumValue}");

    }
}