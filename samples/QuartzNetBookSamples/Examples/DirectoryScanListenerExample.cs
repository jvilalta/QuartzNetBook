﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz.Job;
using System.IO;
using Common.Logging;
using Quartz;

namespace Examples
{
    public class DirectoryScanListenerExample : IDirectoryScanListener, IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            logger.Info("Adding the listener to the context");
            context.Scheduler.Context.Add("DirectoryScanListenerExample", new DirectoryScanListenerExample());
            logger.Info("Added the listener to the context");
        }

        private static readonly ILog logger = LogManager.GetLogger(typeof(JobListenerExample));

        public void FilesUpdatedOrAdded(IEnumerable<FileInfo> updatedFiles)
        {
            throw new NotImplementedException();
        }
    }
}
