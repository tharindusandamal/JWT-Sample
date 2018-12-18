using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            JWTHelper jWTHelper = new JWTHelper();

            var payload = new Dictionary<string, object>
            {
                { "claim1", 0 },
                { "claim2", "claim2-value" }
            };

            var t = jWTHelper.GetToken(payload);

            var d = jWTHelper.GetData(t);
        }
    }
}
