namespace MIDTERM_HO2_POKEMON_BACK_END
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}

public class Pokemon
{
    public int Name { get; set; }
    public int Type { get; set; }
    public int Float { get; set; }
    public int Float { get; set; }
    public String ? IsageUrl { get; set; }
}