namespace Coffee_Maker_WF
{
    partial class FormCoffeeMaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ptcCoffeeMaker = new PictureBox();
            btnAddBeans = new Button();
            btnAddWater = new Button();
            btnAddMilk = new Button();
            btnEspresso = new Button();
            btnAmericano = new Button();
            btnCappuccino = new Button();
            btnLatte = new Button();
            btnClean = new Button();
            txtBeansInput = new TextBox();
            txtWaterInput = new TextBox();
            txtMilkInput = new TextBox();
            txtMilkOutput = new TextBox();
            txtWaterOutput = new TextBox();
            txtBeansOutput = new TextBox();
            panel1 = new Panel();
            txtTemp = new TextBox();
            lblTemp = new Label();
            lblName = new Label();
            txtName = new TextBox();
            panel2 = new Panel();
            lblTotalTime = new Label();
            txtFinalTime = new TextBox();
            panel3 = new Panel();
            lblBeans = new Label();
            txtBeans = new TextBox();
            lblWater = new Label();
            txtWater = new TextBox();
            panel5 = new Panel();
            lblFinalVolume = new Label();
            txtFinalVolume = new TextBox();
            panel4 = new Panel();
            lblMilk = new Label();
            txtMilk = new TextBox();
            lblFrothMilk = new Label();
            txtFrothMilk = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel6 = new Panel();
            lblFrothMilkCustom = new Label();
            lblMilkCustom = new Label();
            lblWaterCustom = new Label();
            lblBeansCustom = new Label();
            txtFrothMilkCustom = new TextBox();
            rdbCustom = new RadioButton();
            rdbDefault = new RadioButton();
            txtMilkCustom = new TextBox();
            txtWaterCustom = new TextBox();
            txtBeansCustom = new TextBox();
            btnHotWater = new Button();
            ((System.ComponentModel.ISupportInitialize)ptcCoffeeMaker).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // ptcCoffeeMaker
            // 
            ptcCoffeeMaker.Image = Properties.Resources.CoffeeMaker;
            ptcCoffeeMaker.Location = new Point(12, 12);
            ptcCoffeeMaker.Name = "ptcCoffeeMaker";
            ptcCoffeeMaker.Size = new Size(516, 697);
            ptcCoffeeMaker.SizeMode = PictureBoxSizeMode.StretchImage;
            ptcCoffeeMaker.TabIndex = 0;
            ptcCoffeeMaker.TabStop = false;
            // 
            // btnAddBeans
            // 
            btnAddBeans.BackColor = SystemColors.HighlightText;
            btnAddBeans.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddBeans.ForeColor = SystemColors.Desktop;
            btnAddBeans.Location = new Point(151, 124);
            btnAddBeans.Name = "btnAddBeans";
            btnAddBeans.Size = new Size(46, 27);
            btnAddBeans.TabIndex = 1;
            btnAddBeans.Text = "Add";
            btnAddBeans.UseVisualStyleBackColor = false;
            btnAddBeans.Click += btnAddBeans_Click;
            // 
            // btnAddWater
            // 
            btnAddWater.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddWater.Location = new Point(284, 123);
            btnAddWater.Name = "btnAddWater";
            btnAddWater.Size = new Size(53, 27);
            btnAddWater.TabIndex = 6;
            btnAddWater.Text = "Add";
            btnAddWater.UseVisualStyleBackColor = true;
            btnAddWater.Click += btnAddWater_Click;
            // 
            // btnAddMilk
            // 
            btnAddMilk.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddMilk.Location = new Point(411, 122);
            btnAddMilk.Name = "btnAddMilk";
            btnAddMilk.Size = new Size(41, 26);
            btnAddMilk.TabIndex = 7;
            btnAddMilk.Text = "Add";
            btnAddMilk.UseVisualStyleBackColor = true;
            btnAddMilk.Click += btnAddMilk_Click;
            // 
            // btnEspresso
            // 
            btnEspresso.BackColor = SystemColors.ActiveCaption;
            btnEspresso.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            btnEspresso.Location = new Point(381, 300);
            btnEspresso.Name = "btnEspresso";
            btnEspresso.Size = new Size(87, 30);
            btnEspresso.TabIndex = 8;
            btnEspresso.Text = "Espresso";
            btnEspresso.UseVisualStyleBackColor = false;
            btnEspresso.Click += btnEspresso_Click;
            // 
            // btnAmericano
            // 
            btnAmericano.BackColor = SystemColors.ActiveCaption;
            btnAmericano.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            btnAmericano.Location = new Point(381, 336);
            btnAmericano.Name = "btnAmericano";
            btnAmericano.Size = new Size(87, 30);
            btnAmericano.TabIndex = 9;
            btnAmericano.Text = "Americano";
            btnAmericano.UseVisualStyleBackColor = false;
            btnAmericano.Click += btnAmericano_Click;
            // 
            // btnCappuccino
            // 
            btnCappuccino.BackColor = SystemColors.ActiveCaption;
            btnCappuccino.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            btnCappuccino.Location = new Point(381, 372);
            btnCappuccino.Name = "btnCappuccino";
            btnCappuccino.Size = new Size(87, 30);
            btnCappuccino.TabIndex = 10;
            btnCappuccino.Text = "Cappuccino";
            btnCappuccino.UseVisualStyleBackColor = false;
            btnCappuccino.Click += btnCappuccino_Click;
            // 
            // btnLatte
            // 
            btnLatte.BackColor = SystemColors.ActiveCaption;
            btnLatte.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            btnLatte.Location = new Point(381, 408);
            btnLatte.Name = "btnLatte";
            btnLatte.Size = new Size(87, 30);
            btnLatte.TabIndex = 11;
            btnLatte.Text = "Latte";
            btnLatte.UseVisualStyleBackColor = false;
            btnLatte.Click += btnLatte_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = SystemColors.ActiveCaption;
            btnClean.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            btnClean.Location = new Point(381, 236);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(87, 30);
            btnClean.TabIndex = 13;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = false;
            // 
            // txtBeansInput
            // 
            txtBeansInput.BackColor = SystemColors.HighlightText;
            txtBeansInput.Location = new Point(87, 124);
            txtBeansInput.Name = "txtBeansInput";
            txtBeansInput.Size = new Size(58, 27);
            txtBeansInput.TabIndex = 15;
            // 
            // txtWaterInput
            // 
            txtWaterInput.Location = new Point(217, 123);
            txtWaterInput.Name = "txtWaterInput";
            txtWaterInput.Size = new Size(61, 27);
            txtWaterInput.TabIndex = 16;
            // 
            // txtMilkInput
            // 
            txtMilkInput.Location = new Point(354, 122);
            txtMilkInput.Name = "txtMilkInput";
            txtMilkInput.Size = new Size(51, 27);
            txtMilkInput.TabIndex = 17;
            // 
            // txtMilkOutput
            // 
            txtMilkOutput.BackColor = SystemColors.ControlDark;
            txtMilkOutput.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMilkOutput.Location = new Point(354, 94);
            txtMilkOutput.Name = "txtMilkOutput";
            txtMilkOutput.ReadOnly = true;
            txtMilkOutput.Size = new Size(98, 25);
            txtMilkOutput.TabIndex = 18;
            // 
            // txtWaterOutput
            // 
            txtWaterOutput.BackColor = SystemColors.ControlDark;
            txtWaterOutput.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtWaterOutput.Location = new Point(217, 95);
            txtWaterOutput.Name = "txtWaterOutput";
            txtWaterOutput.ReadOnly = true;
            txtWaterOutput.Size = new Size(120, 25);
            txtWaterOutput.TabIndex = 19;
            // 
            // txtBeansOutput
            // 
            txtBeansOutput.BackColor = SystemColors.ControlDark;
            txtBeansOutput.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBeansOutput.ForeColor = SystemColors.WindowText;
            txtBeansOutput.Location = new Point(87, 95);
            txtBeansOutput.Name = "txtBeansOutput";
            txtBeansOutput.ReadOnly = true;
            txtBeansOutput.Size = new Size(110, 25);
            txtBeansOutput.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTemp);
            panel1.Controls.Add(lblTemp);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(169, 456);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 33);
            panel1.TabIndex = 21;
            // 
            // txtTemp
            // 
            txtTemp.BackColor = SystemColors.ControlDark;
            txtTemp.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTemp.Location = new Point(242, 3);
            txtTemp.Name = "txtTemp";
            txtTemp.ReadOnly = true;
            txtTemp.Size = new Size(54, 25);
            txtTemp.TabIndex = 26;
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTemp.Location = new Point(172, 6);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(64, 17);
            lblTemp.TabIndex = 24;
            lblTemp.Text = "Temp (C):";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(3, 8);
            lblName.Name = "lblName";
            lblName.Size = new Size(47, 17);
            lblName.TabIndex = 23;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ControlDark;
            txtName.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(58, 3);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(89, 25);
            txtName.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTotalTime);
            panel2.Controls.Add(txtFinalTime);
            panel2.Location = new Point(169, 612);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 33);
            panel2.TabIndex = 24;
            // 
            // lblTotalTime
            // 
            lblTotalTime.AutoSize = true;
            lblTotalTime.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalTime.Location = new Point(3, 8);
            lblTotalTime.Name = "lblTotalTime";
            lblTotalTime.Size = new Size(71, 17);
            lblTotalTime.TabIndex = 23;
            lblTotalTime.Text = "Total time:";
            // 
            // txtFinalTime
            // 
            txtFinalTime.BackColor = SystemColors.ControlDark;
            txtFinalTime.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtFinalTime.Location = new Point(136, 3);
            txtFinalTime.Name = "txtFinalTime";
            txtFinalTime.ReadOnly = true;
            txtFinalTime.Size = new Size(160, 25);
            txtFinalTime.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblBeans);
            panel3.Controls.Add(txtBeans);
            panel3.Controls.Add(lblWater);
            panel3.Controls.Add(txtWater);
            panel3.Location = new Point(169, 495);
            panel3.Name = "panel3";
            panel3.Size = new Size(299, 33);
            panel3.TabIndex = 25;
            // 
            // lblBeans
            // 
            lblBeans.AutoSize = true;
            lblBeans.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBeans.Location = new Point(3, 6);
            lblBeans.Name = "lblBeans";
            lblBeans.Size = new Size(67, 17);
            lblBeans.TabIndex = 25;
            lblBeans.Text = "Beans (g):";
            // 
            // txtBeans
            // 
            txtBeans.BackColor = SystemColors.ControlDark;
            txtBeans.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBeans.Location = new Point(74, 3);
            txtBeans.Name = "txtBeans";
            txtBeans.ReadOnly = true;
            txtBeans.Size = new Size(56, 25);
            txtBeans.TabIndex = 24;
            // 
            // lblWater
            // 
            lblWater.AutoSize = true;
            lblWater.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblWater.Location = new Point(162, 6);
            lblWater.Name = "lblWater";
            lblWater.Size = new Size(74, 17);
            lblWater.TabIndex = 23;
            lblWater.Text = "Water (ml):";
            // 
            // txtWater
            // 
            txtWater.BackColor = SystemColors.ControlDark;
            txtWater.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtWater.Location = new Point(242, 3);
            txtWater.Name = "txtWater";
            txtWater.ReadOnly = true;
            txtWater.Size = new Size(54, 25);
            txtWater.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblFinalVolume);
            panel5.Controls.Add(txtFinalVolume);
            panel5.Location = new Point(169, 573);
            panel5.Name = "panel5";
            panel5.Size = new Size(299, 33);
            panel5.TabIndex = 27;
            // 
            // lblFinalVolume
            // 
            lblFinalVolume.AutoSize = true;
            lblFinalVolume.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblFinalVolume.Location = new Point(3, 8);
            lblFinalVolume.Name = "lblFinalVolume";
            lblFinalVolume.Size = new Size(115, 17);
            lblFinalVolume.TabIndex = 23;
            lblFinalVolume.Text = "Final volume (ml):";
            // 
            // txtFinalVolume
            // 
            txtFinalVolume.BackColor = SystemColors.ControlDark;
            txtFinalVolume.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtFinalVolume.Location = new Point(136, 3);
            txtFinalVolume.Name = "txtFinalVolume";
            txtFinalVolume.ReadOnly = true;
            txtFinalVolume.Size = new Size(160, 25);
            txtFinalVolume.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblMilk);
            panel4.Controls.Add(txtMilk);
            panel4.Controls.Add(lblFrothMilk);
            panel4.Controls.Add(txtFrothMilk);
            panel4.Location = new Point(169, 534);
            panel4.Name = "panel4";
            panel4.Size = new Size(299, 33);
            panel4.TabIndex = 28;
            // 
            // lblMilk
            // 
            lblMilk.AutoSize = true;
            lblMilk.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMilk.Location = new Point(3, 6);
            lblMilk.Name = "lblMilk";
            lblMilk.Size = new Size(63, 17);
            lblMilk.TabIndex = 25;
            lblMilk.Text = "Milk (ml):";
            // 
            // txtMilk
            // 
            txtMilk.BackColor = SystemColors.ControlDark;
            txtMilk.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtMilk.Location = new Point(74, 3);
            txtMilk.Name = "txtMilk";
            txtMilk.ReadOnly = true;
            txtMilk.Size = new Size(56, 25);
            txtMilk.TabIndex = 24;
            // 
            // lblFrothMilk
            // 
            lblFrothMilk.AutoSize = true;
            lblFrothMilk.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblFrothMilk.Location = new Point(136, 6);
            lblFrothMilk.Name = "lblFrothMilk";
            lblFrothMilk.Size = new Size(100, 17);
            lblFrothMilk.TabIndex = 23;
            lblFrothMilk.Text = "Froth Milk (ml):";
            // 
            // txtFrothMilk
            // 
            txtFrothMilk.BackColor = SystemColors.ControlDark;
            txtFrothMilk.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtFrothMilk.Location = new Point(242, 3);
            txtFrothMilk.Name = "txtFrothMilk";
            txtFrothMilk.ReadOnly = true;
            txtFrothMilk.Size = new Size(54, 25);
            txtFrothMilk.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(87, 75);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 29;
            label1.Text = "Beans (g):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(217, 75);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 30;
            label2.Text = "Water (ml):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(354, 75);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 31;
            label3.Text = "Milk (ml):";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Controls.Add(lblFrothMilkCustom);
            panel6.Controls.Add(lblMilkCustom);
            panel6.Controls.Add(lblWaterCustom);
            panel6.Controls.Add(lblBeansCustom);
            panel6.Controls.Add(txtFrothMilkCustom);
            panel6.Controls.Add(rdbCustom);
            panel6.Controls.Add(rdbDefault);
            panel6.Controls.Add(txtMilkCustom);
            panel6.Controls.Add(txtWaterCustom);
            panel6.Controls.Add(txtBeansCustom);
            panel6.Location = new Point(185, 181);
            panel6.Name = "panel6";
            panel6.Size = new Size(181, 136);
            panel6.TabIndex = 32;
            // 
            // lblFrothMilkCustom
            // 
            lblFrothMilkCustom.AutoSize = true;
            lblFrothMilkCustom.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblFrothMilkCustom.Location = new Point(99, 86);
            lblFrothMilkCustom.Name = "lblFrothMilkCustom";
            lblFrothMilkCustom.Size = new Size(71, 17);
            lblFrothMilkCustom.TabIndex = 43;
            lblFrothMilkCustom.Text = "Froth (ml):";
            // 
            // lblMilkCustom
            // 
            lblMilkCustom.AutoSize = true;
            lblMilkCustom.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMilkCustom.Location = new Point(3, 86);
            lblMilkCustom.Name = "lblMilkCustom";
            lblMilkCustom.Size = new Size(63, 17);
            lblMilkCustom.TabIndex = 42;
            lblMilkCustom.Text = "Milk (ml):";
            // 
            // lblWaterCustom
            // 
            lblWaterCustom.AutoSize = true;
            lblWaterCustom.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblWaterCustom.Location = new Point(99, 36);
            lblWaterCustom.Name = "lblWaterCustom";
            lblWaterCustom.Size = new Size(74, 17);
            lblWaterCustom.TabIndex = 41;
            lblWaterCustom.Text = "Water (ml):";
            // 
            // lblBeansCustom
            // 
            lblBeansCustom.AutoSize = true;
            lblBeansCustom.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBeansCustom.Location = new Point(3, 36);
            lblBeansCustom.Name = "lblBeansCustom";
            lblBeansCustom.Size = new Size(67, 17);
            lblBeansCustom.TabIndex = 40;
            lblBeansCustom.Text = "Beans (g):";
            // 
            // txtFrothMilkCustom
            // 
            txtFrothMilkCustom.Location = new Point(99, 106);
            txtFrothMilkCustom.Name = "txtFrothMilkCustom";
            txtFrothMilkCustom.Size = new Size(79, 27);
            txtFrothMilkCustom.TabIndex = 39;
            // 
            // rdbCustom
            // 
            rdbCustom.AutoSize = true;
            rdbCustom.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdbCustom.Location = new Point(102, 6);
            rdbCustom.Name = "rdbCustom";
            rdbCustom.Size = new Size(76, 21);
            rdbCustom.TabIndex = 38;
            rdbCustom.TabStop = true;
            rdbCustom.Text = "Custom";
            rdbCustom.UseVisualStyleBackColor = true;
            rdbCustom.CheckedChanged += rdbCustom_CheckedChanged;
            // 
            // rdbDefault
            // 
            rdbDefault.AutoSize = true;
            rdbDefault.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdbDefault.Location = new Point(5, 6);
            rdbDefault.Name = "rdbDefault";
            rdbDefault.Size = new Size(72, 21);
            rdbDefault.TabIndex = 37;
            rdbDefault.TabStop = true;
            rdbDefault.Text = "Default";
            rdbDefault.UseVisualStyleBackColor = true;
            rdbDefault.CheckedChanged += rdbDefault_CheckedChanged;
            // 
            // txtMilkCustom
            // 
            txtMilkCustom.Location = new Point(3, 106);
            txtMilkCustom.Name = "txtMilkCustom";
            txtMilkCustom.Size = new Size(80, 27);
            txtMilkCustom.TabIndex = 36;
            // 
            // txtWaterCustom
            // 
            txtWaterCustom.Location = new Point(99, 55);
            txtWaterCustom.Name = "txtWaterCustom";
            txtWaterCustom.Size = new Size(79, 27);
            txtWaterCustom.TabIndex = 35;
            // 
            // txtBeansCustom
            // 
            txtBeansCustom.Location = new Point(3, 56);
            txtBeansCustom.Name = "txtBeansCustom";
            txtBeansCustom.Size = new Size(80, 27);
            txtBeansCustom.TabIndex = 33;
            // 
            // btnHotWater
            // 
            btnHotWater.BackColor = SystemColors.ActiveCaption;
            btnHotWater.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            btnHotWater.Location = new Point(381, 200);
            btnHotWater.Name = "btnHotWater";
            btnHotWater.Size = new Size(87, 30);
            btnHotWater.TabIndex = 33;
            btnHotWater.Text = "Hot Water";
            btnHotWater.UseVisualStyleBackColor = false;
            btnHotWater.Click += btnHotWater_Click;
            // 
            // FormCoffeeMaker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 721);
            Controls.Add(btnHotWater);
            Controls.Add(panel6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtBeansOutput);
            Controls.Add(txtWaterOutput);
            Controls.Add(txtMilkOutput);
            Controls.Add(txtMilkInput);
            Controls.Add(txtWaterInput);
            Controls.Add(txtBeansInput);
            Controls.Add(btnClean);
            Controls.Add(btnLatte);
            Controls.Add(btnCappuccino);
            Controls.Add(btnAmericano);
            Controls.Add(btnEspresso);
            Controls.Add(btnAddMilk);
            Controls.Add(btnAddWater);
            Controls.Add(btnAddBeans);
            Controls.Add(ptcCoffeeMaker);
            Name = "FormCoffeeMaker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coffee Maker";
            ((System.ComponentModel.ISupportInitialize)ptcCoffeeMaker).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptcCoffeeMaker;
        private Button btnAddBeans;
        private Button btnAddWater;
        private Button btnAddMilk;
        private Button btnEspresso;
        private Button btnAmericano;
        private Button btnCappuccino;
        private Button btnLatte;
        private Button btnClean;
        private TextBox txtBeansInput;
        private TextBox txtWaterInput;
        private TextBox txtMilkInput;
        private TextBox txtMilkOutput;
        private TextBox txtWaterOutput;
        private TextBox txtBeansOutput;
        private Panel panel1;
        private Label lblName;
        private TextBox txtName;
        private Panel panel2;
        private Label lblTotalTime;
        private TextBox txtFinalTime;
        private Panel panel3;
        private Label lblWater;
        private TextBox txtWater;
        private Panel panel5;
        private Label lblFinalVolume;
        private TextBox txtFinalVolume;
        private Label lblBeans;
        private TextBox txtBeans;
        private Panel panel4;
        private Label lblMilk;
        private TextBox txtMilk;
        private Label lblFrothMilk;
        private TextBox txtFrothMilk;
        private TextBox txtTemp;
        private Label lblTemp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel6;
        private TextBox txtMilkCustom;
        private TextBox txtWaterCustom;
        private TextBox txtBeansCustom;
        private RadioButton rdbCustom;
        private RadioButton rdbDefault;
        private TextBox txtFrothMilkCustom;
        private Label lblFrothMilkCustom;
        private Label lblMilkCustom;
        private Label lblWaterCustom;
        private Label lblBeansCustom;
        private Button btnHotWater;
    }
}