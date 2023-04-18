using System;
using System.Collections;

namespace Collections_01;

// NON-GENERIC COLLECTION
// Stack, Queue, LinkedList, SortedList, ArrayList, HashTable

class Program{
    public static void Main(string[] args){
        ArrayList al = new ArrayList();

        // Add at Back
        al.Add(100);
        al.Add(200);
        al.Add(300);
        al.Add(400);
        al.Add(500);
        al.Add(600);

        foreach(var val in al){
            Console.Write($"{val} ");
        }


        // Add in between
        al.Insert(3, 350);   //will add 350 at index 3

        // Remove at any place
        al.Remove(350);
        al.RemoveAt(3);
        

        Console.WriteLine();
        
    }
}