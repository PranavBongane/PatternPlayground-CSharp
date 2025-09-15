using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    public class CellPhoneBuilder
    {
        private string model;
        private string os;
        private int ram;
        private decimal screenSize;
        private int camera;
        private int battery;

        // Builder methods for setting properties
        public CellPhoneBuilder SetModel(string model)
        {
            this.model = model;
            return this;
        }
        public CellPhoneBuilder SetOS(string os)
        {
            this.os = os;
            return this;
        }
        public CellPhoneBuilder SetRAM(int ram)
        {
            this.ram = ram;
            return this;
        }
        public CellPhoneBuilder SetScreenSize(decimal screenSize)
        {
            this.screenSize = screenSize;
            return this;
        }
        public CellPhoneBuilder SetCamera(int camera)
        {
            this.camera = camera;
            return this;
        }
        public CellPhoneBuilder SetBattery(int battery)
        {
            this.battery = battery;
            return this;
        }

        // Method to build the final CellPhone object
        public CellPhone Build()
        {
            return new CellPhone(model, os, ram, screenSize, camera, battery);
        }

    }
}
