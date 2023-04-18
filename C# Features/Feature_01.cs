using System;

namespace Feature_01;

// New Features of the C#7
// => Improvement in the out parameters


class Program{

    public void Math(int a, int b, ref int c, ref int d){
        c = a+b;
        d = a*b;
    }


    // There is another method
    public  void Math1(int p, int q, out int r, out int s){
        r = p + q;
        s = p * q;
    }


    public static void Main(string[] args){
        Program p = new Program();


        // This is a way of returing multiple values through a function
        int c = 0, d = 1;      // the values we are assigning here will passes on to the function as a reference
        p.Math(10, 20, ref c, ref d);

        Console.WriteLine($"c = {c} and  d = {d}.");



        // Another way of using
        //int r, s;       //no need to initialize the variables in this case( since the value of the variables will never reach the function, since they are not passed as reference.)
        // p.Math1(11, 222, out r, out s);

        p.Math1(11, 22, out int r, out int s); 


        Console.WriteLine($"r = {c} and  s = {d}.");
    }
}