using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public class RcCarSaver : IRcSaver<RcCar>
    {
        IDbConnection sqlConnection;

        public RcCarSaver(IDbConnection dbConnection)
        {
            sqlConnection = dbConnection;
            dbConnection.Open();                   
        }

        public RcCar Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(RcCar rcObject)
        {
            throw new NotImplementedException();
        }
    }
}
