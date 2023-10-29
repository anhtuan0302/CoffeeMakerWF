using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker_WF.Subsystem
{
    public class WaterPump
    {
        public int currentWaterAmount { get; set; }
        public int setWaterAmount { get; set; }
        public int totalTime { get; set; }

        public WaterPump()
        {
            currentWaterAmount = 0;
        }

        public bool AddWater(int amount)
        {
            if (currentWaterAmount + amount <= 500)
            {
                currentWaterAmount += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetWater(int amount)
        {
            if(amount <= currentWaterAmount)
            {
                setWaterAmount = amount;
                currentWaterAmount -= amount;
            }
            else
            {
                MessageBox.Show("Please add water!", "Error");
            }
        }

        public void PumpWater()
        {
            totalTime = setWaterAmount;
        }
    }
}
