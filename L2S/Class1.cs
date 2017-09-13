using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2S
{
    public abstract class L2SConfiguration
    {
        protected IDbConnection Connection { private get; set; }
        public abstract void Configure();
    }
}
