using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using GeoLib.Core;

namespace GeoLib.Data
{
    public class StateRepository : DataRepositoryBase<State, GeoLibDbContext>, IStateRepository
    {
        protected override DbSet<State> DbSet(GeoLibDbContext entityContext)
        {
            return entityContext.StateSet;
        }

        protected override Expression<Func<State, bool>> IdentifierPredicate(GeoLibDbContext entityContext, int id)
        {
            return (e => e.StateId == id);
        }

        public State Get(string abbrev)
        {
            using (GeoLibDbContext entityContext = new GeoLibDbContext())
            {
                return entityContext.StateSet.FirstOrDefault(e => e.Abbreviation.ToUpper() == abbrev.ToUpper());
            }
        }

        public IEnumerable<State> Get(bool primaryOnly)
        {
            using (GeoLibDbContext entityContext = new GeoLibDbContext())
            {
                return entityContext.StateSet.Where(e => e.IsPrimaryState == primaryOnly).ToFullyLoaded();
            }
        }
    }
}
