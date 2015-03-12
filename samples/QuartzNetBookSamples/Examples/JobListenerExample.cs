using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using Common.Logging;
using System.Reflection;

namespace Examples
{
    class JobListenerExample : IJobListener
    {
        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            Console.WriteLine("The scheduler called {0} for job {1}", MethodBase.GetCurrentMethod().Name,context.JobDetail.Key);
        }

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            Console.WriteLine("The scheduler called {0} for job {1}", MethodBase.GetCurrentMethod().Name, context.JobDetail.Key);
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            Console.WriteLine("The scheduler called {0} for job {1}", MethodBase.GetCurrentMethod().Name, context.JobDetail.Key);
        }

        public string Name
        {
            get { return "JobListenerExample"; }
        }
    }
}
