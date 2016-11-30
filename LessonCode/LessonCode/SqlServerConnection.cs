using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public class SqlServerConnection : DbConnection
    {
        public override void Close()
        {
            Console.WriteLine("Close SQL Server connection");
        }

        public override int ExecuteQuery(string query)
        {
            Console.WriteLine($"Execute {query} in SQL Server");
            return 42;
        }

        public override void Init()
        {
            Console.WriteLine("Init of SQL Server");
        }

        public override void Open()
        {
            Console.WriteLine("Open SQL Server connection");
        }

        public override void CreateDb()
        {
            
        }


    }
}
