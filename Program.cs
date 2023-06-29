

Console.WriteLine("making types");

ClassPokeTypes Fire = new ClassPokeTypes(PokeType.Fire, PokeType.Leaf, PokeType.Water);
ClassPokeTypes Water = new ClassPokeTypes(PokeType.Water, PokeType.Fire, PokeType.Leaf);
ClassPokeTypes Leaf = new ClassPokeTypes(PokeType.Leaf, PokeType.Water, PokeType.Fire);
ClassPokeTypes Noraml = new ClassPokeTypes(PokeType.Normal);

Console.WriteLine("attakcs");

var Smash = new Attacks<int>("Smash", "Strong smashing attack", 50);
var cut = new Attacks<int>("Cut", "smart Slicing mood", 35);
var fireBall = new Attacks<int>("Smash", "Strong smashing attack", 50);

Console.WriteLine("making pokemons");

var pokemon1 = new Pokemon<int>("Normal ass bicth", 100, 20, 20);
pokemon1.Types.Add(Noraml);
pokemon1.Addpower(Smash);
pokemon1.Addpower(cut);
pokemon1.Addpower(fireBall);

Console.WriteLine(pokemon1);

