using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Kod.PotLuck.DbEntities.Entities
{
    public class PotLuckEvent : BaseEntity
    {
        public PotLuckEvent()
        {
            this.EventMembers = new HashSet<Member>();
        }
       
        public string EventName { get; set; }
        
        public string EventDescription { get; set; }
     
        public string Venue { get; set; }
   
        public DateTime EventDateTimeFrom { get; set; }
       
        public DateTime EventDateTimeTill { get; set; }
       
        public string EventAddressLineOne { get; set; }
       
        public string EventState { get; set; }
       
        public string EventZip { get; set; }
      
        public string EventCity { get; set; }

        public virtual ICollection<Member> EventMembers { get; set; }
    }
}
