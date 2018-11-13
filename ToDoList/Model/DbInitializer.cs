using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace ToDoList.Model
{
    public class DbInitializer : CreateDatabaseIfNotExists<TodoDbContext>
    {
        protected override void Seed(TodoDbContext context)
        {
            base.Seed(context);
            var plist = new List<Priority>
            {
                new Priority{Num = 1,DisplayValue="最優先"},
                new Priority{Num = 2,DisplayValue="高"},
                new Priority{Num = 3,DisplayValue="中"},
                new Priority{Num = 4,DisplayValue="低"},
                new Priority{Num = 5,DisplayValue="Pending"},
            };
            plist.ForEach(x => context.Priorities.Add(x));
            var tlist = new List<TodoType>
            {
                new TodoType{TypeName = "Job",Description="仕事のTodo"},
                new TodoType{TypeName = "HomeWork",Description="家事"},
                new TodoType{TypeName = "Game",Description="ゲーム"},
                new TodoType{TypeName = "Programing",Description="プログラム"},
                new TodoType{TypeName = "Structure Environment",Description="環境構築"},
            };
            tlist.ForEach(x => context.TodoTypes.Add(x));
            context.SaveChanges();
        }
    }
}
