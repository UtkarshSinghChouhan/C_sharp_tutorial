using System;
namespace Event2;


// WHAT IS EVENT - Events are communicartion b/w two object via a notification mechanism.
//                 Event provides notification ot the client when an object changes its state




// Step - 01 : We need a PUBLISHER CLASS  (For puublishing the vent we need a Delegate and Based on that delegate we need an event)
// step - 02 : We need  SUBSCRIBERS CLASSES





// ======================== PUBLISHER CLASS ============================

class EmployeeSeperator{
    // Declaring a Delegate Based on the Separate() Method
    public delegate void EmployeeSeperatedEventHandler();

    // Declaring an Event based on the Delegate
    public event EmployeeSeperatedEventHandler EmployeeSeperated;


    // We can notify each subscriber class by calling this method
    public void Separate(){

        // Publishing the Event by= simply calling the event
        if(EmployeeSeperated != null){
            EmployeeSeperated(); 
        }

    }
}






// ============================= SUBSCRIBER CLASSES ==========================================

class Finance{

    // We need the instance of the publisher-class to call the event of that class
    private EmployeeSeperator employeeSeperator;

    public Finance(EmployeeSeperator employeeSeperator){
        this.employeeSeperator = employeeSeperator;


        // Hooking the method to the event [i.e. Subscribing to the event]
        employeeSeperator.EmployeeSeperated += EmployeeSeperatedEventHandler;
    }


    // The Signature of the Handler methods must be similar to the Delegate
    public void EmployeeSeperatedEventHandler(){
        Console.WriteLine("Finance Department : employee Seperation process related to finance");
    }
}




class IT{
    private EmployeeSeperator employeeSeperator;
    public IT(EmployeeSeperator employeeSeperator){
        this.employeeSeperator = employeeSeperator;

        // Hooking the method to the event [i.e. Subscribing to the event]
        employeeSeperator.EmployeeSeperated += EmployeeSeperatedEventHandler;

    }


    // The Signature of the Handler methods must be similar to the Delegate
    public void EmployeeSeperatedEventHandler(){
        Console.WriteLine("IT Department : employee Seperation process related to IT");
    }
}












class Program{
    public static void Main(string[] args){

        
        EmployeeSeperator employeeSeperator = new EmployeeSeperator();
        Finance f = new Finance(employeeSeperator);
        IT it = new IT(employeeSeperator);

        employeeSeperator.Separate();

    }
}