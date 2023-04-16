using System;

namespace coding_practice_01;

// Coding_Practicee_01 => the child-class feild should not hide the parent-class feilds


// we can create our own region in vscode as shown below
#region 

// this is inside a region

#endregion

class Person{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName){
        FirstName = firstName;
        LastName = lastName;
    }


    public string GetFullName(){
        return $"{FirstName} {LastName}";
    }
}



class Employee : Person{
    public string  Role { get; set; }

    public Employee(string firstName, string lastName, string role) : base(firstName, lastName){
        Role = Role;
    }


    // This will override the parent class feild and hence it is not recommended to do so.
    // We can declare the base-class method as virtual which will be overridden in the derived class.
    // By doing so we will be able to access both base and derived-class methods.


    public string GetFullName(){
        return $"{Firstname} {LastName}";
    }
}




class Program{
    public static void Main(string[] args){

    }
}