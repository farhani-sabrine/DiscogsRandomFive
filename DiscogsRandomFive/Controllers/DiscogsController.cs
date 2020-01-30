using System;
using DiscogsRandomFive.Model;
using Microsoft.AspNetCore.Mvc;
using DiscogsRandomFive.Services.Interfaces;
using System.Collections.Generic;
using DiscogsRandomFive.Exceptions;

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
            CollectionRelease colRelease;
            try
            {
                if (numberRelease < 1 || numberRelease > 5)
                {
                    throw new InvalidNumberException();
                }

                 colRelease = _serviceConsommation.GetCollectionRealease();
                return _serviceTraitement.GetReleaseByNumber(numberRelease, colRelease);

            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("La collection des disques est vide");
            }
           

            
        }
    }
}