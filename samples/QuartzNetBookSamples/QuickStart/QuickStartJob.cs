using System;
using System.IO;
using Quartz;

namespace QuickStart
{
	public class QuickStartJob : IJob
	{
		public void Execute(IJobExecutionContext context)
		{
			var fileName = "QuickStartJob_runs.txt";
			using (StreamWriter writer = new StreamWriter(File.Open(fileName, FileMode.Append)))
			{
				writer.WriteLine(DateTime.Now.ToString());
				writer.Flush();
				writer.Close();
			}
		}
	}
}
