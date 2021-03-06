using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAngular.Models
{
    public class MyContextDB:DbContext
    {
        public MyContextDB(DbContextOptions<MyContextDB>options):base(options) {
        }

        public DbSet<Message>Message { get; set; }
    }

    public class Message
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string text { get; set; }
    }
}
