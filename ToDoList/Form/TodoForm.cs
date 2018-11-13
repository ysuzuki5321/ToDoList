using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Model;
using ToDoList.Component;
using MetroFramework.Forms;
using ToDoList.Helper;

namespace ToDoList
{
    public partial class TodoForm : MetroForm
    {
        private ITodoRepository<Todo> repository;

        public TodoForm(ITodoRepository<Todo> _repository)
        {
            repository = _repository;
            InitializeComponent();
        }

        private void Todo_Load(object sender, EventArgs e)
        {
            TodoGrid.SetupGrid(repository);
            var items = repository.TodoTypeFilterItems();
            
            TodoTypeFilter.SetUpTodoTypeBinding(items);
        }

        private void TodoTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TodoGrid.TodoTypeFilter(TodoTypeFilter.SelectedItem as TodoType,VisibleDeleteData.Checked);
        }

        private void VisibleDeleteData_CheckedChanged(object sender, EventArgs e)
        {
            if (VisibleDeleteData.Checked) TodoGrid.AllData();
            else TodoGrid.WithoutDeleteData();
        }
    }
}
