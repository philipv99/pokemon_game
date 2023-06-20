
public class Attacks<T> : IAttacks, IhasId
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Power { get; set; }
    public int Speed { get; set; }

    public Attacks(string name, string discription, int power)
    {
        int  Id = IdMaker();
        Name = name;
        Description = discription;
        Power = power;
        Speed = 0;
    }
    public Attacks(string name, string discription, int power, int speed)
    {
        int Id = IdMaker();
        Name = name;
        Description = discription;
        Power = power;
        Speed = speed;
    }

    private int Idvalue = 0 ;
    private int IdMaker()
    {
        Id = Idvalue++ ;
        return Idvalue;
    }

    public override string ToString()
    {
        return $"{Name}\n" + 
               $"{Description}\n" +
               $"PWR:{Power},  SPD:{Speed},  ";
    }
}

