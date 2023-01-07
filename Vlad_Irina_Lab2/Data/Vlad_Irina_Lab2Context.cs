using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vlad_Irina_Lab2.Models;

namespace Vlad_Irina_Lab2.Data
{
    public class Vlad_Irina_Lab2Context : DbContext
    {
        public Vlad_Irina_Lab2Context (DbContextOptions<Vlad_Irina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Vlad_Irina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Vlad_Irina_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Vlad_Irina_Lab2.Models.Author> Author { get; set; }

        public DbSet<Vlad_Irina_Lab2.Models.Category> Category { get; set; }

        public DbSet<Vlad_Irina_Lab2.Models.Member> Member { get; set; }

        public DbSet<Vlad_Irina_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
