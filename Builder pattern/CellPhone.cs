using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Builder_pattern
{
    public class CellPhone
    {

        private string model;
        private string os;
        private int ram;
        private decimal screenSize;
        private int camera;
        private int battery;
        public CellPhone(string model,string os,int ram, decimal screenSize, int camera, int battry)
        {
            this.model = model;
            this.os = os;
            this.ram = ram;
            this.screenSize = screenSize;
            this.camera = camera;
            this.battery = battery;
        }

        public override string ToString()
        {
            return $"Model: {model}, OS: {os}, RAM: {ram}GB, Screen Size: {screenSize} inches, Camera: {camera}MP, Battery: {battery}mAh";
        }

    }
}
