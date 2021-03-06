﻿using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Examples
{
    public class SchedulerListenerExample : ISchedulerListener
    {

        public void JobAdded(IJobDetail jobDetail)
        {
            Console.WriteLine("The scheduler called {0} for job {1}", MethodBase.GetCurrentMethod().Name, jobDetail.Key);
        }

        public void JobDeleted(JobKey jobKey)
        {
            Console.WriteLine("The scheduler called {0} for job {1}", MethodBase.GetCurrentMethod().Name, jobKey);
        }

        public void JobPaused(JobKey jobKey)
        {
            Console.WriteLine("The scheduler called {0} for job {1}", MethodBase.GetCurrentMethod().Name, jobKey);
        }

        public void JobResumed(JobKey jobKey)
        {
            Console.WriteLine("The scheduler called {0} for job {1}", MethodBase.GetCurrentMethod().Name, jobKey);
        }

        public void JobScheduled(ITrigger trigger)
        {
            Console.WriteLine("The scheduler called {0} for job {1}, caused by trigger {2}", MethodBase.GetCurrentMethod().Name, trigger.JobKey, trigger.Key);
        }

        public void JobUnscheduled(TriggerKey triggerKey)
        {
            Console.WriteLine("The scheduler called {0}", MethodBase.GetCurrentMethod().Name);
        }

        public void JobsPaused(string jobGroup)
        {
            Console.WriteLine("The scheduler called {0}", MethodBase.GetCurrentMethod().Name);
        }

        public void JobsResumed(string jobGroup)
        {
            Console.WriteLine("The scheduler called {0}", MethodBase.GetCurrentMethod().Name);
        }

        public void SchedulerError(string msg, SchedulerException cause)
        {
            Console.WriteLine("The scheduler called {0}. The cause was {1}", MethodBase.GetCurrentMethod().Name, cause);
        }

        public void SchedulerInStandbyMode()
        {
            Console.WriteLine("The scheduler called {0}", MethodBase.GetCurrentMethod().Name);
        }

        public void SchedulerShutdown()
        {
            Console.WriteLine("The scheduler called {0}", MethodBase.GetCurrentMethod().Name);
        }

        public void SchedulerShuttingdown()
        {
            Console.WriteLine("The scheduler called {0}", MethodBase.GetCurrentMethod().Name);
        }

        public void SchedulerStarted()
        {
            Console.WriteLine("The scheduler called {0}", MethodBase.GetCurrentMethod().Name);
        }

        public void SchedulerStarting()
        {
            Console.WriteLine("The scheduler called {0}", MethodBase.GetCurrentMethod().Name);
        }

        public void SchedulingDataCleared()
        {
            Console.WriteLine("The scheduler called {0}", MethodBase.GetCurrentMethod().Name);
        }

        public void TriggerFinalized(ITrigger trigger)
        {
            Console.WriteLine("The scheduler called {0} for trigger {1}, belonging to job {2}", MethodBase.GetCurrentMethod().Name, trigger.Key,trigger.JobKey);
        }

        public void TriggerPaused(TriggerKey triggerKey)
        {
            Console.WriteLine("The scheduler called {0} for trigger {1}", MethodBase.GetCurrentMethod().Name,triggerKey);
        }

        public void TriggerResumed(TriggerKey triggerKey)
        {
            Console.WriteLine("The scheduler called {0} for trigger {1}", MethodBase.GetCurrentMethod().Name, triggerKey);
        }

        public void TriggersPaused(string triggerGroup)
        {
            Console.WriteLine("The scheduler called {0}", MethodBase.GetCurrentMethod().Name);
        }

        public void TriggersResumed(string triggerGroup)
        {
            Console.WriteLine("The scheduler called {0}", MethodBase.GetCurrentMethod().Name);
        }
    }
}
