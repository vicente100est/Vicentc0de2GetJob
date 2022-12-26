// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public abstract class Bird
{
    public int _wings;
    public Bird(int wings) => _wings = wings;
}

public interface IFly
{
    void Fly();
}

public interface IRun
{
    int Legs { get; set; }
    void Run();
}

public interface ISwim
{
    void Swim();
}

public class Ostrich : Bird, IRun, ISwim
{
    private int _legs;

    public int Legs
    {
        get { return _legs; }
        set { _legs = value; }
    }

    public Ostrich(int wing) : base (wing)
    {
    }

    public void Run()
    {
        Console.WriteLine("Run my Friend");
    }

    public void Swim()
    {
        Console.WriteLine("Swim Pajaro");
    }
}