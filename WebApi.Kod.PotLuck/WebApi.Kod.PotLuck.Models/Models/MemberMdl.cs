using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.Models;

namespace WebApi.Kod.PotLuck.Models
{
    public class MemberMdl
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

        public ICollection<EventMdl> Events { get; set; }
    }
}
