using System;

namespace Feature_02;

// New Features of the C#7
// => Tuples

class Program{

    //we can return multiple values like this as a Tuple.
    public (int, int) Math(int a, int b){
        int c = a + b;
        int d = a * b;
        return(c, d);
    }


    public (int Sum, int Product) Math1(int a, int b){
        int c = a + b;
        int d = a * b;
        return(c, d);
    }

    public static void Main(string[] args){
        Program p = new Program();

        // One method of calling such function
        var obj = p.Math(10, 20);
        Console.WriteLine($"item1 = {obj.Item1} and item2 = {obj.Item2}.");

        // Another method of calling such function
        var (sum, product) = p.Math(10, 20);
        Console.WriteLine($"Sum = {sum} and Product = {product}.");


        // Another method of calling such function
        var obj1 = p.Math1(10, 20);
        Console.WriteLine($"Sum = {obj1.Sum} and Product = {obj1.Product}.");

    }
}