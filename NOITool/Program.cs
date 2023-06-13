using System.Diagnostics;
using System;
using System.IO;
using static NOITool.NOITool;

namespace NOITool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Logger.Log("窗口启动");
            Application.Run(new NOITool());
            Logger.Log("窗口结束运行");


        }

    }
}