using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerVervoer
{
    public class Row
    {
        public List<Stack> stacks = new List<Stack>();

        public int Id { get; set; }
        public bool IsCooledRow { get; set; }
        public bool IsValuableRow { get; set; }
        public int Weight { get; internal set; }
        public int MaxContainers { get; set; }
        public Row(int id, int maxContainers, bool isCooled, bool isValuableRow)
        {
            Id = id;
            MaxContainers = maxContainers;
            IsCooledRow = isCooled;
            IsValuableRow = isValuableRow;
        }

        public bool SetStack(Stack stackToSort)
        {

            if (!CheckSpaceInRow())
            {
                return false;
            }

            if (SetStackOnCooledRow(stackToSort))
            { 
                Weight = Weight + stackToSort.StackWeight;
                stacks.Add(stackToSort);
                return true;
            }

            if (stackToSort.ContainsValuable)
            {
                if (SetValuableStack(stackToSort))
                {
                    Weight = Weight + stackToSort.StackWeight;
                    stacks.Add(stackToSort);
                    return true;
                }
                return false;
            }


            Weight = Weight + stackToSort.StackWeight;
            //MessageBox.Show(Weight.ToString());
            stacks.Add(stackToSort);
            return true;
        }

        private bool SetStackOnCooledRow(Stack stackToSort)
        {
            if(stackToSort.ContainsCooled == true)
            {
                if (IsCooledRow)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckSpaceInRow()
        {
            if (stacks.Count() >= MaxContainers)
            {
                return false;
            }
            return true;
        }

        private bool SetValuableStack(Stack stackToSort)
        {
            if (IsValuableRow == true)
            {
                if (stackToSort.ContainsValuable)
                {
                    //MessageBox.Show(Id.ToString());
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            return "Size: " + stacks.Count.ToString() + "weight: " + Weight.ToString() + " position: " + Id.ToString();
        }

    }
}
