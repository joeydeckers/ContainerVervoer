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
        public int Weight { get; internal set; }
        public int MaxRows { get; set; }
        public Row(int id, int maxRows, bool IsCooled)
        {
            Id = id;
            MaxRows = maxRows;
            IsCooledRow = IsCooled;
        }

        public bool SetStack(Stack stackToSort)
        {
            //if (!CheckStackIfCooled(stackToSort))
            //{
            //    return false;
            //}
 
            
            stacks.Add(stackToSort);

            
            return true;
        }

        private bool CheckStackIfCooled(Stack stackToSort)
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

    }
}
