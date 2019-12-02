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
        public List<Row> rows = new List<Row>();
        public int Length { get; internal set; }
        public int Width { get; internal set; }

        public Ship(int length, int width)
        {
            Length = length;
            Width = width;
        }

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

            //MessageBox.Show(stacks.Count.ToString());
            CreateRows();

            while(stacks.Count() > 0)
            {
                foreach(Stack stack in stacks)
                {
                    if (SortRows(stack))
                    {
                        stacks.Remove(stack);
                    }
                }
            }
            MessageBox.Show("done");
        }

        private void CreateRows()
        {
            for (int i = 0; i < Length; i++)
            {   
                if(i == 0)
                {
                    Row row = new Row(i, Width, true);
                    rows.Add(row);
                }
                else
                {
                    Row row = new Row(i, Width, false);
                    rows.Add(row);
                }
            }
        }

        private bool SortRows(Stack stack)
        {
           foreach(Row row in rows)
            {
                if (row.SetStack(stack))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return Length.ToString() + Width.ToString();
        }
    }
}
    