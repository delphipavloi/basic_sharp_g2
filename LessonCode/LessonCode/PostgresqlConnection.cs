using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public class PostgresqlConnection : DbConnection
    {
        public override void Close()
        {
            Console.WriteLine("Close Postrgresql connection");
        }

        public override int ExecuteQuery(string query)
        {
            Console.WriteLine($"Execute {query} in Postgresql");
            return 42;
        }

        public override void Init()
        {
            Console.WriteLine("Init of Postgress");
        }

        public override void Open()
        {
            Console.WriteLine("Open Postrgresql connection");
        }

        public override void CreateDb()
        {
            
        }

    }
}
