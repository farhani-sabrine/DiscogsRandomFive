using System.Net.Http;
using DiscogsRandomFive.Model;
using DiscogsRandomFive.Services.Interfaces;

namespace DiscogsRandomFive.Services.Implementations
{
    public class ServiceConsommation : IServiceConsommation
    {
        private readonly string UrlApi = "https://api.discogs.com/users/ausamerika/collection/folders/0/releases";

        public CollectionRelease GetCollectionRealease()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Discogs Test App");

                var response = client.GetAsync(UrlApi).Result;
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsAsync<CollectionRelease>().Result;
            }
        }
    }
}
