using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.Dto;

namespace WebApi.Kod.PotLuck.Models.Extensions
{
    public static class EventExtensions
    {
        public static EventDTO TransformToDto(this EventMdl model)
        {
            Mapper.CreateMap<EventMdl, EventDTO>();
            EventDTO dto = Mapper.Map<EventDTO>(model);
            return dto;
        }

        public static IEnumerable<EventDTO> TransformToDto(this IEnumerable<EventMdl> model)
        {

            foreach (EventMdl mdl in model)
            {
                yield return mdl.TransformToDto();
            }
        }
    }
}
