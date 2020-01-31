using DiscogsRandomFive.Model;
using Microsoft.AspNetCore.Mvc;
using DiscogsRandomFive.Services.Interfaces;
using System.Collections.Generic;

namespace DiscogsRandomFive.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscogsController : ControllerBase
    {
        protected readonly IServiceConsommation _serviceConsommation;
        protected readonly IServiceTraitement _serviceTraitement;

           public DiscogsController(IServiceConsommation servConsommation, IServiceTraitement servTraitement)
           {
            _serviceConsommation = servConsommation;
            _serviceTraitement = servTraitement;
           }

        /// <summary>Cette methode retourne une liste de N disque specifier en parametre</summary>
        /// <param numberRelease>est le nombre de disques demandé</param>
        
             [HttpGet("Get/{numberRelease}")]
             public List<Release> Get(sbyte numberRelease)
             {
                 //colRelease comprend toute la collection
                  CollectionRelease colRelease = _serviceConsommation.GetCollectionRealease();

                 //retourne un nombre d'article spécifier en paramettre  de la collection colRelease
                  return _serviceTraitement.GetReleaseByNumber(numberRelease, colRelease);
 
             }
    }   
}