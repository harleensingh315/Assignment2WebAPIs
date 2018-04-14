using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2_Part2.Models
{
    public class ProjectModels: DbContext
    {
        public ProjectModels(DbContextOptions<ProjectModels>options) : base(options){

        }
        
        public ProjectModels() { }
        public DbSet<Screens> Screen { get; set; }
        public DbSet<Theaters> Theater { get; set; }
    }
}
