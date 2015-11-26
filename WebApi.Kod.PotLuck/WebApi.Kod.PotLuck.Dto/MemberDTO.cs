using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Kod.PotLuck.Dto
{
    public class MemberDTO
    {

        public int MemberId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NickName { get; set; }

        public string AddressLineOne { get; set; }

        public string HouseNumber { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string City { get; set; }

        public string Email { get; set; }

        public string ContactPhoneNumber { get; set; }
    }
}
