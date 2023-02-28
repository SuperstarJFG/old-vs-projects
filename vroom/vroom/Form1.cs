using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vroom
{
    public partial class Dashboard : Form
    {
        MyCar r = new MyCar();
        public Dashboard()
        {
            InitializeComponent();
            //honda civic
            r.SetMPG(37);
            r.SetTankCapacity(12);
            trackBarFuel.Maximum = (int)r.getTankCapacity();
        }

        private void buttonDrive_Click(object sender, EventArgs e)
        {
            r.Drive((int)numericUpDown1.Value);
            //label1.Text = r.getMiles().ToString();
            updateGas();
            label3.Text = "Miles Driven: " + (int)(r.getMiles() + (decimal).00000000000001);
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            r.Refill((int)r.getTankCapacity());
            updateGas();
        }
        public void updateGas()
        {
            decimal gas = r.getGasLevel() * r.getTankCapacity();
            trackBarFuel.Value = (int)gas;
            labelGas.Text = "Gas Level: " + (int)gas + " Gallons";
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            r.STOP();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
