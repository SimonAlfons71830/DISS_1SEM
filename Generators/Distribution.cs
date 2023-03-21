using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISS_1SEM
{
    public abstract class Distribution<T>
    {
        public abstract T Next();
    }
}
