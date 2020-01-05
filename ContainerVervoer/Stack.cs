using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerVervoer
{
    // hierin wordt het sorteren gedaan
    public class Stack
    {
        public int StackWeight { get;  set; }
        public bool ContainsCooled { get;  set; }
        public bool ContainsValuable { get;  set; }

        // hier moet ook komen of de stack links of rechts zit

        public List<Container> Containers = new List<Container>();

        public bool AddToStack(Container container)
        {
            if (container.IsValuable == true)
            {
               
                if (!CheckIfStackContainsValuableContainer())
                {

                    return false;
                }
            }
   

            if (!CheckStackWeight(container))
            {
                return false;
            }
            else
            {
                Containers.Add(container);
                CheckIfContainerIsValuable(container);
                CheckIfContainerIsCooled(container);
                SetValuableContainerOnTop();
            }

            return true;
        }

        private bool CheckStackWeight(Container containerToCheck)
        {



            if(StackWeight + containerToCheck.Weight > 120000)
            {
                return false;
            }
            StackWeight = StackWeight + containerToCheck.Weight;
            return true;
        }

        private bool CheckIfStackContainsValuableContainer()
        {
            if (Containers.Find(containerToCheck => (containerToCheck.IsValuable)) != null)
            {
                return false;
            }

            return true;
        }

        private void CheckIfContainerIsValuable(Container container)
        {
            if(container.IsValuable == true)
            {
                ContainsValuable = true;
            }
        }

        private void CheckIfContainerIsCooled(Container container)
        {
            if (container.IsCooled == true)
            {
                ContainsCooled = true;
            }
        }

        private void SetValuableContainerOnTop()
        {
            if (Containers.Find(containerToCheck => (containerToCheck.IsValuable)) != null)
            {
                Container valuableContainer = Containers.Find(x => x.IsValuable == true);
                //nMessageBox.Show(valuableContainer.ToString());

                Containers.Remove(valuableContainer);
                Containers.Add(valuableContainer);
            }
        }

        public override string ToString()
        {
            return "Gewicht: " + StackWeight.ToString() + "  " + "Gekoeld: " + ContainsCooled.ToString() + "  " + "Waardevol: "  + ContainsValuable.ToString();
        }
    }

}
