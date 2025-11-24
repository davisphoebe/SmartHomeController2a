using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class SmartThermostat : SmartDevice
    {

        // Private fields
        private double currentTemperature;
        private double targetTemperature;

        // Public properties
        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set { currentTemperature = value; }
        }

        public double TargetTemperature
        {
            get { return targetTemperature; }
            set { targetTemperature = value; }
        }

        public SmartThermostat(double thermostatCurrentTemperature, double thermostatTargetTemperature) 
        {
            this.CurrentTemperature = thermostatCurrentTemperature;
            this.TargetTemperature = thermostatTargetTemperature;

        }



    }
}
