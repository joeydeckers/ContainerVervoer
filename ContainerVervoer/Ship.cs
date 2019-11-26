using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerVervoer
{
    public class Ship
    {
        public List<Container> containersToSort = new List<Container>();
        public List<Stack> stacks = new List<Stack>();


        public void AddContainer(bool valuable, bool cooled, int weight)
        {
            if (weight > 30000)
            {
                MessageBox.Show("Too heavy! Try a smaller size");
            }
            else
            {
                containersToSort.Add(new Container(valuable, cooled, weight));
            }
        }

        public void SortContainers()
        {
            while (containersToSort.Count() > 0)
            {
                var newStack = new Stack();
                stacks.Add(newStack);

                foreach (var container in containersToSort.ToList()) {
                    if (newStack.AddToStack(container))
                    {
                        containersToSort.Remove(container);
                    }
                }
            }
            MessageBox.Show(stacks.Count.ToString());
        }
    }
}
    