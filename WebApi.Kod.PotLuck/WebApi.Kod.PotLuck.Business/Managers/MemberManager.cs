using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.Business;
using WebApi.Kod.PotLuck.Business.Interfaces;
using WebApi.Kod.PotLuck.Models;
using WebApi.Kod.PotLuck.Repository;

namespace WebApi.Kod.PotLuck.Business.Managers
{
    public class MemberManager : BaseManager<IRepository<MemberMdl>>, IMemberManager
    {
        public MemberManager(IRepository<MemberMdl> repository)
            : base(repository)
        {

        }
        public async Task<IEnumerable<MemberMdl>> GetMembers()
        {
            var t = await Repository.GetAsync();
            return t;
        }

        public async Task<MemberMdl> GetMembers(int memberId)
        {
            var t = await Repository.GetAsync(x => x.MemberId == memberId);
            return t.FirstOrDefault();
        }
    }
}
