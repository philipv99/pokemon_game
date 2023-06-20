
public class ClassPokeTypes<T> : IPokeTypes<T> where T : class
{
    public PokeType PType { get; set; }
    public PokeType WeakTo {  get; set; }
    public PokeType StrongeTo { get; set; }
    ClassPokeTypes(PokeType type, PokeType strong, PokeType weak)
    {
        PType = type;
        WeakTo = strong;
        StrongeTo = weak;
    }

}
