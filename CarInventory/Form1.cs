using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string make, colour;
            int year, mileage;

            make = makeInput.Text;
            colour = colourInput.Text;
            year = Convert.ToInt16(yearInput.Text);
            mileage = Convert.ToInt16(mileageInput.Text);

            Car c = new Car(make,colour,year,mileage);
            cars.Add(c);

            outputLabel.Text = " ";
            for (int i = 0; i < cars.Count; i++)
            {
                outputLabel.Text += cars[i].make + " " +
                    cars[i].year + " " +
                    cars[i].colour + " " +
                    cars[i].milage + "\n";


            }
        }
    }
}
