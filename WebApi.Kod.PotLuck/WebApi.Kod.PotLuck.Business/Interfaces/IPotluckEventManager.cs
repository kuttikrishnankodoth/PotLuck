using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.Models;
namespace WebApi.Kod.PotLuck.Business.Interfaces
{
    public interface IPotluckEventManager
    {
        Task<IEnumerable<EventMdl>> GetEvents();
    }
}
