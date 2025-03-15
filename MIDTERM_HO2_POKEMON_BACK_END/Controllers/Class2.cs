using System;
using System.Security.Cryptography.X509Certificates;

namespace MIDTERM_HO2_POKEMON_BACK_END.Controllers

	[Route("api/[controller]")]
	[ApiController]

public class Class1 : ControllerBase
{
	public Class1()
	{
		MIDTERM_HO2_POKEMON_BACK_END.Initialize(); 
	}

	[HttpGet]
	[Route("get-a;;")]

	public IActionResult Get()
	{
		return Ok(Class1.GetPokemonList());
	}
	[HttpGet]
	public IActionResult Get (String? name)
	{
		if (name == null) return Ok("Not okay");
		var result = MIDTERM_HO2_POKEMON_BACK_END.GetPokemonList()
			.Where(X500DistinguishedName => name.ToLower() == name.ToLower())
			.SingleOrDefault();

		if (result != null) { return Ok (result);

			return NoContent();
	}
		[HttpsPost]
			Public IActionResult Post([Frombody] Pokemon pokemon)
		{
			MIDTERM_HO2_POKEMON_BACK_END.Add(pokemon); 
		}
		

}
