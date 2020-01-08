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
        // deze moet weg
        // Ik weet dat ik deze weg moet doen en de datastructuur veranderen. Hier had ik toch iets meer moeite mee dan verwacht. Hopelijk weet ik dit in de vakantie te fixen:)
        // Voor deze oplevering haal ik het helaas net niet.
        public List<Stack> stacks = new List<Stack>();
        public List<Row> rows = new List<Row>();
        public int Length { get; internal set; }
        public int Width { get; internal set; }
        public bool IsInBalance { get; internal set; }

        public int TotalWeight { get; internal set; }
        public int TotalWeightLeft { get; internal set; }
        public int TotalWeightRight { get; internal set; } 

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

                        containersToSort.Remove(container);
                    }
                }
                stacks.Add(newStack);
            }
        }

        private void CreateRows()
        {
            for (int i = 0; i < Length; i++)
            {   
                if(i == 0 || i == Length-1)
                {
                    Row row = new Row(i, Width, true, true);
                    rows.Add(row);
                }
                else
                {
                    Row row = new Row(i, Width, false, false);
                    rows.Add(row);
                }
            }
        }

        public void AddStackToRow()
        {
            foreach (var row in rows)
            {
                foreach (var stack in stacks.ToList())
                {
                    if (row.SetStack(stack))
                    {
                        stacks.Remove(stack);
                    }
                }
                row.SetLeftWeight();
                row.SetRightWeight();
            }
            CheckBalance();

        }

        private bool CheckBalance()
        {
            int lowesetSide;
            int highestSide;
            decimal balance;

            foreach (Row row in rows)
            {
                TotalWeight = TotalWeight + (row.RightWeight + row.LeftWeight);
                TotalWeightRight = TotalWeightRight + row.RightWeight;
                TotalWeightLeft = TotalWeightLeft + row.LeftWeight;
            }

            if(TotalWeightLeft > TotalWeightRight)
            {
                lowesetSide = TotalWeightRight;
                highestSide = TotalWeightLeft;
            }
            else
            {
                lowesetSide = TotalWeightLeft;
                highestSide = TotalWeightRight;
            }

            balance = (highestSide - lowesetSide) / highestSide * 100;

            if(balance > 20)
            {
                IsInBalance = false;
                return false;
            }

            IsInBalance = true;
            MessageBox.Show("In balance!");
            return true;
        }

        public override string ToString()
        {
            return Length.ToString() + Width.ToString();
        }
    }
}
    