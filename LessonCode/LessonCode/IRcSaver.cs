using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public interface IRcSaver<T> where T : RcItem
    {
        void Save(T rcObject);
        T Get(int id);
    }
}
