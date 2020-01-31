using System.Net.Http;
using DiscogsRandomFive.Model;
using DiscogsRandomFive.Services.Interfaces;

namespace DiscogsRandomFive.Services.Implementations
{
    public class ServiceConsommation : IServiceConsommation
    {
        /// <summary>Cette methode retourne l'objet CollectionRelease de UrlApi</summary>
        private readonly string UrlApi = "https://api.discogs.com/users/ausamerika/collection/folders/0/releases";

        public CollectionRelease GetCollectionRealease()
        {
            using (HttpClient client = new HttpClient())
            {
                //Obtient une collection d'en-têtes qui doivent être envoyés avec chaque demande
                client.DefaultRequestHeaders.Add("User-Agent", "Discogs Test App");

                //Envoyez une demande GET à l'URI spécifié en tant qu'opération asynchrone
                var response = client.GetAsync(UrlApi).Result;

                //Lève une exception si la propriété IsSuccessStatusCode de la réponse HTTP est fausse.
                response.EnsureSuccessStatusCode();

                //retourne le resultat
                return response.Content.ReadAsAsync<CollectionRelease>().Result;
            }
        }
    }
}
