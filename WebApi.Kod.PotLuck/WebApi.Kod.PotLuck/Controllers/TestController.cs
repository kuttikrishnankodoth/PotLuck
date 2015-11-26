using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApi.Kod.PotLuck.Business.Interfaces;
using WebApi.Kod.PotLuck.Business.Managers;
using WebApi.Kod.PotLuck.Repository;

namespace WebApi.Kod.PotLuck.Controllers
{
    public class TestController : ApiController
    {       
        private IPotluckEventManager manager;
        public TestController(IPotLuckEventRepository repository)
        {
            manager = new PotluckEventManager(repository);
        }
        public async Task<IHttpActionResult> Get()
        {
            var result = await manager.GetEvents();
            return Ok(result);
        }
    }
}
