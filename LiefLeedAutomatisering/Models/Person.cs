using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiefLeedAutomatisering.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        public string Name { get; set; }
        public DateTime DateOfEvent { get; set; }
    }
}