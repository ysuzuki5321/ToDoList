using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ToDoList.Model
{
    public class TodoType : MasterBase
    {
        public string TypeName { get; set; }
        public string Description { get; set; }
    }
}