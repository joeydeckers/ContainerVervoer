using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ContainerVervoer
{
    public partial class Form1 : Form
    {
        Ship _ship = new Ship(0, 0);

        public Form1()
        {
            InitializeComponent();
            valueSetter.Items.Add("True");
            valueSetter.Items.Add("False");

            cooledSetter.Items.Add("True");
            cooledSetter.Items.Add("False");

        }

        private void AddContainer_Click(object sender, EventArgs e)
        {
            bool cooled = bool.Parse(cooledSetter.Text);
            bool valuable = bool.Parse(valueSetter.Text);

            //_ship.AddContainer(valuable, cooled, Convert.ToInt32(weightSetter.Text));
        }

        private void StartSort_Click(object sender, EventArgs e)
        {
            //_ship.Length = Convert.ToInt32(shipLengthSelector.Text);
            //_ship.Width = Convert.ToInt32(shipWidthSelector.Text);


            _ship.SortContainers();


            foreach (var stack in _ship.stacks)
            {
                stackList.Items.Add(stack.ToString());
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ContainerGenerator_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            for (int i = 0; i < 55; i++) {
                _ship.AddContainer(rand.Next(0, 2), rand.Next(0, 2), rand.Next(500, 26000));
            }

            foreach (var container in _ship.containersToSort)
            {
                containersToSortList.Items.Add(container.ToString());
            }
        }
    }
}
