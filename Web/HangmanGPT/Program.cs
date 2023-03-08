using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        var client = new HttpClient();
        var response = await client.GetAsync("https://otv-hangman.azurewebsites.net/api/GetWord");
        if (response.IsSuccessStatusCode)
        {
            var wordResponse = await JsonSerializer.DeserializeAsync<WordResponse>(await response.Content.ReadAsStreamAsync());
            var word = wordResponse.Value;
            Console.WriteLine($"The word is: {word}");
        }
        else
        {
            Console.WriteLine($"Failed to get a word: {response.StatusCode}");
        }
    }
}

public class WordResponse
{
    public int Id { get; set; }
    public string Value { get; set; }
}
