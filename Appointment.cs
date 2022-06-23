using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    internal class Appointment
    {
        public string No { get;  set; }
        public string Patient { get; set; }
        public string Doctor { get; set; }
        public DateTime StartDate;
        public DateTime EndDate;
    }
}
