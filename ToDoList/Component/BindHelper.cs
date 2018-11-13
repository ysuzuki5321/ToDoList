using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Model;

namespace ToDoList.Component
{
    public static class BindHelper
    {
        public static void SetUpTodoTypeBinding(this IComponent component,IEnumerable<TodoType> todoTypes)
        {
            SetUpSelfBinding(component, "TypeName", todoTypes);
        }

        public static void SetUpSelfBinding<T>(this IComponent control,string displayMember,T source)
        {
            SetupPrivateSelfBinding(control, displayMember, source);
        }

        private static void SetupPrivateSelfBinding<T>(dynamic component,string displayMember,T source)
        {
            component.DisplayMember = displayMember;
            component.ValueMember = "Self";
            component.DataSource = source;
        }
    }
}
