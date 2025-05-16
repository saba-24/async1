namespace async1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Uri> uris = 
            [
                new Uri("https://car-api-htd7gjh9brb8asgp.uksouth-01.azurewebsites.net/api/car/car"),
                new Uri("https://gallery-api-3-e2a9g0bkdnfwfrg8.uksouth-01.azurewebsites.net/api/main"),
            ];
            var tasks = uris.Select(async u =>
            {
                Console.WriteLine("awaiting data...");
                string c = await GetData.GetApiData(u);
                return c;
            }).ToArray();
            var results = await Task.WhenAll(tasks);
            foreach (var c in results)
            {
                Console.WriteLine(c);
            }
        }
    }
}

