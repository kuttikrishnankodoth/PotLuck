using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.DbEntities.Entities;

namespace WebApi.Kod.PotLuck.DbEntities.DataBaseConfiguration
{
    public class PotLuckEventConfig : EntityTypeConfiguration<PotLuckEvent>
    {
        public PotLuckEventConfig()
        {
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(c => c.Id);

            HasMany(c => c.EventMembers)
                .WithMany(c => c.MyEvents)
                .Map(m =>
                        {
                            m.ToTable("EventMember");
                            m.MapLeftKey("PotLuckEventId");
                            m.MapRightKey("MemberId");
                        }
                    );
        }
    }
}
