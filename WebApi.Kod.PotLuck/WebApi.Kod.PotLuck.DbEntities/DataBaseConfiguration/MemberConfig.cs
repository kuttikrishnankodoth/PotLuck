using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.DbEntities.Entities;

namespace WebApi.Kod.PotLuck.DbEntities.DataBaseConfiguration
{
    public class MemberConfig : EntityTypeConfiguration<Member>
    {
        public MemberConfig()
        {
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(c => c.Id);
        }

    }
}
