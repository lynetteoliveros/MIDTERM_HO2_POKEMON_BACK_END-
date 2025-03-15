using System;
using System.Collections.Generic;
public class1
public class Class1
{
	public Class1()
	{
		private static List <Pokemon> pokemons = new List<Pokemon> ();

		public static void initialize()
		{ 
		_pokemons.Add (new Pokemon
			Name = "Pikachu",
			Type = "Meralco",
			Height = 0.4f,
			Weight = 6.0f, 
			IsageUrl = "https://rwa.githubuserconten.com/PokeAPI/sprites/master/sprites/pokemon/1.png"
		});
	}

	public static List<Pokemon> GetPokemonList()
	{
		if (_pokemons == null || _pokemons.Count() == 0){
			Initialize(); 
		}
		return _pokemons;
	}
	
	public static void AddPokemon(Pokemon pokemon)
	{
	_pokemons.Add(pokemon); 
	}

}
