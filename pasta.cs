using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210907_MavPASS
{
    public class Pasta
    {
        // Variables
        private string name = "n/a";
        private double timeToCook = -1;


        // Properties
        public string Name { 
            get { return this.name; }
            set { this.name = value; }
        }

        public double TimeToCook
        {
            get { return this.timeToCook; }
            set { this.timeToCook = value; }
        }

        // Constructors
        public Pasta()
        {

        }

        public Pasta(string aName, double aTimeToCook )
        {
            this.Name = aName;
            this.TimeToCook = aTimeToCook;
        }
    }
}
