using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Resource<T>
    {
        public Guid Id { get; }
        public T? Value { get; set; }

        public Resource()
        {
            Id = Guid.NewGuid();
        }
    }
}
