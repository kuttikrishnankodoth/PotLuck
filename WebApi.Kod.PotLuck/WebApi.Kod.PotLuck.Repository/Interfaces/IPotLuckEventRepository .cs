using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.Models;

namespace WebApi.Kod.PotLuck.Repository
{
    public interface IPotLuckEventRepository
    {
        Task<IEnumerable<EventMdl>> GetAsync(
        Expression<Func<EventMdl, bool>> filter = null,
        Func<IQueryable<EventMdl>, IOrderedQueryable<EventMdl>> orderBy = null,
            string includeProperties = "");

        Task InsertAsync(EventMdl entity);

        Task UpdateAsync(EventMdl entityToUpdate);

        void Delete(object id);
    }
}
