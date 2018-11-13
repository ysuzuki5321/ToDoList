using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{

    public class Priority : MasterBase
    {
        public int Num { get; set; }
        public string DisplayValue { get; set; }
    }
}
