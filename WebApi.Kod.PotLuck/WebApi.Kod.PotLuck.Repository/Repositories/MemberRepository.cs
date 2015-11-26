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
    public class MemberRepository : IRepository<MemberMdl>
    {
        private PotLuckContext context;
        private DbSet<Member> dbSet;

        public MemberRepository()
        {
            context = new PotLuckContext();
            dbSet = context.Set<Member>();
        }
        public static Expression<Func<Member, MemberMdl>> AsMemberMdl =
           x => new MemberMdl
               {
                   MemberId = x.Id,
                   AddressLineOne = x.AddressLineOne,
                   City = x.City,
                   ContactPhoneNumber = x.ContactPhoneNumber,
                   Email = x.Email,
                   FirstName = x.FirstName,
                   HouseNumber = x.HouseNumber,
                   LastName = x.LastName,
                   NickName = x.NickName,
                   State = x.State,
                   Zip = x.Zip
               };


        public async Task<IEnumerable<MemberMdl>> GetAsync(Expression<Func<MemberMdl, bool>> filter = null,
            Func<IQueryable<MemberMdl>, IOrderedQueryable<MemberMdl>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<MemberMdl> query;
            query = dbSet.Select(AsMemberMdl);
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

        public Task InsertAsync(MemberMdl entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(MemberMdl entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

    }
}
