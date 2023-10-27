using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker_WF
{
    public class Result
    {
        public string name { get; set; }
        public int beansAmount { get; set; }
        public int waterAmount { get; set; }
        public int milkAmount { get; set; }
        public int frothMilkAmount { get; set; }
        public int temperature { get; set; }
        public int finalVolume { get; set; }
        public int finalTime { get; set; }

        public Result(string name, int beansAmount, int waterAmount, int milkAmount, int frothMilkAmount, int temperature, int finalTime)
        {
            this.name = name;
            this.beansAmount = beansAmount;
            this.waterAmount = waterAmount;
            this.milkAmount = milkAmount;
            this.frothMilkAmount = frothMilkAmount;
            this.temperature = temperature;
            this.finalVolume = beansAmount + waterAmount + milkAmount + frothMilkAmount;
            this.finalTime = finalTime;
        }
    }
}
