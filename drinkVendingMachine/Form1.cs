using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drinkVendingMachine
{
    //Create a struct for each of the classes 
    public struct Soda
    {
        public string name;
        public int amount;
        public decimal price;
    }

    public partial class Form1 : Form
    {
        //Create the variable that will hold the sales
        double totalSales;
        const string otherOption = "There are no more perhaps another choice?....";
        Soda[] sodas = new Soda[]
        {
            coke, sprite, mountainDew, sevenUp, jarritos 
        };
        private static Soda coke;
        private static Soda sprite;
        private static Soda mountainDew;
        private static Soda sevenUp;
        private static Soda jarritos;

        public Form1()
        {
            InitializeComponent();
        }

        //When the picture is clicked the amount of sodas should go down and the total sales number should go up
        private void cokePictureBox_Click(object sender, EventArgs e)
        {
            //display them within the labels 
            try
            {
                coke.amount = int.Parse(cokeDrinks.Text);
                coke.name = cokeNameLabel.Text;
                coke.price = decimal.Parse(cokePrice.Text.Substring(1));
                //Find a way to assign the price of the sodas.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //increment the total sales by the price of the soda and decrement the amount of drinks
            totalSales += 1;
            coke.amount -= 1;
            //display the total sales in the label and the drinks sales
            salesLabel.Text = "$" + totalSales.ToString();
            cokeDrinks.Text = coke.amount.ToString();

            //Display a message for when the soda amount is empty
            if (coke.amount == 0) {
                MessageBox.Show(otherOption);
            }
        }

        private void spritePictureBox_Click(object sender, EventArgs e)
        {
            //display
            try
            {
                sprite.amount = int.Parse(spriteDrinks.Text);
                sprite.name = spriteNameLabel.Text;
                sprite.price = decimal.Parse(spritePrice.Text.Substring(1));
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            totalSales += 1;
            sprite.amount -= 1;
            //Display the total sales in the label and the drinks sales 
            salesLabel.Text = "$" + totalSales.ToString();
            spriteDrinks.Text = sprite.amount.ToString();

            //Make sure that the number does not go below 0
            if (sprite.amount == 0) {
                MessageBox.Show(otherOption);
            }

        }

        private void mountainDewPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                mountainDew.name = dewNameLabel.Text;
                mountainDew.amount = int.Parse(dewDrinks.Text);
                mountainDew.price = decimal.Parse(dewPrice.Text.Substring(1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            totalSales += 1.50;
            mountainDew.amount -= 1;

            salesLabel.Text = "$" + totalSales.ToString();
            dewDrinks.Text = mountainDew.amount.ToString();

            if (mountainDew.amount == 0) {
                MessageBox.Show(otherOption);
            }
        }

        private void jarritosPictueBox_Click(object sender, EventArgs e)
        {
            try
            {
                jarritos.name = jarritosNameLabel.Text;
                jarritos.amount = int.Parse(jarritosDrinks.Text);
                jarritos.price = decimal.Parse(jarPrice.Text.Substring(1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            totalSales += 1.25;
            jarritos.amount -= 1;

            salesLabel.Text = "$" + totalSales.ToString();
            jarritosDrinks.Text = jarritos.amount.ToString();

            if (jarritos.amount == 0) {
                MessageBox.Show(otherOption);
            }
        }

        private void sevenUpPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                sevenUp.name = sevenNameLabel.Text;
                sevenUp.amount = int.Parse(sevenUpDrinks.Text);
                sevenUp.price = decimal.Parse(sevenPrice.Text.Substring(1));
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            totalSales += 2;
            sevenUp.amount -= 1;

            salesLabel.Text = "$" + totalSales.ToString();
            sevenUpDrinks.Text = sevenUp.amount.ToString();

            if (sevenUp.amount == 0) {
                MessageBox.Show(otherOption);
            }
        }
    }
}
