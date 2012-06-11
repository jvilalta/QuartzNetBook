using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using Common.Logging;

namespace Examples
{
    class JobListenerExample : IJobListener
    {
        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            logger.Info("JobExecutionVetoed");
        }

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            logger.Info("JobToBeExecuted");
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            logger.Info("JobWasExecuted");
        }

        public string Name
        {
            get { return "JobListenerExample"; }
        }
        private static readonly ILog logger = LogManager.GetLogger(typeof(JobListenerExample));
    }
}
