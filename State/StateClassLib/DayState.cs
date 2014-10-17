using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateClassLib
{
    public class DayState : IClockSetupState
    {
        private ClockSetup clockSetup;
        private int day;

        public DayState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            day = DateTime.Now.Day;
        }

        public void PreviousValue()
        {
            if (day == 1)
            {
                day = 31;
            }
            day--;
        }

        public void NextValue()
        {
            if (day == 31)
            {
                day = 1;
            }
            day++;
        }

        public void SelectValue()
        {
            Console.WriteLine("Day set to: '" + day + "'");
            clockSetup.State = clockSetup.DayState;
        }

        public virtual string Instructions { get { return "Please set the day..."; } }
        public virtual int SelectedValue { get { return day; } }
    }
}
