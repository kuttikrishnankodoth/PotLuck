using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApi.Kod.PotLuck.Business.Interfaces;
using WebApi.Kod.PotLuck.Business.Managers;
using WebApi.Kod.PotLuck.Models;
using WebApi.Kod.PotLuck.Models.Extensions;
using System.Web.Http.Description;
using WebApi.Kod.PotLuck.Dto;

namespace WebApi.Kod.PotLuck.Controllers
{
    public class EventsController : ApiController
    {
        private IPotluckEventManager _manager;
        public EventsController(IPotluckEventManager manager)
        {
            _manager = manager;
        }

        /// <summary>
        /// You can query Event details using this end point.
        /// </summary>
        /// <returns>EventDTO</returns>
       
        public async Task<IHttpActionResult> Get()
        {
            var result = await _manager.GetEvents();
            return Ok(result.TransformToDto());
        }
    }
}
