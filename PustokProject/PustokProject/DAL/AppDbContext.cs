using Microsoft.EntityFrameworkCore;
using PustokProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<HomeFeature> HomeFeatures { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
