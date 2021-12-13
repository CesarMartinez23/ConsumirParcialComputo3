using System;
using System.Net.Http;
using System.Threading.Tasks;
public class ClientAPI
{
    private string BASE_URL = "https://apicarugb.herokuapp.com/";

    public Task<HttpResponseMessage> Find(String service="")
    {
        try
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BASE_URL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return client.GetAsync(service);
        }
        catch
        {
            return null;
        }
    }
}