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
    public class MembersController : ApiController
    {

        private IMemberManager _manager;
        public MembersController(IMemberManager manager)
        {
            _manager = manager;
        }

        /// <summary>
        /// Get Action method 
        /// </summary>
        /// <returns>MemberDTO</returns>       
        public async Task<IHttpActionResult> Get()
        {
            var result = await _manager.GetMembers();
            return Ok(result);
        }

        /// <summary>
        /// This end point can be used to get a member with provided member id
        /// </summary>
        /// <param name="memberId">MemberId</param>
        /// <returns>MemberDTO</returns>
        [ResponseType(typeof(MemberDTO))]
        public async Task<IHttpActionResult> Get(int memberId)
        {
            var result = await _manager.GetMembers(memberId);
            return Ok(result.TransformToDto());
        }
    }
}
