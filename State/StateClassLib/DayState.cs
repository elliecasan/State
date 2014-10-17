using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateClassLib
{
    public class DayState : IClockSetupState
    {
        public void PreviousValue()
        {
            throw new NotImplementedException();
        }

        public void NextValue()
        {
            throw new NotImplementedException();
        }

        public void SelectValue()
        {
            throw new NotImplementedException();
        }

        public string Instructions { get; private set; }
        public int SelectedValue { get; private set; }
    }
}
