using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ToDoList.Model
{
    public class TodoDataRepository : ITodoRepository<Todo>
    {
        private TodoDbContext db = new TodoDbContext();

        public IEnumerable<Todo> AllData()
        {
            return db.Todos.ToList();
        }

        public void Delete(Todo item)
        {
            var data = db.Todos.FirstOrDefault(x => x.Id == item.Id);
            data.Deleted = true;
            UpdateData(data);
        }

        public IEnumerable<Priority> Priorities()
        {
            db.Priorities.Load();
            return db.Priorities.Local.ToBindingList();
        }

        public Todo Single<K>(K key)
        {
            throw new NotImplementedException();
        }

        public List<TodoType> TodoTypeFilterItems()
        {
            var list = db.TodoTypes.ToList();
            list.Insert(0, new TodoType { Id = -1, TypeName = "" });
            return list; 
        }

        public IEnumerable<TodoType> TodoTypes()
        {
            db.TodoTypes.Load();
            return db.TodoTypes.Local.ToBindingList();
        }

        public IEnumerable<Todo> TodoTypeFilter(TodoType type,bool withDeleteData)
        {
            db.Todos.Load();
            
            return db.Todos.Local.ToBindingList()
                .Where(x => x.TodoType.Equals(type)
                    && (!withDeleteData || !x.Deleted));
        }

        public void Add(Todo item)
        {
            item.InsertDate = DateTime.Now;
            db.Todos.Add(item);
            db.SaveChanges();
        }

        public void Update(Todo item)
        {
            var data = db.Todos.FirstOrDefault(x => x.Id == item.Id);
            if (data.Done) data.DoneDate = DateTime.Now;
            else data.DoneDate = null;
            UpdateData(data);
        }

        private void UpdateData(Todo item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public DbUpdateType TodoTableUpdate(Todo todo)
        {
            if (!todo.IsComplete())
                return DbUpdateType.NotComlete;
            if (todo.Id == 0)
            {
                Add(todo);
                return DbUpdateType.Insert;
            }
            else
            {
                Update(todo);
                return DbUpdateType.Update;
            }
        }

        public IEnumerable<Todo> ScanAllDataWithoutDeleteData()
        {
            return db.Todos.Where(x => !x.Deleted).ToList();
        }
    }
}
