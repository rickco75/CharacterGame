using System;
using Microsoft.EntityFrameworkCore;

namespace CharacterGame.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
    }
}
