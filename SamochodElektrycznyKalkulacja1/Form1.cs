using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamochodElektrycznyKalkulacja1
{
    public partial class Form1 : Form
    {
        Car passatB6 = new Car("Passat B6", 8, 125, 5M);
+-
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carNameLabel.Text = passatB6.Name;
            CostLabel.Text = passatB6.calculateFuelCost(kmPerYearNUD.Value, yearsNUD.Value, petrolPriceNUD.Value, fuelConsumptionNUD.Value).ToString();
        }

        private void fuelConsumptionNUD_ValueChanged(object sender, EventArgs e)
        {
            CostLabel.Text = passatB6.calculateFuelCost(kmPerYearNUD.Value, yearsNUD.Value, petrolPriceNUD.Value, fuelConsumptionNUD.Value).ToString();
        }
    }
}
