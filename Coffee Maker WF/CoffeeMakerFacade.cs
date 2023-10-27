using Coffee_Maker_WF.Subsystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker_WF
{
    public class CoffeeMakerFacade
    {
        private Grinder grinder;
        private MilkPump milkPump;
        private WaterPump waterPump;
        private Heater heater;

        private int totalTime { get; set; }

        public CoffeeMakerFacade()
        {
            grinder = new Grinder();
            milkPump = new MilkPump();
            waterPump = new WaterPump();
            heater = new Heater();
        }

        public void AddBeans(int amount)
        {
            grinder.AddBeans(amount);
        }

        public int CurrentBeansAmount()
        {
            return grinder.currentBeansAmount;
        }

        public void AddWater(int amount)
        {
            waterPump.AddWater(amount);
        }

        public int CurrentWaterAmount()
        {
            return waterPump.currentWaterAmount;
        }

        public void AddMilk(int amount)
        {
            milkPump.AddMilk(amount);
        }

        public int CurrentMilkAmount()
        {
               return milkPump.currentMilkAmount;
        }

        public Result MakeEspresso(int beans, int water)
        {
            waterPump.SetWater(water);
            grinder.SetBeans(beans);
            heater.SetTemp(90);
            waterPump.PumpWater();
            heater.Heat();
            grinder.Grind();
            totalTime = waterPump.totalTime + heater.totalTime + grinder.totalTime;
            Result espresso = new Result("Espresso", beans, water, 0, 0, 90, totalTime);
            return espresso;
        }

        public Result MakeAmericano(int beans, int water)
        {
            waterPump.SetWater(water);
            grinder.SetBeans(beans);
            heater.SetTemp(92);
            waterPump.PumpWater();
            heater.Heat();
            grinder.Grind();
            totalTime = waterPump.totalTime + heater.totalTime + grinder.totalTime;
            Result americano = new Result("Americano", beans, water, 0, 0, 92, totalTime);
            return americano;
        }

        public Result MakeCappuccino(int beans, int water, int milk, int frothMilk)
        {
            waterPump.SetWater(water);
            grinder.SetBeans(beans);
            heater.SetTemp(92);
            milkPump.SetMilk(milk);
            milkPump.SetFrothMilk(frothMilk);
            waterPump.PumpWater();
            heater.Heat();
            grinder.Grind();
            milkPump.PumpMilk();
            milkPump.PumpFrothMilk();
            heater.Heat();
            totalTime = waterPump.totalTime + heater.totalTime + grinder.totalTime + milkPump.totalTime;
            Result cappuccino = new Result("Cappuccino", beans, water, milk, frothMilk, 92, totalTime);
            return cappuccino;
        }

        public Result MakeLatte(int beans, int water, int milk, int frothMilk)
        {
            waterPump.SetWater(water);
            grinder.SetBeans(beans);
            heater.SetTemp(94);
            milkPump.SetMilk(milk);
            milkPump.SetFrothMilk(frothMilk);
            waterPump.PumpWater();
            heater.Heat();
            grinder.Grind();
            milkPump.PumpMilk();
            milkPump.PumpFrothMilk();
            heater.Heat();
            totalTime = waterPump.totalTime + heater.totalTime + grinder.totalTime + milkPump.totalTime;
            Result latte = new Result("Latte", beans, water, milk, frothMilk, 94, totalTime);
            return latte;
        }

        public Result MakeHotWater(int water)
        {
            waterPump.SetWater(water);
            heater.SetTemp(100);
            heater.Heat();
            totalTime = waterPump.totalTime + heater.totalTime;
            Result hotWater = new Result("Hot Water", 0, water, 0, 0, 100, totalTime);
            return hotWater;
        }
    }
}
