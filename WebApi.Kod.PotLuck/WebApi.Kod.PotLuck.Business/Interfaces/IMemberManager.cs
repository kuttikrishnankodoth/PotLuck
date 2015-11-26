using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.Models;
namespace WebApi.Kod.PotLuck.Business.Interfaces
{
    public interface IMemberManager
    {
       Task<IEnumerable<MemberMdl>> GetMembers();
       Task<MemberMdl> GetMembers(int memberId);
    }
}
