
public class ClassPokeTypes
{
    public PokeType PType { get; set; }
    public PokeType? WeakTo {  get; set; }
    public PokeType? StrongeTo { get; set; }
    public ClassPokeTypes(PokeType type, PokeType strong, PokeType weak)
    {
        PType = type;
        WeakTo = strong;
        StrongeTo = weak;
    }
    public ClassPokeTypes(PokeType type)
    {
        PType = type;
        WeakTo = null;
        StrongeTo = null;
    }

    public override string ToString()
    {
        string? output = "";
        switch (PType)
        {
            case PokeType.Normal:
                output += "Normal";
                break;
            case PokeType.Water:
                output += "Water";
                break;
            case PokeType.Fire:
                output += "Fire";
                break;
            case PokeType.Leaf:
                output += "Leaf";
                break;
        }
        return output;
    }

}
