using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz.Spi;
using Quartz.Impl.Matchers;
using Quartz;

namespace Examples
{
    public class PluginExample : ISchedulerPlugin
    {
        public void Initialize(string pluginName, IScheduler sched)
        {
            sched.ListenerManager.AddJobListener(new JobListenerExample(), EverythingMatcher<JobKey>.AllJobs());
            sched.ListenerManager.AddJobListener(new JobDurationListenerExample(), EverythingMatcher<JobKey>.AllJobs());
            sched.ListenerManager.AddSchedulerListener(new SchedulerListenerExample());
        }

        public void Shutdown()
        {
            //Do Nothing
        }

        public void Start()
        {
            //Do Nothing
        }
    }
}
