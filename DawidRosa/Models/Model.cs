using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<Data> Datas { get; set; }
    }

    public class Data
    {
        public int Id { get; set; }
        public string NameAndSurname { get; set; }
        public string Reason { get; set; }
        
    }
}

