using System;

namespace Classes;


//Interface is a completely abstract class and can only contain abstract methods and properties

// By default the memebers of the Interface is Abstract and Public.

// Whwn implementing a method of an interface, inside a Derived-class we do not need to use the "override" keyword

// Interfaces cannot contain class-feilds

public interface iBase{
    void run();
    void write();

    // Default implementation of the method, we need not to implement this method inside the derived class.(we can if we want to).

    void reading(){
        Console.WriteLine("Reading ---- defualt implemetation of the method inside the interface IBase");
    }

    // This is just the declaration of property inside the interface and needs to be implemented in the derived-class.
    public int num { get; set; }

    // static class-feild inside the interface
    static int total = 10;
    static int total2;

    // static methods needs to be defined inside the interface
    static int sum (int a, int b){
        return a+b;
    }
};


public class Derived : iBase{
    public void run(){
        Console.WriteLine("Running -- inside the Derived class");
    }

    public void write(){
        Console.WriteLine("Writeing --- inside the Derived class");
    }

    // implementation of the property

    public int n;
    public int num { 
        get{
            return n;
        } 

        set{
            n = value;
        }
    }
};