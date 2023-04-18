namespace Classes;

public abstract class Phone{
    public abstract void call();
    public void ringTone(){
        Console.WriteLine("=========ZZZZZZZ=========");
    }
}


public class Samsung : Phone{
    public override void call(){
        Console.WriteLine("Inside the overridden method---Samsung");
    }

};