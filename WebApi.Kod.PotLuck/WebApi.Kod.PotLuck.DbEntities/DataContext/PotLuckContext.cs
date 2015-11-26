using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.DbEntities.DataBaseConfiguration;
using WebApi.Kod.PotLuck.DbEntities.DbInitializer;
using WebApi.Kod.PotLuck.DbEntities.Entities;

namespace WebApi.Kod.PotLuck.DbEntities.DataContext
{

    public class PotLuckContext : DbContext
    {
        public PotLuckContext()
            : base("PotLuckConnection")
        {
            Database.SetInitializer(new PotLuckDbInitializer());
        }
        public IDbSet<PotLuckEvent> PLEvent { get; set; }
        public IDbSet<Member> EventMember { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new MemberConfig());
            modelBuilder.Configurations.Add(new PotLuckEventConfig());

        }
    }
}
