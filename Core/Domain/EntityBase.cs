using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class EntityBase<T>
    {
        public T ID { get; set; }
    }
}
