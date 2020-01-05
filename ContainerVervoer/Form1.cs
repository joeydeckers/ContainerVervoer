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
        Ship _ship = new Ship(3, 6);

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
            


            _ship.SortContainers();


            foreach (var stack in _ship.stacks)
            {
                stackList.Items.Add(stack.ToString());
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        // Dit is tijdelijk om makkelijk te testen
        private void ContainerGenerator_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            for (int i = 0; i < 500; i++) {
                // moet maken dat de waardevolle container minder vaak voorkomt
               // _ship.AddContainer(rand.Next(0, 2), rand.Next(0, 2), rand.Next(500, 26000));
                _ship.AddContainer(0, rand.Next(0, 2), rand.Next(500, 26000));

            }

            foreach (var container in _ship.containersToSort)
            {
                containersToSortList.Items.Add(container.ToString());
            }

        }

        private void CreateRows_Click(object sender, EventArgs e)
        {
            _ship.AddStackToRow();

            foreach (var row in _ship.rows)
            {
                rowsList.Items.Add(row.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetShip_Click(object sender, EventArgs e)
        {
            _ship.Length = Convert.ToInt32(shipLengthSelector.Text);
            _ship.Width = Convert.ToInt32(shipWidthSelector.Text);
        }
    }
}
