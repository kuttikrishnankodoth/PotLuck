using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Kod.PotLuck.DbEntities.Entities
{
    public class Member : BaseEntity
    {
        public Member()
        {
            this.MyEvents = new HashSet<PotLuckEvent>();
        }
        
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

        public virtual ICollection<PotLuckEvent> MyEvents { get; set; }
    }
}
