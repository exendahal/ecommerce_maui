namespace EcommerceMAUI.Helpers
{
    public static class HttpHelper
    {
        public static async Task<string> GetHttpResponse(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return jsonResponse;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                }
                return string.Empty;
            }
        }
    }
}
