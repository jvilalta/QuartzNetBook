using Quartz;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Examples
{
    class JobDurationListenerExample : IJobListener
    {
        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            // Do nothing
        }

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Job {0} in group {1} is about to be executed", context.JobDetail.Key.Name, context.JobDetail.Key.Group);
            _Stopwatches.Add(context.FireInstanceId, stopwatch);
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            var elapsed = _Stopwatches[context.FireInstanceId].ElapsedMilliseconds;
            Console.WriteLine("Job {0} in group {1} was executed in {2}ms", context.JobDetail.Key.Name, context.JobDetail.Key.Group, elapsed);
        }

        public string Name
        {
            get { return "JobDurationListener"; }
        }
        private Dictionary<string, Stopwatch> _Stopwatches = new Dictionary<string, Stopwatch>();
    }
}
