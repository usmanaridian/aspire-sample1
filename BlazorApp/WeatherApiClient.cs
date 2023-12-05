﻿namespace BlazorApp
{
	public class WeatherApiClient(HttpClient httpClient)
	{
		public async Task<WeatherForecast[]> GetWeatherForecasts() =>
			await httpClient.GetFromJsonAsync<WeatherForecast[]>("weatherforecast") ?? [];
	}

	public class WeatherForecast
	{
		public DateOnly Date { get; set; }
		public int TemperatureC { get; set; }
		public string? Summary { get; set; }
		public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
	}
}
