using System;

namespace Generics_03;




// Instead of using the <T> typesafe in each method of the class as in th eprevious example
//  we can also use it in the class as well.
// WE CAN MADE GENERICS METHODS, CLASSES, INTEFACES, DELEGATES.

class Generics<T>{
    public void Add(T a, T b){

        // Dynamic keyword identifies the type at run time
        dynamic d1 = a;
        dynamic d2 = b;
        Console.WriteLine(d1 + d1);
    }

    
    public void Sub(T a, T b){
        dynamic d1 = a;
        dynamic d2 = b;
        Console.WriteLine(d1 - d2);
    }

    public void Mul(T a, T b){
        dynamic d1 = a;
        dynamic d2 = b;
        Console.WriteLine(d1 * d2);
    }

    public void Div(T a, T b){
        dynamic d1 = a;
        dynamic d2 = b;
        Console.WriteLine(d1 / d2);
    }

}

class Program{


    public static void Main(string[] args){
        Generics<int> g = new Generics<int>();

        g.Add(10, 20);
        g.Sub(10, 20);
        g.Mul(10, 20);
        g.Div(10, 20);
        
        

    }
}