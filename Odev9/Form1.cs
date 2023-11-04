using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Public Tanimlama.
        CarService carService = new CarService();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgrwCars.DataSource = carService.GetAll();
            dgrwCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Id = Convert.ToInt32(tbxId.Text);
            car.Brand = tbxBrand.Text;
            car.Model = tbxModel.Text;
            car.Power = Convert.ToInt32(tbxPower.Text);
            car.Cost = Convert.ToDouble(tbxCost.Text.Replace(".",","));

            carService.Add(car);

            dgrwCars.DataSource = null;
            dgrwCars.DataSource = carService.GetAll();
        }
    }
}
