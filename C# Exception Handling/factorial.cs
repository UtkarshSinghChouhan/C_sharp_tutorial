using System;
namespace factorial;

class negNumber : Exception{
    public override string Message{
        get{
            return "the input nuber is a negative number";
        }
    }
}

class notaNumber : Exception{
    public override string Message{
        get{
            return "the input nuber is not aw`1 number";
        }
    }
}

class Program{
    public static void Main(string[] arg){
        try{
            string inp = Console.ReadLine();
            int num;

            if(!(int.TryParse(inp, out num))){
                throw new notaNumber();
            }

            if((int.Parse(inp)) < 0){
                throw new negNumber();
            }


            int fact = 1;
            int number = int.Parse(inp);

            while(number != 0){
                fact *= number;
                number--;
            }

            Console.WriteLine($"The factorial of the nuber is : {fact}");

        }

        catch(negNumber nn){
            Console.WriteLine($"Error: {nn.Message}");
        }

        catch(notaNumber nan){
            Console.WriteLine($"Error: {nan.Message}");
        }
    }
}