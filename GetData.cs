using System.Text.Json;

namespace async1;

public class GetData
{
    public static async Task<string> GetApiData(Uri uri)
    {
        using (HttpClient client = new HttpClient(){BaseAddress = uri})
        {
            var msg = await client.GetStringAsync("");
            return msg;
        }
    }
}