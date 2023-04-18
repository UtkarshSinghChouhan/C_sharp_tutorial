using System;
using System.Collections;

namespace Collections_02;

// HASHTABLE

class Program{
    public static void Main(string[]args){
        Hashtable ht = new Hashtable();

        ht.Add("Name", "Utkarsh");
        ht.Add("Age", 23);
        ht.Add("Email", "usc@email.com");
        ht.Add("Gender", 'M');
        ht.Add("Location", "Jalandhar");

        foreach(var key in ht.Keys){
            Console.WriteLine($"{key} => {ht[key]}");
        }
    }
}