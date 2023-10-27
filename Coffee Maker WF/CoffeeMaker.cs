using Coffee_Maker_WF.Subsystem;
using System.Diagnostics.Eventing.Reader;

namespace Coffee_Maker_WF
{
    public partial class FormCoffeeMaker : Form
    {
        CoffeeMakerFacade coffeeMakerFacade = new CoffeeMakerFacade();

        public FormCoffeeMaker()
        {
            InitializeComponent();
            txtBeansOutput.Text = "Current: 0";
            txtWaterOutput.Text = "Current: 0";
            txtMilkOutput.Text = "Current: 0";
        }
        private void btnAddBeans_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBeansInput.Text))
            {
                MessageBox.Show("Please Input Beans Amout To Add!", "Error");
            }
            else if (!int.TryParse(txtBeansInput.Text, out _))
            {
                MessageBox.Show("Please Enter Valid Numbers For Beans Amount To Add!", "Error");
            }
            else if (int.Parse(txtBeansInput.Text) <= 0)
            {
                MessageBox.Show("Please Enter Positive Numbers For Beans!", "Error");
            }
            else
            {
                int beansInput = int.Parse(txtBeansInput.Text);
                coffeeMakerFacade.AddBeans(beansInput);
                txtBeansOutput.Text = "Current: " + coffeeMakerFacade.CurrentBeansAmount().ToString();
                txtBeansInput.Text = "";
            }
        }

        private void btnAddWater_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWaterInput.Text))
            {
                MessageBox.Show("Please Input Water Amout To Add!", "Error");
            }
            else if (!int.TryParse(txtWaterInput.Text, out _))
            {
                MessageBox.Show("Please Enter Valid Numbers For Water Amount To Add!", "Error");
            }
            else if (int.Parse(txtWaterInput.Text) <= 0)
            {
                MessageBox.Show("Please Enter Positive Numbers For Water!", "Error");
            }
            else
            {
                int waterInput = int.Parse(txtWaterInput.Text);
                coffeeMakerFacade.AddWater(waterInput);
                txtWaterOutput.Text = "Current: " + coffeeMakerFacade.CurrentWaterAmount().ToString();
                txtWaterInput.Text = "";
            }
        }

        private void btnAddMilk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMilkInput.Text))
            {
                MessageBox.Show("Please Input Milk Amout To Add!", "Error");
            }
            else if (!int.TryParse(txtMilkInput.Text, out _))
            {
                MessageBox.Show("Please Enter Valid Numbers For Milk Amount To Add!", "Error");
            }
            else if (int.Parse(txtMilkInput.Text) <= 0)
            {
                MessageBox.Show("Please Enter Positive Numbers For Milk!", "Error");
            }
            else
            {
                int milkInput = int.Parse(txtMilkInput.Text);
                coffeeMakerFacade.AddMilk(milkInput);
                txtMilkOutput.Text = "Current: " + coffeeMakerFacade.CurrentMilkAmount().ToString();
                txtMilkInput.Text = "";
            }
        }

        private void btnHotWater_Click(object sender, EventArgs e)
        {
            if (rdbDefault.Checked || rdbCustom.Checked)
            {
                if (rdbDefault.Checked)
                {
                    txtWaterCustom.Text = "100";
                    txtBeansCustom.Text = "0";
                    txtMilkCustom.Text = "0";
                    txtFrothMilkCustom.Text = "0";
                    var hotWater = coffeeMakerFacade.MakeHotWater(100);
                    txtWaterOutput.Text = "Current: " + coffeeMakerFacade.CurrentWaterAmount().ToString();
                    txtName.Text = hotWater.name;
                    txtTemp.Text = hotWater.temperature.ToString();
                    txtBeans.Text = hotWater.beansAmount.ToString();
                    txtWater.Text = hotWater.waterAmount.ToString();
                    txtMilk.Text = hotWater.milkAmount.ToString();
                    txtFrothMilk.Text = hotWater.frothMilkAmount.ToString();
                    txtFinalVolume.Text = hotWater.finalVolume.ToString();
                    if (hotWater.finalTime < 60)
                    {
                        txtFinalTime.Text = hotWater.finalTime.ToString() + " seconds";
                    }
                    else
                    {
                        txtFinalTime.Text = (hotWater.finalTime / 60).ToString() + " minutes " + (hotWater.finalTime % 60).ToString() + " seconds";
                    }
                }
                if (rdbCustom.Checked)
                {
                    txtBeansCustom.Text = "0";
                    txtBeansCustom.ReadOnly = true;
                    txtMilkCustom.Text = "0";
                    txtMilkCustom.ReadOnly = true;
                    txtFrothMilkCustom.Text = "0";
                    txtFrothMilkCustom.ReadOnly = true;
                    if (string.IsNullOrEmpty(txtWaterCustom.Text))
                    {
                        MessageBox.Show("Please Input Custom Of Water!", "Error");
                    }
                    else if (!int.TryParse(txtWaterCustom.Text, out _))
                    {
                        MessageBox.Show("Please Enter Valid Numbers For Water!", "Error");
                    }
                    else if (int.Parse(txtWaterCustom.Text) <= 0)
                    {
                        MessageBox.Show("Please Enter Positive Numbers For Water!", "Error");
                    }
                    else if (int.Parse(txtWaterCustom.Text) > coffeeMakerFacade.CurrentWaterAmount())
                    {
                        MessageBox.Show("Please Add Water!", "Error");
                    }
                    else
                    {
                        int waterInputCustom = int.Parse(txtWaterCustom.Text);
                        var hotWater = coffeeMakerFacade.MakeHotWater(waterInputCustom);
                        txtWaterOutput.Text = "Current: " + coffeeMakerFacade.CurrentWaterAmount().ToString();
                        txtName.Text = hotWater.name;
                        txtTemp.Text = hotWater.temperature.ToString();
                        txtBeans.Text = hotWater.beansAmount.ToString();
                        txtWater.Text = hotWater.waterAmount.ToString();
                        txtMilk.Text = hotWater.milkAmount.ToString();
                        txtFrothMilk.Text = hotWater.frothMilkAmount.ToString();
                        txtFinalVolume.Text = hotWater.finalVolume.ToString();
                        if (hotWater.finalTime < 60)
                        {
                            txtFinalTime.Text = hotWater.finalTime.ToString() + " seconds";
                        }
                        else
                        {
                            txtFinalTime.Text = (hotWater.finalTime / 60).ToString() + " minutes " + (hotWater.finalTime % 60).ToString() + " seconds";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Default Or Custom!", "Error");
            }
        }

        private void btnEspresso_Click(object sender, EventArgs e)
        {
            if (rdbDefault.Checked || rdbCustom.Checked)
            {
                if (rdbDefault.Checked)
                {
                    txtBeansCustom.Text = "8";
                    txtWaterCustom.Text = "17";
                    txtMilkCustom.Text = "0";
                    txtFrothMilkCustom.Text = "0";
                    var espresso = coffeeMakerFacade.MakeEspresso(8, 17);
                    txtBeansOutput.Text = "Current: " + coffeeMakerFacade.CurrentBeansAmount().ToString();
                    txtWaterOutput.Text = "Current: " + coffeeMakerFacade.CurrentWaterAmount().ToString();
                    txtName.Text = espresso.name;
                    txtTemp.Text = espresso.temperature.ToString();
                    txtBeans.Text = espresso.beansAmount.ToString();
                    txtWater.Text = espresso.waterAmount.ToString();
                    txtMilk.Text = espresso.milkAmount.ToString();
                    txtFrothMilk.Text = espresso.frothMilkAmount.ToString();
                    txtFinalVolume.Text = espresso.finalVolume.ToString();
                    if (espresso.finalTime < 60)
                    {
                        txtFinalTime.Text = espresso.finalTime.ToString() + " seconds";
                    }
                    else
                    {
                        txtFinalTime.Text = (espresso.finalTime / 60).ToString() + " minutes " + (espresso.finalTime % 60).ToString() + " seconds";
                    }
                }
                if (rdbCustom.Checked)
                {
                    txtMilkCustom.Text = "0";
                    txtMilkCustom.ReadOnly = true;
                    txtFrothMilkCustom.Text = "0";
                    txtFrothMilkCustom.ReadOnly = true;
                    if (string.IsNullOrEmpty(txtBeansCustom.Text) || string.IsNullOrEmpty(txtWaterCustom.Text))
                    {
                        MessageBox.Show("Please Input Custom Of Beans And Water!", "Error");
                    }
                    else if (!int.TryParse(txtBeansCustom.Text, out _) || !int.TryParse(txtWaterCustom.Text, out _))
                    {
                        MessageBox.Show("Please Enter Valid Numbers For Beans And Water!", "Error");
                    }
                    else if (int.Parse(txtBeansCustom.Text) <= 0 || int.Parse(txtWaterCustom.Text) <= 0)
                    {
                        MessageBox.Show("Please Enter Positive Numbers For Beans And Water!", "Error");
                    }
                    else if (int.Parse(txtBeansCustom.Text) > coffeeMakerFacade.CurrentBeansAmount() || int.Parse(txtWaterCustom.Text) > coffeeMakerFacade.CurrentWaterAmount())
                    {
                        MessageBox.Show("Please Add Beans Or Water!", "Error");
                    }
                    else
                    {
                        int beansInputCustom = int.Parse(txtBeansCustom.Text);
                        int waterInputCustom = int.Parse(txtWaterCustom.Text);
                        var espresso = coffeeMakerFacade.MakeEspresso(beansInputCustom, waterInputCustom);
                        txtBeansOutput.Text = "Current: " + coffeeMakerFacade.CurrentBeansAmount().ToString();
                        txtWaterOutput.Text = "Current: " + coffeeMakerFacade.CurrentWaterAmount().ToString();
                        txtName.Text = espresso.name;
                        txtTemp.Text = espresso.temperature.ToString();
                        txtBeans.Text = espresso.beansAmount.ToString();
                        txtWater.Text = espresso.waterAmount.ToString();
                        txtMilk.Text = espresso.milkAmount.ToString();
                        txtFrothMilk.Text = espresso.frothMilkAmount.ToString();
                        txtFinalVolume.Text = espresso.finalVolume.ToString();
                        if (espresso.finalTime < 60)
                        {
                            txtFinalTime.Text = espresso.finalTime.ToString() + " seconds";
                        }
                        else
                        {
                            txtFinalTime.Text = (espresso.finalTime / 60).ToString() + " minutes " + (espresso.finalTime % 60).ToString() + " seconds";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Default Or Custom!", "Error");
            }
        }

        private void btnAmericano_Click(object sender, EventArgs e)
        {
            if (rdbDefault.Checked || rdbCustom.Checked)
            {
                if (rdbDefault.Checked)
                {
                    txtBeansCustom.Text = "5";
                    txtWaterCustom.Text = "25";
                    txtMilkCustom.Text = "0";
                    txtFrothMilkCustom.Text = "0";
                    var americano = coffeeMakerFacade.MakeAmericano(5, 25);
                    txtBeansOutput.Text = "Current: " + coffeeMakerFacade.CurrentBeansAmount().ToString();
                    txtWaterOutput.Text = "Current: " + coffeeMakerFacade.CurrentWaterAmount().ToString();
                    txtName.Text = americano.name;
                    txtTemp.Text = americano.temperature.ToString();
                    txtBeans.Text = americano.beansAmount.ToString();
                    txtWater.Text = americano.waterAmount.ToString();
                    txtMilk.Text = americano.milkAmount.ToString();
                    txtFrothMilk.Text = americano.frothMilkAmount.ToString();
                    txtFinalVolume.Text = americano.finalVolume.ToString();
                    if (americano.finalTime < 60)
                    {
                        txtFinalTime.Text = americano.finalTime.ToString() + " seconds";
                    }
                    else
                    {
                        txtFinalTime.Text = (americano.finalTime / 60).ToString() + " minutes " + (americano.finalTime % 60).ToString() + " seconds";
                    }
                }
                if (rdbCustom.Checked)
                {
                    txtMilkCustom.Text = "0";
                    txtMilkCustom.ReadOnly = true;
                    txtFrothMilkCustom.Text = "0";
                    txtFrothMilkCustom.ReadOnly = true;
                    if (string.IsNullOrEmpty(txtBeansCustom.Text) || string.IsNullOrEmpty(txtWaterCustom.Text))
                    {
                        MessageBox.Show("Please Input Custom Of Beans And Water!", "Error");
                    }
                    else if (!int.TryParse(txtBeansCustom.Text, out _) || !int.TryParse(txtWaterCustom.Text, out _))
                    {
                        MessageBox.Show("Please Enter Valid Numbers For Beans And Water!", "Error");
                    }
                    else if (int.Parse(txtBeansCustom.Text) <= 0 || int.Parse(txtWaterCustom.Text) <= 0)
                    {
                        MessageBox.Show("Please Enter Positive Numbers For Beans And Water!", "Error");
                    }
                    else if (int.Parse(txtBeansCustom.Text) > coffeeMakerFacade.CurrentBeansAmount() || int.Parse(txtWaterCustom.Text) > coffeeMakerFacade.CurrentWaterAmount())
                    {
                        MessageBox.Show("Please Add Beans Or Water!", "Error");
                    }
                    else
                    {
                        int beansInputCustom = int.Parse(txtBeansCustom.Text);
                        int waterInputCustom = int.Parse(txtWaterCustom.Text);
                        var americano = coffeeMakerFacade.MakeAmericano(beansInputCustom, waterInputCustom);
                        txtBeansOutput.Text = "Current: " + coffeeMakerFacade.CurrentBeansAmount().ToString();
                        txtWaterOutput.Text = "Current: " + coffeeMakerFacade.CurrentWaterAmount().ToString();
                        txtName.Text = americano.name;
                        txtTemp.Text = americano.temperature.ToString();
                        txtBeans.Text = americano.beansAmount.ToString();
                        txtWater.Text = americano.waterAmount.ToString();
                        txtMilk.Text = americano.milkAmount.ToString();
                        txtFrothMilk.Text = americano.frothMilkAmount.ToString();
                        txtFinalVolume.Text = americano.finalVolume.ToString();
                        if (americano.finalTime < 60)
                        {
                            txtFinalTime.Text = americano.finalTime.ToString() + " seconds";
                        }
                        else
                        {
                            txtFinalTime.Text = (americano.finalTime / 60).ToString() + " minutes " + (americano.finalTime % 60).ToString() + " seconds";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Default Or Custom!", "Error");
            }
        }

        private void btnCappuccino_Click(object sender, EventArgs e)
        {
            if (rdbDefault.Checked || rdbCustom.Checked)
            {
                if (rdbDefault.Checked)
                {
                    txtBeansCustom.Text = "5";
                    txtWaterCustom.Text = "10";
                    txtMilkCustom.Text = "10";
                    txtFrothMilkCustom.Text = "10";
                    var cappuccino = coffeeMakerFacade.MakeCappuccino(5, 10, 10, 10);
                    txtBeansOutput.Text = "Current: " + coffeeMakerFacade.CurrentBeansAmount().ToString();
                    txtWaterOutput.Text = "Current: " + coffeeMakerFacade.CurrentWaterAmount().ToString();
                    txtMilkOutput.Text = "Current: " + coffeeMakerFacade.CurrentMilkAmount().ToString();
                    txtName.Text = cappuccino.name;
                    txtTemp.Text = cappuccino.temperature.ToString();
                    txtBeans.Text = cappuccino.beansAmount.ToString();
                    txtWater.Text = cappuccino.waterAmount.ToString();
                    txtMilk.Text = cappuccino.milkAmount.ToString();
                    txtFrothMilk.Text = cappuccino.frothMilkAmount.ToString();
                    txtFinalVolume.Text = cappuccino.finalVolume.ToString();
                    if (cappuccino.finalTime < 60)
                    {
                        txtFinalTime.Text = cappuccino.finalTime.ToString() + " seconds";
                    }
                    else
                    {
                        txtFinalTime.Text = (cappuccino.finalTime / 60).ToString() + " minutes " + (cappuccino.finalTime % 60).ToString() + " seconds";
                    }
                }
                if (rdbCustom.Checked)
                {
                    if (string.IsNullOrEmpty(txtBeansCustom.Text) || string.IsNullOrEmpty(txtWaterCustom.Text) || string.IsNullOrEmpty(txtMilkCustom.Text) || string.IsNullOrEmpty(txtFrothMilkCustom.Text))
                    {
                        MessageBox.Show("Please Input Custom Of Beans, Water, Milk And Froth Milk!", "Error");
                    }
                    else if (!int.TryParse(txtBeansCustom.Text, out _) || !int.TryParse(txtWaterCustom.Text, out _) || !int.TryParse(txtMilkCustom.Text, out _) || !int.TryParse(txtFrothMilkCustom.Text, out _))
                    {
                        MessageBox.Show("Please Enter Valid Numbers For Beans, Water, Milk And Froth Milk!", "Error");
                    }
                    else if (int.Parse(txtBeansCustom.Text) <= 0 || int.Parse(txtWaterCustom.Text) <= 0 || int.Parse(txtMilkCustom.Text) <= 0 || int.Parse(txtFrothMilkCustom.Text) <= 0)
                    {
                        MessageBox.Show("Please Enter Positive Numbers For Beans, Water, Milk And Froth Milk!", "Error");
                    }
                    else if (int.Parse(txtBeansCustom.Text) > coffeeMakerFacade.CurrentBeansAmount() || int.Parse(txtWaterCustom.Text) > coffeeMakerFacade.CurrentWaterAmount() || int.Parse(txtMilkCustom.Text) > coffeeMakerFacade.CurrentMilkAmount() || int.Parse(txtFrothMilkCustom.Text) > coffeeMakerFacade.CurrentMilkAmount())
                    {
                        MessageBox.Show("Please Add Beans, Water, Milk Or Froth Milk!", "Error");
                    }
                    else
                    {
                        int beansInputCustom = int.Parse(txtBeansCustom.Text);
                        int waterInputCustom = int.Parse(txtWaterCustom.Text);
                        int milkInputCustom = int.Parse(txtMilkCustom.Text);
                        int frothMilkInputCustom = int.Parse(txtFrothMilkCustom.Text);
                        var cappuccino = coffeeMakerFacade.MakeCappuccino(beansInputCustom, waterInputCustom, milkInputCustom, frothMilkInputCustom);
                        txtBeansOutput.Text = "Current: " + coffeeMakerFacade.CurrentBeansAmount().ToString();
                        txtWaterOutput.Text = "Current: " + coffeeMakerFacade.CurrentWaterAmount().ToString();
                        txtMilkOutput.Text = "Current: " + coffeeMakerFacade.CurrentMilkAmount().ToString();
                        txtName.Text = cappuccino.name;
                        txtTemp.Text = cappuccino.temperature.ToString();
                        txtBeans.Text = cappuccino.beansAmount.ToString();
                        txtWater.Text = cappuccino.waterAmount.ToString();
                        txtMilk.Text = cappuccino.milkAmount.ToString();
                        txtFrothMilk.Text = cappuccino.frothMilkAmount.ToString();
                        txtFinalVolume.Text = cappuccino.finalVolume.ToString();
                        if (cappuccino.finalTime < 60)
                        {
                            txtFinalTime.Text = cappuccino.finalTime.ToString() + " seconds";
                        }
                        else
                        {
                            txtFinalTime.Text = (cappuccino.finalTime / 60).ToString() + " minutes " + (cappuccino.finalTime % 60).ToString() + " seconds";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Default Or Custom!", "Error");
            }
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            if (rdbDefault.Checked || rdbCustom.Checked)
            {
                if (rdbDefault.Checked)
                {
                    txtBeansCustom.Text = "5";
                    txtWaterCustom.Text = "10";
                    txtMilkCustom.Text = "20";
                    txtFrothMilkCustom.Text = "10";
                    var latte = coffeeMakerFacade.MakeLatte(5, 10, 20, 10);
                    txtBeansOutput.Text = "Current: " + coffeeMakerFacade.CurrentBeansAmount().ToString();
                    txtWaterOutput.Text = "Current: " + coffeeMakerFacade.CurrentWaterAmount().ToString();
                    txtMilkOutput.Text = "Current: " + coffeeMakerFacade.CurrentMilkAmount().ToString();
                    txtName.Text = latte.name;
                    txtTemp.Text = latte.temperature.ToString();
                    txtBeans.Text = latte.beansAmount.ToString();
                    txtWater.Text = latte.waterAmount.ToString();
                    txtMilk.Text = latte.milkAmount.ToString();
                    txtFrothMilk.Text = latte.frothMilkAmount.ToString();
                    txtFinalVolume.Text = latte.finalVolume.ToString();
                    if (latte.finalTime < 60)
                    {
                        txtFinalTime.Text = latte.finalTime.ToString() + " seconds";
                    }
                    else
                    {
                        txtFinalTime.Text = (latte.finalTime / 60).ToString() + " minutes " + (latte.finalTime % 60).ToString() + " seconds";
                    }
                }
                if (rdbCustom.Checked)
                {
                    if (string.IsNullOrEmpty(txtBeansCustom.Text) || string.IsNullOrEmpty(txtWaterCustom.Text) || string.IsNullOrEmpty(txtMilkCustom.Text) || string.IsNullOrEmpty(txtFrothMilkCustom.Text))
                    {
                        MessageBox.Show("Please Input Custom Of Beans, Water, Milk And Froth Milk!", "Error");
                    }
                    else if (!int.TryParse(txtBeansCustom.Text, out _) || !int.TryParse(txtWaterCustom.Text, out _) || !int.TryParse(txtMilkCustom.Text, out _) || !int.TryParse(txtFrothMilkCustom.Text, out _))
                    {
                        MessageBox.Show("Please Enter Valid Numbers For Beans, Water, Milk And Froth Milk!", "Error");
                    }
                    else if (int.Parse(txtBeansCustom.Text) <= 0 || int.Parse(txtWaterCustom.Text) <= 0 || int.Parse(txtMilkCustom.Text) <= 0 || int.Parse(txtFrothMilkCustom.Text) <= 0)
                    {
                        MessageBox.Show("Please Enter Positive Numbers For Beans, Water, Milk And Froth Milk!", "Error");
                    }
                    else if (int.Parse(txtBeansCustom.Text) > coffeeMakerFacade.CurrentBeansAmount() || int.Parse(txtWaterCustom.Text) > coffeeMakerFacade.CurrentWaterAmount() || int.Parse(txtMilkCustom.Text) > coffeeMakerFacade.CurrentMilkAmount() || int.Parse(txtFrothMilkCustom.Text) > coffeeMakerFacade.CurrentMilkAmount())
                    {
                        MessageBox.Show("Please Add Beans, Water, Milk Or Froth Milk!", "Error");
                    }
                    else
                    {
                        int beansInputCustom = int.Parse(txtBeansCustom.Text);
                        int waterInputCustom = int.Parse(txtWaterCustom.Text);
                        int milkInputCustom = int.Parse(txtMilkCustom.Text);
                        int frothMilkInputCustom = int.Parse(txtFrothMilkCustom.Text);
                        var latte = coffeeMakerFacade.MakeLatte(beansInputCustom, waterInputCustom, milkInputCustom, frothMilkInputCustom);
                        txtBeansOutput.Text = "Current: " + coffeeMakerFacade.CurrentBeansAmount().ToString();
                        txtWaterOutput.Text = "Current: " + coffeeMakerFacade.CurrentWaterAmount().ToString();
                        txtMilkOutput.Text = "Current: " + coffeeMakerFacade.CurrentMilkAmount().ToString();
                        txtName.Text = latte.name;
                        txtTemp.Text = latte.temperature.ToString();
                        txtBeans.Text = latte.beansAmount.ToString();
                        txtWater.Text = latte.waterAmount.ToString();
                        txtMilk.Text = latte.milkAmount.ToString();
                        txtFrothMilk.Text = latte.frothMilkAmount.ToString();
                        txtFinalVolume.Text = latte.finalVolume.ToString();
                        if (latte.finalTime < 60)
                        {
                            txtFinalTime.Text = latte.finalTime.ToString() + " seconds";
                        }
                        else
                        {
                            txtFinalTime.Text = (latte.finalTime / 60).ToString() + " minutes " + (latte.finalTime % 60).ToString() + " seconds";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Default Or Custom!", "Error");
            }
        }

        private void rdbDefault_CheckedChanged(object sender, EventArgs e)
        {
            txtBeansCustom.ReadOnly = true;
            txtWaterCustom.ReadOnly = true;
            txtMilkCustom.ReadOnly = true;
            txtFrothMilkCustom.ReadOnly = true;
        }

        private void rdbCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtBeansCustom.ReadOnly = false;
            txtWaterCustom.ReadOnly = false;
            txtMilkCustom.ReadOnly = false;
            txtFrothMilkCustom.ReadOnly = false;
        }
    }
}