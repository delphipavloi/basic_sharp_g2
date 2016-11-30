using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnection postgres = new PostgresqlConnection();
            DbConnection sqlServer = new SqlServerConnection();

            PostgresqlConnection postgresConn = new PostgresqlConnection();
            SqlServerConnection sqlServerConn = new SqlServerConnection();

            IDbConnection postgressDbConn = postgres;


            postgres = sqlServerConn;

            sqlServer = postgres;

            sqlServer = postgresConn;

            RcCarSaver rcSaver = new RcCarSaver(sqlServer);

            byte smallByte;
            int intValue = 3000;

            smallByte = (byte)intValue;
            Console.WriteLine(smallByte);
            Init(2);
            Init(242);
            Init("Hello");
            Init(postgresConn);

            RcItemSaver<RcCar> rcCarItemSaver = new RcItemSaver<RcCar>();
            
            IRcSaver<RcHeli> heliSaver = new RcHeliSaver();

            Console.ReadLine();
        }

        static void Init(object obj)
        {
            PostgresqlConnection posgtress = obj as PostgresqlConnection;
            if (posgtress != null)
            {
                posgtress.Init();
            }
        }
         
    }
}
