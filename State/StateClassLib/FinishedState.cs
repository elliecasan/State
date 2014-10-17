using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateClassLib
{
    class FinishedState : IClockSetupState
    {
        private ClockSetup clockSetup;
        public FinishedState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
        }

        public void PreviousValue()
        {
            Console.WriteLine("FinishedState Previous Value (ignored)");
        }

        public void NextValue()
        {
            Console.WriteLine("FinishedState Next Value (ignored)");
        }

        public void SelectValue()
        {
            DateTime selectedDate = clockSetup.GetSelectedDate;
            Console.WriteLine("Date set to: " + selectedDate);
            clockSetup.State = clockSetup.YearState;
        }

        public string Instructions { get { return "Press knob to view selected date."; } }

        public int SelectedValue
        {
            get { throw new System.NotSupportedException("Clock setup finished"); }
        }
    }
}
