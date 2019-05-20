namespace WebApplication6
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebApplication6.Models;

    public class LogContext : DbContext
    {
        
        public LogContext()
            : base("name=LogContext")
        {
        }

        public DbSet<Log> Logs {get; set; }

      
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}