using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateClassLib
{
    public class ClockSetup
    {
        private IClockSetupState yearState;
        private IClockSetupState monthState;
        private IClockSetupState dayState;
        private IClockSetupState finishedState;

        private IClockSetupState currentState;

        public ClockSetup()
        {
            yearState = new YearState(this);
            monthState = new MonthState(this);
            dayState = new DayState(this);
            finishedState = new FinishedState(this);

            currentState = finishedState;
        }

        public virtual IClockSetupState State
        {
            set { currentState = value; }
           
        }

        public virtual void RotateLeft()
        {
            currentState.PreviousValue();
        }
        public virtual void RotateRight()
        {
            currentState.NextValue();
        }

         public virtual void PushKnob()
        {
            currentState.SelectValue();
        }

        public virtual IClockSetupState YearState
        {
            get { return yearState; }
            set { yearState = value; }
        }
        public virtual IClockSetupState MonthState
        {
            get { return monthState; }
            set { monthState = value; }
        }
        public virtual IClockSetupState DayState
        {
            get { return dayState; }
            set { dayState = value; }
        }

        public virtual IClockSetupState FinishedState
        {
            get { return finishedState; }
            set { finishedState = value; }
        }

        public virtual DateTime GetSelectedDate
        {
            get { return new DateTime(yearState.SelectedValue,monthState.SelectedValue,dayState.SelectedValue); }
        }
    }
}
