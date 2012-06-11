using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz.Impl;
using System.Collections.Specialized;
using System.Threading;

namespace EmbeddedScheduler
{
	class Program
	{
		static void Main(string[] args)
		{
			var factory = new StdSchedulerFactory();
			var scheduler = factory.GetScheduler();
			scheduler.Start();
			while (!scheduler.IsStarted)
			{
				Console.WriteLine("Waiting for scheduler to start.");
				Thread.Sleep(1000);
			}
			Console.WriteLine("IsStarted={0}", scheduler.IsStarted);
			Console.WriteLine("SchedulerInstanceId={0}", scheduler.SchedulerInstanceId);
			Console.WriteLine("SchedulerName={0}", scheduler.SchedulerName);
			Console.WriteLine("The scheduler is running. Press any key to stop");
			Console.ReadKey();
			Console.WriteLine("Shutting down scheduler");
			scheduler.Shutdown(false);
			while (!scheduler.IsShutdown)
			{
				Console.WriteLine("Waiting for scheduler to shutdown.");
				Thread.Sleep(1000);
			}
			Console.WriteLine("IsShutdown={0}", scheduler.IsShutdown);
			Console.WriteLine("The scheduler has been shutdown.");
		}

	}
}

