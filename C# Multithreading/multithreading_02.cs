using System;

namespace multithreading_02;


// In multithreading we can call each method by using a seperate thread.
// In such case the operating system will allocate time period for each thread to execute.

class Program{

    static void func1(){
        Console.WriteLine("Entering Thread - 01");

        for(int i = 0; i <= 50; i++){
            Console.WriteLine($"Inside Func 1 : {i}");
        }

        Console.WriteLine("Exiting Thread - 01");
    }



    static void func2(){
        Console.WriteLine("Entering Thread - 02");

        for(int i = 0; i <= 50; i++){
            Console.WriteLine($"Inside Func 2 : {i}");

            
            if(i == 50){
                Console.WriteLine("Main Thread going to sleep...");
                Thread.Sleep(5000);
                Console.WriteLine("Main Thread woke up.");
            }
        }
        Console.WriteLine("Exiting Thread - 02");
    }


    
    static void func3(){
        Console.WriteLine("Entering Thread - 03");

        for(int i = 0; i <= 50; i++){
            Console.WriteLine($"Inside Func 3 : {i}");
        }
        Console.WriteLine("Exiting Thread - 03");
    }


    public static void Main(string[] args){
        Thread t1 = new Thread(func1);
        Thread t2 = new Thread(func2);
        Thread t3 = new Thread(func3);

        t1.Start();
        t2.Start();
        t3.Start();
    }
}