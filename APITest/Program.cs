using RestSharp;
using System.Net;
using System.Text.Json;

RestClient pokeClient = new("https://pokeapi.co/api/v2");
RestRequest request = new("pokemon/ppp");
RestResponse response = pokeClient.GetAsync(request).Result;

if (response.StatusCode == System.Net.HttpStatusCode.OK)
{
    Pokemon p = JsonSerializer.Deserialize<Pokemon>(response.Content);

    Console.WriteLine(p);
    Console.WriteLine(p.Name);
    Console.WriteLine(p.Weight);
    Console.WriteLine(p.Default);
}
