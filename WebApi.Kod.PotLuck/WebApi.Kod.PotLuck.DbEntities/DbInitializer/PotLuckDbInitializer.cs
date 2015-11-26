using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Kod.PotLuck.DbEntities.DataContext;
using WebApi.Kod.PotLuck.DbEntities.Entities;

namespace WebApi.Kod.PotLuck.DbEntities.DbInitializer
{
    public class PotLuckDbInitializer : DropCreateDatabaseIfModelChanges<PotLuckContext>
    {
        protected override void Seed(PotLuckContext context)
        {
            var members1 = new List<Member>
            {
                new Member{AddressLineOne="Test Address 1",City="Test City",ContactPhoneNumber="123-777-7656",CreatedBy=1,CreatedTime=DateTime.Now,Email="test@gmail.com",FirstName="Test",HouseNumber="1234",LastName="Test LastName",LastUpdatedBy=1,LastUpdatedTime=DateTime.Now,NickName="Test Nick",State="CT",Zip="17112"}
            };
            var members2 = new List<Member>
            {
                new Member{AddressLineOne="Test Address 2",City="Test City",ContactPhoneNumber="123-777-7656",CreatedBy=1,CreatedTime=DateTime.Now,Email="test@gmail.com",FirstName="Test",HouseNumber="1234",LastName="Test LastName",LastUpdatedBy=1,LastUpdatedTime=DateTime.Now,NickName="Test Nick",State="CT",Zip="17112"}
            };
            var plEvent = new List<PotLuckEvent>
            {
                new PotLuckEvent{CreatedBy=1,CreatedTime=DateTime.Now,EventAddressLineOne="Main Street",EventCity="Maryland Heights",EventDateTimeFrom=DateTime.Now,EventDateTimeTill=DateTime.Now,EventDescription="Test",EventName="Test Event 1",EventState="MO",EventZip="63043",LastUpdatedBy=1,LastUpdatedTime=DateTime.Now,EventMembers=members1},
                new PotLuckEvent{CreatedBy=1,CreatedTime=DateTime.Now,EventAddressLineOne="Main Street",EventCity="Maryland Heights",EventDateTimeFrom=DateTime.Now,EventDateTimeTill=DateTime.Now,EventDescription="Test",EventName="Test Event 2",EventState="MO",EventZip="63043",LastUpdatedBy=1,LastUpdatedTime=DateTime.Now,EventMembers=members2},

            };

            plEvent.ForEach(x => context.PLEvent.Add(x));
            context.SaveChanges();
        }
    }
}
