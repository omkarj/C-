using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceDemo
{
    public partial class WindowsServiceDemo : ServiceBase
    {
        public WindowsServiceDemo()
        {
            InitializeComponent();

            if (!System.Diagnostics.EventLog.SourceExists("WindowsServiceDemoSource"))
                System.Diagnostics.EventLog.CreateEventSource("WindowsServiceDemoSource", "WindowsServiceDemoLog");

            eventLog1.Source = "WindowsServiceDemoSource";
            eventLog1.Log = "WindowsServiceDemoLog";
        }

        /*
        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("MyWindowsServiceDemo Started");
            
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 600;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();

        }
        */

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("MyWindowsServiceDemo Started");
            FileSystemWatcher watcher = new FileSystemWatcher();
            //watch();
            watcher.Path = @"D:\sampleFolder1";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "*.*";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.EnableRaisingEvents = true;
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("MyWindowsServiceDemo Stopped");
        }

        protected override void OnPause()
        {
            eventLog1.WriteEntry("MyWindowsServiceDemo Paused");
        }

        protected override void OnContinue()
        {
            eventLog1.WriteEntry("MyWindowsServiceDemo Started Again");
        }

        /*
        private void watch()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = @"D:\sampleFolder1";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "*.*";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.EnableRaisingEvents = true;
        }
        */

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry(string.Format("{0} has been modified", e.Name));
        }

        private void OnCreated(object source, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry(string.Format("{0} has been created", e.Name));
        }

        private void OnDeleted(object source, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry(string.Format("{0} has been deleted", e.Name));
        }

        private void OnRenamed(object source, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry(string.Format("{0} has been renamed", e.Name));
        }

        private void OnTimer(object sender, System.Timers.ElapsedEventArgs e)
        {
            eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information);
        }
        
    }
}
