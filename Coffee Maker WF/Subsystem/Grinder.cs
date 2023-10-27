using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker_WF.Subsystem
{
    public class Grinder
    {
        public int currentBeansAmount { get; set; }
        public int setBeansAmount { get; set; }
        public int totalTime { get; set; }

        public Grinder()
        {
            currentBeansAmount = 0;
        }

        public void AddBeans(int amount)
        {
            if (currentBeansAmount + amount <= 250)
            {
                currentBeansAmount += amount;
                MessageBox.Show("Add " + amount + "g Beans Successfully", "Successfully");
            }
            else
            {
                MessageBox.Show("Exceeds The Maximum Capacity Of Beans (250ml)", "Error");
            }
        }

        public void SetBeans(int amount)
        {
            if (amount <= currentBeansAmount)
            {
                setBeansAmount = amount;
                currentBeansAmount -= amount;
            }
            else
            {
                MessageBox.Show("Please add beans!", "Error");
            }
        }

        public void Grind()
        {
            totalTime = setBeansAmount * 2;
        }
    }
}
