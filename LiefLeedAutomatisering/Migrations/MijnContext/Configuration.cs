namespace LiefLeedAutomatisering.Migrations.MijnContext
{
    using LiefLeedAutomatisering.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LiefLeedAutomatisering.Data.MijnContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\MijnContext";
        }

        protected override void Seed(LiefLeedAutomatisering.Data.MijnContext context)
        {
            context.Persons.AddOrUpdate(
                p => p.Name, 
                new Person { Name = "Erkan", DateOfEvent = DateTime.Now.AddYears(-25) },
                new Person { Name = "Testpersoon", DateOfEvent = DateTime.Now.AddYears(-30) }
            );
        }
    }
}
