using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAndAttendanceCSV.Core.Models
{
    public  class EventDataModel
    {
        public DateTime eventTime { get; set; }
       // public int id { get; set; }
        public string deviceName { get; set; }
        public object cardNo { get; set; }
      //  public int eventType { get; set; }
        public string eventDescription { get; set; }
      //  public int eventSubType { get; set; }
        public string eventDetails { get; set; }
        public object linkedEvent { get; set; }
        public string firstName { get; set; }
        public object middleName { get; set; }
        public string surname { get; set; }
        public int userID { get; set; }
       // public int priority { get; set; }
//public int address { get; set; }
      //  public int peripheralID { get; set; }
      //  public object ioBoardID { get; set; }
      //  public int doorGroupID { get; set; }
      //  public bool deviceDeleted { get; set; }
    }
}
