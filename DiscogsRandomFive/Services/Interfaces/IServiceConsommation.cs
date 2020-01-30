using DiscogsRandomFive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscogsRandomFive.Services.Interfaces
{
    public interface IServiceConsommation
    {
        CollectionRelease GetCollectionRealease();
    }
}
