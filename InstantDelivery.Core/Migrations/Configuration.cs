using InstantDelivery.Core.Entities;

namespace InstantDelivery.Core.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<InstantDelivery.Core.InstantDeliveryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "InstantDelivery.Core.InstantDeliveryContext";
        }

        protected override void Seed(InstantDelivery.Core.InstantDeliveryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Employees.AddOrUpdate(new Employee
            {
                FirstName = "Johnny",
                LastName = "Rambo",
                Gender = Gender.Male
            });
            context.SaveChanges();
        }
    }
}
