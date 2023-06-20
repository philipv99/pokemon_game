
public class ClassPokeTypes
{
    public PokeType PType { get; set; }
    public PokeType WeakTo {  get; set; }
    public PokeType StrongeTo { get; set; }
    public ClassPokeTypes(PokeType type, PokeType strong, PokeType weak)
    {
        PType = type;
        WeakTo = strong;
        StrongeTo = weak;
    }

}
