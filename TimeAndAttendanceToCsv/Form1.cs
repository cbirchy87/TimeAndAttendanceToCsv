using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using TimeAndAttendanceToCsv.Models;

namespace TimeAndAttendanceToCsv
{
    public partial class Form1 : Form
    {
        TimeAttLogic tal;
        appsettingsModel settings;
        public Form1()
        {
            InitializeComponent();
            tal =  new TimeAttLogic();
            GetSettings();
        }

        private async void btn_GetCSV_Click(object sender, EventArgs e)
        {
           // await tal.GetTimeAndAttendanceData(settings);
            await tal.GetCustomTimeAndAttendanceData(settings);
            tal.createCustomCSV();
           // tal.createCSV();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void GetSettings()
        {
            settings = JsonConvert.DeserializeObject<appsettingsModel>(File.ReadAllText(@"appsettings.json"));
        }
    }
}