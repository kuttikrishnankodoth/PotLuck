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
    public class PotluckEventManager : BaseManager<IRepository<EventMdl>>, IPotluckEventManager
    {
        public PotluckEventManager(IRepository<EventMdl> repository)
            : base(repository)
        {

        }

        public async Task<IEnumerable<EventMdl>> GetEvents()
        {
            var t = await Repository.GetAsync();
            return t;
        }
    }

}
