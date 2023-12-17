using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectInCsharp1FoodOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 NewForm2;



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // cal pizza price
        //1- size , 2- topping , 3- crust
        float calPizzaSizePrice()
        {
            
            if(rbSmall.Checked) 
            {
                return Convert.ToSingle(rbSmall.Tag);
            } 
           else if(rblarge.Checked) 
            {
                return Convert.ToSingle(rblarge.Tag);
            
            }
            return 1;
 
        }
        float calCrustPizzaPrice()
        {
            float TPrice = 0;
            if (rbCrustThick.Checked) 
            {
                TPrice += Convert.ToSingle(rbCrustThick.Tag);
            }
             if (rbCrustThin.Checked)
            {
                TPrice += Convert.ToSingle(rbCrustThin.Tag);
            }
            return TPrice;
        }
        float calToppingsPizzaPrice()
        {float TPrice = 0;  
            if (chkKetchupPizza.Checked) 
            {
                TPrice += Convert.ToSingle(chkKetchupPizza.Tag);
            }
            if (chkCarrotsPizza.Checked) 
            {
                TPrice += Convert.ToSingle(chkCarrotsPizza.Tag) ;
            }
            if (chkZaytonPizza.Checked) 
            {
                TPrice += Convert.ToSingle (chkZaytonPizza .Tag);
            }
            if (chBPizza.Checked)
            {
                TPrice += Convert .ToSingle(chBPizza.Tag);
            }
            return TPrice;

        }
        // total price pizza
        float totalpricePizza()
        {
            return calCrustPizzaPrice() + calToppingsPizzaPrice() + calPizzaSizePrice();
        }
        // burger
        float calculateBurragerSize()
        {
            if(rbSmall.Checked) 
            {
            return Convert.ToSingle(rbSmall.Tag);   
            }
            else if(rblarge.Checked)
            {
                return Convert.ToSingle(rblarge.Tag);
            }
            return 1;
        }
        float calculateBurragerTopping()
        {
            float TPrice = 0;
            if(chkburgerketchup.Checked)
            {
                return TPrice += Convert.ToSingle(chkburgerketchup.Tag);
            }
            if(chkBurgerMoz.Checked)
            {
                return TPrice += Convert.ToSingle(chkBurgerMoz.Tag);
            }
            if (chkBurgerSalsa.Checked)
            {
                return TPrice += Convert.ToSingle(chkBurgerSalsa.Tag);
            }
            if (chkBurgerCheeder.Checked)
            {
                return TPrice += Convert.ToSingle(chkBurgerCheeder.Tag);
            }
            return TPrice;
        }
        // total price burger
        float calculateTotalPriceBurger()
        {

            return calculateBurragerSize ()+calculateBurragerTopping() ;
        }
        // Criep
        float calutlatCripSize()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if (rblarge.Checked)
            {
                return Convert.ToSingle(rblarge.Tag);
            }
            return 1;

        }
        float calulateCripToppings()
        {
            float TPrice = 0;
            if (chkmayonnaiseCrepe.Checked)
                TPrice += Convert.ToSingle(chkmayonnaiseCrepe.Tag);

            if (chkTomatoesCrepe.Checked)
                TPrice += Convert.ToSingle(chkTomatoesCrepe.Tag);

            if (chkKetchupCrepe.Checked)
                TPrice += Convert.ToSingle(chkKetchupCrepe.Tag);

            if (chkMzerllaCrepe.Checked)
                TPrice += Convert.ToSingle(chkMzerllaCrepe.Tag);

            return TPrice;
        }
        float calculateCrepType()
        {
            if (rbSuramaCrepe.Checked)
                return Convert.ToSingle(rbSuramaCrepe.Tag);
            else if (rbPotatoesCrepe.Checked)
                return Convert.ToSingle(rbPotatoesCrepe.Tag);
            else if (rbMeatCrepe.Checked)
                return Convert.ToSingle(rbMeatCrepe.Tag);
            else if (rbSuramaCrepe.Checked)
                return Convert.ToSingle(rbSuramaCrepe.Tag);
            return 0;
        }
        float calculateCripPrice()
        {
            return calculateCrepType()+ calulateCripToppings()+ calutlatCripSize();
        }

        float CalcTotalPrice()
        {
            float TotalPrice = 0;
            if (chBburger.Checked)
                TotalPrice += calculateTotalPriceBurger();
            if (chBPizza.Checked)
                TotalPrice += totalpricePizza();
            if (chbCrip.Checked)
                TotalPrice += calculateCripPrice();

            return TotalPrice;
        }

        void UpdateTotalPrice()
        {

            lbltotalprice.Text = Convert.ToString(CalcTotalPrice()) + "$";
        }
        // check order button ==> enable or not
        bool checkOrderBtn()
        {

            if(chbCrip.Checked || chBPizza.Checked || chBburger.Checked )
            {
                button1.Enabled = true;
                return true;
            }
            else
            {
                button1.Enabled = false;
                return false;
            }

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gpBurger.Enabled = chBburger.Checked; //  enable groub eonce check
            UpdateTotalPrice();
            checkOrderBtn();
        }

        private void gpBurger_Enter(object sender, EventArgs e)
        {

        }

        private void rbCrustThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void chbCrip_CheckedChanged(object sender, EventArgs e)
        {
            gBCrip.Enabled = chBburger.Checked;
            UpdateTotalPrice();
            checkOrderBtn();

        }

        private void chBPizza_CheckedChanged(object sender, EventArgs e)
        {
            gbPizza.Enabled= chBPizza.Checked;
            UpdateTotalPrice();
            checkOrderBtn();

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void rblarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void chkburgerketchup_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void chkBurgerSalsa_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void chkBurgerMoz_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void chkBurgerCheeder_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void chkKetchupCrepe_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void chkMzerllaCrepe_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void chkTomatoesCrepe_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void chkmayonnaiseCrepe_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void rbMeatCrepe_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void rbSuramaCrepe_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void rbPotatoesCrepe_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void rbChickenCrepe_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void gbCurstType_Enter(object sender, EventArgs e)
        {

        }

        private void ChkMozerllaPizza_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void rbCrustThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void chkKetchupPizza_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void chkZaytonPizza_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        private void chkCarrotsPizza_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }
        void printburgerSummary()
        {

          //  NewForm2.
        }
        private void button1_Click(object sender, EventArgs e)
        {
           NewForm2 = new Form2();
            NewForm2.gbBurgerSummary.Text= lbltotalprice.Text;
           // NewForm2.lblOrderSUmmary.Text = lbltotalprice.Text;

        }
    }
   

}
