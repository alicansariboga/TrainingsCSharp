using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Arac Bilgileri
            Cars car1 = new Cars();
            car1.CarBrand = "Mercedes";
            car1.CarModel = "AMG";
            car1.CarExperience =  8500;
            car1.CarPower = 350;
            car1.CarCost = 500;

            Cars car2 = new Cars();
            car2.CarBrand = "AUDI";
            car2.CarModel = "RS7 ";
            car2.CarExperience = 8500;
            car2.CarPower = 400;
            car2.CarCost = 700;

            Cars car3 = new Cars();
            car3.CarBrand = "BMW";
            car3.CarModel = "520d";
            car3.CarExperience = 8500;
            car3.CarPower = 330;
            car3.CarCost = 450;

            Cars car4 = new Cars();
            car4.CarBrand = "RANGE ROVER";
            car4.CarModel = "Velar";
            car4.CarExperience = 8500;
            car4.CarPower = 360;
            car4.CarCost = 450;

            List<Cars> cars = new List<Cars>() { car1, car2, car3, car4 };

            foreach (var car in cars)
            {
                lbxCarList.Items.Add(car.CarBrand + " - " + car.CarModel);
            }

            dgrwCarList.DataSource = cars;
        }
    }
}
