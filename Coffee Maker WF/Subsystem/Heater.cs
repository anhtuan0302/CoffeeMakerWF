using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker_WF.Subsystem
{
    public class Heater
    {
        public int setTemp { get; set; }
        public int totalTime { get; set; }

        public Heater()
        {
            setTemp = 0;
            totalTime = 0;
        }

        public void SetTemp(int temp)
        {
            setTemp = temp;
        }

        public void Heat()
        {
            if(setTemp > 0)
            {
                totalTime = setTemp * 2;
            }
            else
            {
                MessageBox.Show("Please Set The Temperature First", "Error");
            }
        }
    }
}
