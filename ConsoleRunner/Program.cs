using Newtonsoft.Json;
using TimeAndAttendanceCSV.Core;
using TimeAndAttendanceCSV.Core.Models;

namespace ConsoleRunner
{
    internal class Program
    {
        static TimeAttLogic tal;
        static appsettingsModel settings;
        static string to, from;
        static async Task Main(string[] args)
        {
            if (args.Count() == 2)
            {
                to = args[0];
                from = args[1];
            }
            else
            {
                to = DateTime.Now.AddYears(-100).ToString();
                from = DateTime.Now.ToString();
            }
            
            tal = new TimeAttLogic();
            GetSettings();
            await tal.GetCustomTimeAndAttendanceData(settings, to, from);
            tal.createCustomCSV();
        }
        private static void GetSettings()
        {
            settings = JsonConvert.DeserializeObject<appsettingsModel>(File.ReadAllText(@"appsettings.json"));
        }
    }
}