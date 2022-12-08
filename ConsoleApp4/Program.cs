
using ConsoleApp4;
using Newtonsoft.Json;
using System.Text.Json.Serialization;


List<UserInfo>  response = await GetAsync("https://jsonplaceholder.typicode.com/users");
foreach (var item in response)
{
    Console.WriteLine(item.Id);
}


static async Task<List<UserInfo>> GetAsync(string path)
{
    List<UserInfo> post = default;
    using(HttpClient client = new HttpClient())
    {
        var responseMessage= await client.GetAsync(path);
        if (responseMessage.IsSuccessStatusCode)
        {
            var responseString=await responseMessage.Content.ReadAsStringAsync();
            post = JsonConvert.DeserializeObject<List<UserInfo>>(responseString);

        }
        else
        {
            throw new Exception();
        }
    }
    return post;    
}




