using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OOPRecords.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(string dbName) : base(dbName)
        {
            Database.SetInitializer(new Initializer());
        }
        
        public DbSet<Teacher> Teachers { get; set; }    
        public DbSet<Student> Students { get; set; }
    }
}
