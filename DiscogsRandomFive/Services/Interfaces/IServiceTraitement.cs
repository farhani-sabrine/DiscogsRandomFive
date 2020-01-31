using DiscogsRandomFive.Model;
using System.Collections.Generic;


namespace DiscogsRandomFive.Services.Interfaces
{
    public interface IServiceTraitement
    {
        List<Release> GetReleaseByNumber(sbyte numberRelease, CollectionRelease colRelease);
    }
}
