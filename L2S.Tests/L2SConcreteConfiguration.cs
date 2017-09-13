using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2S.Tests
{
    class L2SConcreteConfiguration : L2SConfiguration
    {
        public override void Configure()
        {
            Connection = new SqlConnection("Server=.\\LOCALINSTANCE;Database=Tests;Trusted_Connection=true;");
        }
    }
}
