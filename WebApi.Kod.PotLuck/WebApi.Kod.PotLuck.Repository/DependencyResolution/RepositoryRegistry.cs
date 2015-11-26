using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.Models;

namespace WebApi.Kod.PotLuck.Repository.DependencyResolution
{
    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {          
            For<IRepository<EventMdl>>().Use<PotLuckEventRepository>();
            For<IRepository<MemberMdl>>().Use<MemberRepository>();
        }
    }
}
