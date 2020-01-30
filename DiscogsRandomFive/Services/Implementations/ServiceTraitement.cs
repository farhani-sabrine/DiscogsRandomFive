using DiscogsRandomFive.Model;
using DiscogsRandomFive.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiscogsRandomFive.Services.Implementations
{
    public class ServiceTraitement : IServiceTraitement
    {

        /// <summary>Cette methode retourne une liste de N disque specifier en parametre</summary>
        /// <param numberRelease>est le nombre de disques demandé</param>
        /// <param colRelease>est la collection de toute la liste de realease et la pagination </param>
        public List<Release> GetReleaseByNumber(sbyte numberRelease, CollectionRelease colRelease)
        {
                var rnd = new Random();
                return colRelease.Releases.OrderBy(x => rnd.Next()).Take(numberRelease).ToList();
                  

        }
    }
}
