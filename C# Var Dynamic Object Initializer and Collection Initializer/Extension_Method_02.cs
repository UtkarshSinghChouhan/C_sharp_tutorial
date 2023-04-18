using System;

namespace Extension_Method;

// Inorder to Bind a method(called the extension method to an already existing class we first
// need to make another static class and add extension methods inside this static class and pass the arguments to 
// these functions as shown below to bind then to hte requires class.)


// If we make an extension-method with the same name and same signature of an existing method in the class
// then the extension method will not be called.


static class Extension_Method_02{
    public static void Func3(this Program p){
        Console.WriteLine("This is the Third Function inside the Extension_Method_02 Class which will be binded to the Program class");
    }
    public static void Main(string[] args){
        Console.WriteLine("This is inside the Program 22222");


        // ============= Now we are going to call the Func1(), Func2() and Func3() methods using the instance of the Program class ==============================



        // Even if the Existing class is a sealed class(which cannot have a derived class) we can add extension methods to it
        Program p = new Program();
        p.Func1();
        p.Func2();
        p.Func3();
    }
};