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
        public void CleanDroid()
        {

        }

    }
}
