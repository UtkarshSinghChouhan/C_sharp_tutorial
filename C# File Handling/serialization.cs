using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;           //to convert the object into the binary format

namespace serialization;


public class Person{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class DataSerializer{
    public void BinarySerialize(object data, string filePath){
    }
}

class Program{
    public static void Main(string[] args){

    }
}