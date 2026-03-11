using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    internal class Car
    {
        // Class block

        // Data (Variables)
        int fuelAmount = 60;
        public float currentSpeed;
        float maxSpeed = 160;
        float acceleration = 10;

        bool leftBlinkerOn = true;

        // Constructors 
        public Car()
        {

        }
        public Car(int fuelAmount, float maxSpeed)
        {
            // if variable created in function is the same as 
            // Variable in class. Function variable is defualt

            // This accesses variable from class
            this.fuelAmount = fuelAmount;
        }
        
        // Functionality (Methods)
        public void startMotor()
        {

        }
        
        private void Acceleration()
        {
            fuelAmount -= 1;
        }
        
        void boostCar()
        {
            
        }
    }
}
