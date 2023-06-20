
    public interface IPokeTypes<T> where T : class
{
    public PokeType PType { get; set; }
    public PokeType WeakTo { get ; set; }
    public PokeType StrongeTo { get; set; }
}
