using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker_WF.Subsystem
{
    public class MilkPump
    {
        public int currentMilkAmount { get; set; }
        public int setMilkAmount { get; set; }
        public int setFrothMilkAmount { get; set; }
        public int totalTime { get; set; }

        public MilkPump()
        {
            currentMilkAmount = 0;
        }

        public bool AddMilk(int amount)
        {
            if (currentMilkAmount + amount <= 250)
            {
                currentMilkAmount += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetMilk(int amount)
        {
            if (amount <= currentMilkAmount)
            {
                setMilkAmount = amount;
                currentMilkAmount -= amount;
            }
            else
            {
                MessageBox.Show("Please add milk!", "Error");
            }
        }

        public void SetFrothMilk(int amount)
        {
            if (amount <= currentMilkAmount)
            {
                setFrothMilkAmount = amount;
                currentMilkAmount -= amount;
            }
            else
            {
                MessageBox.Show("Please add milk!", "Error");
            }
        }

        public void PumpMilk()
        {
            totalTime = setMilkAmount;
        }

        public void PumpFrothMilk()
        {
            totalTime += setFrothMilkAmount * 3;
        }
    }
}
