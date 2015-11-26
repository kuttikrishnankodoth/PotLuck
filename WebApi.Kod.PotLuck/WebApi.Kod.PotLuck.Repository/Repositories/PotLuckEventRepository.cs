using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.DbEntities.DataContext;
using WebApi.Kod.PotLuck.DbEntities.Entities;
using WebApi.Kod.PotLuck.Models;
using WebApi.Kod.PotLuck.Repository;

namespace WebApi.Kod.PotLuck.Repository
{
    public class PotLuckEventRepository : IRepository<EventMdl>
    {
        private PotLuckContext context;
        private DbSet<PotLuckEvent> dbSet;
        public PotLuckEventRepository()
        {
            context = new PotLuckContext();
            dbSet = context.Set<PotLuckEvent>();
        }

        public async Task<IEnumerable<EventMdl>> GetAsync(Expression<Func<EventMdl, bool>> filter = null, Func<IQueryable<EventMdl>, IOrderedQueryable<EventMdl>> orderBy = null, string includeProperties = "")
        {
            IQueryable<EventMdl> query;
            query = dbSet.Select(x => new EventMdl
            {
                EventId = x.Id,
                Venue = x.Venue,
                EventZip = x.EventZip,
                EventState = x.EventState,
                EventName = x.EventName,
                EventDescription = x.EventDescription,
                EventDateTimeTill = x.EventDateTimeTill,
                EventDateTimeFrom = x.EventDateTimeFrom,
                EventCity = x.EventCity,
                EventAddressLineOne = x.EventAddressLineOne

            });
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }

        public Task InsertAsync(EventMdl entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(EventMdl entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }


    }
}
