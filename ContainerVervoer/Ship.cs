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
            CreateRows();
        }

        public void AddContainer(int valuable, int cooled, int weight)
        {
            if (weight > 26000)
            {
                MessageBox.Show("Too heavy! Try a smaller size");
            }
            else
            {
                bool valuableToParse = Convert.ToBoolean(valuable);
                bool cooledToParse = Convert.ToBoolean(cooled);

                containersToSort.Add(new Container(valuableToParse, cooledToParse, weight));
            }
        }

        public void SortContainers()
        {
            while (containersToSort.Count() > 0)
            {
                Stack newStack = new Stack();

                foreach (var container in containersToSort.ToList()) {
                    if (newStack.AddToStack(container))
                    {
                        //MessageBox.Show(container.Weight.ToString());
                        containersToSort.Remove(container);
                    }
                }
                stacks.Add(newStack);

            }
            // aparte row sort knop maken
            //AddStackToRow();
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

        private void AddStackToRow()
        {
            while (stacks.Count() > 0) {
                if (rows.Find(rowToCheck => (rowToCheck.IsCooledRow)) != null)
                {
                    Row cooledRow = rows.Find(x => x.IsCooledRow == true);
                    foreach (var stack in stacks.ToList())
                    {

                        if (stack.ContainsCooled == true)
                        {
                            cooledRow.SetStack(stack);
                            //MessageBox.Show("success");
                            //stacks.Remove(stack);
                        }
                        else
                        {

                        }
                        stacks.Remove(stack);

                    }

                }
            }

        }

        public override string ToString()
        {
            return Length.ToString() + Width.ToString();
        }
    }
}
    