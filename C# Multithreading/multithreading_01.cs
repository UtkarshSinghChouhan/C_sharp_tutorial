using System;
using System.Threading;

namespace multithreading_01;

// Every application by default contains one thread to execute the program and that is known as "Main Thread".
// In a single threaded model the actions are completed one after the another.

// In multi threaded model each thread is trying to perform different action.
// The main idea behind this is maximum utilization of the cpu resources.

class Program{
    static void func1(){
        for(int i = 0; i <= 50; i++){
            Console.WriteLine($"Inside Func 1 : {i}");
        }
    }



    static void func2(){
        for(int i = 0; i <= 50; i++){
            Console.WriteLine($"Inside Func 2 : {i}");

            // Here we are trying to simulate the problem encountered due to a single threaded model, which can be overcome by using the  multi-threaded model.
            // Where each thread is trying to perform different action.
            if(i == 50){
                Console.WriteLine("Main Thread going to sleep...");
                Thread.Sleep(5000);
                Console.WriteLine("Main Thread woke up.");
            }
        }
    }


    // In a single threaded model the func3() execution will not start untill the execution of the func2 is completed.
    static void func3(){
        for(int i = 0; i <= 50; i++){
            Console.WriteLine($"Inside Func 3 : {i}");
        }
    }
    public static void Main(string[] args){
        func1();
        func2();
        func3();
    }
}