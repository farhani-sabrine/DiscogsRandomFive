using System;
using DiscogsRandomFive.Model;
using Microsoft.AspNetCore.Mvc;
using DiscogsRandomFive.Services.Interfaces;

namespace DiscogsRandomFive.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscogsController : ControllerBase
    {
        protected readonly IServiceConsommation _serviceConsommation;

        public DiscogsController(IServiceConsommation serviceConsommation)
        {
            _serviceConsommation = serviceConsommation;
        }


        [HttpGet("Get")]
        public CollectionRelease Get()
        {
            return _serviceConsommation.GetCollectionRealease();
        }
    }
}