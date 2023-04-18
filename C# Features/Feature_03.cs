using System;

namespace Feature_03;


// New Features of the C#7
// => Deconstructors are used for accessing the private feilds of the class

class Employee{
    int eNo;
    string eName, job;

    double salary;

    public Employee(int eNo, string eName, string job, double salary){
        this.eNo = eNo;
        this.eName = eName;
        this.job = job;
        this.salary = salary ;
    }


    // Method Deconstruct()
    public void Deconstruct(out int eNo, out string eName, out string job, out double salary){
        // Here the class-feild values which are intilialized by the constructor are assigned to the out-parameters of the function
        eNo = this.eNo;
        eName = this.eName;
        job = this.job;
        salary = this.salary;

    }


    // Further remember that  we can overload the Deconstruct method
    // here we are returning only two values
    public void Deconstruct(out int eNo, out string eName){
        // Here the class-feild values which are intilialized by the constructor are assigned to the out-parameters of the function
        eNo = this.eNo;
        eName = this.eName;

    }

}


class Program{
    public static void Main(string[] args){
        Employee e = new Employee(1001, "Utkarsh", "Developer", 30000);

        var(eNo, eName, job, salary) = e;       //we donot need to explicitly call the Deconstruct method we can assign the multiple values returned by the function just like this

        Console.WriteLine(eNo);
        Console.WriteLine(eName);
        Console.WriteLine(job);
        Console.WriteLine(salary);



        // call to the overloaded Deconstruct() method
        var(newEnumber, newEname) = e;

        // or we donot need to overload the Deconstruct method we use the method like
        var(no, name, _, _) = e;           // the value which we donot want we can simply use the underscore.

        
    } 
}