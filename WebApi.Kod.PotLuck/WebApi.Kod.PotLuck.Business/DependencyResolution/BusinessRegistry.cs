using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.Repository.DependencyResolution;

namespace WebApi.Kod.PotLuck.Business.DependencyResolution
{
    public class BusinessRegistry : Registry
    {
        public BusinessRegistry()
        {
            Scan(
                scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
            
            IncludeRegistry<RepositoryRegistry>();
        }
    }
}
