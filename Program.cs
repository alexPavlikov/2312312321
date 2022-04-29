using Serilog;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;


namespace Airport_v2
{
    static class Status
    {
        public static bool Value { get; set; }
        public static bool Enter { get; set; }
        public static int Id { get; set; }
        public static bool Update { get; set; }
        public static string User { get; set; }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());



            //Log.Logger = new LoggerConfiguration()
            //    .MinimumLevel.Information().WriteTo.File("logs.log", rollingInterval: RollingInterval.Month, outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] {Message}{NewLine}{Exception}")
            //    .CreateLogger();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            //Log.CloseAndFlush();

        }
    }
}
