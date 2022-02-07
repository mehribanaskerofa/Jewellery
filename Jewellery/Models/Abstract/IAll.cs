using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery.Models.Abstract
{
     public interface IAll<T>
    {
        List<T> GotAll();
        void Updated(T t);
        void Deleted(T t);
        void Added(T t);
    }
}
