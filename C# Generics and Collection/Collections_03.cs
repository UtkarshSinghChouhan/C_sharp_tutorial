using System;
using System.Collections;

namespace Collections_03;

// STACK  

//Acheiving A shopping cart functionality using two stacks
class ShoppingCart{
       Stack cart = new Stack();
       Stack redoStack = new Stack();

       public void Add(string item){
            cart.Push(item);
       }

       public void Undo(){
            var item = cart.Pop();
            redoStack.Push(item);
       }

       public void Redo(){
            var item = redoStack.Pop();
            cart.Push(item);
       }

       public void ViewCart(){
            foreach(var val in cart){
                Console.Write($"{val} ");
            }
            Console.WriteLine();
       }       
}


class Program{
    public static void Main(string[] srgs){
        Stack st = new Stack();

        st.Push(10);
        st.Push(20);
        st.Push(30);
        st.Push(40);
        st.Push(50);

        Console.WriteLine(st.Peek());

       

        // ============================ SHOPPING CART =======================
        var cart = new ShoppingCart();

    }
}