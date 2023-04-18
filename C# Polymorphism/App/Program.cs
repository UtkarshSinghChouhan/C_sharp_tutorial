using System;
using Classes;
namespace App;

class Animal{
    public virtual void animalSound(){
        Console.WriteLine("The animal makes a sound");
    }
};

class Pig : Animal{
    public override void animalSound(){
        Console.WriteLine("The pig says : wee wee");
    }

};

class Cat : Animal{
    public override void animalSound(){
        Console.WriteLine("The cat says : mew mew");
    }

};

public class Program{
    static void Main(string[]args){
        Animal myAnimal = new Animal();
        Animal myPig = new Pig();
        Animal myCat = new Cat();


        myAnimal.animalSound();
        myPig.animalSound();
        myCat.animalSound();


        // Abstract Class Explanation
        Samsung s = new Samsung();
        s.call();
        s.ringTone();


        // Interface Explanation
        Derived d = new Derived();
        d.run();
        d.write();

        // Imlementing teh property from the interface
        d.num = 8;
        Console.WriteLine(d.num);

        // Accessing the static feild using the interface name
        Console.WriteLine(iBase.total);

        // Static feilds can be initialized outside the interface like this
        iBase.total2 = 20;
        Console.WriteLine(iBase.total2);

        // Accessing the static method of the interface.
        Console.WriteLine(iBase.sum(10, 20));


    }
};