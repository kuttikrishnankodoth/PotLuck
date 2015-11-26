using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Kod.PotLuck.DbEntities.Entities
{
    public  abstract class BaseEntity
    {
        [Column(Order = 1)]
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }
        public int CreatedBy { get; set; }
        public int LastUpdatedBy { get; set; }
    }
}
