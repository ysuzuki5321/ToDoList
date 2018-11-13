using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    public abstract class MasterBase
    {
        public virtual int Id { get; set; }

        public virtual MasterBase Self
        {
            get
            {
                return this;
            }
        }


        public override bool Equals(object value)
        {
            var other = value as MasterBase;
            if (other == null)
                return false;

            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
