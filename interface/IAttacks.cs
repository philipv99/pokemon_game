
    internal interface IAttacks<T> where T : IhasId
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int power { get; set; }
    public int speed { get; set; }
}
