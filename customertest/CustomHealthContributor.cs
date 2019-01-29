using Steeltoe.Common.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace customertest
{
    public class CustomHealthContributor : IHealthContributor
    {
        public string Id => "CustomHealthContributor";

        public HealthCheckResult Health()
        {
            var result = new HealthCheckResult
            {
                // this is used as part of the aggregate, it is not directly part of the middleware response
                Status = HealthStatus.DOWN,
                Description = "This health check does not check anything"
            };
            result.Details.Add("status", HealthStatus.UP.ToString());
            return result;
        }
    }
}
