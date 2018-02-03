using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstromechDroidVirtualPet
{
    public class AstromechDroid
    {
        // Fields
        private bool isClean;
        private bool isBattery;
        private bool isWheel;

        // Properties
        public bool IsClean
        {
            get { return this.isClean; }
            set { this.isClean = value; }
        }

        public bool IsBattery
        {
            get { return this.isBattery; }
            set { this.isBattery = value; }
        }

        public bool IsWheel
        {
            get { return this.isWheel; }
            set { this.isWheel = value; }
        }
        // Constructor
        public AstromechDroid()
        {
            // Default Constructor
        }

        public AstromechDroid(bool isClean)
        {
            this.isClean = isClean;
        }

        public AstromechDroid(bool isClean, bool isBattery, bool isWheel)
        {
            this.isClean = isClean;
            this.isBattery = isBattery;
            this.isWheel = isWheel;
        }


        // Methods
        public string Clean()
        {
            if (isClean == false)
            {
              
                return "The R2 unit has been cleaned.";
            }
            else
            {
                return "The R2 unit does not need a cleaning.";
            }
        }

        public string Battery()
        {
            if (isBattery == false)
            {
                
                return "The R2 unit has a new battery.";
            }
            else
            {
                return "The R2 unit does not require a new battery.";
            }
        }

        public string Wheel()
        {
            if (isWheel == false)
            {
              
                return "The R2 unit wheels have been replaced.";
            }
            else
            {
                return "The R2 unit does not require a new wheel.";
            }
        }

        //private void TickGenerator()
        //{
        //    Tick();
        //}

    }
}
