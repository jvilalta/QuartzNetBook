using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples
{
    public class SchedulerListenerExample : ISchedulerListener
    {

        public void JobAdded(IJobDetail jobDetail)
        {
            throw new NotImplementedException();
        }

        public void JobDeleted(JobKey jobKey)
        {
            throw new NotImplementedException();
        }

        public void JobPaused(JobKey jobKey)
        {
            throw new NotImplementedException();
        }

        public void JobResumed(JobKey jobKey)
        {
            throw new NotImplementedException();
        }

        public void JobScheduled(ITrigger trigger)
        {
            throw new NotImplementedException();
        }

        public void JobUnscheduled(TriggerKey triggerKey)
        {
            throw new NotImplementedException();
        }

        public void JobsPaused(string jobGroup)
        {
            throw new NotImplementedException();
        }

        public void JobsResumed(string jobGroup)
        {
            throw new NotImplementedException();
        }

        public void SchedulerError(string msg, SchedulerException cause)
        {
            throw new NotImplementedException();
        }

        public void SchedulerInStandbyMode()
        {
            throw new NotImplementedException();
        }

        public void SchedulerShutdown()
        {
            throw new NotImplementedException();
        }

        public void SchedulerShuttingdown()
        {
            throw new NotImplementedException();
        }

        public void SchedulerStarted()
        {
            throw new NotImplementedException();
        }

        public void SchedulerStarting()
        {
            throw new NotImplementedException();
        }

        public void SchedulingDataCleared()
        {
            throw new NotImplementedException();
        }

        public void TriggerFinalized(ITrigger trigger)
        {
            throw new NotImplementedException();
        }

        public void TriggerPaused(TriggerKey triggerKey)
        {
            throw new NotImplementedException();
        }

        public void TriggerResumed(TriggerKey triggerKey)
        {
            throw new NotImplementedException();
        }

        public void TriggersPaused(string triggerGroup)
        {
            throw new NotImplementedException();
        }

        public void TriggersResumed(string triggerGroup)
        {
            throw new NotImplementedException();
        }
    }
}
