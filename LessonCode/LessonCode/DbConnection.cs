using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public abstract class DbConnection : IDbConnection
    {
        public abstract void Close();
        public abstract void CreateDb();
        public abstract int ExecuteQuery(string query);
        public string GetStatus()
        {
            return "Db Status";
        }
        public abstract void Init();
        public abstract void Open();
    }
}
