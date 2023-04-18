using System;
namespace Delegate;

public delegate void RectDelegate(double width, double height);

class Reactangle{

    public void getArea(double width, double height){
        Console.WriteLine("The area is : " + width*height);
    }

    public void getPerimeter(double width, double height){
        Console.WriteLine("The perimeter is : " + 2*(width + height));
    }
};



// public delegate double Delegate1(int x, float y, double z);
// public delegate void Delegate2(int x, float y, double z);
// public delegate bool Delegate3(string str);

class GenericDelegate{
    public static double AddNum1(int x, float y, double z){
        return x+y+z;
    }

    public static void AddNum2(int x, float y, double z){
        Console.WriteLine(x + y + z);
    }

    public static bool checkLength(string str){
        if(str.Length > 5){
            return true;
        }else{
            return false;
        }
    }
}











class Program{
    // Step - 01 Defining the Delegate --> the return type, no. of parameter and the type of the parameters of the Delagate must be same as the Target-method
    public delegate int addDelegate(int a, int b);
    public  int addNum(int a, int b){
        return a+b;
    }

    public delegate string sayDelegate(string str);
    public  string sayHello(string name){
        return "Hello" + name;
    }


    public static void Main(string[] args){
        Program p = new Program();
        Console.WriteLine(p.addNum(10,20));
        Console.WriteLine(p.sayHello(" Utkarsh"));


        // Step - 02 Instantiating the delegate  --> here the target method name is passed as a paramter to the Delegate Constructor
        addDelegate aD = new addDelegate(p.addNum);

        // Step - 03 Calling the Delegate by passing the required parameter values so that internally the method which is bound to the Delegate get executed.
        Console.WriteLine(aD(10, 20));

        sayDelegate sD = new sayDelegate(p.sayHello);
        Console.WriteLine(sD(" Utkarsh"));


        // =================================================================================================================================================================


        // Multicast Delegate
        Reactangle r = new Reactangle();
        r.getArea(10, 20);

        // Instance of the Multicast Delegate
        RectDelegate rD = new RectDelegate(r.getArea);
        // rD += r.getPerimeter;

        rD(10, 20);

        // We can also instatite a delegate like
        RectDelegate obj = r.getArea;
        obj.Invoke(10.12,20.22);



        // =================================================================================================================================================================


        // GENERIC DELEGATES
        Func<int, float, double, double> obj1 = GenericDelegate.AddNum1;       //since the AddNum1 method is static we can access its method just by using the class name.
        Console.WriteLine(obj1(10 , 20.3f, 23.34));

        Action<int, float, double> obj2 = GenericDelegate.AddNum2;
        obj2(10, 20.3f, 23.4544);

        Predicate<string> obj3 = GenericDelegate.checkLength;
        Console.WriteLine(obj3("Utkarsh"));


        // We can also use generic Delegtes along with the anonymous functions with the lanba expression(=>)
        Func<int, float, double, double> obj11 = (x, y, z) => {
            return x+y+z;
        };

        int x = 10;
        Console.WriteLine($"he value of the x = {x}");
    }

}