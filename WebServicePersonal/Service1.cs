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
using System.Timers;

namespace WebServicePersonal
{
    public partial class Service1 : ServiceBase
    {
        Timer timer = new Timer();
        

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WritetoFile("Service Started at " + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 5000; //milliseconds
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            WritetoFile("Service Stopped at" + DateTime.Now);
        }

        private void OnElapsedTime(object sender, ElapsedEventArgs e)
        {
            WritetoFile("Service is recall at " + DateTime.Now);
        }

        private void WritetoFile(String Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.ToShortDateString().Replace('/', '_') + ".txt";

            if (!File.Exists(filepath))
            {
                //create a file to write to
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }

            }
            
        }
    }
}
