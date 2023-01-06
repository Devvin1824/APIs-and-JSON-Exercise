using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

           // Console.WriteLine(kanyeQuote);

           // Console.WriteLine(ronQuote);    

            for (int i = 0; i < 5; i++)
            {
                functions.KanyeQuote();
                functions.RonQuote();
                Console.WriteLine();
            }

            var key = "37ece36c446e06a7fc88ee9cc29d11f2";
            var city = "Seattle";
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}"; // endpoint
            var weatherResponse = client.GetStringAsync(weatherURL).Result; // response 
            var newWeather = JObject.Parse(weatherResponse);
            
            
            Console.WriteLine(newWeather);

        }
    }
}
