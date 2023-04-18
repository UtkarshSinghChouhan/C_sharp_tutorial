using System;
namespace Var;

class Var{
    public static void Main(string[] args){
        Console.WriteLine("=================== Inside the main method of the Var class ========================");

        // Var keyword is similar to "auto" keyword in C++
        var i = 10;
        var j = "Utkarsh";
        var k = 10.23f;
        var l = 10.2345;
        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.WriteLine(k);
        Console.WriteLine(l);


        // var is early binded(compile time) where as dynamic is late binded(run time)

        dynamic a = 10;
        Console.WriteLine(a);
    }
};