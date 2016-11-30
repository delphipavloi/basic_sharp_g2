using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public class RcItemSaver<T> : IRcSaver<T> where T : RcItem
    {
        T[] items;

        public T Get(int id)
        {
            items = new T[10];

            throw new NotImplementedException();
        }

        public void Save(T rcObject)
        {
            throw new NotImplementedException();
        }
    }
}
