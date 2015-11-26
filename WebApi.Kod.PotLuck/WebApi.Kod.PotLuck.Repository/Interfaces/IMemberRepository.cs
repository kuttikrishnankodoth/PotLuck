using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.Models;

namespace WebApi.Kod.PotLuck.Repository
{
    public interface IMemberRepository
    {
        Task<IEnumerable<MemberMdl>> GetAsync(
        Expression<Func<MemberMdl, bool>> filter = null,
        Func<IQueryable<MemberMdl>, IOrderedQueryable<MemberMdl>> orderBy = null,
            string includeProperties = "");

        Task InsertAsync(MemberMdl entity);

        Task UpdateAsync(MemberMdl entityToUpdate);

        void Delete(object id);
    }
}
