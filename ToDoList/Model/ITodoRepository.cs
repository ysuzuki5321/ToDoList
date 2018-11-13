using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    public enum DbUpdateType
    {
        Insert,
        Update,
        Quiet,
        NotComlete,
    }
    public interface ITodoRepository<T> : IRepository<T>
    {
        IEnumerable<Priority> Priorities();

        IEnumerable<TodoType> TodoTypes();

        IEnumerable<Todo> TodoTypeFilter(TodoType type,bool withDeleteData);

        IEnumerable<Todo> ScanAllDataWithoutDeleteData();

        List<TodoType> TodoTypeFilterItems();

        DbUpdateType TodoTableUpdate(T item);

        
    }
}
