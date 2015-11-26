using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Kod.PotLuck.Models
{
    public class EventMdl
    {
        public int EventId { get; set; }

        public string EventName { get; set; }

        public string EventDescription { get; set; }

        public string Venue { get; set; }

        public DateTime EventDateTimeFrom { get; set; }

        public DateTime EventDateTimeTill { get; set; }

        public string EventAddressLineOne { get; set; }

        public string EventState { get; set; }

        public string EventZip { get; set; }

        public string EventCity { get; set; }

        public  ICollection<MemberMdl> Members { get; set; }
    }
}
