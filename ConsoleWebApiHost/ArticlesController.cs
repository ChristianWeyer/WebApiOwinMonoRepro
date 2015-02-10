using System.Linq;
using System.Web.Http;
using Newtonsoft.Json;
using System.Collections.Concurrent;

namespace WebApiHost
{
    public class ArticlesController : ApiController
    {
		private static ConcurrentDictionary<int, dynamic> database;

		static ArticlesController()
		{
			database = new ConcurrentDictionary<int, dynamic>();
			database.TryAdd(1, new { Id = 1, Title = "Super lecker Pudding", Description = "Blaaa blaaa blubbb", Amount = 8 });
			database.TryAdd(2, new { Id = 2, Title = "Mjamm-mjamm Gurken", Description = "Yadda yadda yad", Amount = 149 });
			database.TryAdd(3, new { Id = 3, Title = "Mhhhh Salzstangen", Description = "Momm momm mom", Amount = 53 });
		}

        public dynamic GetArticlesFiltered()
        {
			return database.Values;
        }
    }
}
