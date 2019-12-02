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

            _ship.AddContainer(valuable, cooled, Convert.ToInt32(weightSetter.Text));
        }

        private void StartSort_Click(object sender, EventArgs e)
        {
            _ship.Length = Convert.ToInt32(shipLengthSelector.Text);
            _ship.Width = Convert.ToInt32(shipWidthSelector.Text);

            foreach (var container in _ship.containersToSort)
            {
                containersToSortList.Items.Add(container.ToString());
            }
            _ship.SortContainers();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
