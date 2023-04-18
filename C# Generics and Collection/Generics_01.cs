using System;
using System.Linq;

namespace Generics_01;

// We have two types of Collections -> Generic(Collection that is capablke of storing specified type of values like int, string) and Non-Generic Collection(ArrayList which can store any type of value in it)

class Program{

    // public bool Compare(int a, int b){
    //     if(a == b){
    //         return true;
    //     }

    //     return false;
    // }






    // int is a value-type meaning a struct
    // object is a reference-type meaning class

    // Boxing is the internal process of converting int to object.
    // Un-Boxing is the internal process of converting object to int.
    // Due To boxing and Unboxing there is performance degradation.
        
    // BY writing object-keyword as parameter we can compare value of any type instead of defining the whole entire function each time of different types of values.

    // public bool Compare(object a, object b){
    //     if(a.Equals(b)){
    //         return true;
    //     }

    //     return false;
    // }





    // Genrics helps us to gain performace by elimination unnecesary boxing and unboxing.

    public bool Compare<T>(T a, T b){
        if(a.Equals(b)){
            return true;
        }

        return false;
    }




    public static void Main(string[] args){
        Program p = new Program();

        // The method changes itself according to the type we specified during the method call
        // this will reduce the internal boxing and unboxing from type->object->type for comparison.
        // Also helps to reduce the internal machine load.

        bool res1 = p.Compare<int>(10, 20);                  //int values
        bool res2 = p.Compare<double>(10.212, 20.2424);      //double and int values
        bool res3 = p.Compare<float>(10.212f, 20.13234f);     //float and int values
        bool res4 = p.Compare<bool>(true, true);            //bool values

        Console.WriteLine(res1);

    }
};


