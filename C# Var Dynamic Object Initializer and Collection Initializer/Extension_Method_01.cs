using System;
namespace Extension_Method;

sealed public class Program{

    public void Func1(){
        Console.WriteLine("This is the First Function inside the Program Class");
    }

    public void Func2(){
        Console.WriteLine("This is the Second Function inside the Program Class");
    }


    public static void Main(string[] args){
        var nums = new int[]{1, 2, 3, 4, 5, 6, 7, 8 ,9 , 10};


        //================ EXTENSION MTHOD => WHERE() ===================
        var evenNumbers = nums.Where((ele) => {
            return (ele % 2 == 0);
        });

        Console.Write("Even Numbers are : ");
        foreach (var item in evenNumbers)
        {
            Console.Write(item + " ");
        }


        //================ EXTENSION MTHOD => SELECT() ===================

        var elements = nums.Select((ele) => {
            return ele;
        });

        Console.Write("\nDifferent elements of the array are : ");

        foreach (var item in elements)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();


        // ==================== CALLING FUNC1 AND FUNC2 =====================
        Program p = new Program();
        p.Func1();
        p.Func2();
    }
};