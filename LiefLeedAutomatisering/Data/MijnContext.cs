using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LiefLeedAutomatisering.Models;

namespace LiefLeedAutomatisering.Data
{
    public class MijnContext : DbContext
    {
        public MijnContext() : base("name=MijnContext")
        {
        }
        public DbSet<Person> Persons { get; set; }
    }
}