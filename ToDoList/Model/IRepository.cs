using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    public interface IRepository<T>
    {
        T Single<K>(K key);

        IEnumerable<T> AllData();

        void Add(T item);

        void Update(T item);

        void Delete(T item);
    }
}
