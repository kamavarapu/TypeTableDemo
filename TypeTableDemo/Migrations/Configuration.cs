namespace TypeTableDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TypeTableDemo.TypeTableContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TypeTableDemo.TypeTableContext context)
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

            if (context.StatusTypes.Any(t => t.Code.Equals("TWO")))
            {
                var two = context.StatusTypes.FirstOrDefault(t => t.Code.Equals("TWO"));
                context.StatusTypes.Remove(two);
            }

            context.StatusTypes.AddOrUpdate
            (
                new StatusType { Id = 1, Code = "ONE", Name = "One" },
                //new StatusType { Id = 2, Code = "TWO", Name = "Two" },
                new StatusType { Id = 3, Code = "THREE", Name = "Three" },
                new StatusType { Id = 4, Code = "FOUR", Name = "Four" },
                new StatusType { Id = 5, Code = "FIVE", Name = "Five" },
                new StatusType { Id = 6, Code = "SIX", Name = "Six" },
                new StatusType { Id = 7, Code = "SEVEN", Name = "Seven" }
            );
        }
    }
}