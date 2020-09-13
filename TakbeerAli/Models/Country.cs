using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TakbeerAli.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }

        public string Capital { get; set; }
    }

    public class CountryDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
    }
}