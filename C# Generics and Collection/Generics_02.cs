using System;

namespace Generics_02;


class Generics{
    public void Add<T>(T a, T b){

        // Dynamic keyword identifies the type at run time
        dynamic d1 = a;
        dynamic d2 = b;
        Console.WriteLine(d1 + d1);
    }

    
    public void Sub<T>(T a, T b){
        dynamic d1 = a;
        dynamic d2 = b;
        Console.WriteLine(d1 - d2);
    }

    public void Mul<T>(T a, T b){
        dynamic d1 = a;
        dynamic d2 = b;
        Console.WriteLine(d1 * d2);
    }

    public void Div<T>(T a, T b){
        dynamic d1 = a;
        dynamic d2 = b;
        Console.WriteLine(d1 / d2);
    }

}

class Program{


    public static void Main(string[] args){
        Generics g = new Generics();

        g.Add<int>(10, 20);
        g.Sub<float>(10.12f, 20.1131f);
        g.Mul<double>(10.175, 20.125);
        g.Div<int>(10, 20);
        
        

    }
}