using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player //abstract class called Player, holds generateRoshambo method
    {
        //method generateRoshambo returns string

        private string name;

        // public override string ToString()
        //{
        //    //return Rashambo(); //value?
        //}

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public Player()
        {
            name = "";
        }

        public Player(string n)
        {
            Name = n;
        }

        public abstract string generateRoshambo(); //do not need virtual because all abstracts are virtual

    }
}
