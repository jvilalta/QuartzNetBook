using Quartz;
using System;
using System.Reflection;

namespace Examples
{
    class TriggerListenerExample:ITriggerListener
    {
        public string Name
        {
            get { return "TriggerListenerExample"; }
        }

        public void TriggerComplete(ITrigger trigger, IJobExecutionContext context, SchedulerInstruction triggerInstructionCode)
        {
            Console.WriteLine("The scheduler called {0} for trigger {1}", MethodBase.GetCurrentMethod().Name, trigger.Key);
        }

        public void TriggerFired(ITrigger trigger, IJobExecutionContext context)
        {
            Console.WriteLine("The scheduler called {0} for trigger {1}", MethodBase.GetCurrentMethod().Name, trigger.Key);
        }

        public void TriggerMisfired(ITrigger trigger)
        {
            Console.WriteLine("The scheduler called {0} for trigger {1}", MethodBase.GetCurrentMethod().Name, trigger.Key);
        }

        public bool VetoJobExecution(ITrigger trigger, IJobExecutionContext context)
        {
            Console.WriteLine("The scheduler called {0} for trigger {1}", MethodBase.GetCurrentMethod().Name,trigger.Key);
            return false;
        }
    }
}
