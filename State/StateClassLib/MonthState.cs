using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateClassLib
{
    public class MonthState : IClockSetupState
    {
        private ClockSetup clockSetup;
        private int month;

        public MonthState(ClockSetup clockSetup, int month)
        {
            this.clockSetup = clockSetup;
            this.month = month;
        }
        public MonthState(ClockSetup clockSetup1)
        {
            this.clockSetup = clockSetup1;
        }

        public void PreviousValue()
        {
            if (month == 1)
            {
                month = 12;
            }
            month--;
        }

        public void NextValue()
        {
            if (month == 12)
            {
                month = 1;
            }
            month++;
        }

        public void SelectValue()
        {
            Console.WriteLine("Month set to: '" + month + "'");
            clockSetup.State = clockSetup.MonthState;
        }

        public virtual string Instructions { get { return "Please set the month..."; } }
        public virtual int SelectedValue { get { return month; } }
    }
}
