namespace ToDoList.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class TodoDbContext : DbContext
    {
        //// コンテキストは、アプリケーションの構成ファイル (App.config または Web.config) から 'TodoDbContext' 
        //// 接続文字列を使用するように構成されています。既定では、この接続文字列は LocalDb インスタンス上
        //// の 'ToDoList.Model.TodoDbContext' データベースを対象としています。 
        //// 
        //// 別のデータベースとデータベース プロバイダーまたはそのいずれかを対象とする場合は、
        //// アプリケーション構成ファイルで 'TodoDbContext' 接続文字列を変更してください。
        //public TodoDbContext()
        //    : base("name=TodoDbContext")
        //{
        //}

        //// モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
        //// 詳細については、http://go.microsoft.com/fwlink/?LinkId=390109 を参照してください。

        public DbSet<Todo> Todos { get; set; }
        public DbSet<Priority> Priorities　{ get; set; }
        public DbSet<TodoType> TodoTypes { get; set; }
    }

}