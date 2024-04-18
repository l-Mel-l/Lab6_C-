public abstract class Transport
{
    public abstract double Speed { get; }
    public abstract double CarryingCapacity { get; }
    public abstract double Range { get; }

    //Абстрактный метод для возвращения значения свойств
    public abstract string GetTransportInfo();
}

//классы наследуемые от класса транспорт, которые реализуют его свойства

public abstract class Car : Transport
{
    public override double Speed => 0;
    public override double CarryingCapacity => 0;
    public override double Range => 0;
}

public abstract class Aircraft : Transport
{
    public override double Speed => 0;
    public override double CarryingCapacity => 0;
    public override double Range => 0;
}

public abstract class Ship : Transport
{
    public override double Speed => 0;
    public override double CarryingCapacity => 0;
    public override double Range => 0;
}

//классы наследуемые от абстрактных классов, которые реализуют свойства и методы

public class Lamborgini : Car
{
    public String Name = "Ламборджини Авентадор";
    public override double Speed => 350;
    public override double CarryingCapacity => 500;
    public override double Range => 1000;

    public override string GetTransportInfo()
    {
        return $"{Name} грузоподъемностью {CarryingCapacity} кг может проехать {Range} км";
    }
}

public class Boeing : Aircraft
{
    public String Name = "Боинг 747";
    public override double Speed => 900;
    public override double CarryingCapacity => 250000;
    public override double Range => 15000;

    public override string GetTransportInfo()
    {
        return $"{Name} грузоподъемностью {CarryingCapacity} кг может проехать {Range} км";
    }
}

public class QueenMary: Ship
{
    public String Name = "Queen Mary 2";
    public override double Speed => 40;
    public override double CarryingCapacity => 220000;
    public override double Range => 14000;

    public override string GetTransportInfo()
    {
        return $"{Name} грузоподъемностью {CarryingCapacity} кг может проехать {Range} км";
    }
}

class Program
{
    static void Main()
    {
        //создём объекты классов и выводим их информацию
        Lamborgini lamborgini = new Lamborgini();
        Boeing boeing = new Boeing();
        QueenMary queenMary = new QueenMary();

        Console.WriteLine(lamborgini.GetTransportInfo());
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine(boeing.GetTransportInfo());
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine(queenMary.GetTransportInfo());
    }
}