using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main()
        {
            var Database = new BlogDbContext();
            var query = Database.Posts.Where(p => p.Body.Length > 18);
            Console.WriteLine(query);
            foreach (var p in query)
            {
                Console.WriteLine(p.Body);
            }
        }
    }
}
