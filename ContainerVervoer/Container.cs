using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerVervoer
{
    public class Container
    {
        public bool IsValuable { get; internal set; }
        public bool IsCooled { get; internal set; }
        public int Weight { get; internal set; }

        public Container(bool valuable, bool cooled, int weight)
        {

            IsValuable = valuable;
            IsCooled = cooled;
            Weight =  weight += 4000;
        }

        public override string ToString()
        {
            return "Valuable:" + IsValuable.ToString() + "cooled:" + IsCooled.ToString() + "weight:" + Weight.ToString();
        }
    }
}
