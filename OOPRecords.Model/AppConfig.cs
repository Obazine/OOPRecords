using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRecords.Model
{
    public class AppConfig
    {
        public static Type[] Services()
        {
            return new[] {typeof(StudentRepository)};
        }

        public static IDictionary<string, Type> MainMenus()
        {
            return new Dictionary<string, Type>()
            {
                ["Students"] = typeof(StudentRepository)
            };
        }

        public static DbContext CreateDbContext()
        {
            return new DatabaseContext("OOPRecords");
        }
    }
}
