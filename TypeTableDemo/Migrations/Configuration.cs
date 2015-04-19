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
                //new StatusType { Id = 6, Code = "SIX", Name = "Six" },
                //new StatusType { Id = 7, Code = "SEVEN", Name = "Seven" },
                //new StatusType { Id = 8, Code = "EIGHT", Name = "Eight" },
                //new StatusType { Id = 9, Code = "NINE", Name = "Nine" },
                //new StatusType { Id = 10, Code = "TEN", Name = "Ten" },
                //new StatusType { Id = 11, Code = "ELEVEN", Name = "Eleven" },
                //new StatusType { Id = 15, Code = "FIFTEEN", Name = "Fifteen" },
                new StatusType { Id = 20, Code = "TWENTY", Name = "Twenty" }
            );
        }
    }
}