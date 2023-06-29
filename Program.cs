

ClassPokeTypes Fire = new ClassPokeTypes(PokeType.Fire, PokeType.Leaf, PokeType.Water);
ClassPokeTypes Water = new ClassPokeTypes(PokeType.Water, PokeType.Fire, PokeType.Leaf);
ClassPokeTypes Leaf = new ClassPokeTypes(PokeType.Leaf, PokeType.Water, PokeType.Fire);
ClassPokeTypes Noraml = new ClassPokeTypes(PokeType.Normal);

var Smash = new Attacks<int>("Smash", "Strong smashing attack", 50);
var cut = new Attacks<int>("Cut", "Smart Slicing mood", 35);
var fireBall = new Attacks<int>("Fire Ball", "Spits out a Ball of fire", 40);
var Fly = new Attacks<int>("Fly", "Flys away only to strike from abow", 20);
var Heatbutt = new Attacks<int>("HeadButt", "Runs at it's fows, using it's head as a wepon", 20);


Console.WriteLine("making pokemons......");

var pokemon1 = new Pokemon<int>("Normal ass bicth", 100, 20, 20);
pokemon1.Types.Add(Noraml);
pokemon1.Addpower(Smash);
pokemon1.Addpower(cut);
pokemon1.Addpower(fireBall);
pokemon1.Addpower(Fly);

Console.WriteLine(pokemon1);

pokemon1.Addpower(Heatbutt);

Console.WriteLine(pokemon1);


