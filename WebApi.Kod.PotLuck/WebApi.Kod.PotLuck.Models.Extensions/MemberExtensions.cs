using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.Dto;

namespace WebApi.Kod.PotLuck.Models.Extensions
{
    public static class MemberExtensions
    {
        public static MemberDTO TransformToDto(this MemberMdl model)
        {
            Mapper.CreateMap<MemberMdl, MemberDTO>();
            MemberDTO dto = Mapper.Map<MemberDTO>(model);
            return dto;
        }

        public static IEnumerable<MemberDTO> TransformToDto(this IEnumerable<MemberMdl> model)
        {

            foreach (MemberMdl mdl in model)
            {
                yield return mdl.TransformToDto();
            }
        }
    }
}
