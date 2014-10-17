using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateClassLib
{
    public class YearState : IClockSetupState
    {
        private ClockSetup clockSetup;
        private int year;

        public YearState(ClockSetup clockSetup, int year)
        {
            this.clockSetup = clockSetup;
            this.year = year;
        }

        public YearState(ClockSetup clockSetup1)
        {
            this.clockSetup = clockSetup1;
        }

        public void PreviousValue()
        {
            year--;
        }

        public void NextValue()
        {
            year++;
        }

        public void SelectValue()
        {
            Console.WriteLine("Year set to: '" + year + "'");
            clockSetup.State = clockSetup.YearState;
        }

        public virtual string Instructions { get { return "Please set the year..."; } }
        public virtual int SelectedValue { get { return year; } }
    }
}
