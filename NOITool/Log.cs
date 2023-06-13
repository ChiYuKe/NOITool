using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NOITool.NOITool;

namespace NOITool
{
    public static class Logger
    {

        //private static List<string> logMessages = new List<string>();

        //public static void Log(string message)
        //{

        //    logMessages.Add(message);
        //}

        //public static void FlushLogToFile(string filePath)
        //{
        //    File.WriteAllLines(filePath, logMessages);
        //}
        ////获取时间戳
        //public static void LogTime()
        //{
        //    DateTimeOffset now = DateTimeOffset.Now;
        //    long timestamp = now.Ticks;
        //    string LTimeText = "[" + timestamp + "]";

        //}


        private static List<string> logMessages = new List<string>();

        public static void Log(string message)
        {
            logMessages.Add(GetTimestamp() + " " + message);
            string folderPath = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(folderPath, "NOITool_log.log");
            File.WriteAllLines(filePath, logMessages);
        }

        //public static void FlushLogToFile()
        //{
        //    string folderPath = Directory.GetCurrentDirectory();
        //    string filePath = Path.Combine(folderPath, "NOITool_log.log");
        //    File.WriteAllLines(filePath, logMessages);
        //}
        //获取时间戳
        private static string GetTimestamp()
        {
            DateTimeOffset now = DateTimeOffset.Now;
            long timestamp = now.Ticks;
            return "[" + timestamp + "]";
        }

    }
}
