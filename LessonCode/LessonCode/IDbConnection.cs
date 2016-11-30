using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public interface IDbConnection : IInitable
    {
        void Open();

        void Close();

        int ExecuteQuery(string query);

        string GetStatus();
    }
}
