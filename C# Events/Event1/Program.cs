using System;
namespace Event1;




// Delegates enables a publiser and subscriber pattern where
// delegate-object is the publisher and target methods are subscriber.


// Events Formalize this publisher and subscriber pattern.

// All the classes subscribed to the event are notified at once.











// Declaring the Delegate
public delegate void Transformer(int x);


// ===================== PUBLISHER CLASS(which publishes the event) ===================


class Notify{
    // Declaring an event of Delegate Type
    public event Transformer transformerEvent;

    public void notifyOnCell(int x){
        // if nobody has subscribed to the event it will return null
        if(transformerEvent != null){
           transformerEvent(x);
        }
    }

};


class subscriber1{
    public static void Xhandler(int x){
        Console.WriteLine("Event received by subscriber 1 object");
    }
};
class subscriber2{
    public static void Yhandler(int y){
        Console.WriteLine("Event received by subscriber 2 object");
    }
};







class Program{

    public static void Square(int x){
        Console.WriteLine($"The square is = {x * x}");
    }



    public static void Cuber(int x){
        Console.WriteLine($"The cube is  = {x * x * x}");
    }





    public static void Main(string[] args){
        Console.WriteLine("Enter a number :");
        int inp = int.Parse(Console.ReadLine());



        // Instatiating the Delegate and Binding functions with the Delegate
        Transformer t = new Transformer(Square);
        t += Cuber;
        t(inp);




        Notify n = new Notify();
        // Hooking methods with the event
        n.transformerEvent += subscriber1.Xhandler; //it means subscriber1 is subscribing to the event
        n.transformerEvent += subscriber2.Yhandler; //it means subscriber2 is subscribing to the event

        n.notifyOnCell(inp);
    }
}