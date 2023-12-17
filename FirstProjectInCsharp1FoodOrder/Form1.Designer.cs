namespace FirstProjectInCsharp1FoodOrder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpBurger = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbPizza = new System.Windows.Forms.GroupBox();
            this.gBCrip = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rblarge = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.GbTp = new System.Windows.Forms.GroupBox();
            this.chkBurgerSalsa = new System.Windows.Forms.CheckBox();
            this.chkBurgerCheeder = new System.Windows.Forms.CheckBox();
            this.chkBurgerMoz = new System.Windows.Forms.CheckBox();
            this.chkburgerketchup = new System.Windows.Forms.CheckBox();
            this.gbCurstType = new System.Windows.Forms.GroupBox();
            this.rbCrustThick = new System.Windows.Forms.RadioButton();
            this.rbCrustThin = new System.Windows.Forms.RadioButton();
            this.gbPizzaToppings = new System.Windows.Forms.GroupBox();
            this.chkZaytonPizza = new System.Windows.Forms.CheckBox();
            this.chkCarrotsPizza = new System.Windows.Forms.CheckBox();
            this.ChkMozerllaPizza = new System.Windows.Forms.CheckBox();
            this.chkKetchupPizza = new System.Windows.Forms.CheckBox();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbPotatoesCrepe = new System.Windows.Forms.RadioButton();
            this.rbChickenCrepe = new System.Windows.Forms.RadioButton();
            this.rbSuramaCrepe = new System.Windows.Forms.RadioButton();
            this.rbMeatCrepe = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkTomatoesCrepe = new System.Windows.Forms.CheckBox();
            this.chkmayonnaiseCrepe = new System.Windows.Forms.CheckBox();
            this.chkMzerllaCrepe = new System.Windows.Forms.CheckBox();
            this.chkKetchupCrepe = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.chBburger = new System.Windows.Forms.CheckBox();
            this.chbCrip = new System.Windows.Forms.CheckBox();
            this.chBPizza = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gpBurger.SuspendLayout();
            this.gbPizza.SuspendLayout();
            this.gBCrip.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GbTp.SuspendLayout();
            this.gbCurstType.SuspendLayout();
            this.gbPizzaToppings.SuspendLayout();
            this.gbType.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBurger
            // 
            this.gpBurger.BackColor = System.Drawing.Color.White;
            this.gpBurger.Controls.Add(this.GbTp);
            this.gpBurger.Controls.Add(this.groupBox5);
            this.gpBurger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpBurger.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBurger.Location = new System.Drawing.Point(23, 104);
            this.gpBurger.Name = "gpBurger";
            this.gpBurger.Size = new System.Drawing.Size(319, 343);
            this.gpBurger.TabIndex = 0;
            this.gpBurger.TabStop = false;
            this.gpBurger.Text = "Burger";
            this.gpBurger.Enter += new System.EventHandler(this.gpBurger_Enter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make Your Food Order";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "thought bubble emoji app icon (12).jpg");
            // 
            // gbPizza
            // 
            this.gbPizza.Controls.Add(this.groupBox7);
            this.gbPizza.Controls.Add(this.gbCurstType);
            this.gbPizza.Controls.Add(this.gbPizzaToppings);
            this.gbPizza.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPizza.Location = new System.Drawing.Point(744, 104);
            this.gbPizza.Name = "gbPizza";
            this.gbPizza.Size = new System.Drawing.Size(321, 293);
            this.gbPizza.TabIndex = 3;
            this.gbPizza.TabStop = false;
            this.gbPizza.Text = "Pizza";
            // 
            // gBCrip
            // 
            this.gBCrip.BackColor = System.Drawing.Color.White;
            this.gBCrip.Controls.Add(this.gbType);
            this.gBCrip.Controls.Add(this.groupBox6);
            this.gBCrip.Controls.Add(this.groupBox2);
            this.gBCrip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBCrip.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBCrip.Location = new System.Drawing.Point(386, 104);
            this.gBCrip.Name = "gBCrip";
            this.gBCrip.Size = new System.Drawing.Size(333, 358);
            this.gBCrip.TabIndex = 4;
            this.gBCrip.TabStop = false;
            this.gBCrip.Text = "Crip";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rblarge);
            this.groupBox5.Controls.Add(this.rbSmall);
            this.groupBox5.Location = new System.Drawing.Point(25, 55);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(226, 105);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "size";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(16, 32);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(75, 28);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "5";
            this.rbSmall.Text = "small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rblarge
            // 
            this.rblarge.AutoSize = true;
            this.rblarge.Location = new System.Drawing.Point(16, 66);
            this.rblarge.Name = "rblarge";
            this.rblarge.Size = new System.Drawing.Size(73, 28);
            this.rblarge.TabIndex = 1;
            this.rblarge.TabStop = true;
            this.rblarge.Tag = "10";
            this.rblarge.Text = "large";
            this.rblarge.UseVisualStyleBackColor = true;
            this.rblarge.CheckedChanged += new System.EventHandler(this.rblarge_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(39, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "size";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 28);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "10";
            this.radioButton3.Text = "large";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 32);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(75, 28);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "5";
            this.radioButton4.Text = "small";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // GbTp
            // 
            this.GbTp.Controls.Add(this.chkBurgerSalsa);
            this.GbTp.Controls.Add(this.chkBurgerCheeder);
            this.GbTp.Controls.Add(this.chkBurgerMoz);
            this.GbTp.Controls.Add(this.chkburgerketchup);
            this.GbTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbTp.Location = new System.Drawing.Point(25, 199);
            this.GbTp.Name = "GbTp";
            this.GbTp.Size = new System.Drawing.Size(223, 84);
            this.GbTp.TabIndex = 4;
            this.GbTp.TabStop = false;
            this.GbTp.Text = "Toppings";
            // 
            // chkBurgerSalsa
            // 
            this.chkBurgerSalsa.AutoSize = true;
            this.chkBurgerSalsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBurgerSalsa.Location = new System.Drawing.Point(29, 42);
            this.chkBurgerSalsa.Name = "chkBurgerSalsa";
            this.chkBurgerSalsa.Size = new System.Drawing.Size(52, 17);
            this.chkBurgerSalsa.TabIndex = 5;
            this.chkBurgerSalsa.Tag = "5";
            this.chkBurgerSalsa.Text = "Salsa";
            this.chkBurgerSalsa.UseVisualStyleBackColor = true;
            this.chkBurgerSalsa.CheckedChanged += new System.EventHandler(this.chkBurgerSalsa_CheckedChanged);
            // 
            // chkBurgerCheeder
            // 
            this.chkBurgerCheeder.AutoSize = true;
            this.chkBurgerCheeder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBurgerCheeder.Location = new System.Drawing.Point(115, 42);
            this.chkBurgerCheeder.Name = "chkBurgerCheeder";
            this.chkBurgerCheeder.Size = new System.Drawing.Size(102, 17);
            this.chkBurgerCheeder.TabIndex = 6;
            this.chkBurgerCheeder.Tag = "5";
            this.chkBurgerCheeder.Text = "CheederCheese";
            this.chkBurgerCheeder.UseVisualStyleBackColor = true;
            this.chkBurgerCheeder.CheckedChanged += new System.EventHandler(this.chkBurgerCheeder_CheckedChanged);
            // 
            // chkBurgerMoz
            // 
            this.chkBurgerMoz.AutoSize = true;
            this.chkBurgerMoz.Checked = true;
            this.chkBurgerMoz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBurgerMoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBurgerMoz.Location = new System.Drawing.Point(115, 19);
            this.chkBurgerMoz.Name = "chkBurgerMoz";
            this.chkBurgerMoz.Size = new System.Drawing.Size(65, 17);
            this.chkBurgerMoz.TabIndex = 4;
            this.chkBurgerMoz.Tag = "5";
            this.chkBurgerMoz.Text = "Mozerlla";
            this.chkBurgerMoz.UseVisualStyleBackColor = true;
            this.chkBurgerMoz.CheckedChanged += new System.EventHandler(this.chkBurgerMoz_CheckedChanged);
            // 
            // chkburgerketchup
            // 
            this.chkburgerketchup.AutoSize = true;
            this.chkburgerketchup.Checked = true;
            this.chkburgerketchup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkburgerketchup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkburgerketchup.Location = new System.Drawing.Point(29, 19);
            this.chkburgerketchup.Name = "chkburgerketchup";
            this.chkburgerketchup.Size = new System.Drawing.Size(66, 17);
            this.chkburgerketchup.TabIndex = 3;
            this.chkburgerketchup.Tag = "5";
            this.chkburgerketchup.Text = "Ketchup";
            this.chkburgerketchup.UseVisualStyleBackColor = true;
            this.chkburgerketchup.CheckedChanged += new System.EventHandler(this.chkburgerketchup_CheckedChanged);
            // 
            // gbCurstType
            // 
            this.gbCurstType.Controls.Add(this.rbCrustThick);
            this.gbCurstType.Controls.Add(this.rbCrustThin);
            this.gbCurstType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCurstType.Location = new System.Drawing.Point(24, 46);
            this.gbCurstType.Name = "gbCurstType";
            this.gbCurstType.Size = new System.Drawing.Size(223, 40);
            this.gbCurstType.TabIndex = 4;
            this.gbCurstType.TabStop = false;
            this.gbCurstType.Text = "Crust";
            this.gbCurstType.Enter += new System.EventHandler(this.gbCurstType_Enter);
            // 
            // rbCrustThick
            // 
            this.rbCrustThick.AutoSize = true;
            this.rbCrustThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCrustThick.Location = new System.Drawing.Point(130, 16);
            this.rbCrustThick.Name = "rbCrustThick";
            this.rbCrustThick.Size = new System.Drawing.Size(52, 17);
            this.rbCrustThick.TabIndex = 4;
            this.rbCrustThick.TabStop = true;
            this.rbCrustThick.Tag = "10";
            this.rbCrustThick.Text = "Thick";
            this.rbCrustThick.UseVisualStyleBackColor = true;
            this.rbCrustThick.CheckedChanged += new System.EventHandler(this.rbCrustThick_CheckedChanged);
            // 
            // rbCrustThin
            // 
            this.rbCrustThin.AutoSize = true;
            this.rbCrustThin.Checked = true;
            this.rbCrustThin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCrustThin.Location = new System.Drawing.Point(29, 16);
            this.rbCrustThin.Name = "rbCrustThin";
            this.rbCrustThin.Size = new System.Drawing.Size(46, 17);
            this.rbCrustThin.TabIndex = 3;
            this.rbCrustThin.TabStop = true;
            this.rbCrustThin.Tag = "0";
            this.rbCrustThin.Text = "Thin";
            this.rbCrustThin.UseVisualStyleBackColor = true;
            this.rbCrustThin.CheckedChanged += new System.EventHandler(this.rbCrustThin_CheckedChanged);
            // 
            // gbPizzaToppings
            // 
            this.gbPizzaToppings.Controls.Add(this.chkZaytonPizza);
            this.gbPizzaToppings.Controls.Add(this.chkCarrotsPizza);
            this.gbPizzaToppings.Controls.Add(this.ChkMozerllaPizza);
            this.gbPizzaToppings.Controls.Add(this.chkKetchupPizza);
            this.gbPizzaToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPizzaToppings.Location = new System.Drawing.Point(24, 92);
            this.gbPizzaToppings.Name = "gbPizzaToppings";
            this.gbPizzaToppings.Size = new System.Drawing.Size(223, 84);
            this.gbPizzaToppings.TabIndex = 5;
            this.gbPizzaToppings.TabStop = false;
            this.gbPizzaToppings.Text = "Toppings";
            // 
            // chkZaytonPizza
            // 
            this.chkZaytonPizza.AutoSize = true;
            this.chkZaytonPizza.Checked = true;
            this.chkZaytonPizza.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkZaytonPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkZaytonPizza.Location = new System.Drawing.Point(29, 42);
            this.chkZaytonPizza.Name = "chkZaytonPizza";
            this.chkZaytonPizza.Size = new System.Drawing.Size(59, 17);
            this.chkZaytonPizza.TabIndex = 7;
            this.chkZaytonPizza.Tag = "5";
            this.chkZaytonPizza.Text = "Zayton";
            this.chkZaytonPizza.UseVisualStyleBackColor = true;
            this.chkZaytonPizza.CheckedChanged += new System.EventHandler(this.chkZaytonPizza_CheckedChanged);
            // 
            // chkCarrotsPizza
            // 
            this.chkCarrotsPizza.AutoSize = true;
            this.chkCarrotsPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCarrotsPizza.Location = new System.Drawing.Point(115, 42);
            this.chkCarrotsPizza.Name = "chkCarrotsPizza";
            this.chkCarrotsPizza.Size = new System.Drawing.Size(59, 17);
            this.chkCarrotsPizza.TabIndex = 8;
            this.chkCarrotsPizza.Tag = "5";
            this.chkCarrotsPizza.Text = "Carrots";
            this.chkCarrotsPizza.UseVisualStyleBackColor = true;
            this.chkCarrotsPizza.CheckedChanged += new System.EventHandler(this.chkCarrotsPizza_CheckedChanged);
            // 
            // ChkMozerllaPizza
            // 
            this.ChkMozerllaPizza.AutoSize = true;
            this.ChkMozerllaPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkMozerllaPizza.Location = new System.Drawing.Point(115, 19);
            this.ChkMozerllaPizza.Name = "ChkMozerllaPizza";
            this.ChkMozerllaPizza.Size = new System.Drawing.Size(65, 17);
            this.ChkMozerllaPizza.TabIndex = 6;
            this.ChkMozerllaPizza.Tag = "5";
            this.ChkMozerllaPizza.Text = "Mozerlla";
            this.ChkMozerllaPizza.UseVisualStyleBackColor = true;
            this.ChkMozerllaPizza.CheckedChanged += new System.EventHandler(this.ChkMozerllaPizza_CheckedChanged);
            // 
            // chkKetchupPizza
            // 
            this.chkKetchupPizza.AutoSize = true;
            this.chkKetchupPizza.Checked = true;
            this.chkKetchupPizza.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKetchupPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKetchupPizza.Location = new System.Drawing.Point(29, 19);
            this.chkKetchupPizza.Name = "chkKetchupPizza";
            this.chkKetchupPizza.Size = new System.Drawing.Size(66, 17);
            this.chkKetchupPizza.TabIndex = 5;
            this.chkKetchupPizza.Tag = "5";
            this.chkKetchupPizza.Text = "Ketchup";
            this.chkKetchupPizza.UseVisualStyleBackColor = true;
            this.chkKetchupPizza.CheckedChanged += new System.EventHandler(this.chkKetchupPizza_CheckedChanged);
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbPotatoesCrepe);
            this.gbType.Controls.Add(this.rbChickenCrepe);
            this.gbType.Controls.Add(this.rbSuramaCrepe);
            this.gbType.Controls.Add(this.rbMeatCrepe);
            this.gbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbType.Location = new System.Drawing.Point(42, 261);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(223, 91);
            this.gbType.TabIndex = 4;
            this.gbType.TabStop = false;
            this.gbType.Text = "Type";
            // 
            // rbPotatoesCrepe
            // 
            this.rbPotatoesCrepe.AutoSize = true;
            this.rbPotatoesCrepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPotatoesCrepe.Location = new System.Drawing.Point(130, 56);
            this.rbPotatoesCrepe.Name = "rbPotatoesCrepe";
            this.rbPotatoesCrepe.Size = new System.Drawing.Size(67, 17);
            this.rbPotatoesCrepe.TabIndex = 10;
            this.rbPotatoesCrepe.TabStop = true;
            this.rbPotatoesCrepe.Tag = "15";
            this.rbPotatoesCrepe.Text = "Potatoes";
            this.rbPotatoesCrepe.UseVisualStyleBackColor = true;
            this.rbPotatoesCrepe.CheckedChanged += new System.EventHandler(this.rbPotatoesCrepe_CheckedChanged);
            // 
            // rbChickenCrepe
            // 
            this.rbChickenCrepe.AutoSize = true;
            this.rbChickenCrepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChickenCrepe.Location = new System.Drawing.Point(29, 56);
            this.rbChickenCrepe.Name = "rbChickenCrepe";
            this.rbChickenCrepe.Size = new System.Drawing.Size(64, 17);
            this.rbChickenCrepe.TabIndex = 9;
            this.rbChickenCrepe.TabStop = true;
            this.rbChickenCrepe.Tag = "25";
            this.rbChickenCrepe.Text = "Chicken";
            this.rbChickenCrepe.UseVisualStyleBackColor = true;
            this.rbChickenCrepe.CheckedChanged += new System.EventHandler(this.rbChickenCrepe_CheckedChanged);
            // 
            // rbSuramaCrepe
            // 
            this.rbSuramaCrepe.AutoSize = true;
            this.rbSuramaCrepe.Checked = true;
            this.rbSuramaCrepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuramaCrepe.Location = new System.Drawing.Point(130, 16);
            this.rbSuramaCrepe.Name = "rbSuramaCrepe";
            this.rbSuramaCrepe.Size = new System.Drawing.Size(61, 17);
            this.rbSuramaCrepe.TabIndex = 8;
            this.rbSuramaCrepe.TabStop = true;
            this.rbSuramaCrepe.Tag = "20";
            this.rbSuramaCrepe.Text = "Suarma";
            this.rbSuramaCrepe.UseVisualStyleBackColor = true;
            this.rbSuramaCrepe.CheckedChanged += new System.EventHandler(this.rbSuramaCrepe_CheckedChanged);
            // 
            // rbMeatCrepe
            // 
            this.rbMeatCrepe.AutoSize = true;
            this.rbMeatCrepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMeatCrepe.Location = new System.Drawing.Point(29, 16);
            this.rbMeatCrepe.Name = "rbMeatCrepe";
            this.rbMeatCrepe.Size = new System.Drawing.Size(49, 17);
            this.rbMeatCrepe.TabIndex = 7;
            this.rbMeatCrepe.TabStop = true;
            this.rbMeatCrepe.Tag = "20";
            this.rbMeatCrepe.Text = "Meat";
            this.rbMeatCrepe.UseVisualStyleBackColor = true;
            this.rbMeatCrepe.CheckedChanged += new System.EventHandler(this.rbMeatCrepe_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkTomatoesCrepe);
            this.groupBox6.Controls.Add(this.chkmayonnaiseCrepe);
            this.groupBox6.Controls.Add(this.chkMzerllaCrepe);
            this.groupBox6.Controls.Add(this.chkKetchupCrepe);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(42, 171);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(223, 84);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Toppings";
            // 
            // chkTomatoesCrepe
            // 
            this.chkTomatoesCrepe.AutoSize = true;
            this.chkTomatoesCrepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoesCrepe.Location = new System.Drawing.Point(29, 42);
            this.chkTomatoesCrepe.Name = "chkTomatoesCrepe";
            this.chkTomatoesCrepe.Size = new System.Drawing.Size(73, 17);
            this.chkTomatoesCrepe.TabIndex = 5;
            this.chkTomatoesCrepe.Tag = "3";
            this.chkTomatoesCrepe.Text = "Tomatoes";
            this.chkTomatoesCrepe.UseVisualStyleBackColor = true;
            this.chkTomatoesCrepe.CheckedChanged += new System.EventHandler(this.chkTomatoesCrepe_CheckedChanged);
            // 
            // chkmayonnaiseCrepe
            // 
            this.chkmayonnaiseCrepe.AutoSize = true;
            this.chkmayonnaiseCrepe.Checked = true;
            this.chkmayonnaiseCrepe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkmayonnaiseCrepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkmayonnaiseCrepe.Location = new System.Drawing.Point(115, 42);
            this.chkmayonnaiseCrepe.Name = "chkmayonnaiseCrepe";
            this.chkmayonnaiseCrepe.Size = new System.Drawing.Size(83, 17);
            this.chkmayonnaiseCrepe.TabIndex = 6;
            this.chkmayonnaiseCrepe.Tag = "3";
            this.chkmayonnaiseCrepe.Text = "Mayonnaise";
            this.chkmayonnaiseCrepe.UseVisualStyleBackColor = true;
            this.chkmayonnaiseCrepe.CheckedChanged += new System.EventHandler(this.chkmayonnaiseCrepe_CheckedChanged);
            // 
            // chkMzerllaCrepe
            // 
            this.chkMzerllaCrepe.AutoSize = true;
            this.chkMzerllaCrepe.Checked = true;
            this.chkMzerllaCrepe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMzerllaCrepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMzerllaCrepe.Location = new System.Drawing.Point(115, 19);
            this.chkMzerllaCrepe.Name = "chkMzerllaCrepe";
            this.chkMzerllaCrepe.Size = new System.Drawing.Size(65, 17);
            this.chkMzerllaCrepe.TabIndex = 4;
            this.chkMzerllaCrepe.Tag = "3";
            this.chkMzerllaCrepe.Text = "Mozerlla";
            this.chkMzerllaCrepe.UseVisualStyleBackColor = true;
            this.chkMzerllaCrepe.CheckedChanged += new System.EventHandler(this.chkMzerllaCrepe_CheckedChanged);
            // 
            // chkKetchupCrepe
            // 
            this.chkKetchupCrepe.AutoSize = true;
            this.chkKetchupCrepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKetchupCrepe.Location = new System.Drawing.Point(29, 19);
            this.chkKetchupCrepe.Name = "chkKetchupCrepe";
            this.chkKetchupCrepe.Size = new System.Drawing.Size(66, 17);
            this.chkKetchupCrepe.TabIndex = 3;
            this.chkKetchupCrepe.Tag = "3";
            this.chkKetchupCrepe.Text = "Ketchup";
            this.chkKetchupCrepe.UseVisualStyleBackColor = true;
            this.chkKetchupCrepe.CheckedChanged += new System.EventHandler(this.chkKetchupCrepe_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton5);
            this.groupBox7.Controls.Add(this.radioButton6);
            this.groupBox7.Location = new System.Drawing.Point(24, 182);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(226, 105);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "size";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(16, 66);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(78, 36);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "10";
            this.radioButton5.Text = "large";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(16, 32);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(81, 36);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Tag = "5";
            this.radioButton6.Text = "small";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // chBburger
            // 
            this.chBburger.Location = new System.Drawing.Point(109, 60);
            this.chBburger.Name = "chBburger";
            this.chBburger.Size = new System.Drawing.Size(140, 38);
            this.chBburger.TabIndex = 5;
            this.chBburger.Text = "checkBox1";
            this.chBburger.UseVisualStyleBackColor = true;
            this.chBburger.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chbCrip
            // 
            this.chbCrip.Location = new System.Drawing.Point(421, 59);
            this.chbCrip.Name = "chbCrip";
            this.chbCrip.Size = new System.Drawing.Size(113, 31);
            this.chbCrip.TabIndex = 6;
            this.chbCrip.Text = "checkBox2";
            this.chbCrip.UseVisualStyleBackColor = true;
            this.chbCrip.CheckedChanged += new System.EventHandler(this.chbCrip_CheckedChanged);
            // 
            // chBPizza
            // 
            this.chBPizza.Location = new System.Drawing.Point(797, 59);
            this.chBPizza.Name = "chBPizza";
            this.chBPizza.Size = new System.Drawing.Size(113, 31);
            this.chBPizza.TabIndex = 7;
            this.chBPizza.Text = "checkBox3";
            this.chBPizza.UseVisualStyleBackColor = true;
            this.chBPizza.CheckedChanged += new System.EventHandler(this.chBPizza_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(831, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Prices";
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.Location = new System.Drawing.Point(857, 562);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(134, 112);
            this.lbltotalprice.TabIndex = 9;
            this.lbltotalprice.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 71);
            this.button1.TabIndex = 10;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 71);
            this.button2.TabIndex = 11;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FirstProjectInCsharp1FoodOrder.Properties.Resources.thought_bubble_emoji_app_icon__12_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 683);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltotalprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chBPizza);
            this.Controls.Add(this.chbCrip);
            this.Controls.Add(this.chBburger);
            this.Controls.Add(this.gBCrip);
            this.Controls.Add(this.gbPizza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpBurger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpBurger.ResumeLayout(false);
            this.gbPizza.ResumeLayout(false);
            this.gBCrip.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GbTp.ResumeLayout(false);
            this.GbTp.PerformLayout();
            this.gbCurstType.ResumeLayout(false);
            this.gbCurstType.PerformLayout();
            this.gbPizzaToppings.ResumeLayout(false);
            this.gbPizzaToppings.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBurger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox gbPizza;
        private System.Windows.Forms.GroupBox gBCrip;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rblarge;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox GbTp;
        private System.Windows.Forms.CheckBox chkBurgerSalsa;
        private System.Windows.Forms.CheckBox chkBurgerCheeder;
        private System.Windows.Forms.CheckBox chkBurgerMoz;
        private System.Windows.Forms.CheckBox chkburgerketchup;
        private System.Windows.Forms.GroupBox gbCurstType;
        private System.Windows.Forms.RadioButton rbCrustThick;
        private System.Windows.Forms.RadioButton rbCrustThin;
        private System.Windows.Forms.GroupBox gbPizzaToppings;
        private System.Windows.Forms.CheckBox chkZaytonPizza;
        private System.Windows.Forms.CheckBox chkCarrotsPizza;
        private System.Windows.Forms.CheckBox ChkMozerllaPizza;
        private System.Windows.Forms.CheckBox chkKetchupPizza;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbPotatoesCrepe;
        private System.Windows.Forms.RadioButton rbChickenCrepe;
        private System.Windows.Forms.RadioButton rbSuramaCrepe;
        private System.Windows.Forms.RadioButton rbMeatCrepe;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkTomatoesCrepe;
        private System.Windows.Forms.CheckBox chkmayonnaiseCrepe;
        private System.Windows.Forms.CheckBox chkMzerllaCrepe;
        private System.Windows.Forms.CheckBox chkKetchupCrepe;
        private System.Windows.Forms.CheckBox chBburger;
        private System.Windows.Forms.CheckBox chbCrip;
        private System.Windows.Forms.CheckBox chBPizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

