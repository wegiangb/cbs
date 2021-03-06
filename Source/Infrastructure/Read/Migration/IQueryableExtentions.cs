using System.Collections.Generic;
using System.Linq;
using Dolittle.ReadModels;

namespace Infrastructure.Read.Migration
{
    public static class IQueryableExtentions
    {
        public static IQueryable<T> MigrateQuery<T>(this IQueryable<T> query, ICanMigrate<T> migrator)
            where T : IReadModel
        {
            var queryAsEnumerable = query.AsEnumerable();
            IList<T> readModels = new List<T>();

            foreach (var item in queryAsEnumerable)
            {
                readModels.Add(migrator.GetMigratedReadModel(item));
            }
            return readModels.AsQueryable();

        }
    }
}